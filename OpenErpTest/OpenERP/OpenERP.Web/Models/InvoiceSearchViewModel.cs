namespace OpenERP.Web.Models
{
    using System.Collections.Generic;
    using System.ComponentModel;

    using OpenERP.Web.WCF.Customer;
    using OpenERP.Web.WCF.Product;

    public class InvoiceSearchViewModel
    {
        public InvoiceSearchViewModel()
        {
            Products = new List<ProductProduct>();
        }

        [DisplayName("Kliendi nimi")]
        public string CustomerName { get; set; }
        [DisplayName("Toote nimi")]
        public string ProductName { get; set; }

        public List<ProductProduct> Products { get; set; }

        public int ProductId { get; set; }

        public ProductProduct Product { get; set; }
        public int ProductCount { get; set; }

        public Customer Customer { get; set; }
    }

    public class InvoiceCreateViewModel
    {
        public string SubTask { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }

        [DisplayName("Toode")]
        public ProductProduct Product { get; set; }
        [DisplayName("Klient")]
        public Customer Customer { get; set; }

        [DisplayName("Kogus")]
        public int Amount { get; set; }

        [DisplayName("Summa kokku")]
        public double TotalAmount { get; set; }
    }
}