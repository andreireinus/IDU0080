using CookComputing.XmlRpc;
using System;

namespace Jlob.OpenErpNet
{

    public interface IOpenErp : IXmlRpcProxy
    {
        [XmlRpcMethod("execute")]
        int create(string dbName, int userId, string pwd, string model, string method, XmlRpcStruct fieldValues);

        [XmlRpcMethod("execute")]
        Object[] search(string dbName, int userId, string pwd, string model, string method, Object[] filters, int offset, int limit, string order);

        [XmlRpcMethod("execute")]
        Object[] search(string dbName, int userId, string pwd, string model, string method, Object[] filters, int offset, int limit);

        [XmlRpcMethod("execute")]
        Object[] search(string dbName, int userId, string pwd, string model, string method, Object[] filters);

        [XmlRpcMethod("execute")]
        bool write(string dbName, int userId, string pwd, string model, string method, int[] ids, XmlRpcStruct fieldValues);

        [XmlRpcMethod("execute")]
        bool unlink(string dbName, int userId, string dbPwd, string model, string method, object[] ids);

        [XmlRpcMethod("execute")]
        Object[] read(string dbName, int userId, string dbPwd, string model, string method, object[] ids, object[] fields);

        [XmlRpcMethod("exec_workflow")]
        Object ExecuteWorkflow(string dbName, int userId, string dbPwd, string model, string workflowName, object parameter);
    }
}
