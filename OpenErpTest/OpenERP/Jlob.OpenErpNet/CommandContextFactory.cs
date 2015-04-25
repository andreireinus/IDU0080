using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Reflection;

namespace Jlob.OpenErpNet
{
    public class CommandContextFactory
    {

        public static CommandContext BuildCommandContextFromExpression<T>(Expression<Func<T, bool>> conditions)
        {
            CommandContext context = new CommandContext();
            context.ParameterName = conditions.Parameters[0].Name;
            context.EntityName = GetOpenErpEntityName(conditions.Parameters[0]);
            Expression initialExpression = conditions.Body;
            if (initialExpression != null)
            {
                while (initialExpression != null)
                {
                    //Podemos tener concatenacion de expressiones, evaluamos el tipo
                    if (initialExpression.NodeType == ExpressionType.AndAlso)
                    {
                        BinaryExpression operation = initialExpression as BinaryExpression;
                        if (operation.Right is MethodCallExpression)
                        {
                            processMethodCallExpression(operation.Right as MethodCallExpression, context);
                        }
                        if (operation.Right is BinaryExpression)
                        {
                            processBinaryExpression(operation.Right as BinaryExpression, context);
                        }
                        initialExpression = operation.Left as BinaryExpression;
                    }
                    else
                    {
                        if (initialExpression is MethodCallExpression)
                        {
                            processMethodCallExpression(initialExpression as MethodCallExpression, context);
                        }
                        if (initialExpression is BinaryExpression)
                        {
                            processBinaryExpression(initialExpression as BinaryExpression, context);
                        }
                        initialExpression = null;
                    }
                }
            }
            return context;
        }

        public static CommandContext BuildCommandContextFromEntity<T>(T entity)
        {
            OpenErpMapAttribute[] attributes;
            CommandContext context = new CommandContext();
            context.EntityType = typeof(T);
            attributes = (OpenErpMapAttribute[])context.EntityType.GetCustomAttributes(typeof(OpenErpMapAttribute), false);
            if (attributes.Length > 0)
            {
                context.EntityName = attributes[0].OpenErpName;
            }
            else
            {
                String message = string.Format("Entity {0} has not OpenErpMap attributed defined", context.EntityType.Name);
                throw new InvalidOperationException(message);
            }
            foreach (PropertyInfo property in context.EntityType.GetProperties())
            {
                CommandArgument argument = new CommandArgument();
                attributes = (OpenErpMapAttribute[])property.GetCustomAttributes(typeof(OpenErpMapAttribute), false);
                if (attributes.Length > 0)
                {
                    argument.Property = property.Name;
                    if (!string.IsNullOrWhiteSpace(attributes[0].OpenErpName))
                    {
                        argument.Property = attributes[0].OpenErpName;
                    }
                    argument.ArgumentType = attributes[0].OpenErpType;
                    argument.Value = property.GetValue(entity, null);
                    argument.Operation = "=";
                    if (argument.Value == null)
                    {
                        argument.Value = false;
                    }
                    context.Arguments.Add(argument);
                }
            }
            return context;
        }
        
        private static void processMethodCallExpression(MethodCallExpression expression, CommandContext context)
        {
            CommandArgument argument = new CommandArgument();
            if (expression != null)
            {
                switch (expression.Method.Name)
                {
                    case "Contains":
                        argument.Value = GetValue(expression, context);
                        SetProperty(expression, context, argument);
                        if (argument.Value is string)
                        {
                            argument.Operation = "ilike";
                        }
                        if (argument.Value is Array)
                        {   
                            argument.Operation = "in";
                        }
                        context.Arguments.Add(argument);
                        break;
                    case "StartsWith":
                        argument.Value = GetValue(expression, context) + "%";
                        SetProperty(expression, context, argument);
                        argument.Operation = "ilike";
                        context.Arguments.Add(argument);
                        break;
                    case "EndsWith":
                        argument.Value = "%" + GetValue(expression, context);
                        SetProperty(expression, context, argument);
                        argument.Operation = "ilike";
                        context.Arguments.Add(argument);
                        break;
                    case "Equals":
                        argument.Value = GetValue(expression, context);
                        SetProperty(expression, context, argument);
                        argument.Operation = "=";
                        context.Arguments.Add(argument);
                        break;
                    default:
                        break;
                }
            }
        }

        private static void processBinaryExpression(BinaryExpression operation, CommandContext context)
        {
            CommandArgument argument = new CommandArgument();
            argument.Value = GetValue(operation, context);
            SetProperty(operation, context, argument);
            switch (operation.NodeType)
            {
                case ExpressionType.GreaterThan:
                    argument.Operation = ">";
                    break;
                case ExpressionType.GreaterThanOrEqual:
                    argument.Operation = ">=";
                    break;
                case ExpressionType.LessThan:
                    argument.Operation = "<";
                    break;
                case ExpressionType.LessThanOrEqual:
                    argument.Operation = "<=";
                    break;
                case ExpressionType.Equal:
                    argument.Operation = "=";
                    break;
                default:
                    break;
            }
            context.Arguments.Add(argument);
        }

