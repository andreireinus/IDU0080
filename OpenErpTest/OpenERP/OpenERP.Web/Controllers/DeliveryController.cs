using System.Web.Mvc;

namespace OpenERP.Web.Controllers
{
    using OpenERP.Web.Models;

    public class DeliveryController : BaseController
    {
        public ActionResult Index(string number)
        {
            var model = new DeliveryViewModel { Number = number };

            this.RunSafe(
                () =>
                    {
                        if (!string.IsNullOrWhiteSpace(model.Number))
                        {
                            model.Invoice = (new WCF.Invoice.InvoiceClient()).GetByNumber(number);
                        }
                    });
            

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(DeliveryViewModel model)
        {
            this.RunSafe(
                () =>
                    {
                        if (!string.IsNullOrWhiteSpace(model.Number))
                        {
                            model.Invoice = (new WCF.Invoice.InvoiceClient()).GetByNumber(model.Number);
                        }
                    });
            return View(model);
        }

        [HttpPost]
        public ActionResult Deliver(DeliveryViewModel model)
        {
            this.RunSafe(
                () =>
                    {
                        if (!string.IsNullOrWhiteSpace(model.Number))
                        {
                            model.Invoice = (new WCF.Invoice.InvoiceClient()).GetByNumber(model.Number);
                        }

                        (new WCF.Delivery.DeliveryClient()).Add(model.Invoice.Id, model.DeliveryQuantity);
                        model.Invoice = (new WCF.Invoice.InvoiceClient()).GetByNumber(model.Number);
                    });
            return this.View("Index", model);
        }
    }
}