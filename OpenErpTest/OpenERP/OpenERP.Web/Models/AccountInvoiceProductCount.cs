namespace OpenERP.Web.Models
{
    public class AccountInvoiceProductCountDTO
    {
        public int ProductId { get; set; }
        public int Invoiced { get; set; }
        public int Delivered { get; set; }
    }
}