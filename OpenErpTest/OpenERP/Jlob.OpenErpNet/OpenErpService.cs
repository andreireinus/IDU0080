using CookComputing.XmlRpc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Configuration;
using System.Reflection;

namespace Jlob.OpenErpNet
{
    public class OpenErpService
    {
        private OpenErpServiceContext context;
        private const string UrlLogin = "/xmlrpc/common";
        private const string UrlClient = "/xmlrpc/object";
        private const string DbNameOption = "OpenErpDbName";
        private const string UserNameOption = "OpenErpUser";
        private const string PwdOption = "OpenErpPwd";
        private const string UrlOption = "OpenErpUrl";

        #region Constructors
        /// <summary>
        /// Takes configuration from app.config parameters
        /// </summary>
        public OpenErpService()
        {
            context = new OpenErpServiceContext();
            context.OpenErpLogin = XmlRpcProxyGen.Create<IOpenErpLogin>();
            context.OpenErpClient = XmlRpcProxyGen.Create<IOpenErp>();
            if (!String.IsNullOrEmpty(ConfigurationManager.AppSettings[UrlOption]))
            {
                context.OpenErpLogin.Url = ConfigurationManager.AppSettings[UrlOption] + UrlLogin;
                context.OpenErpClient.Url = ConfigurationManager.AppSettings[UrlOption] + UrlClient;
            }
            if (!String.IsNullOrEmpty(ConfigurationManager.AppSettings[DbNameOption]))
            {
                context.DbName = ConfigurationManager.AppSettings[DbNameOption];
            }
            if (!String.IsNullOrEmpty(ConfigurationManager.AppSettings[UserNameOption]))
            {
                context.User = ConfigurationManager.AppSettings[UserNameOption];
            }
            if (!String.IsNullOrEmpty(ConfigurationManager.AppSettings[PwdOption]))
            {
                context.Pwd = ConfigurationManager.AppSettings[PwdOption];
            }
        }

        /// <summary>
        /// Createas a new instance of OpenErpService
        /// </summary>
        /// <param name="url">OpenErp access url, ej: http://192.168.2.1:8069</param>
        public OpenErpService(string url)
            : this()
        {
            this.context.OpenErpClient.Url = url + UrlClient;
            this.context.OpenErpLogin.Url = url + UrlLogin;
        }

        /// <summary>
        /// Creates a new instance of OpenErpService
        /// </summary>
        /// <param name="url">OpenErp instance access url, ej: http://192.168.2.1:8069</param>
        /// <param name="dbName">Database name to connect to OpenErp instance</param>
        /// <param name="userName">Username to connect to OpenErp instance</param>
        /// <param name="pwd">Password to connect to OpenErp instance</param>
        public OpenErpService(string url, string dbName, string userName, string pwd)
            : this(url)
        {
            context.DbName = dbName;
            context.User = userName;
            context.Pwd = pwd;
        }
        #endregion

        private void ExecuteWorkflow(string entityName, string workflowName, object id)
        {
            this.context.OpenErpClient.ExecuteWorkflow(
                this.context.DbName, 
                this.context.UserId, 
                this.context.Pwd, 
                entityName, 
                workflowName, 
                id);
        }

        public void ExecuteWorkflow<T>(string workflowName, int id)
        {
            var type = typeof(T);
            var attr = type.GetCustomAttribute<OpenErpMapAttribute>();

            if (attr == null)
            {
                throw new ArgumentException("T does not contain OpenErpMapAttribute");
            }

            this.ExecuteWorkflow(attr.OpenErpName, workflowName, id);
        }


        public IEnumerable<T> GetEntities<T>(Expression<Func<T, bool>> conditions) where T : class, new()
        {
            CommandContext context;
            context = CommandContextFactory.BuildCommandContextFromExpression<T>(conditions);
            IEnumerable<object> ids = SearchCommand(context);
            context.ClearArguments();
            ResultSet result = GetEntityCommand(context, ids);
            IEnumerable<T> entities = EntityFactory.BuildEntities<T>(this, result);
            return entities;
        }

        public IEnumerable ContextEntities(CommandContext context)
        {
            ResultSet resultset;
            IEnumerable<object> ids;
            ids = SearchCommand(context);
            context.ClearArguments();
            resultset = GetEntityCommand(context, ids);
            MethodInfo method = typeof(EntityFactory).GetMethod("BuildEntities", new[] { this.GetType(), typeof(ResultSet) });
            method = method.MakeGenericMethod(context.EntityType);
            IEnumerable res = method.Invoke(this, new object[] { this, resultset }) as IEnumerable;
            return res.Cast<object>();
        }

        /// <summary>
        /// Gets an entity from openerp. Reads openerpmap attribute for underlaying property type and
        /// gets from openerp.
        /// </summary>
        /// <param name="property">Property info</param>
        /// <param name="id">Id of entity to search</param>
        /// <returns>Entity object</returns>
        internal object GetEntityById(CommandContext context, int id)
        {
            ResultSet resultset;
            resultset = GetEntityCommand(context, new object[] { id });
            //Call a BuildEntities genereci method from this class
            MethodInfo method = typeof(EntityFactory).GetMethod("BuildEntities", new[] { this.GetType(), typeof(ResultSet) });
            method = method.MakeGenericMethod(context.EntityType);
            IEnumerable res = method.Invoke(this, new object[] { this, resultset }) as IEnumerable;
            return res.Cast<object>().First();
        }

