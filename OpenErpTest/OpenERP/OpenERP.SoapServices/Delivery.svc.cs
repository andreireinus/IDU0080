namespace OpenERP.SoapServices
{
    using OpenERP.Library;

    public class Delivery : ServiceBase, IDelivery
    {
        public int Add(int partnerId, int quantity)
        {
            return this.Run(() => OpenErpWrapper.Deliver(partnerId, quantity));
        }
    }
}
