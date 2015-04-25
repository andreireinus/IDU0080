namespace OpenERP.Library
{
    public class AccountInvoiceProductCount
    {
        public int ProductId { get; set; }
        public int Invoiced { get; set; }
        public int Delivered { get; set; }

        public AccountInvoiceProductCount()
        {
        }

        public AccountInvoiceProductCount(ProductProduct product, int quantity)
        {
            ProductId = product.Id;
            Invoiced = quantity;
            Delivered = 0;
        }
    }
}