        /// <summary>
        /// Add entity to OpenErp
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        public void AddEntity<T>(T entity) where T : class
        {
            CommandContext context;
            int id;
            context = CommandContextFactory.BuildCommandContextFromEntity<T>(entity);
            id = AddCommand(context);
            //Asignamos el id a la entidad
            SetEntityId<T>(entity, id);
        }

        /// <summary>
        /// Delete entity from OpenErp
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        public void DeleteEntity<T>(T entity) where T : class
        {
            CommandContext context;
            context = CommandContextFactory.BuildCommandContextFromEntity<T>(entity);
            DeleteCommand(context);

        }

        /// <summary>
        /// Update OpenErp entity with current entity values
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        public void UpdateEntity<T>(T entity) where T : class
        {
            CommandContext context;
            context = CommandContextFactory.BuildCommandContextFromEntity<T>(entity);
            UpdateCommand(context);
        }

        private IEnumerable<object> SearchCommand(CommandContext commandContext)
        {
            object[] res;
            //Login
            this.context.UserId = this.context.OpenErpLogin.login(this.context.DbName, this.context.User, this.context.Pwd);

            var commandArguments = commandContext.GetArguments();

            res = this.context.OpenErpClient.search(
                this.context.DbName, 
                this.context.UserId, 
                this.context.Pwd, 
                commandContext.EntityName, 
                "search", 
                commandArguments);
            return res.ToList();
        }

        /// <summary>
        /// Execute Add command in OpenErp with context params.
        /// 
        /// Exclude id property because OpenErp will return it after creation.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private int AddCommand(CommandContext context)
        {
            int res;
            //Login
            this.context.UserId = this.context.OpenErpLogin.login(this.context.DbName, this.context.User, this.context.Pwd);
            //Transformamos los argumentos en XmlRpcStruct
            XmlRpcStruct fields = new XmlRpcStruct();
            foreach (CommandArgument argument in context.Arguments)
            {
                if (!argument.Property.Equals("id"))
                {
                    fields.Add(argument.Property, argument.Value);
                }
            }
            try
            {
                res = this.context.OpenErpClient.create(this.context.DbName, this.context.UserId, this.context.Pwd, context.EntityName, "create", fields);
            }
            catch (XmlRpcFaultException e)
            {
                throw OpenErpServiceException.GetException(e);
            }
            return res;
        }

        /// <summary>
        /// Executes delete command in OpenErp. Get id from context.
        /// </summary>
        /// <param name="context"></param>
        private void DeleteCommand(CommandContext context)
        {
            this.context.UserId = this.context.OpenErpLogin.login(this.context.DbName, this.context.User, this.context.Pwd);
            CommandArgument idArgument = (from a in context.Arguments
                                          where a.Property.Equals("id")
                                          select a).First();
            object[] idArray = new object[1];
            idArray[0] = idArgument.Value;
            this.context.OpenErpClient.unlink(this.context.DbName, this.context.UserId, this.context.Pwd, context.EntityName, "unlink", idArray);
        }

        private void UpdateCommand(CommandContext context)
        {
            this.context.UserId = this.context.OpenErpLogin.login(this.context.DbName, this.context.User, this.context.Pwd);
            int[] idArray = new int[1];
            //Transformamos los argumentos en XmlRpcStruct
            XmlRpcStruct fields = new XmlRpcStruct();
            foreach (CommandArgument argument in context.Arguments)
            {
                if (!argument.Property.Equals("id"))
                {
                    if (argument.Value != null)
                    {
                        fields.Add(argument.Property, argument.Value);
                    }
                }
                else
                {
                    idArray[0] = (int)argument.Value;
                }
            }
            this.context.OpenErpClient.write(this.context.DbName, this.context.UserId, this.context.Pwd, context.EntityName, "write", idArray, fields);
        }

        public ResultSet GetEntityCommand(CommandContext commandContext, IEnumerable<object> ids)
        {
            Object[] resultset;
            resultset = this.context.OpenErpClient.read(this.context.DbName, this.context.UserId, this.context.Pwd, commandContext.EntityName, "read", ids.ToArray(), commandContext.GetArguments());
            return new ResultSet(resultset);
        }

        /// <summary>
        /// Set property id from T entity. Used after insert a entity
        /// into OpenErp. OpenErp will return id of inserted entity and
        /// this method will asign to an entity's property mapped as id.
        /// </summary>
        /// <typeparam name="T">Entity type</typeparam>
        /// <param name="entity">Entity instance</param>
        /// <param name="value">Id to assign</param>
        private void SetEntityId<T>(T entity, int value)
        {
            Type t = typeof(T);
            System.Reflection.PropertyInfo prop = t.GetProperties()
                                                            .FirstOrDefault(p =>
                                                                p.GetCustomAttributes(typeof(OpenErpMapAttribute), false)
                                                                    .Cast<OpenErpMapAttribute>().Count(e => e.OpenErpName.Equals("id")) == 1);
            if (prop != null)
            {
                prop.SetValue(entity, value, null);
            }
        }

    }
}
