namespace OpenERP.SoapServices
{
    using OpenERP.Library;

    public class Payment : ServiceBase, IPayment
    {
        public int Add(int invoiceId, double amount)
        {
            return this.Run(() => OpenErpWrapper.AddPaymentVoucher(invoiceId, amount));
        }
    }
}
