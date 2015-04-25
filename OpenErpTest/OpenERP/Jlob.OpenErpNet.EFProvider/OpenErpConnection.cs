using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data;
using Jlob.OpenErpNet;

namespace Jlob.OpenErpNet.EFProvider
{
    public sealed class OpenErpConnection:DbConnection
    {

        private OpenErpConnectionString connectionString;
        private OpenErpService openErpService;
        private ConnectionState state;

        protected override DbTransaction BeginDbTransaction(System.Data.IsolationLevel isolationLevel)
        {
            throw new NotImplementedException();
        }

        public override void ChangeDatabase(string databaseName)
        {
            throw new NotImplementedException();
        }

        public override void Close()
        {
            throw new NotImplementedException();
        }

        public override string ConnectionString
        {
            get
            {
                if (connectionString != null)
                {
                    return connectionString.Text;
                }
                else
                {
                    return string.Empty;
                }
            }
            set
            {
                connectionString = new OpenErpConnectionString(value);
            }
        }

        protected override DbCommand CreateDbCommand()
        {
            throw new NotImplementedException();
        }

        public override string DataSource
        {
            get {
                if (connectionString != null)
                {
                    return connectionString.DataSource;
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public override string Database
        {
            get {
                if (connectionString != null)
                {
                    return connectionString.InitialCatalog;
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public override void Open()
        {
            if (this.state == ConnectionState.Closed)
            {
                if (this.openErpService == null)
                {
                    this.openErpService = new OpenErpService(this.connectionString.DataSource, 
                        this.connectionString.InitialCatalog, 
                        this.connectionString.UserId, 
                        this.connectionString.Password);
                }
            }
            throw new NotImplementedException();
        }

        public override string ServerVersion
        {
            get { return "7.0"; }
        }

        public override System.Data.ConnectionState State
        {
            get { return this.state; }
        }

    }
}
