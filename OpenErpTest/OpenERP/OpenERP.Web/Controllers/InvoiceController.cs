namespace OpenERP.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Mvc;

    using AutoMapper;

    using OpenERP.Web.Models;
    using OpenERP.Web.WCF.Invoice;
    using OpenERP.Web.WCF.Product;
    using OpenERP.Web.WCF.Customer;

    public class InvoiceController : BaseController
    {
        private readonly CustomerClient customerService = new CustomerClient();
        private readonly ProductClient productService = new ProductClient();

        public ActionResult Index()
        {
            return View(new InvoiceSearchViewModel
            {
                CustomerName = "ryhm372",
                ProductName = "ryhm372"
            });
        }

        [HttpPost]
        public ActionResult Index(InvoiceSearchViewModel model)
        {
            this.RunSafe(() =>
            {
                if (!string.IsNullOrWhiteSpace(model.CustomerName))
                {
                    model.Customer = customerService.Search(model.CustomerName).First();
                }

                if (!string.IsNullOrWhiteSpace(model.ProductName))
                {
                    model.Products = productService.SearchByName(model.ProductName).ToList();
                }
            });

            return this.View(model);
        }

        [HttpPost]
        public ActionResult Create(InvoiceCreateViewModel model)
        {
            model = this.UpdateCreateViewModel(model);

            if (model.SubTask != "create-invoice")
            {
                return this.View(model);
            }

            var client = new InvoiceClient();
            var invoice = client.Create(
                Mapper.Map<WCF.Invoice.Customer>(model.Customer),
                Mapper.Map<WCF.Invoice.ProductProduct>(model.Product),
                model.Amount);


            return RedirectToAction("Created", new { id = invoice.Id });
        }

        public ActionResult Created(int id)
        {
            var client = new InvoiceClient();
            var invoice = client.GetById(id);

            return this.View("Created", invoice);

        }

        private InvoiceCreateViewModel UpdateCreateViewModel(InvoiceCreateViewModel model)
        {
            model.Customer = this.customerService.SearchById(model.CustomerId);
            model.Product = this.productService.SearchById(model.ProductId);

            if (model.Amount <= 0)
            {
                model.Amount = 0;
            }

            if (model.Amount > 0 && model.Product.LstPrice.HasValue)
            {
                model.TotalAmount = model.Product.LstPrice.Value * model.Amount;
            }

            return model;
        }
    }
}