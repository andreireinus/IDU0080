namespace OpenERP.ConsoleApplication
{
    using System;
    using System.Linq;
    using System.Security;

    using Jlob.OpenErpNet;

    using OpenERP.Library;
    using OpenERP.Library.Entities;

    class Program
    {
        [SecurityCritical]
        static void Main(string[] args)
        {
            var customer = OpenErpWrapper.SearchCustomer("372").First();
            var product =
                OpenErpWrapper.GetService().GetEntities<ProductProduct>(p => p.NameTemplate.Contains("372")).First();

            var invoice = OpenErpWrapper.CreateInvoice(customer, product, 1);
            OpenErpWrapper.AddPaymentVoucher(invoice.Id, invoice.Residual.Value);
            OpenErpWrapper.Deliver(invoice.Id, 1);
            Console.ReadKey();
        }
    }
}
