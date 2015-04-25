namespace OpenERP.Web.Models
{
    using OpenERP.Web.WCF.Invoice;

    public class DeliveryViewModel
    {
        public string Number { get; set; }

        public AccountInvoice Invoice { get; set; }
        public int DeliveryQuantity { get; set; }
    }
}