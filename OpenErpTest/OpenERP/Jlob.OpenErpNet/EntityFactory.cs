using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using CookComputing.XmlRpc;

namespace Jlob.OpenErpNet
{
    public class EntityFactory
    {

        /// <summary>
        /// Create entities and load values
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="resultset"></param>
        /// <returns></returns>
        public static ICollection<T> BuildEntities<T>(OpenErpService service, ResultSet resultset) where T : class, new()
        {
            OpenErpSet<T> entityCollection = new OpenErpSet<T>(service);
            BuildEntities<T>(service, resultset, entityCollection);
            return entityCollection;
        }

        /// <summary>
        /// Use an existint collection to load entities
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="service"></param>
        /// <param name="resultset"></param>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static void BuildEntities<T>(OpenErpService service, ResultSet resultset, ICollection<T> collection) where T : class, new()
        {
            foreach (object entity in resultset.Data)
            {
                XmlRpcStruct xmlStruct = (XmlRpcStruct)entity;
                collection.Add(BuildEntity<T>(service, xmlStruct));
            }
        }

        public static T BuildEntity<T>(OpenErpService service, XmlRpcStruct xmlStruct) where T : class, new()
        {
            T entity = new T();
            foreach (DictionaryEntry item in xmlStruct)
            {
                PropertyInfo property = GetPropertyFromEntity<T>(item.Key as string);
                if (property != null)
                {
                    object value = item.Value;
                    if (IsOpenErpNull(item.Value))
                    {
                        //If is a basic type this throws an exception
                        value = null;
                    }
                    else if (IsGenericCollection(property.PropertyType))
                    {
                        //Create a collection of entities
                        Type type = typeof(OpenErpSet<>).MakeGenericType(property.PropertyType.GetGenericArguments());
                        value = Activator.CreateInstance(type, service, item.Value);
                    }
                    else
                    {
                        OpenErpMapAttribute attibute = (OpenErpMapAttribute)property.GetCustomAttributes(typeof(OpenErpMapAttribute), false).FirstOrDefault();
                        if (attibute != null)
                        {
                            switch (attibute.OpenErpType)
                            {
                                case OpenErpType.Char:
                                    if (property.Name.Equals("DateTime"))
                                    {
                                        value = DateTime.ParseExact(item.Value.ToString(), "yyyy-MM-dd HH:mm:ss", System.Threading.Thread.CurrentThread.CurrentCulture);
                                    }
                                    break;
                                case OpenErpType.Text:
                                    break;
                                case OpenErpType.Date:
                                    value = DateTime.ParseExact(item.Value.ToString(), "yyyy-MM-dd", System.Threading.Thread.CurrentThread.CurrentCulture);
                                    break;
                                case OpenErpType.Datetime:
                                    value = DateTime.ParseExact(item.Value.ToString(), "yyyy-MM-dd HH:mm:ss", System.Threading.Thread.CurrentThread.CurrentCulture);
                                    break;
                                default:
                                    value = item.Value;
                                    break;
                            }
                        }
                    }
                    //check if is a object. Load related entity.
                    if (value as object[] != null)
                    {
                        if ((value as object[]).Length > 0)
                        {
                            value = (value as object[])[0]; //id of related entity
                        }
                        else
                        {
                            value = null;
                        }
                    }
                    //Asign value directly
                    property.SetValue(entity, value, null);
                }
            }
            return entity;
        }

        public static PropertyInfo GetPropertyFromEntity<T>(string key)
        {
            PropertyInfo property;
            Type type = typeof(T);
            property = type.GetProperties().FirstOrDefault(p => p.Name.Equals(key));
            if (property == null)
            {
                property = type.GetProperties()
                                .FirstOrDefault(p =>
                                    p.GetCustomAttributes(typeof(OpenErpMapAttribute), false)
                                    .Cast<OpenErpMapAttribute>()
                                    .Where(e => e.OpenErpName.Equals(key))
                                    .Count() == 1);
            }
            return property;
        }

        public static OpenErpType GetOpenErpType(PropertyInfo property)
        {
            OpenErpMapAttribute[] attributes;
            attributes = (OpenErpMapAttribute[])property.GetCustomAttributes(typeof(OpenErpMapAttribute), false);
            if (attributes.Length > 0)
            {
                return attributes[0].OpenErpType;
            }
            return OpenErpType.Undefined;
        }

        /// <summary>
        /// Checks for a null value from OpenErp.
        /// OpenErp will return false for a null value.
        /// </summary>
        /// <param name="value"></param>
        public static bool IsOpenErpNull(object value)
        {
            if (value is bool && !(bool)value)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Check if is a generic collection
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsGenericCollection(Type type){
            return type.IsGenericType?type.GetGenericTypeDefinition() == typeof(ICollection<>):false;
        }

        public static bool IsGenericEnumerable(Type type)
        {
            return type.IsGenericType ? type.GetGenericTypeDefinition() == typeof(IEnumerable<>) : false;
        }

    }
}