        private static void SetProperty(Expression expression, CommandContext context, CommandArgument argument)
        {
            argument.Property = string.Empty;
            switch (expression.NodeType)
            {
                case ExpressionType.Call:
                    MethodCallExpression methodCall = expression as MethodCallExpression;
                    SetProperty(methodCall.Object, context, argument);
                    if (string.IsNullOrEmpty(argument.Property))
                    {
                        foreach (Expression item in methodCall.Arguments)
                        {
                            SetProperty(item, context, argument);
                        }
                    }
                    break;
                case ExpressionType.MemberAccess:
                    MemberExpression memberAccess = expression as MemberExpression;
                    if (memberAccess.Expression is ParameterExpression)
                    {
                        if ((memberAccess.Expression as ParameterExpression).Name.Equals(context.ParameterName))
                        {
                            argument.Property = GetOpenErpPropertyName(memberAccess as MemberExpression);
                            argument.ArgumentType = GetOpenErpPropertyType(memberAccess as MemberExpression);
                        }
                    }
                    break;
                case ExpressionType.Constant:
                    argument.Property = (expression as ConstantExpression).Value.ToString();
                    break;
                default:
                    if (expression is BinaryExpression)
                    {
                        BinaryExpression binary = expression as BinaryExpression;
                        SetProperty(binary.Left, context, argument);
                        if (string.IsNullOrEmpty(argument.Property))
                        {
                            SetProperty(binary.Right, context, argument);
                        }
                    }
                    break;
            }
        }

        private static object GetValue(Expression expression, CommandContext context)
        {
            object res = null;
            switch (expression.NodeType)
            {
                case ExpressionType.Call:
                    MethodCallExpression methodCall = expression as MethodCallExpression;
                    res = GetValue(methodCall.Object, context);
                    if (res == null)
                    {
                        foreach (Expression item in methodCall.Arguments)
                        {
                            res = GetValue(item, context);
                        }
                    }
                    break;
                case ExpressionType.MemberAccess:
                    MemberExpression memberAccess = expression as MemberExpression;
                    if (memberAccess.Expression is ParameterExpression)
                    {
                        if (!(memberAccess.Expression as ParameterExpression).Name.Equals(context.ParameterName))
                        {
                            if (IsGenericCollection(memberAccess.Type))
                            {
                                System.Reflection.MethodInfo methodToArray = memberAccess.Type.GetMethods().FirstOrDefault(m => m.Name == "ToArray");
                                var expresion = Expression.Call(memberAccess, methodToArray);
                                var getterLambda = Expression.Lambda<Func<object>>(expresion);
                                var getter = getterLambda.Compile();
                                res = getter();
                            }
                            else if(IsNullable(memberAccess.Type))
                            {
                                string test = "hola";
                            }
                            else
                            {
                                var objectMember = Expression.Convert(memberAccess, typeof(object));
                                var getterLambda = Expression.Lambda<Func<object>>(objectMember);
                                var getter = getterLambda.Compile();
                                res = getter();
                            }
                        }
                    }
                    else
                    {
                        if (IsGenericCollection(memberAccess.Type))
                        {
                            System.Reflection.MethodInfo methodToArray = memberAccess.Type.GetMethods().FirstOrDefault(m => m.Name == "ToArray");
                            var expresion = Expression.Call(memberAccess, methodToArray);
                            var getterLambda = Expression.Lambda<Func<object>>(expresion);
                            var getter = getterLambda.Compile();
                            res = getter();
                        }
                        else
                        {
                            var objectMember = Expression.Convert(memberAccess, typeof(object));
                            var getterLambda = Expression.Lambda<Func<object>>(objectMember);
                            var getter = getterLambda.Compile();
                            res = getter();
                        }
                    }
                    break;
                case ExpressionType.Constant:
                    res = (expression as ConstantExpression).Value;
                    break;
                default:
                    if (expression is BinaryExpression)
                    {
                        BinaryExpression binary = expression as BinaryExpression;
                        res = GetValue(binary.Right, context);
                        if (res == null)
                        {
                            res = GetValue(binary.Left, context);
                        }
                    }
                    break;
            }
            return res;
        }

        private static String GetOpenErpPropertyName(MemberExpression member)
        {
            string name = string.Empty;
            OpenErpMapAttribute[] attributes;
            attributes = (OpenErpMapAttribute[])member.Member.GetCustomAttributes(typeof(OpenErpMapAttribute), false);
            if (attributes.Length > 0)
            {
                name = attributes[0].OpenErpName;
            }
            else
            {
                name = member.Member.Name;
            }
            return name;
        }

        private static OpenErpType GetOpenErpPropertyType(MemberExpression member)
        {
            OpenErpType type=OpenErpType.Undefined;
            OpenErpMapAttribute[] attributes;
            attributes = (OpenErpMapAttribute[])member.Member.GetCustomAttributes(typeof(OpenErpMapAttribute), false);
            if (attributes.Length > 0)
            {
                type = attributes[0].OpenErpType;
            }
            return type;
        }

        internal static String GetOpenErpEntityName(ParameterExpression member)
        {
            string name = string.Empty;
            if (member != null)
            {
                name = GetOpenErpEntityName(member.Type);
            }
            return name;
        }

        public static String GetOpenErpEntityName(Type type)
        {
            string name = string.Empty;
            OpenErpMapAttribute[] attributes;
            attributes = (OpenErpMapAttribute[])type.GetCustomAttributes(typeof(OpenErpMapAttribute), false);
            if (attributes.Length > 0)
            {
                name = attributes[0].OpenErpName;
            }
            else
            {
                //if no attibute is defined, use class name
                name = type.Name.Replace("_", ".");
            }
            return name;
        }
        
        private static bool IsGenericCollection(Type referenceType)
        {
            if (referenceType.IsGenericType)
            {
                Type enumerableType = typeof(IEnumerable<>).MakeGenericType(referenceType.GetGenericArguments());
                Type[] interfaces = referenceType.GetInterfaces();
                return interfaces.Contains(enumerableType);
            }
            return false;
        }

        private static bool IsNullable(Type referenceType)
        {
            if (referenceType.IsGenericType && referenceType.GetGenericTypeDefinition() == typeof(Nullable<>)) 
            {
                return true;
            }
            return false;
        }
    }
}
