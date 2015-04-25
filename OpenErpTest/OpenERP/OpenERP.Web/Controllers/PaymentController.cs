using System.Web.Mvc;

namespace OpenERP.Web.Controllers
{
    using OpenERP.Web.Models;
    using OpenERP.Web.WCF.Invoice;
    using OpenERP.Web.WCF.Payment;

    public class PaymentController : BaseController
    {
        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult Add(string number)
        {
            AccountInvoice invoice = null;

            this.RunSafe(() => invoice = (new InvoiceClient()).GetByNumber(number));
            
            return this.View(invoice);
        }

        [HttpPost]
        public ActionResult Add(string number, string amount)
        {
            AccountInvoice invoice = null;
            
            this.RunSafe(
                () =>
                    {
                        invoice = (new InvoiceClient()).GetByNumber(number);

                        var dAmount = double.Parse(amount);

                        var paymentService = new PaymentClient();
                        paymentService.Add(invoice.Id, dAmount);

                        invoice = (new InvoiceClient()).GetByNumber(number);
                    });
            

            return this.View(invoice);
        }
    }
}