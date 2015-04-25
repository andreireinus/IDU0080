using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Reflection;
using System.Collections;

namespace Jlob.OpenErpNet
{
    /// <summary>
    /// Class for declare extension methods
    /// </summary>
    public static class OpenErpExtensions
    {

        private static object GetValue(Expression member)
        {
            var objectMember = Expression.Convert(member, typeof(object));

            var getterLambda = Expression.Lambda<Func<object>>(objectMember);

            var getter = getterLambda.Compile();

            return getter();
        }

        /// <summary>
        /// If property passed in path argument is a OpenErp class, 
        /// it will load from OpenErp and set path property.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="source"></param>
        /// <param name="path">Property to load</param>
        /// <returns></returns>
        public static IEnumerable<T> Include<T, TProperty>(this IEnumerable<T> source, Expression<Func<T, TProperty>> path) where T : class, new()
        {
            OpenErpSet<T> enumerable = source as OpenErpSet<T>;
            if (enumerable != null)
            {
                OpenErpService service = enumerable.Service;
                MemberExpression memberAccess = path.Body as MemberExpression;
                if (memberAccess!=null)
                {
                    MemberInfo member = memberAccess.Member as MemberInfo;
                    if (member != null)
                    {
                        //Search for openerpmap attribute
                        Type memberType = ((PropertyInfo)memberAccess.Member).PropertyType;
                        OpenErpMapAttribute[] attributes;
                        if (memberType != null)
                        {
                            if (EntityFactory.IsGenericCollection(memberType) || EntityFactory.IsGenericEnumerable(memberType))
                            {
                                //Collection, load entities
                                //If collection is type of OpenErpSet, just load data.
                                //Else, try to get openerpattribute
                                Type EnumerationType = memberType.GetGenericArguments()[0];
                                attributes = (OpenErpMapAttribute[])EnumerationType.GetCustomAttributes(typeof(OpenErpMapAttribute), false);
                                var accessFunction = path.Compile();
                                foreach (T item in enumerable)
                                {
                                    var value = accessFunction(item);
                                    if (value != null)
                                    {
                                        //Check for OpenErpSet and call load.
                                        Type openErpSetType = typeof(OpenErpSet<>).MakeGenericType(EnumerationType);
                                        if (value.GetType() == openErpSetType)
                                        {
                                            //call load data
                                            var res = value.GetType().GetMethod("LoadData").Invoke(value, null);
                                        }
                                    }
                                    else
                                    {
                                        //if has openerpmap attribute, load related data, else nothing can be done
                                        if (EnumerationType != null)
                                        {
                                            if (attributes.Length > 0)
                                            {
                                                //property type has a OpenErp mapped attribute
                                                PropertyInfo idProperty = member.DeclaringType.GetProperties().Where(p => p.Name.Equals("Id")).Single();
                                                int id = (int)idProperty.GetValue(item, null);
                                                CommandContext context = new CommandContext();
                                                context.EntityName = attributes[0].OpenErpName;
                                                context.EntityType = EnumerationType;
                                                string fieldName = ((OpenErpMapAttribute)(member.GetCustomAttributes(false).First())).OpenErpName;
                                                context.Arguments.Add(new CommandArgument() { Operation = "=", Property = fieldName, Value = id });
                                                Object res = service.ContextEntities(context);
                                                ((PropertyInfo)memberAccess.Member).SetValue(item, res, null);
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                //Single entity to load.
                                //Check basic type
                                if (memberType.IsPrimitive || memberType.Equals(typeof(string)))
                                {
                                    // Nothing can be done
                                }
                                else
                                {
                                    // Have an entity
                                    OpenErpForeignKeyAttribute fk;
                                    CommandContext context = new CommandContext();
                                    context.EntityName = CommandContextFactory.GetOpenErpEntityName(memberType);
                                    context.EntityType = memberType;
                                    fk = (OpenErpForeignKeyAttribute)member.GetCustomAttributes(typeof(OpenErpForeignKeyAttribute), false).FirstOrDefault();
                                    if (fk!=null)
                                    {
                                        PropertyInfo idProperty = member.DeclaringType.GetProperties().Where(p => p.Name.Equals(fk.PropertyName)).Single();
                                        foreach (T item in enumerable)
                                        {
                                            int id = (int)idProperty.GetValue(item, null);
                                            //Buscamos en OpenErp
                                            Object res = service.GetEntityById(context, id);
                                            ((PropertyInfo)memberAccess.Member).SetValue(item, res, null);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    throw new ArgumentException("Not a valid property to include.");
                }
            }
            return source;
        }
    }
}
