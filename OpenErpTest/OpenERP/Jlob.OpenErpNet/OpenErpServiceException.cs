using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookComputing.XmlRpc;

namespace Jlob.OpenErpNet
{
    public class OpenErpServiceException:Exception
    {

        public OpenErpServiceException()
        {
        }

        public OpenErpServiceException(string message)
            : base(message)
        {
        }

        public OpenErpServiceException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected internal static OpenErpServiceException GetException(XmlRpcFaultException e)
        {
            string message = string.Empty;
            string[] messages = e.Message.Split('\n');
            if (messages.Length >= 3)
            {
                try
                {
                    message = string.Join("\n", messages.Skip(2));
                }
                catch (Exception)
                {
                    message = e.Message;
                }
            }
            else
            {
                message = e.Message;
            }
            return new OpenErpServiceException(message, e);
        }
    }
}
