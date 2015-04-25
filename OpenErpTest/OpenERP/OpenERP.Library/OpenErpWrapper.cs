namespace OpenERP.Library
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Linq.Expressions;

    using Jlob.OpenErpNet;

    using Newtonsoft.Json;

    using OpenERP.Library.Entities;

    public class OpenErpWrapper
    {
        private static OpenErpService service;

        public static OpenErpService GetService()
        {
            return service
                   ?? (service = new OpenErpService("http://193.40.244.170:1099", "openerp_eng", "admin", "openerp_eng"));
        }

        public static int AddPaymentVoucher(int invoiceId, double amount)
        {
            if (amount <= 0)
            {
                throw new BusinessLogicException(BusinessLogicCodes.PaymentAboveZero, "Maksesumma peab olema suurem nullist");
            }

            var invoice = GetService().GetEntities<AccountInvoice>(i => i.Id == invoiceId).First();

            if (invoice.Residual == 0 || invoice.State != "open")
            {
                throw new BusinessLogicException(BusinessLogicCodes.InvoicePaid, "Arve on juba tasutud");
            }

            if (invoice.Residual != null)
            {
                amount = Math.Min(amount, invoice.Residual.Value);
            }

            Debug.Assert(invoice.MoveId != null, "invoice.MoveId != null");
            var moveLineId = GetMoveLineId(invoice.MoveId.Value);

            var accountVoucher = new AccountVoucher
            {
                JournalId = 7,
                AccountId = 12,
                CurrencyId = 1,
                Date = DateTime.Now,
                PartnerId = invoice.PartnerId,
                CompanyId = 1,
                PaymentOption = "without_writeoff",
                Comment = "draft",
                Type = "receipt",
                Name = invoice.Number,
                Reference = invoice.Number,

                Amount = amount
            };

            service.AddEntity(accountVoucher);

            var accountVoucherLine = CreateVoucherLine(accountVoucher.Id, amount, invoice.PartnerId, invoiceId, moveLineId);
            service.AddEntity(accountVoucherLine);

            service.ExecuteWorkflow<AccountVoucher>("proforma_voucher", accountVoucher.Id);

            return -1;
        }

        private static int GetMoveLineId(int moveId)
        {
            return GetService().GetEntities<AccountMoveLine>(l => l.MoveId == moveId).First().Id;
        }

        public static void AddPaymentVoucherLine(int voucherId, double amount, int customerId, int invoiceId, int moveLineId)
        {
            var line = CreateVoucherLine(voucherId, amount, customerId, invoiceId, moveLineId);
            GetService().AddEntity(line);
        }

        private static AccountVoucherLine CreateVoucherLine(int voucherId, double amount, int customerId, int invoiceId, int moveLineId)
        {
            return new AccountVoucherLine
            {
                Name = "Web payment",
                VoucherId = voucherId,
                PartnerId = customerId,
                Type = "cr",
                AccountId = 9,
                MoveLineId = moveLineId,
                Amount = amount
            };
        }

        public static AccountInvoice CreateInvoice(Customer customer, ProductProduct product, int quantity)
        {
            if (quantity <= 0)
            {
                throw new Exception("Kogus peab olema positiivne arv");
            }

            var productCount = new AccountInvoiceProductCount(product, quantity);

            var invoice = new AccountInvoice
            {
                PartnerId = customer.Id,
                AddressInvoiceId = 1,
                UserId = 1,
                AccountId = 9, // Viit deebit-kande kontole - 'X11002 Debtors - (test)'
                JournalId = 1, // Myygi raamatupidamisse lahevad selle arve kanded - 'Sales Journal - (test)'
                CurrencyId = 1, // EUR
                CompanyId = 1,
                DateInvoice = DateTime.Now,
                Name = product.NameTemplate,
                Comment = JsonConvert.SerializeObject(productCount),
                ReferenceType = "none",
            };

            GetService().AddEntity(invoice);
            GetService().AddEntity(CreateInvoiceRow(invoice, product, quantity));

            GetService().ExecuteWorkflow<AccountInvoice>("invoice_open", invoice.Id);

            return GetService().GetEntities<AccountInvoice>(i => i.Id == invoice.Id).First();
        }


        private static AccountInvoiceLine CreateInvoiceRow(AccountInvoice invoice, ProductProduct product, int quantity)
        {
            return new AccountInvoiceLine
            {
                AccountId = 22,
                Name = product.NameTemplate,
                PriceUnit = product.LstPrice,
                Quantity = quantity,
                ProductId = product.Id,
                InvoiceId = invoice.Id,
            };
        }

        public static AccountInvoice GetInvoice(int invoiceId)
        {
            return GetInvoice(i => i.Id == invoiceId);
        }

        public static AccountInvoice GetInvoice(Expression<Func<AccountInvoice, bool>> func)
        {
            var invoice = GetService().GetEntities(func).FirstOrDefault();
            if (invoice == null)
            {
                throw new BusinessLogicException(BusinessLogicCodes.InvoiceNotFound, "Arvet ei leitud.");
            }

            var lines = GetService().GetEntities<AccountInvoiceLine>(l => l.InvoiceId == invoice.Id).ToArray();
            foreach (var line in lines)
            {
                AccountInvoiceLine line1 = line;
                line.Product = GetService().GetEntities<ProductProduct>(p => p.Id == line1.ProductId).FirstOrDefault();
            }

            invoice.InvoiceLines = lines;

            return invoice;
        }

        public static int Deliver(int invoiceId, int quantity)
        {
            var invoice = GetInvoice(invoiceId);
            if (invoice.Residual > 0)
            {
                throw new BusinessLogicException(BusinessLogicCodes.DeliverError, "Arve tasumata.");                
            }

            var productCount = JsonConvert.DeserializeObject<AccountInvoiceProductCount>(invoice.Comment);
            var left = productCount.Invoiced - productCount.Delivered;

            if (left == 0)
            {
                throw new BusinessLogicException(BusinessLogicCodes.DeliverError, "Kõik tooted on välja antud");
            }

            if (left < quantity)
            {
                throw new BusinessLogicException(BusinessLogicCodes.DeliverError, "Ei saa nii palju tooteid väljastada.");
            }

            var product = GetService().GetEntities<ProductProduct>(a => a.Id == productCount.ProductId).FirstOrDefault();
            if (product == null)
            {
                throw new BusinessLogicException(BusinessLogicCodes.DeliverError, "Toodet ei leitud.");
            }

            var stockMove = new StockMove
            {
                ProductId = product.Id,
                ProductQty = quantity,
                ProductUom = 1,
                LocationId = 12,
                LocationDestId = 9,
                Name = product.NameTemplate,
                PartnerId = invoice.PartnerId
            };

            GetService().AddEntity(stockMove);
            GetService().ExecuteWorkflow<StockMove>("action_done", stockMove.Id);

            productCount.Delivered += quantity;
            invoice.Comment = JsonConvert.SerializeObject(productCount);
            GetService().UpdateEntity(invoice);

            return stockMove.Id;

        }

        public static Customer[] SearchCustomer(string searchString)
        {
            var result = GetService().GetEntities<Customer>(c => c.Name.Contains(searchString)).ToArray();
            if (!result.Any())
            {
                throw new BusinessLogicException(BusinessLogicCodes.CustomerNotFound, "Klienti ei leitud");
            }

            return result;
        }

        public static Customer SearchCustomer(int id)
        {
            var result = OpenErpWrapper.GetService().GetEntities<Library.Entities.Customer>(c => c.Id == id).ToArray();
            if (!result.Any())
            {
                throw new BusinessLogicException(BusinessLogicCodes.CustomerNotFound, "Klienti ei leitud");
            }

            return result.First();
        }
    }
}
