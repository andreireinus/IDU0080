using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace Jlob.OpenErpNet.EFProvider
{
    /// <summary>
    /// Main access class
    /// </summary>
    public sealed class OpenErpFactory:DbProviderFactory
    {
        public static readonly OpenErpFactory Instance = new OpenErpFactory();

        public override bool CanCreateDataSourceEnumerator
        {
            get
            {
                return false;
            }
        }

        public override DbCommand CreateCommand()
        {
            return new OpenErpCommand();
        }

        public override DbCommandBuilder CreateCommandBuilder()
        {
            return new OpenErpCommandBuilder();
        }

        public override DbConnection CreateConnection()
        {
            return new OpenErpConnection();
        }

        public override DbConnectionStringBuilder CreateConnectionStringBuilder()
        {
            return new OpenErpConnectionStringBuilder();
        }

        public override DbDataSourceEnumerator CreateDataSourceEnumerator()
        {
            return new OpenErpDataSourceEnumerator();
        }

        public override DbParameter CreateParameter()
        {
            return base.CreateParameter();
        }

        public override System.Security.CodeAccessPermission CreatePermission(System.Security.Permissions.PermissionState state)
        {
            return base.CreatePermission(state);
        }
    }
}
