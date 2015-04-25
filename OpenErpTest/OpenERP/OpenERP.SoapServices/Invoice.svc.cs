namespace OpenERP.SoapServices
{
    using OpenERP.Library;

    public class Invoice : ServiceBase, IInvoice
    {
        public AccountInvoice Create(Library.Entities.Customer customer, ProductProduct product, int quantity)
        {
            return this.Run(() => OpenErpWrapper.CreateInvoice(customer, product, quantity));
        }

        public AccountInvoice GetById(int id)
        {
            return this.Run(() => OpenErpWrapper.GetInvoice(i => i.Id == id));
        }

        public AccountInvoice GetByNumber(string number)
        {
            return this.Run(() => OpenErpWrapper.GetInvoice(i => i.Number == number));
        }
    }
}
