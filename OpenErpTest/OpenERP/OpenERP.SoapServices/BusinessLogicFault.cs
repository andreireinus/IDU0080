namespace OpenERP.SoapServices
{
    using System;
    using System.Runtime.Serialization;
    using System.ServiceModel;

    using OpenERP.Library;

    [ServiceContract]
    public interface IProduct
    {
        [OperationContract]
        [FaultContract(typeof(BusinessLogicFault))]
        ProductProduct SearchById(int id);

        [OperationContract]
        [FaultContract(typeof(BusinessLogicFault))]
        ProductProduct[] SearchByName(string name);
    }

    [ServiceContract]
    public interface IPayment
    {
        [OperationContract]
        [FaultContract(typeof(BusinessLogicFault))]
        int Add(int invoiceId, double amount);
    }

    [ServiceContract]
    public interface IInvoice
    {
        [OperationContract]
        [FaultContract(typeof(BusinessLogicFault))]
        AccountInvoice Create(Library.Entities.Customer customer, ProductProduct product, int quantity);

        [OperationContract]
        [FaultContract(typeof(BusinessLogicFault))]
        AccountInvoice GetById(int id);

        [OperationContract]
        [FaultContract(typeof(BusinessLogicFault))]
        AccountInvoice GetByNumber(string number);
    }

    [ServiceContract]
    public interface ICustomer
    {
        [OperationContract]
        [FaultContract(typeof(BusinessLogicFault))]
        Library.Entities.Customer[] Search(string name);

        [OperationContract]
        [FaultContract(typeof(BusinessLogicFault))]
        Library.Entities.Customer SearchById(int id);
    }

    [ServiceContract]
    public interface IDelivery
    {
        [OperationContract]
        [FaultContract(typeof(BusinessLogicFault))]
        int Add(int partnerId, int quantity);
    }  

    [DataContract(Namespace = "http://idu0080.ttu.ee")]
    public class BusinessLogicFault
    {
        [DataMember]
        public int Code { get; set; }

        [DataMember]
        public string Message { get; set; }
    }

    public class ServiceBase
    {
        protected T Run<T>(Func<T> func)
        {
            try
            {
                return func();
            }
            catch (BusinessLogicException exception)
            {
                throw new FaultException<BusinessLogicFault>(
                    new BusinessLogicFault { Code = exception.Code, Message = exception.Message },
                    new FaultReason("BusinessLogicException"));
            }
            catch (Exception exception)
            {
                throw new FaultException<BusinessLogicFault>(
                    new BusinessLogicFault { Code = -1, Message = exception.Message });
            }
        }
    }
}