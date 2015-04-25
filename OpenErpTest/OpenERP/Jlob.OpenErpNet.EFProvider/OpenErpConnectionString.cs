using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jlob.OpenErpNet
{
    sealed class OpenErpConnectionString
    {
        private const string UrlLogin = "/xmlrpc/common";
        private const string UrlClient = "/xmlrpc/object";

        public string DataSource { get; set; }
        public string InitialCatalog { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public string Text { get; set; }

        public OpenErpConnectionString(string connectionString)
        {
            if (String.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentException("Connectionstring is null or empty");
            }
            Text = connectionString;
            foreach (string parameter in connectionString.Split(';'))
            {
                string[] splitedString = parameter.Split('=');
                switch (splitedString[0])
	            {
                    case "Data Source":
                        this.DataSource = splitedString[1];
                        break;
                    case "User Id":
                        this.UserId = splitedString[1];
                        break;
                    case "Password":
                        this.Password = splitedString[1];
                        break;
                    case "Initial Catalog":
                        this.InitialCatalog = splitedString[1];
                        break;
		            default:
                        break;
	            }
            }
        }
    }
}
