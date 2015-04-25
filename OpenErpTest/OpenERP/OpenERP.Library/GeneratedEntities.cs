namespace OpenERP.Library
{
	using System;
	using Jlob.OpenErpNet;

	[OpenErpMap("account.account")]
	public class AccountAccount : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("balance", OpenErpType.Float)]
		public double? Balance { get; set; }
		[OpenErpMap("code", OpenErpType.Char)]
		public string Code { get; set; }
		[OpenErpMap("company_currency_id", OpenErpType.Integer)]
		public int? CompanyCurrencyId { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("credit", OpenErpType.Float)]
		public double? Credit { get; set; }
		[OpenErpMap("currency_id", OpenErpType.Integer)]
		public int? CurrencyId { get; set; }
		[OpenErpMap("currency_mode", OpenErpType.Selection)]
		public string CurrencyMode { get; set; }
		[OpenErpMap("debit", OpenErpType.Float)]
		public double? Debit { get; set; }
		[OpenErpMap("level", OpenErpType.Integer)]
		public int? Level { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("note", OpenErpType.Char)]
		public string Note { get; set; }
		[OpenErpMap("parent_id", OpenErpType.Integer)]
		public int? ParentId { get; set; }
		[OpenErpMap("parent_left", OpenErpType.Integer)]
		public int? ParentLeft { get; set; }
		[OpenErpMap("parent_right", OpenErpType.Integer)]
		public int? ParentRight { get; set; }
		[OpenErpMap("reconcile", OpenErpType.Boolean)]
		public bool Reconcile { get; set; }
		[OpenErpMap("shortcut", OpenErpType.Char)]
		public string Shortcut { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
		[OpenErpMap("user_type", OpenErpType.Integer)]
		public int? UserType { get; set; }
	}

	[OpenErpMap("account.account.template")]
	public class AccountAccountTemplate : OpenErpEntityBase {
		[OpenErpMap("code", OpenErpType.Char)]
		public string Code { get; set; }
		[OpenErpMap("currency_id", OpenErpType.Integer)]
		public int? CurrencyId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("nocreate", OpenErpType.Boolean)]
		public bool Nocreate { get; set; }
		[OpenErpMap("note", OpenErpType.Char)]
		public string Note { get; set; }
		[OpenErpMap("parent_id", OpenErpType.Integer)]
		public int? ParentId { get; set; }
		[OpenErpMap("reconcile", OpenErpType.Boolean)]
		public bool Reconcile { get; set; }
		[OpenErpMap("shortcut", OpenErpType.Char)]
		public string Shortcut { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
		[OpenErpMap("user_type", OpenErpType.Integer)]
		public int? UserType { get; set; }
	}

	[OpenErpMap("account.account.type")]
	public class AccountAccountType : OpenErpEntityBase {
		[OpenErpMap("close_method", OpenErpType.Selection)]
		public string CloseMethod { get; set; }
		[OpenErpMap("code", OpenErpType.Char)]
		public string Code { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("note", OpenErpType.Char)]
		public string Note { get; set; }
		[OpenErpMap("report_type", OpenErpType.Selection)]
		public string ReportType { get; set; }
		[OpenErpMap("sign", OpenErpType.Selection)]
		public string Sign { get; set; }
	}

	[OpenErpMap("account.analytic.account")]
	public class AccountAnalyticAccount : OpenErpEntityBase {
		[OpenErpMap("amount_invoiced", OpenErpType.Float)]
		public double? AmountInvoiced { get; set; }
		[OpenErpMap("amount_max", OpenErpType.Float)]
		public double? AmountMax { get; set; }
		[OpenErpMap("balance", OpenErpType.Float)]
		public double? Balance { get; set; }
		[OpenErpMap("code", OpenErpType.Char)]
		public string Code { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("complete_name", OpenErpType.Char)]
		public string CompleteName { get; set; }
		[OpenErpMap("contact_id", OpenErpType.Integer)]
		public int? ContactId { get; set; }
		[OpenErpMap("credit", OpenErpType.Float)]
		public double? Credit { get; set; }
		[OpenErpMap("currency_id", OpenErpType.Integer)]
		public int CurrencyId { get; set; }
		[OpenErpMap("date", OpenErpType.Date)]
		public DateTime? Date { get; set; }
		[OpenErpMap("date_start", OpenErpType.Date)]
		public DateTime? DateStart { get; set; }
		[OpenErpMap("debit", OpenErpType.Float)]
		public double? Debit { get; set; }
		[OpenErpMap("description", OpenErpType.Char)]
		public string Description { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("parent_id", OpenErpType.Integer)]
		public int? ParentId { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("pricelist_id", OpenErpType.Integer)]
		public int? PricelistId { get; set; }
		[OpenErpMap("quantity", OpenErpType.Float)]
		public double? Quantity { get; set; }
		[OpenErpMap("quantity_max", OpenErpType.Float)]
		public double? QuantityMax { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("to_invoice", OpenErpType.Integer)]
		public int? ToInvoice { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("account.analytic.journal")]
	public class AccountAnalyticJournal : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("code", OpenErpType.Char)]
		public string Code { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
	}

	[OpenErpMap("account.analytic.line")]
	public class AccountAnalyticLine : OpenErpEntityBase {
		[OpenErpMap("account_id", OpenErpType.Integer)]
		public int AccountId { get; set; }
		[OpenErpMap("amount", OpenErpType.Float)]
		public double Amount { get; set; }
		[OpenErpMap("amount_currency", OpenErpType.Float)]
		public double? AmountCurrency { get; set; }
		[OpenErpMap("code", OpenErpType.Char)]
		public string Code { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("currency_id", OpenErpType.Integer)]
		public int? CurrencyId { get; set; }
		[OpenErpMap("date", OpenErpType.Date)]
		public DateTime Date { get; set; }
		[OpenErpMap("general_account_id", OpenErpType.Integer)]
		public int GeneralAccountId { get; set; }
		[OpenErpMap("invoice_id", OpenErpType.Integer)]
		public int? InvoiceId { get; set; }
		[OpenErpMap("journal_id", OpenErpType.Integer)]
		public int JournalId { get; set; }
		[OpenErpMap("move_id", OpenErpType.Integer)]
		public int? MoveId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("product_uom_id", OpenErpType.Integer)]
		public int? ProductUomId { get; set; }
		[OpenErpMap("ref", OpenErpType.Char)]
		public string Ref { get; set; }
		[OpenErpMap("to_invoice", OpenErpType.Integer)]
		public int? ToInvoice { get; set; }
		[OpenErpMap("unit_amount", OpenErpType.Float)]
		public double? UnitAmount { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("account.bank.statement")]
	public class AccountBankStatement : OpenErpEntityBase {
		[OpenErpMap("account_id", OpenErpType.Integer)]
		public int? AccountId { get; set; }
		[OpenErpMap("balance_end", OpenErpType.Float)]
		public double? BalanceEnd { get; set; }
		[OpenErpMap("balance_end_cash", OpenErpType.Float)]
		public double? BalanceEndCash { get; set; }
		[OpenErpMap("balance_end_real", OpenErpType.Float)]
		public double? BalanceEndReal { get; set; }
		[OpenErpMap("balance_start", OpenErpType.Float)]
		public double? BalanceStart { get; set; }
		[OpenErpMap("closing_date", OpenErpType.Datetime)]
		public DateTime? ClosingDate { get; set; }
		[OpenErpMap("coda_id", OpenErpType.Integer)]
		public int? CodaId { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("currency", OpenErpType.Integer)]
		public int? Currency { get; set; }
		[OpenErpMap("date", OpenErpType.Date)]
		public DateTime Date { get; set; }
		[OpenErpMap("journal_id", OpenErpType.Integer)]
		public int JournalId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("period_id", OpenErpType.Integer)]
		public int PeriodId { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("total_entry_encoding", OpenErpType.Float)]
		public double? TotalEntryEncoding { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("account.bank.statement.line")]
	public class AccountBankStatementLine : OpenErpEntityBase {
		[OpenErpMap("account_id", OpenErpType.Integer)]
		public int AccountId { get; set; }
		[OpenErpMap("amount", OpenErpType.Float)]
		public double? Amount { get; set; }
		[OpenErpMap("amount_reconciled", OpenErpType.Float)]
		public double? AmountReconciled { get; set; }
		[OpenErpMap("analytic_account_id", OpenErpType.Integer)]
		public int? AnalyticAccountId { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("date", OpenErpType.Date)]
		public DateTime Date { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("note", OpenErpType.Char)]
		public string Note { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("ref", OpenErpType.Char)]
		public string Ref { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
		[OpenErpMap("statement_id", OpenErpType.Integer)]
		public int StatementId { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
		[OpenErpMap("voucher_id", OpenErpType.Integer)]
		public int? VoucherId { get; set; }
	}

	[OpenErpMap("account.cashbox.line")]
	public class AccountCashboxLine : OpenErpEntityBase {
		[OpenErpMap("ending_id", OpenErpType.Integer)]
		public int? EndingId { get; set; }
		[OpenErpMap("number", OpenErpType.Integer)]
		public int? Number { get; set; }
		[OpenErpMap("pieces", OpenErpType.Float)]
		public double? Pieces { get; set; }
		[OpenErpMap("starting_id", OpenErpType.Integer)]
		public int? StartingId { get; set; }
		[OpenErpMap("subtotal", OpenErpType.Float)]
		public double? Subtotal { get; set; }
	}

	[OpenErpMap("account.chart.template")]
	public class AccountChartTemplate : OpenErpEntityBase {
		[OpenErpMap("account_root_id", OpenErpType.Integer)]
		public int? AccountRootId { get; set; }
		[OpenErpMap("bank_account_view_id", OpenErpType.Integer)]
		public int? BankAccountViewId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("property_account_expense", OpenErpType.Integer)]
		public int? PropertyAccountExpense { get; set; }
		[OpenErpMap("property_account_expense_categ", OpenErpType.Integer)]
		public int? PropertyAccountExpenseCateg { get; set; }
		[OpenErpMap("property_account_income", OpenErpType.Integer)]
		public int? PropertyAccountIncome { get; set; }
		[OpenErpMap("property_account_income_categ", OpenErpType.Integer)]
		public int? PropertyAccountIncomeCateg { get; set; }
		[OpenErpMap("property_account_payable", OpenErpType.Integer)]
		public int? PropertyAccountPayable { get; set; }
		[OpenErpMap("property_account_receivable", OpenErpType.Integer)]
		public int? PropertyAccountReceivable { get; set; }
		[OpenErpMap("property_reserve_and_surplus_account", OpenErpType.Integer)]
		public int? PropertyReserveAndSurplusAccount { get; set; }
		[OpenErpMap("tax_code_root_id", OpenErpType.Integer)]
		public int? TaxCodeRootId { get; set; }
	}

	[OpenErpMap("account.coda")]
	public class AccountCoda : OpenErpEntityBase {
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("date", OpenErpType.Date)]
		public DateTime? Date { get; set; }
		[OpenErpMap("journal_id", OpenErpType.Integer)]
		public int? JournalId { get; set; }
		[OpenErpMap("note", OpenErpType.Char)]
		public string Note { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("account.entries.report")]
	public class AccountEntriesReport : OpenErpEntityBase {
		[OpenErpMap("account_id", OpenErpType.Integer)]
		public int? AccountId { get; set; }
		[OpenErpMap("amount_currency", OpenErpType.Float)]
		public double? AmountCurrency { get; set; }
		[OpenErpMap("analytic_account_id", OpenErpType.Integer)]
		public int? AnalyticAccountId { get; set; }
		[OpenErpMap("balance", OpenErpType.Float)]
		public double? Balance { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("credit", OpenErpType.Float)]
		public double? Credit { get; set; }
		[OpenErpMap("currency_id", OpenErpType.Integer)]
		public int? CurrencyId { get; set; }
		[OpenErpMap("date", OpenErpType.Date)]
		public DateTime? Date { get; set; }
		[OpenErpMap("date_created", OpenErpType.Date)]
		public DateTime? DateCreated { get; set; }
		[OpenErpMap("date_maturity", OpenErpType.Date)]
		public DateTime? DateMaturity { get; set; }
		[OpenErpMap("day", OpenErpType.Char)]
		public string Day { get; set; }
		[OpenErpMap("debit", OpenErpType.Float)]
		public double? Debit { get; set; }
		[OpenErpMap("fiscalyear_id", OpenErpType.Integer)]
		public int? FiscalyearId { get; set; }
		[OpenErpMap("journal_id", OpenErpType.Integer)]
		public int? JournalId { get; set; }
		[OpenErpMap("month", OpenErpType.Selection)]
		public string Month { get; set; }
		[OpenErpMap("move_line_state", OpenErpType.Selection)]
		public string MoveLineState { get; set; }
		[OpenErpMap("move_state", OpenErpType.Selection)]
		public string MoveState { get; set; }
		[OpenErpMap("nbr", OpenErpType.Integer)]
		public int? Nbr { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("period_id", OpenErpType.Integer)]
		public int? PeriodId { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("product_uom_id", OpenErpType.Integer)]
		public int? ProductUomId { get; set; }
		[OpenErpMap("quantity", OpenErpType.Float)]
		public double? Quantity { get; set; }
		[OpenErpMap("reconcile_id", OpenErpType.Integer)]
		public int? ReconcileId { get; set; }
		[OpenErpMap("ref", OpenErpType.Char)]
		public string Ref { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
		[OpenErpMap("user_type", OpenErpType.Integer)]
		public int? UserType { get; set; }
		[OpenErpMap("year", OpenErpType.Char)]
		public string Year { get; set; }
	}

	[OpenErpMap("account.fiscal.position")]
	public class AccountFiscalPosition : OpenErpEntityBase {
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("note", OpenErpType.Char)]
		public string Note { get; set; }
	}

	[OpenErpMap("account.fiscal.position.account")]
	public class AccountFiscalPositionAccount : OpenErpEntityBase {
		[OpenErpMap("account_dest_id", OpenErpType.Integer)]
		public int? AccountDestId { get; set; }
		[OpenErpMap("account_src_id", OpenErpType.Integer)]
		public int? AccountSrcId { get; set; }
		[OpenErpMap("position_id", OpenErpType.Integer)]
		public int? PositionId { get; set; }
	}

	[OpenErpMap("account.fiscal.position.account.template")]
	public class AccountFiscalPositionAccountTemplate : OpenErpEntityBase {
		[OpenErpMap("account_dest_id", OpenErpType.Integer)]
		public int? AccountDestId { get; set; }
		[OpenErpMap("account_src_id", OpenErpType.Integer)]
		public int? AccountSrcId { get; set; }
		[OpenErpMap("position_id", OpenErpType.Integer)]
		public int? PositionId { get; set; }
	}

	[OpenErpMap("account.fiscal.position.tax")]
	public class AccountFiscalPositionTax : OpenErpEntityBase {
		[OpenErpMap("position_id", OpenErpType.Integer)]
		public int? PositionId { get; set; }
		[OpenErpMap("tax_dest_id", OpenErpType.Integer)]
		public int? TaxDestId { get; set; }
		[OpenErpMap("tax_src_id", OpenErpType.Integer)]
		public int? TaxSrcId { get; set; }
	}

	[OpenErpMap("account.fiscal.position.tax.template")]
	public class AccountFiscalPositionTaxTemplate : OpenErpEntityBase {
		[OpenErpMap("position_id", OpenErpType.Integer)]
		public int? PositionId { get; set; }
		[OpenErpMap("tax_dest_id", OpenErpType.Integer)]
		public int? TaxDestId { get; set; }
		[OpenErpMap("tax_src_id", OpenErpType.Integer)]
		public int? TaxSrcId { get; set; }
	}

	[OpenErpMap("account.fiscal.position.template")]
	public class AccountFiscalPositionTemplate : OpenErpEntityBase {
		[OpenErpMap("chart_template_id", OpenErpType.Integer)]
		public int? ChartTemplateId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
	}

	[OpenErpMap("account.fiscalyear")]
	public class AccountFiscalyear : OpenErpEntityBase {
		[OpenErpMap("code", OpenErpType.Char)]
		public string Code { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int CompanyId { get; set; }
		[OpenErpMap("date_start", OpenErpType.Date)]
		public DateTime DateStart { get; set; }
		[OpenErpMap("date_stop", OpenErpType.Date)]
		public DateTime DateStop { get; set; }
		[OpenErpMap("end_journal_period_id", OpenErpType.Integer)]
		public int? EndJournalPeriodId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
	}

	[OpenErpMap("account.invoice")]
	public class AccountInvoice : OpenErpEntityBase {
		[OpenErpMap("account_id", OpenErpType.Integer)]
		public int AccountId { get; set; }
        //[OpenErpMap("address_contact_id", OpenErpType.Integer)]
        //public int? AddressContactId { get; set; }
		[OpenErpMap("address_invoice_id", OpenErpType.Integer)]
		public int AddressInvoiceId { get; set; }
        //[OpenErpMap("amount_tax", OpenErpType.Float)]
        //public double? AmountTax { get; set; }
        [OpenErpMap("amount_total", OpenErpType.Float)]
        public double? AmountTotal { get; set; }
        //[OpenErpMap("amount_untaxed", OpenErpType.Float)]
        //public double? AmountUntaxed { get; set; }
        //[OpenErpMap("check_total", OpenErpType.Float)]
        //public double? CheckTotal { get; set; }
		[OpenErpMap("comment", OpenErpType.Char)]
		public string Comment { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int CompanyId { get; set; }
		[OpenErpMap("currency_id", OpenErpType.Integer)]
		public int CurrencyId { get; set; }
        //[OpenErpMap("date_due", OpenErpType.Date)]
        //public DateTime? DateDue { get; set; }
        [OpenErpMap("date_invoice", OpenErpType.Date)]
        public DateTime? DateInvoice { get; set; }
        //[OpenErpMap("fiscal_position", OpenErpType.Integer)]
        //public int? FiscalPosition { get; set; }
        //[OpenErpMap("internal_number", OpenErpType.Char)]
        //public string InternalNumber { get; set; }
		[OpenErpMap("journal_id", OpenErpType.Integer)]
		public int JournalId { get; set; }
		[OpenErpMap("move_id", OpenErpType.Integer)]
		public int? MoveId { get; set; }
        //[OpenErpMap("move_name", OpenErpType.Char)]
        //public string MoveName { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("number", OpenErpType.Char)]
		public string Number { get; set; }
        //[OpenErpMap("origin", OpenErpType.Char)]
        //public string Origin { get; set; }
        //[OpenErpMap("partner_bank_id", OpenErpType.Integer)]
        //public int? PartnerBankId { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int PartnerId { get; set; }
        //[OpenErpMap("payment_term", OpenErpType.Integer)]
        //public int? PaymentTerm { get; set; }
        //[OpenErpMap("period_id", OpenErpType.Integer)]
        //public int? PeriodId { get; set; }
        //[OpenErpMap("reconciled", OpenErpType.Boolean)]
        //public bool Reconciled { get; set; }
        //[OpenErpMap("reference", OpenErpType.Char)]
        //public string Reference { get; set; }
		[OpenErpMap("reference_type", OpenErpType.Selection)]
		public string ReferenceType { get; set; }
        [OpenErpMap("residual", OpenErpType.Float)]
        public double? Residual { get; set; }
        [OpenErpMap("state", OpenErpType.Selection)]
        public string State { get; set; }
        //[OpenErpMap("type", OpenErpType.Selection)]
        //public string Type { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }

        public AccountInvoiceLine[] InvoiceLines { get; set; }
	}

	[OpenErpMap("account.invoice.line")]
	public class AccountInvoiceLine : OpenErpEntityBase {
		[OpenErpMap("account_analytic_id", OpenErpType.Integer)]
		public int? AccountAnalyticId { get; set; }
		[OpenErpMap("account_id", OpenErpType.Integer)]
		public int? AccountId { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("discount", OpenErpType.Float)]
		public double? Discount { get; set; }
		[OpenErpMap("invoice_id", OpenErpType.Integer)]
		public int InvoiceId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("note", OpenErpType.Char)]
		public string Note { get; set; }
		[OpenErpMap("origin", OpenErpType.Char)]
		public string Origin { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("price_subtotal", OpenErpType.Float)]
		public double? PriceSubtotal { get; set; }
		[OpenErpMap("price_unit", OpenErpType.Float)]
		public double? PriceUnit { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int ProductId { get; set; }
		[OpenErpMap("quantity", OpenErpType.Float)]
		public double? Quantity { get; set; }
		[OpenErpMap("uos_id", OpenErpType.Integer)]
		public int? UosId { get; set; }

        public ProductProduct Product { get; set; }
	}

	[OpenErpMap("account.invoice.report")]
	public class AccountInvoiceReport : OpenErpEntityBase {
		[OpenErpMap("account_id", OpenErpType.Integer)]
		public int? AccountId { get; set; }
		[OpenErpMap("address_contact_id", OpenErpType.Integer)]
		public int? AddressContactId { get; set; }
		[OpenErpMap("address_invoice_id", OpenErpType.Integer)]
		public int? AddressInvoiceId { get; set; }
		[OpenErpMap("categ_id", OpenErpType.Integer)]
		public int? CategId { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("currency_id", OpenErpType.Integer)]
		public int? CurrencyId { get; set; }
		[OpenErpMap("currency_rate", OpenErpType.Float)]
		public double? CurrencyRate { get; set; }
		[OpenErpMap("date", OpenErpType.Date)]
		public DateTime? Date { get; set; }
		[OpenErpMap("date_due", OpenErpType.Date)]
		public DateTime? DateDue { get; set; }
		[OpenErpMap("day", OpenErpType.Char)]
		public string Day { get; set; }
		[OpenErpMap("delay_to_pay", OpenErpType.Float)]
		public double? DelayToPay { get; set; }
		[OpenErpMap("due_delay", OpenErpType.Float)]
		public double? DueDelay { get; set; }
		[OpenErpMap("fiscal_position", OpenErpType.Integer)]
		public int? FiscalPosition { get; set; }
		[OpenErpMap("journal_id", OpenErpType.Integer)]
		public int? JournalId { get; set; }
		[OpenErpMap("month", OpenErpType.Selection)]
		public string Month { get; set; }
		[OpenErpMap("nbr", OpenErpType.Integer)]
		public int? Nbr { get; set; }
		[OpenErpMap("partner_bank_id", OpenErpType.Integer)]
		public int? PartnerBankId { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("payment_term", OpenErpType.Integer)]
		public int? PaymentTerm { get; set; }
		[OpenErpMap("period_id", OpenErpType.Integer)]
		public int? PeriodId { get; set; }
		[OpenErpMap("price_average", OpenErpType.Float)]
		public double? PriceAverage { get; set; }
		[OpenErpMap("price_total", OpenErpType.Float)]
		public double? PriceTotal { get; set; }
		[OpenErpMap("price_total_tax", OpenErpType.Float)]
		public double? PriceTotalTax { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("product_qty", OpenErpType.Float)]
		public double? ProductQty { get; set; }
		[OpenErpMap("residual", OpenErpType.Float)]
		public double? Residual { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
		[OpenErpMap("uom_name", OpenErpType.Char)]
		public string UomName { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
		[OpenErpMap("year", OpenErpType.Char)]
		public string Year { get; set; }
	}

	[OpenErpMap("account.invoice.tax")]
	public class AccountInvoiceTax : OpenErpEntityBase {
		[OpenErpMap("account_id", OpenErpType.Integer)]
		public int? AccountId { get; set; }
		[OpenErpMap("amount", OpenErpType.Float)]
		public double? Amount { get; set; }
		[OpenErpMap("base", OpenErpType.Float)]
		public double? Base { get; set; }
		[OpenErpMap("base_amount", OpenErpType.Float)]
		public double? BaseAmount { get; set; }
		[OpenErpMap("base_code_id", OpenErpType.Integer)]
		public int? BaseCodeId { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("factor_base", OpenErpType.Float)]
		public double? FactorBase { get; set; }
		[OpenErpMap("factor_tax", OpenErpType.Float)]
		public double? FactorTax { get; set; }
		[OpenErpMap("invoice_id", OpenErpType.Integer)]
		public int? InvoiceId { get; set; }
		[OpenErpMap("manual", OpenErpType.Boolean)]
		public bool Manual { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
		[OpenErpMap("tax_amount", OpenErpType.Float)]
		public double? TaxAmount { get; set; }
		[OpenErpMap("tax_code_id", OpenErpType.Integer)]
		public int? TaxCodeId { get; set; }
	}

	[OpenErpMap("account.journal")]
	public class AccountJournal : OpenErpEntityBase {
		[OpenErpMap("allow_date", OpenErpType.Boolean)]
		public bool AllowDate { get; set; }
		[OpenErpMap("analytic_journal_id", OpenErpType.Integer)]
		public int? AnalyticJournalId { get; set; }
		[OpenErpMap("centralisation", OpenErpType.Boolean)]
		public bool Centralisation { get; set; }
		[OpenErpMap("code", OpenErpType.Char)]
		public string Code { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int CompanyId { get; set; }
		[OpenErpMap("currency", OpenErpType.Integer)]
		public int? Currency { get; set; }
		[OpenErpMap("default_credit_account_id", OpenErpType.Integer)]
		public int? DefaultCreditAccountId { get; set; }
		[OpenErpMap("default_debit_account_id", OpenErpType.Integer)]
		public int? DefaultDebitAccountId { get; set; }
		[OpenErpMap("entry_posted", OpenErpType.Boolean)]
		public bool EntryPosted { get; set; }
		[OpenErpMap("group_invoice_lines", OpenErpType.Boolean)]
		public bool GroupInvoiceLines { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("refund_journal", OpenErpType.Boolean)]
		public bool RefundJournal { get; set; }
		[OpenErpMap("sequence_id", OpenErpType.Integer)]
		public int SequenceId { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
		[OpenErpMap("update_posted", OpenErpType.Boolean)]
		public bool UpdatePosted { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
		[OpenErpMap("view_id", OpenErpType.Integer)]
		public int ViewId { get; set; }
	}

	[OpenErpMap("account.journal.column")]
	public class AccountJournalColumn : OpenErpEntityBase {
		[OpenErpMap("field", OpenErpType.Selection)]
		public string Field { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("readonly", OpenErpType.Boolean)]
		public bool Readonly { get; set; }
		[OpenErpMap("required", OpenErpType.Boolean)]
		public bool Required { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
		[OpenErpMap("view_id", OpenErpType.Integer)]
		public int? ViewId { get; set; }
	}

	[OpenErpMap("account.journal.period")]
	public class AccountJournalPeriod : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("fiscalyear_id", OpenErpType.Integer)]
		public int? FiscalyearId { get; set; }
		[OpenErpMap("icon", OpenErpType.Char)]
		public string Icon { get; set; }
		[OpenErpMap("journal_id", OpenErpType.Integer)]
		public int? JournalId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("period_id", OpenErpType.Integer)]
		public int? PeriodId { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
	}

	[OpenErpMap("account.journal.view")]
	public class AccountJournalView : OpenErpEntityBase {
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
	}

	[OpenErpMap("account.model")]
	public class AccountModel : OpenErpEntityBase {
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("journal_id", OpenErpType.Integer)]
		public int? JournalId { get; set; }
		[OpenErpMap("legend", OpenErpType.Char)]
		public string Legend { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
	}

	[OpenErpMap("account.model.line")]
	public class AccountModelLine : OpenErpEntityBase {
		[OpenErpMap("account_id", OpenErpType.Integer)]
		public int? AccountId { get; set; }
		[OpenErpMap("amount_currency", OpenErpType.Float)]
		public double? AmountCurrency { get; set; }
		[OpenErpMap("analytic_account_id", OpenErpType.Integer)]
		public int? AnalyticAccountId { get; set; }
		[OpenErpMap("credit", OpenErpType.Float)]
		public double? Credit { get; set; }
		[OpenErpMap("currency_id", OpenErpType.Integer)]
		public int? CurrencyId { get; set; }
		[OpenErpMap("date_maturity", OpenErpType.Selection)]
		public string DateMaturity { get; set; }
		[OpenErpMap("debit", OpenErpType.Float)]
		public double? Debit { get; set; }
		[OpenErpMap("model_id", OpenErpType.Integer)]
		public int? ModelId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("quantity", OpenErpType.Float)]
		public double? Quantity { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
	}

	[OpenErpMap("account.move")]
	public class AccountMove : OpenErpEntityBase {
		[OpenErpMap("amount", OpenErpType.Float)]
		public double? Amount { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("date", OpenErpType.Date)]
		public DateTime? Date { get; set; }
		[OpenErpMap("journal_id", OpenErpType.Integer)]
		public int? JournalId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("narration", OpenErpType.Char)]
		public string Narration { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("period_id", OpenErpType.Integer)]
		public int? PeriodId { get; set; }
		[OpenErpMap("ref", OpenErpType.Char)]
		public string Ref { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("to_check", OpenErpType.Boolean)]
		public bool ToCheck { get; set; }
	}

	[OpenErpMap("account.move.line")]
	public class AccountMoveLine : OpenErpEntityBase {
		[OpenErpMap("account_id", OpenErpType.Integer)]
		public int? AccountId { get; set; }
		[OpenErpMap("account_tax_id", OpenErpType.Integer)]
		public int? AccountTaxId { get; set; }
		[OpenErpMap("amount_currency", OpenErpType.Float)]
		public double? AmountCurrency { get; set; }
		[OpenErpMap("amount_residual", OpenErpType.Float)]
		public double? AmountResidual { get; set; }
		[OpenErpMap("amount_residual_currency", OpenErpType.Float)]
		public double? AmountResidualCurrency { get; set; }
		[OpenErpMap("analytic_account_id", OpenErpType.Integer)]
		public int? AnalyticAccountId { get; set; }
		[OpenErpMap("balance", OpenErpType.Float)]
		public double? Balance { get; set; }
		[OpenErpMap("blocked", OpenErpType.Boolean)]
		public bool Blocked { get; set; }
		[OpenErpMap("centralisation", OpenErpType.Selection)]
		public string Centralisation { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("credit", OpenErpType.Float)]
		public double? Credit { get; set; }
		[OpenErpMap("currency_id", OpenErpType.Integer)]
		public int? CurrencyId { get; set; }
		[OpenErpMap("date", OpenErpType.Date)]
		public DateTime? Date { get; set; }
		[OpenErpMap("date_created", OpenErpType.Date)]
		public DateTime? DateCreated { get; set; }
		[OpenErpMap("date_maturity", OpenErpType.Date)]
		public DateTime? DateMaturity { get; set; }
		[OpenErpMap("debit", OpenErpType.Float)]
		public double? Debit { get; set; }
        //[OpenErpMap("invoice", OpenErpType.Integer)]
        //public int? Invoice { get; set; }
		[OpenErpMap("journal_id", OpenErpType.Integer)]
		public int? JournalId { get; set; }
		[OpenErpMap("move_id", OpenErpType.Integer)]
		public int MoveId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("narration", OpenErpType.Char)]
		public string Narration { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("period_id", OpenErpType.Integer)]
		public int? PeriodId { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("product_uom_id", OpenErpType.Integer)]
		public int? ProductUomId { get; set; }
		[OpenErpMap("quantity", OpenErpType.Float)]
		public double? Quantity { get; set; }
		[OpenErpMap("reconcile_id", OpenErpType.Integer)]
		public int? ReconcileId { get; set; }
		[OpenErpMap("reconcile_partial_id", OpenErpType.Integer)]
		public int? ReconcilePartialId { get; set; }
		[OpenErpMap("ref", OpenErpType.Char)]
		public string Ref { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("statement_id", OpenErpType.Integer)]
		public int? StatementId { get; set; }
		[OpenErpMap("tax_amount", OpenErpType.Float)]
		public double? TaxAmount { get; set; }
		[OpenErpMap("tax_code_id", OpenErpType.Integer)]
		public int? TaxCodeId { get; set; }
	}

	[OpenErpMap("account.move.reconcile")]
	public class AccountMoveReconcile : OpenErpEntityBase {
		[OpenErpMap("create_date", OpenErpType.Date)]
		public DateTime? CreateDate { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("type", OpenErpType.Char)]
		public string Type { get; set; }
	}

	[OpenErpMap("account.payment.term")]
	public class AccountPaymentTerm : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("note", OpenErpType.Char)]
		public string Note { get; set; }
	}

	[OpenErpMap("account.payment.term.line")]
	public class AccountPaymentTermLine : OpenErpEntityBase {
		[OpenErpMap("days", OpenErpType.Integer)]
		public int? Days { get; set; }
		[OpenErpMap("days2", OpenErpType.Integer)]
		public int? Days2 { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("payment_id", OpenErpType.Integer)]
		public int? PaymentId { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
		[OpenErpMap("value", OpenErpType.Selection)]
		public string Value { get; set; }
		[OpenErpMap("value_amount", OpenErpType.Float)]
		public double? ValueAmount { get; set; }
	}

	[OpenErpMap("account.period")]
	public class AccountPeriod : OpenErpEntityBase {
		[OpenErpMap("code", OpenErpType.Char)]
		public string Code { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("date_start", OpenErpType.Date)]
		public DateTime? DateStart { get; set; }
		[OpenErpMap("date_stop", OpenErpType.Date)]
		public DateTime? DateStop { get; set; }
		[OpenErpMap("fiscalyear_id", OpenErpType.Integer)]
		public int? FiscalyearId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("special", OpenErpType.Boolean)]
		public bool Special { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
	}

	[OpenErpMap("account.sequence.fiscalyear")]
	public class AccountSequenceFiscalyear : OpenErpEntityBase {
		[OpenErpMap("fiscalyear_id", OpenErpType.Integer)]
		public int? FiscalyearId { get; set; }
		[OpenErpMap("sequence_id", OpenErpType.Integer)]
		public int? SequenceId { get; set; }
		[OpenErpMap("sequence_main_id", OpenErpType.Integer)]
		public int? SequenceMainId { get; set; }
	}

	[OpenErpMap("account.subscription")]
	public class AccountSubscription : OpenErpEntityBase {
		[OpenErpMap("date_start", OpenErpType.Date)]
		public DateTime? DateStart { get; set; }
		[OpenErpMap("model_id", OpenErpType.Integer)]
		public int? ModelId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("period_nbr", OpenErpType.Integer)]
		public int? PeriodNbr { get; set; }
		[OpenErpMap("period_total", OpenErpType.Integer)]
		public int? PeriodTotal { get; set; }
		[OpenErpMap("period_type", OpenErpType.Selection)]
		public string PeriodType { get; set; }
		[OpenErpMap("ref", OpenErpType.Char)]
		public string Ref { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
	}

	[OpenErpMap("account.subscription.line")]
	public class AccountSubscriptionLine : OpenErpEntityBase {
		[OpenErpMap("date", OpenErpType.Date)]
		public DateTime? Date { get; set; }
		[OpenErpMap("move_id", OpenErpType.Integer)]
		public int? MoveId { get; set; }
		[OpenErpMap("subscription_id", OpenErpType.Integer)]
		public int? SubscriptionId { get; set; }
	}

	[OpenErpMap("account.tax")]
	public class AccountTax : OpenErpEntityBase {
		[OpenErpMap("account_collected_id", OpenErpType.Integer)]
		public int? AccountCollectedId { get; set; }
		[OpenErpMap("account_paid_id", OpenErpType.Integer)]
		public int? AccountPaidId { get; set; }
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("amount", OpenErpType.Float)]
		public double? Amount { get; set; }
		[OpenErpMap("applicable_type", OpenErpType.Selection)]
		public string ApplicableType { get; set; }
		[OpenErpMap("base_code_id", OpenErpType.Integer)]
		public int? BaseCodeId { get; set; }
		[OpenErpMap("base_sign", OpenErpType.Float)]
		public double? BaseSign { get; set; }
		[OpenErpMap("child_depend", OpenErpType.Boolean)]
		public bool ChildDepend { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("description", OpenErpType.Char)]
		public string Description { get; set; }
		[OpenErpMap("domain", OpenErpType.Char)]
		public string Domain { get; set; }
		[OpenErpMap("include_base_amount", OpenErpType.Boolean)]
		public bool IncludeBaseAmount { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("parent_id", OpenErpType.Integer)]
		public int? ParentId { get; set; }
		[OpenErpMap("price_include", OpenErpType.Boolean)]
		public bool PriceInclude { get; set; }
		[OpenErpMap("python_applicable", OpenErpType.Char)]
		public string PythonApplicable { get; set; }
		[OpenErpMap("python_compute", OpenErpType.Char)]
		public string PythonCompute { get; set; }
		[OpenErpMap("python_compute_inv", OpenErpType.Char)]
		public string PythonComputeInv { get; set; }
		[OpenErpMap("ref_base_code_id", OpenErpType.Integer)]
		public int? RefBaseCodeId { get; set; }
		[OpenErpMap("ref_base_sign", OpenErpType.Float)]
		public double? RefBaseSign { get; set; }
		[OpenErpMap("ref_tax_code_id", OpenErpType.Integer)]
		public int? RefTaxCodeId { get; set; }
		[OpenErpMap("ref_tax_sign", OpenErpType.Float)]
		public double? RefTaxSign { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
		[OpenErpMap("tax_code_id", OpenErpType.Integer)]
		public int? TaxCodeId { get; set; }
		[OpenErpMap("tax_sign", OpenErpType.Float)]
		public double? TaxSign { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
		[OpenErpMap("type_tax_use", OpenErpType.Selection)]
		public string TypeTaxUse { get; set; }
	}

	[OpenErpMap("account.tax.code")]
	public class AccountTaxCode : OpenErpEntityBase {
		[OpenErpMap("code", OpenErpType.Char)]
		public string Code { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("info", OpenErpType.Char)]
		public string Info { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("notprintable", OpenErpType.Boolean)]
		public bool Notprintable { get; set; }
		[OpenErpMap("parent_id", OpenErpType.Integer)]
		public int? ParentId { get; set; }
		[OpenErpMap("sign", OpenErpType.Float)]
		public double? Sign { get; set; }
		[OpenErpMap("sum", OpenErpType.Float)]
		public double? Sum { get; set; }
		[OpenErpMap("sum_period", OpenErpType.Float)]
		public double? SumPeriod { get; set; }
	}

	[OpenErpMap("account.tax.code.template")]
	public class AccountTaxCodeTemplate : OpenErpEntityBase {
		[OpenErpMap("code", OpenErpType.Char)]
		public string Code { get; set; }
		[OpenErpMap("info", OpenErpType.Char)]
		public string Info { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("notprintable", OpenErpType.Boolean)]
		public bool Notprintable { get; set; }
		[OpenErpMap("parent_id", OpenErpType.Integer)]
		public int? ParentId { get; set; }
		[OpenErpMap("sign", OpenErpType.Float)]
		public double? Sign { get; set; }
	}

	[OpenErpMap("account.tax.template")]
	public class AccountTaxTemplate : OpenErpEntityBase {
		[OpenErpMap("account_collected_id", OpenErpType.Integer)]
		public int? AccountCollectedId { get; set; }
		[OpenErpMap("account_paid_id", OpenErpType.Integer)]
		public int? AccountPaidId { get; set; }
		[OpenErpMap("amount", OpenErpType.Float)]
		public double? Amount { get; set; }
		[OpenErpMap("applicable_type", OpenErpType.Selection)]
		public string ApplicableType { get; set; }
		[OpenErpMap("base_code_id", OpenErpType.Integer)]
		public int? BaseCodeId { get; set; }
		[OpenErpMap("base_sign", OpenErpType.Float)]
		public double? BaseSign { get; set; }
		[OpenErpMap("chart_template_id", OpenErpType.Integer)]
		public int? ChartTemplateId { get; set; }
		[OpenErpMap("child_depend", OpenErpType.Boolean)]
		public bool ChildDepend { get; set; }
		[OpenErpMap("description", OpenErpType.Char)]
		public string Description { get; set; }
		[OpenErpMap("domain", OpenErpType.Char)]
		public string Domain { get; set; }
		[OpenErpMap("include_base_amount", OpenErpType.Boolean)]
		public bool IncludeBaseAmount { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("parent_id", OpenErpType.Integer)]
		public int? ParentId { get; set; }
		[OpenErpMap("price_include", OpenErpType.Boolean)]
		public bool PriceInclude { get; set; }
		[OpenErpMap("python_applicable", OpenErpType.Char)]
		public string PythonApplicable { get; set; }
		[OpenErpMap("python_compute", OpenErpType.Char)]
		public string PythonCompute { get; set; }
		[OpenErpMap("python_compute_inv", OpenErpType.Char)]
		public string PythonComputeInv { get; set; }
		[OpenErpMap("ref_base_code_id", OpenErpType.Integer)]
		public int? RefBaseCodeId { get; set; }
		[OpenErpMap("ref_base_sign", OpenErpType.Float)]
		public double? RefBaseSign { get; set; }
		[OpenErpMap("ref_tax_code_id", OpenErpType.Integer)]
		public int? RefTaxCodeId { get; set; }
		[OpenErpMap("ref_tax_sign", OpenErpType.Float)]
		public double? RefTaxSign { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
		[OpenErpMap("tax_code_id", OpenErpType.Integer)]
		public int? TaxCodeId { get; set; }
		[OpenErpMap("tax_sign", OpenErpType.Float)]
		public double? TaxSign { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
		[OpenErpMap("type_tax_use", OpenErpType.Selection)]
		public string TypeTaxUse { get; set; }
	}

	[OpenErpMap("account.voucher")]
	public class AccountVoucher : OpenErpEntityBase {
		[OpenErpMap("account_id", OpenErpType.Integer)]
		public int? AccountId { get; set; }
		[OpenErpMap("amount", OpenErpType.Float)]
		public double? Amount { get; set; }
        //[OpenErpMap("analytic_id", OpenErpType.Integer)]
        //public int? AnalyticId { get; set; }
        //[OpenErpMap("audit", OpenErpType.Boolean)]
        //public bool Audit { get; set; }
		[OpenErpMap("comment", OpenErpType.Char)]
		public string Comment { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("currency_id", OpenErpType.Integer)]
		public int? CurrencyId { get; set; }
		[OpenErpMap("date", OpenErpType.Date)]
		public DateTime? Date { get; set; }
        //[OpenErpMap("date_due", OpenErpType.Date)]
        //public DateTime? DateDue { get; set; }
		[OpenErpMap("journal_id", OpenErpType.Integer)]
		public int? JournalId { get; set; }
        //[OpenErpMap("move_id", OpenErpType.Integer)]
        //public int? MoveId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
        //[OpenErpMap("narration", OpenErpType.Char)]
        //public string Narration { get; set; }
        //[OpenErpMap("number", OpenErpType.Char)]
        //public string Number { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("payment_option", OpenErpType.Selection)]
		public string PaymentOption { get; set; }
        //[OpenErpMap("pay_now", OpenErpType.Selection)]
        //public string PayNow { get; set; }
        //[OpenErpMap("period_id", OpenErpType.Integer)]
        //public int? PeriodId { get; set; }
        //[OpenErpMap("pre_line", OpenErpType.Boolean)]
        //public bool PreLine { get; set; }
		[OpenErpMap("reference", OpenErpType.Char)]
		public string Reference { get; set; }
        //[OpenErpMap("state", OpenErpType.Selection)]
        //public string State { get; set; }
        //[OpenErpMap("tax_amount", OpenErpType.Float)]
        //public double? TaxAmount { get; set; }
        //[OpenErpMap("tax_id", OpenErpType.Integer)]
        //public int? TaxId { get; set; }
        [OpenErpMap("type", OpenErpType.Selection)]
        public string Type { get; set; }
        //[OpenErpMap("writeoff_acc_id", OpenErpType.Integer)]
        //public int? WriteoffAccId { get; set; }
        //[OpenErpMap("writeoff_amount", OpenErpType.Float)]
        //public double? WriteoffAmount { get; set; }
	}

	[OpenErpMap("account.voucher.line")]
	public class AccountVoucherLine : OpenErpEntityBase {
		[OpenErpMap("account_analytic_id", OpenErpType.Integer)]
		public int? AccountAnalyticId { get; set; }
		[OpenErpMap("account_id", OpenErpType.Integer)]
		public int? AccountId { get; set; }
		[OpenErpMap("amount", OpenErpType.Float)]
		public double? Amount { get; set; }
		[OpenErpMap("amount_original", OpenErpType.Float)]
		public double? AmountOriginal { get; set; }
		[OpenErpMap("amount_unreconciled", OpenErpType.Float)]
		public double? AmountUnreconciled { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("date_due", OpenErpType.Date)]
		public DateTime? DateDue { get; set; }
		[OpenErpMap("date_original", OpenErpType.Date)]
		public DateTime? DateOriginal { get; set; }
		[OpenErpMap("move_line_id", OpenErpType.Integer)]
		public int? MoveLineId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
		[OpenErpMap("untax_amount", OpenErpType.Float)]
		public double? UntaxAmount { get; set; }
		[OpenErpMap("voucher_id", OpenErpType.Integer)]
		public int? VoucherId { get; set; }
	}

	[OpenErpMap("aie.category")]
	public class AieCategory : OpenErpEntityBase {
		[OpenErpMap("code", OpenErpType.Char)]
		public string Code { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("parent_id", OpenErpType.Integer)]
		public int? ParentId { get; set; }
	}

	[OpenErpMap("analytic.entries.report")]
	public class AnalyticEntriesReport : OpenErpEntityBase {
		[OpenErpMap("account_id", OpenErpType.Integer)]
		public int? AccountId { get; set; }
		[OpenErpMap("amount", OpenErpType.Float)]
		public double? Amount { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("currency_id", OpenErpType.Integer)]
		public int? CurrencyId { get; set; }
		[OpenErpMap("date", OpenErpType.Date)]
		public DateTime? Date { get; set; }
		[OpenErpMap("day", OpenErpType.Char)]
		public string Day { get; set; }
		[OpenErpMap("general_account_id", OpenErpType.Integer)]
		public int? GeneralAccountId { get; set; }
		[OpenErpMap("journal_id", OpenErpType.Integer)]
		public int? JournalId { get; set; }
		[OpenErpMap("month", OpenErpType.Selection)]
		public string Month { get; set; }
		[OpenErpMap("move_id", OpenErpType.Integer)]
		public int? MoveId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("nbr", OpenErpType.Integer)]
		public int? Nbr { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("product_uom_id", OpenErpType.Integer)]
		public int? ProductUomId { get; set; }
		[OpenErpMap("unit_amount", OpenErpType.Float)]
		public double? UnitAmount { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
		[OpenErpMap("year", OpenErpType.Char)]
		public string Year { get; set; }
	}

	[OpenErpMap("auction.artists")]
	public class AuctionArtists : OpenErpEntityBase {
		[OpenErpMap("biography", OpenErpType.Char)]
		public string Biography { get; set; }
		[OpenErpMap("birth_death_dates", OpenErpType.Char)]
		public string BirthDeathDates { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("pseudo", OpenErpType.Char)]
		public string Pseudo { get; set; }
	}

	[OpenErpMap("auction.bid")]
	public class AuctionBid : OpenErpEntityBase {
		[OpenErpMap("auction_id", OpenErpType.Integer)]
		public int? AuctionId { get; set; }
		[OpenErpMap("contact_tel", OpenErpType.Char)]
		public string ContactTel { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
	}

	[OpenErpMap("auction.bid_line")]
	public class AuctionBid_line : OpenErpEntityBase {
		[OpenErpMap("auction", OpenErpType.Char)]
		public string Auction { get; set; }
		[OpenErpMap("bid_id", OpenErpType.Integer)]
		public int? BidId { get; set; }
		[OpenErpMap("call", OpenErpType.Boolean)]
		public bool Call { get; set; }
		[OpenErpMap("lot_id", OpenErpType.Integer)]
		public int? LotId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("price", OpenErpType.Float)]
		public double? Price { get; set; }
	}

	[OpenErpMap("auction.dates")]
	public class AuctionDates : OpenErpEntityBase {
		[OpenErpMap("acc_expense", OpenErpType.Integer)]
		public int? AccExpense { get; set; }
		[OpenErpMap("acc_income", OpenErpType.Integer)]
		public int? AccIncome { get; set; }
		[OpenErpMap("account_analytic_id", OpenErpType.Integer)]
		public int? AccountAnalyticId { get; set; }
		[OpenErpMap("adj_total", OpenErpType.Float)]
		public double? AdjTotal { get; set; }
		[OpenErpMap("auction1", OpenErpType.Date)]
		public DateTime? Auction1 { get; set; }
		[OpenErpMap("auction2", OpenErpType.Date)]
		public DateTime? Auction2 { get; set; }
		[OpenErpMap("expo1", OpenErpType.Date)]
		public DateTime? Expo1 { get; set; }
		[OpenErpMap("expo2", OpenErpType.Date)]
		public DateTime? Expo2 { get; set; }
		[OpenErpMap("journal_id", OpenErpType.Integer)]
		public int? JournalId { get; set; }
		[OpenErpMap("journal_seller_id", OpenErpType.Integer)]
		public int? JournalSellerId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
	}

	[OpenErpMap("auction.deposit")]
	public class AuctionDeposit : OpenErpEntityBase {
		[OpenErpMap("create_uid", OpenErpType.Integer)]
		public int? CreateUid { get; set; }
		[OpenErpMap("date_dep", OpenErpType.Date)]
		public DateTime? DateDep { get; set; }
		[OpenErpMap("info", OpenErpType.Char)]
		public string Info { get; set; }
		[OpenErpMap("method", OpenErpType.Selection)]
		public string Method { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("tax_id", OpenErpType.Integer)]
		public int? TaxId { get; set; }
		[OpenErpMap("total_neg", OpenErpType.Boolean)]
		public bool TotalNeg { get; set; }
		[OpenErpMap("transfer", OpenErpType.Boolean)]
		public bool Transfer { get; set; }
	}

	[OpenErpMap("auction.deposit.cost")]
	public class AuctionDepositCost : OpenErpEntityBase {
		[OpenErpMap("account", OpenErpType.Integer)]
		public int? Account { get; set; }
		[OpenErpMap("amount", OpenErpType.Float)]
		public double? Amount { get; set; }
		[OpenErpMap("deposit_id", OpenErpType.Integer)]
		public int? DepositId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
	}

	[OpenErpMap("auction.lot.category")]
	public class AuctionLotCategory : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("aie_categ", OpenErpType.Integer)]
		public int? AieCateg { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("priority", OpenErpType.Float)]
		public double? Priority { get; set; }
	}

	[OpenErpMap("auction.lot.history")]
	public class AuctionLotHistory : OpenErpEntityBase {
		[OpenErpMap("auction_id", OpenErpType.Integer)]
		public int? AuctionId { get; set; }
		[OpenErpMap("lot_id", OpenErpType.Integer)]
		public int? LotId { get; set; }
		[OpenErpMap("name", OpenErpType.Date)]
		public DateTime? Name { get; set; }
		[OpenErpMap("price", OpenErpType.Float)]
		public double? Price { get; set; }
	}

	[OpenErpMap("auction.lots")]
	public class AuctionLots : OpenErpEntityBase {
		[OpenErpMap("ach_avance", OpenErpType.Float)]
		public double? AchAvance { get; set; }
		[OpenErpMap("ach_emp", OpenErpType.Boolean)]
		public bool AchEmp { get; set; }
		[OpenErpMap("ach_inv_id", OpenErpType.Integer)]
		public int? AchInvId { get; set; }
		[OpenErpMap("ach_login", OpenErpType.Char)]
		public string AchLogin { get; set; }
		[OpenErpMap("ach_uid", OpenErpType.Integer)]
		public int? AchUid { get; set; }
		[OpenErpMap("artist2_id", OpenErpType.Integer)]
		public int? Artist2Id { get; set; }
		[OpenErpMap("artist_id", OpenErpType.Integer)]
		public int? ArtistId { get; set; }
		[OpenErpMap("auction_id", OpenErpType.Integer)]
		public int? AuctionId { get; set; }
		[OpenErpMap("author_right", OpenErpType.Integer)]
		public int? AuthorRight { get; set; }
		[OpenErpMap("bord_vnd_id", OpenErpType.Integer)]
		public int? BordVndId { get; set; }
		[OpenErpMap("buyer_price", OpenErpType.Float)]
		public double? BuyerPrice { get; set; }
		[OpenErpMap("costs", OpenErpType.Float)]
		public double? Costs { get; set; }
		[OpenErpMap("create_uid", OpenErpType.Integer)]
		public int? CreateUid { get; set; }
		[OpenErpMap("gross_margin", OpenErpType.Float)]
		public double? GrossMargin { get; set; }
		[OpenErpMap("gross_revenue", OpenErpType.Float)]
		public double? GrossRevenue { get; set; }
		[OpenErpMap("important", OpenErpType.Boolean)]
		public bool Important { get; set; }
		[OpenErpMap("is_ok", OpenErpType.Boolean)]
		public bool IsOk { get; set; }
		[OpenErpMap("lot_est1", OpenErpType.Float)]
		public double? LotEst1 { get; set; }
		[OpenErpMap("lot_est2", OpenErpType.Float)]
		public double? LotEst2 { get; set; }
		[OpenErpMap("lot_local", OpenErpType.Char)]
		public string LotLocal { get; set; }
		[OpenErpMap("lot_num", OpenErpType.Integer)]
		public int? LotNum { get; set; }
		[OpenErpMap("lot_type", OpenErpType.Selection)]
		public string LotType { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("name2", OpenErpType.Char)]
		public string Name2 { get; set; }
		[OpenErpMap("net_margin", OpenErpType.Float)]
		public double? NetMargin { get; set; }
		[OpenErpMap("net_revenue", OpenErpType.Float)]
		public double? NetRevenue { get; set; }
		[OpenErpMap("obj_comm", OpenErpType.Boolean)]
		public bool ObjComm { get; set; }
		[OpenErpMap("obj_desc", OpenErpType.Char)]
		public string ObjDesc { get; set; }
		[OpenErpMap("obj_num", OpenErpType.Integer)]
		public int? ObjNum { get; set; }
		[OpenErpMap("obj_price", OpenErpType.Float)]
		public double? ObjPrice { get; set; }
		[OpenErpMap("obj_ret", OpenErpType.Float)]
		public double? ObjRet { get; set; }
		[OpenErpMap("paid_ach", OpenErpType.Boolean)]
		public bool PaidAch { get; set; }
		[OpenErpMap("paid_vnd", OpenErpType.Boolean)]
		public bool PaidVnd { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("sel_inv_id", OpenErpType.Integer)]
		public int? SelInvId { get; set; }
		[OpenErpMap("seller_id", OpenErpType.Integer)]
		public int? SellerId { get; set; }
		[OpenErpMap("seller_price", OpenErpType.Float)]
		public double? SellerPrice { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("vnd_lim", OpenErpType.Float)]
		public double? VndLim { get; set; }
		[OpenErpMap("vnd_lim_net", OpenErpType.Boolean)]
		public bool VndLimNet { get; set; }
	}

	[OpenErpMap("base.action.rule")]
	public class BaseActionRule : OpenErpEntityBase {
		[OpenErpMap("act_categ_id", OpenErpType.Integer)]
		public int? ActCategId { get; set; }
		[OpenErpMap("act_email_cc", OpenErpType.Char)]
		public string ActEmailCc { get; set; }
		[OpenErpMap("act_email_from", OpenErpType.Char)]
		public string ActEmailFrom { get; set; }
		[OpenErpMap("act_email_to", OpenErpType.Char)]
		public string ActEmailTo { get; set; }
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("act_mail_body", OpenErpType.Char)]
		public string ActMailBody { get; set; }
		[OpenErpMap("act_mail_to_email", OpenErpType.Char)]
		public string ActMailToEmail { get; set; }
		[OpenErpMap("act_mail_to_partner", OpenErpType.Boolean)]
		public bool ActMailToPartner { get; set; }
		[OpenErpMap("act_mail_to_user", OpenErpType.Boolean)]
		public bool ActMailToUser { get; set; }
		[OpenErpMap("act_mail_to_watchers", OpenErpType.Boolean)]
		public bool ActMailToWatchers { get; set; }
		[OpenErpMap("act_method", OpenErpType.Char)]
		public string ActMethod { get; set; }
		[OpenErpMap("act_remind_attach", OpenErpType.Boolean)]
		public bool ActRemindAttach { get; set; }
		[OpenErpMap("act_remind_partner", OpenErpType.Boolean)]
		public bool ActRemindPartner { get; set; }
		[OpenErpMap("act_remind_user", OpenErpType.Boolean)]
		public bool ActRemindUser { get; set; }
		[OpenErpMap("act_reply_to", OpenErpType.Char)]
		public string ActReplyTo { get; set; }
		[OpenErpMap("act_section_id", OpenErpType.Integer)]
		public int? ActSectionId { get; set; }
		[OpenErpMap("act_state", OpenErpType.Selection)]
		public string ActState { get; set; }
		[OpenErpMap("act_user_id", OpenErpType.Integer)]
		public int? ActUserId { get; set; }
		[OpenErpMap("create_date", OpenErpType.Datetime)]
		public DateTime? CreateDate { get; set; }
		[OpenErpMap("filter_id", OpenErpType.Integer)]
		public int? FilterId { get; set; }
		[OpenErpMap("last_run", OpenErpType.Datetime)]
		public DateTime? LastRun { get; set; }
		[OpenErpMap("model_id", OpenErpType.Integer)]
		public int ModelId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("regex_history", OpenErpType.Char)]
		public string RegexHistory { get; set; }
		[OpenErpMap("regex_name", OpenErpType.Char)]
		public string RegexName { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
		[OpenErpMap("server_action_id", OpenErpType.Integer)]
		public int? ServerActionId { get; set; }
		[OpenErpMap("trg_categ_id", OpenErpType.Integer)]
		public int? TrgCategId { get; set; }
		[OpenErpMap("trg_date_range", OpenErpType.Integer)]
		public int? TrgDateRange { get; set; }
		[OpenErpMap("trg_date_range_type", OpenErpType.Selection)]
		public string TrgDateRangeType { get; set; }
		[OpenErpMap("trg_date_type", OpenErpType.Selection)]
		public string TrgDateType { get; set; }
		[OpenErpMap("trg_max_history", OpenErpType.Integer)]
		public int? TrgMaxHistory { get; set; }
		[OpenErpMap("trg_partner_categ_id", OpenErpType.Integer)]
		public int? TrgPartnerCategId { get; set; }
		[OpenErpMap("trg_partner_id", OpenErpType.Integer)]
		public int? TrgPartnerId { get; set; }
		[OpenErpMap("trg_section_id", OpenErpType.Integer)]
		public int? TrgSectionId { get; set; }
		[OpenErpMap("trg_state_from", OpenErpType.Selection)]
		public string TrgStateFrom { get; set; }
		[OpenErpMap("trg_state_to", OpenErpType.Selection)]
		public string TrgStateTo { get; set; }
		[OpenErpMap("trg_user_id", OpenErpType.Integer)]
		public int? TrgUserId { get; set; }
	}

	[OpenErpMap("board.board")]
	public class BoardBoard : OpenErpEntityBase {
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("view_id", OpenErpType.Integer)]
		public int? ViewId { get; set; }
	}

	[OpenErpMap("board.board.line")]
	public class BoardBoardLine : OpenErpEntityBase {
		[OpenErpMap("action_id", OpenErpType.Integer)]
		public int? ActionId { get; set; }
		[OpenErpMap("board_id", OpenErpType.Integer)]
		public int? BoardId { get; set; }
		[OpenErpMap("height", OpenErpType.Integer)]
		public int? Height { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("position", OpenErpType.Selection)]
		public string Position { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
		[OpenErpMap("width", OpenErpType.Integer)]
		public int? Width { get; set; }
	}

	[OpenErpMap("board.note")]
	public class BoardNote : OpenErpEntityBase {
		[OpenErpMap("date", OpenErpType.Date)]
		public DateTime? Date { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("note", OpenErpType.Char)]
		public string Note { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("board.note.type")]
	public class BoardNoteType : OpenErpEntityBase {
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
	}

	[OpenErpMap("calendar.alarm")]
	public class CalendarAlarm : OpenErpEntityBase {
		[OpenErpMap("action", OpenErpType.Selection)]
		public string Action { get; set; }
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("alarm_id", OpenErpType.Integer)]
		public int? AlarmId { get; set; }
		[OpenErpMap("description", OpenErpType.Char)]
		public string Description { get; set; }
		[OpenErpMap("duration", OpenErpType.Integer)]
		public int? Duration { get; set; }
		[OpenErpMap("event_date", OpenErpType.Datetime)]
		public DateTime? EventDate { get; set; }
		[OpenErpMap("event_end_date", OpenErpType.Datetime)]
		public DateTime? EventEndDate { get; set; }
		[OpenErpMap("model_id", OpenErpType.Integer)]
		public int? ModelId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("repeat", OpenErpType.Integer)]
		public int? Repeat { get; set; }
		[OpenErpMap("res_id", OpenErpType.Integer)]
		public int? ResId { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("trigger_date", OpenErpType.Datetime)]
		public DateTime? TriggerDate { get; set; }
		[OpenErpMap("trigger_duration", OpenErpType.Integer)]
		public int? TriggerDuration { get; set; }
		[OpenErpMap("trigger_interval", OpenErpType.Selection)]
		public string TriggerInterval { get; set; }
		[OpenErpMap("trigger_occurs", OpenErpType.Selection)]
		public string TriggerOccurs { get; set; }
		[OpenErpMap("trigger_related", OpenErpType.Selection)]
		public string TriggerRelated { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("calendar.attendee")]
	public class CalendarAttendee : OpenErpEntityBase {
		[OpenErpMap("availability", OpenErpType.Selection)]
		public string Availability { get; set; }
		[OpenErpMap("categ_id", OpenErpType.Integer)]
		public int? CategId { get; set; }
		[OpenErpMap("cn", OpenErpType.Char)]
		public string Cn { get; set; }
		[OpenErpMap("cutype", OpenErpType.Selection)]
		public string Cutype { get; set; }
		[OpenErpMap("delegated_from", OpenErpType.Char)]
		public string DelegatedFrom { get; set; }
		[OpenErpMap("delegated_to", OpenErpType.Char)]
		public string DelegatedTo { get; set; }
		[OpenErpMap("dir", OpenErpType.Char)]
		public string Dir { get; set; }
		[OpenErpMap("email", OpenErpType.Char)]
		public string Email { get; set; }
		[OpenErpMap("event_date", OpenErpType.Datetime)]
		public DateTime? EventDate { get; set; }
		[OpenErpMap("event_end_date", OpenErpType.Datetime)]
		public DateTime? EventEndDate { get; set; }
		[OpenErpMap("language", OpenErpType.Selection)]
		public string Language { get; set; }
		[OpenErpMap("member", OpenErpType.Char)]
		public string Member { get; set; }
		[OpenErpMap("partner_address_id", OpenErpType.Integer)]
		public int? PartnerAddressId { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("role", OpenErpType.Selection)]
		public string Role { get; set; }
		[OpenErpMap("rsvp", OpenErpType.Boolean)]
		public bool Rsvp { get; set; }
		[OpenErpMap("sent_by", OpenErpType.Char)]
		public string SentBy { get; set; }
		[OpenErpMap("sent_by_uid", OpenErpType.Integer)]
		public int? SentByUid { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("calendar.event")]
	public class CalendarEvent : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("alarm_id", OpenErpType.Integer)]
		public int? AlarmId { get; set; }
		[OpenErpMap("allday", OpenErpType.Boolean)]
		public bool Allday { get; set; }
		[OpenErpMap("base_calendar_alarm_id", OpenErpType.Integer)]
		public int? BaseCalendarAlarmId { get; set; }
		[OpenErpMap("base_calendar_url", OpenErpType.Char)]
		public string BaseCalendarUrl { get; set; }
		[OpenErpMap("byday", OpenErpType.Selection)]
		public string Byday { get; set; }
		[OpenErpMap("class", OpenErpType.Selection)]
		public string Class { get; set; }
		[OpenErpMap("count", OpenErpType.Integer)]
		public int? Count { get; set; }
		[OpenErpMap("create_date", OpenErpType.Datetime)]
		public DateTime? CreateDate { get; set; }
		[OpenErpMap("date", OpenErpType.Datetime)]
		public DateTime? Date { get; set; }
		[OpenErpMap("date_deadline", OpenErpType.Datetime)]
		public DateTime? DateDeadline { get; set; }
		[OpenErpMap("day", OpenErpType.Integer)]
		public int? Day { get; set; }
		[OpenErpMap("description", OpenErpType.Char)]
		public string Description { get; set; }
		[OpenErpMap("duration", OpenErpType.Float)]
		public double? Duration { get; set; }
		[OpenErpMap("edit_all", OpenErpType.Boolean)]
		public bool EditAll { get; set; }
		[OpenErpMap("end_date", OpenErpType.Date)]
		public DateTime? EndDate { get; set; }
		[OpenErpMap("end_type", OpenErpType.Selection)]
		public string EndType { get; set; }
		[OpenErpMap("exdate", OpenErpType.Char)]
		public string Exdate { get; set; }
		[OpenErpMap("exrule", OpenErpType.Char)]
		public string Exrule { get; set; }
		[OpenErpMap("fr", OpenErpType.Boolean)]
		public bool Fr { get; set; }
		[OpenErpMap("freq", OpenErpType.Selection)]
		public string Freq { get; set; }
		[OpenErpMap("interval", OpenErpType.Integer)]
		public int? Interval { get; set; }
		[OpenErpMap("location", OpenErpType.Char)]
		public string Location { get; set; }
		[OpenErpMap("mo", OpenErpType.Boolean)]
		public bool Mo { get; set; }
		[OpenErpMap("month_list", OpenErpType.Selection)]
		public string MonthList { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("organizer", OpenErpType.Char)]
		public string Organizer { get; set; }
		[OpenErpMap("organizer_id", OpenErpType.Integer)]
		public int? OrganizerId { get; set; }
		[OpenErpMap("recurrency", OpenErpType.Boolean)]
		public bool Recurrency { get; set; }
		[OpenErpMap("recurrent_id", OpenErpType.Datetime)]
		public DateTime? RecurrentId { get; set; }
		[OpenErpMap("recurrent_uid", OpenErpType.Integer)]
		public int? RecurrentUid { get; set; }
		[OpenErpMap("rrule", OpenErpType.Char)]
		public string Rrule { get; set; }
		[OpenErpMap("rrule_type", OpenErpType.Selection)]
		public string RruleType { get; set; }
		[OpenErpMap("sa", OpenErpType.Boolean)]
		public bool Sa { get; set; }
		[OpenErpMap("select1", OpenErpType.Selection)]
		public string Select1 { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
		[OpenErpMap("show_as", OpenErpType.Selection)]
		public string ShowAs { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("su", OpenErpType.Boolean)]
		public bool Su { get; set; }
		[OpenErpMap("th", OpenErpType.Boolean)]
		public bool Th { get; set; }
		[OpenErpMap("tu", OpenErpType.Boolean)]
		public bool Tu { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
		[OpenErpMap("we", OpenErpType.Boolean)]
		public bool We { get; set; }
		[OpenErpMap("week_list", OpenErpType.Selection)]
		public string WeekList { get; set; }
		[OpenErpMap("vtimezone", OpenErpType.Selection)]
		public string Vtimezone { get; set; }
	}

	[OpenErpMap("calendar.todo")]
	public class CalendarTodo : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("alarm_id", OpenErpType.Integer)]
		public int? AlarmId { get; set; }
		[OpenErpMap("allday", OpenErpType.Boolean)]
		public bool Allday { get; set; }
		[OpenErpMap("base_calendar_alarm_id", OpenErpType.Integer)]
		public int? BaseCalendarAlarmId { get; set; }
		[OpenErpMap("base_calendar_url", OpenErpType.Char)]
		public string BaseCalendarUrl { get; set; }
		[OpenErpMap("byday", OpenErpType.Selection)]
		public string Byday { get; set; }
		[OpenErpMap("class", OpenErpType.Selection)]
		public string Class { get; set; }
		[OpenErpMap("count", OpenErpType.Integer)]
		public int? Count { get; set; }
		[OpenErpMap("create_date", OpenErpType.Datetime)]
		public DateTime? CreateDate { get; set; }
		[OpenErpMap("date", OpenErpType.Datetime)]
		public DateTime? Date { get; set; }
		[OpenErpMap("date_deadline", OpenErpType.Datetime)]
		public DateTime? DateDeadline { get; set; }
		[OpenErpMap("day", OpenErpType.Integer)]
		public int? Day { get; set; }
		[OpenErpMap("description", OpenErpType.Char)]
		public string Description { get; set; }
		[OpenErpMap("duration", OpenErpType.Integer)]
		public int? Duration { get; set; }
		[OpenErpMap("edit_all", OpenErpType.Boolean)]
		public bool EditAll { get; set; }
		[OpenErpMap("end_date", OpenErpType.Date)]
		public DateTime? EndDate { get; set; }
		[OpenErpMap("end_type", OpenErpType.Selection)]
		public string EndType { get; set; }
		[OpenErpMap("exdate", OpenErpType.Char)]
		public string Exdate { get; set; }
		[OpenErpMap("exrule", OpenErpType.Char)]
		public string Exrule { get; set; }
		[OpenErpMap("fr", OpenErpType.Boolean)]
		public bool Fr { get; set; }
		[OpenErpMap("freq", OpenErpType.Selection)]
		public string Freq { get; set; }
		[OpenErpMap("interval", OpenErpType.Integer)]
		public int? Interval { get; set; }
		[OpenErpMap("location", OpenErpType.Char)]
		public string Location { get; set; }
		[OpenErpMap("mo", OpenErpType.Boolean)]
		public bool Mo { get; set; }
		[OpenErpMap("month_list", OpenErpType.Selection)]
		public string MonthList { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("organizer", OpenErpType.Char)]
		public string Organizer { get; set; }
		[OpenErpMap("organizer_id", OpenErpType.Integer)]
		public int? OrganizerId { get; set; }
		[OpenErpMap("recurrency", OpenErpType.Boolean)]
		public bool Recurrency { get; set; }
		[OpenErpMap("recurrent_id", OpenErpType.Datetime)]
		public DateTime? RecurrentId { get; set; }
		[OpenErpMap("recurrent_uid", OpenErpType.Integer)]
		public int? RecurrentUid { get; set; }
		[OpenErpMap("rrule", OpenErpType.Char)]
		public string Rrule { get; set; }
		[OpenErpMap("rrule_type", OpenErpType.Selection)]
		public string RruleType { get; set; }
		[OpenErpMap("sa", OpenErpType.Boolean)]
		public bool Sa { get; set; }
		[OpenErpMap("select1", OpenErpType.Selection)]
		public string Select1 { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
		[OpenErpMap("show_as", OpenErpType.Selection)]
		public string ShowAs { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("su", OpenErpType.Boolean)]
		public bool Su { get; set; }
		[OpenErpMap("th", OpenErpType.Boolean)]
		public bool Th { get; set; }
		[OpenErpMap("tu", OpenErpType.Boolean)]
		public bool Tu { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
		[OpenErpMap("we", OpenErpType.Boolean)]
		public bool We { get; set; }
		[OpenErpMap("week_list", OpenErpType.Selection)]
		public string WeekList { get; set; }
		[OpenErpMap("vtimezone", OpenErpType.Selection)]
		public string Vtimezone { get; set; }
	}

	[OpenErpMap("crm.case.categ")]
	public class CrmCaseCateg : OpenErpEntityBase {
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("object_id", OpenErpType.Integer)]
		public int? ObjectId { get; set; }
		[OpenErpMap("section_id", OpenErpType.Integer)]
		public int? SectionId { get; set; }
	}

	[OpenErpMap("crm.case.resource.type")]
	public class CrmCaseResourceType : OpenErpEntityBase {
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("section_id", OpenErpType.Integer)]
		public int? SectionId { get; set; }
	}

	[OpenErpMap("crm.case.section")]
	public class CrmCaseSection : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("allow_unlink", OpenErpType.Boolean)]
		public bool AllowUnlink { get; set; }
		[OpenErpMap("change_responsible", OpenErpType.Boolean)]
		public bool ChangeResponsible { get; set; }
		[OpenErpMap("code", OpenErpType.Char)]
		public string Code { get; set; }
		[OpenErpMap("complete_name", OpenErpType.Char)]
		public string CompleteName { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("note", OpenErpType.Char)]
		public string Note { get; set; }
		[OpenErpMap("parent_id", OpenErpType.Integer)]
		public int? ParentId { get; set; }
		[OpenErpMap("reply_to", OpenErpType.Char)]
		public string ReplyTo { get; set; }
		[OpenErpMap("resource_calendar_id", OpenErpType.Integer)]
		public int? ResourceCalendarId { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
		[OpenErpMap("working_hours", OpenErpType.Float)]
		public double? WorkingHours { get; set; }
	}

	[OpenErpMap("crm.case.stage")]
	public class CrmCaseStage : OpenErpEntityBase {
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("on_change", OpenErpType.Boolean)]
		public bool OnChange { get; set; }
		[OpenErpMap("probability", OpenErpType.Float)]
		public double Probability { get; set; }
		[OpenErpMap("requirements", OpenErpType.Char)]
		public string Requirements { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
	}

	[OpenErpMap("crm.lead")]
	public class CrmLead : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("birthdate", OpenErpType.Char)]
		public string Birthdate { get; set; }
		[OpenErpMap("categ_id", OpenErpType.Integer)]
		public int? CategId { get; set; }
		[OpenErpMap("channel_id", OpenErpType.Integer)]
		public int? ChannelId { get; set; }
		[OpenErpMap("city", OpenErpType.Char)]
		public string City { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("contact_name", OpenErpType.Char)]
		public string ContactName { get; set; }
		[OpenErpMap("country_id", OpenErpType.Integer)]
		public int? CountryId { get; set; }
		[OpenErpMap("create_date", OpenErpType.Datetime)]
		public DateTime? CreateDate { get; set; }
		[OpenErpMap("date_action", OpenErpType.Date)]
		public DateTime? DateAction { get; set; }
		[OpenErpMap("date_action_last", OpenErpType.Datetime)]
		public DateTime? DateActionLast { get; set; }
		[OpenErpMap("date_action_next", OpenErpType.Datetime)]
		public DateTime? DateActionNext { get; set; }
		[OpenErpMap("date_closed", OpenErpType.Datetime)]
		public DateTime? DateClosed { get; set; }
		[OpenErpMap("date_deadline", OpenErpType.Date)]
		public DateTime? DateDeadline { get; set; }
		[OpenErpMap("date_open", OpenErpType.Datetime)]
		public DateTime? DateOpen { get; set; }
		[OpenErpMap("day_close", OpenErpType.Float)]
		public double? DayClose { get; set; }
		[OpenErpMap("day_open", OpenErpType.Float)]
		public double? DayOpen { get; set; }
		[OpenErpMap("description", OpenErpType.Char)]
		public string Description { get; set; }
		[OpenErpMap("email", OpenErpType.Char)]
		public string Email { get; set; }
		[OpenErpMap("email_cc", OpenErpType.Char)]
		public string EmailCc { get; set; }
		[OpenErpMap("email_from", OpenErpType.Char)]
		public string EmailFrom { get; set; }
		[OpenErpMap("fax", OpenErpType.Char)]
		public string Fax { get; set; }
		[OpenErpMap("function", OpenErpType.Char)]
		public string Function { get; set; }
		[OpenErpMap("is_customer_add", OpenErpType.Boolean)]
		public bool IsCustomerAdd { get; set; }
		[OpenErpMap("is_supplier_add", OpenErpType.Boolean)]
		public bool IsSupplierAdd { get; set; }
		[OpenErpMap("mobile", OpenErpType.Char)]
		public string Mobile { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("optin", OpenErpType.Boolean)]
		public bool Optin { get; set; }
		[OpenErpMap("optout", OpenErpType.Boolean)]
		public bool Optout { get; set; }
		[OpenErpMap("partner_address_id", OpenErpType.Integer)]
		public int? PartnerAddressId { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("partner_name", OpenErpType.Char)]
		public string PartnerName { get; set; }
		[OpenErpMap("phone", OpenErpType.Char)]
		public string Phone { get; set; }
		[OpenErpMap("planned_revenue", OpenErpType.Float)]
		public double? PlannedRevenue { get; set; }
		[OpenErpMap("priority", OpenErpType.Selection)]
		public string Priority { get; set; }
		[OpenErpMap("probability", OpenErpType.Float)]
		public double? Probability { get; set; }
		[OpenErpMap("referred", OpenErpType.Char)]
		public string Referred { get; set; }
		[OpenErpMap("section_id", OpenErpType.Integer)]
		public int? SectionId { get; set; }
		[OpenErpMap("stage_id", OpenErpType.Integer)]
		public int? StageId { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("state_id", OpenErpType.Integer)]
		public int? StateId { get; set; }
		[OpenErpMap("street", OpenErpType.Char)]
		public string Street { get; set; }
		[OpenErpMap("street2", OpenErpType.Char)]
		public string Street2 { get; set; }
		[OpenErpMap("zip", OpenErpType.Char)]
		public string Zip { get; set; }
		[OpenErpMap("title", OpenErpType.Integer)]
		public int? Title { get; set; }
		[OpenErpMap("title_action", OpenErpType.Char)]
		public string TitleAction { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
		[OpenErpMap("type_id", OpenErpType.Integer)]
		public int? TypeId { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
		[OpenErpMap("write_date", OpenErpType.Datetime)]
		public DateTime? WriteDate { get; set; }
	}

	[OpenErpMap("crm.lead.report")]
	public class CrmLeadReport : OpenErpEntityBase {
		[OpenErpMap("categ_id", OpenErpType.Integer)]
		public int? CategId { get; set; }
		[OpenErpMap("channel_id", OpenErpType.Integer)]
		public int? ChannelId { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("country_id", OpenErpType.Integer)]
		public int? CountryId { get; set; }
		[OpenErpMap("create_date", OpenErpType.Datetime)]
		public DateTime? CreateDate { get; set; }
		[OpenErpMap("creation_date", OpenErpType.Date)]
		public DateTime? CreationDate { get; set; }
		[OpenErpMap("date_closed", OpenErpType.Date)]
		public DateTime? DateClosed { get; set; }
		[OpenErpMap("day", OpenErpType.Char)]
		public string Day { get; set; }
		[OpenErpMap("delay_close", OpenErpType.Float)]
		public double? DelayClose { get; set; }
		[OpenErpMap("delay_expected", OpenErpType.Float)]
		public double? DelayExpected { get; set; }
		[OpenErpMap("delay_open", OpenErpType.Float)]
		public double? DelayOpen { get; set; }
		[OpenErpMap("email", OpenErpType.Integer)]
		public int? Email { get; set; }
		[OpenErpMap("month", OpenErpType.Selection)]
		public string Month { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("nbr", OpenErpType.Integer)]
		public int? Nbr { get; set; }
		[OpenErpMap("opening_date", OpenErpType.Date)]
		public DateTime? OpeningDate { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("planned_revenue", OpenErpType.Float)]
		public double? PlannedRevenue { get; set; }
		[OpenErpMap("priority", OpenErpType.Selection)]
		public string Priority { get; set; }
		[OpenErpMap("probability", OpenErpType.Float)]
		public double? Probability { get; set; }
		[OpenErpMap("probable_revenue", OpenErpType.Float)]
		public double? ProbableRevenue { get; set; }
		[OpenErpMap("section_id", OpenErpType.Integer)]
		public int? SectionId { get; set; }
		[OpenErpMap("stage_id", OpenErpType.Integer)]
		public int? StageId { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
		[OpenErpMap("type_id", OpenErpType.Integer)]
		public int? TypeId { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("crm.meeting")]
	public class CrmMeeting : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("alarm_id", OpenErpType.Integer)]
		public int? AlarmId { get; set; }
		[OpenErpMap("allday", OpenErpType.Boolean)]
		public bool Allday { get; set; }
		[OpenErpMap("base_calendar_alarm_id", OpenErpType.Integer)]
		public int? BaseCalendarAlarmId { get; set; }
		[OpenErpMap("base_calendar_url", OpenErpType.Char)]
		public string BaseCalendarUrl { get; set; }
		[OpenErpMap("byday", OpenErpType.Selection)]
		public string Byday { get; set; }
		[OpenErpMap("categ_id", OpenErpType.Integer)]
		public int? CategId { get; set; }
		[OpenErpMap("class", OpenErpType.Selection)]
		public string Class { get; set; }
		[OpenErpMap("count", OpenErpType.Integer)]
		public int? Count { get; set; }
		[OpenErpMap("create_date", OpenErpType.Datetime)]
		public DateTime? CreateDate { get; set; }
		[OpenErpMap("date", OpenErpType.Datetime)]
		public DateTime? Date { get; set; }
		[OpenErpMap("date_action_last", OpenErpType.Datetime)]
		public DateTime? DateActionLast { get; set; }
		[OpenErpMap("date_action_next", OpenErpType.Datetime)]
		public DateTime? DateActionNext { get; set; }
		[OpenErpMap("date_closed", OpenErpType.Datetime)]
		public DateTime? DateClosed { get; set; }
		[OpenErpMap("date_deadline", OpenErpType.Datetime)]
		public DateTime? DateDeadline { get; set; }
		[OpenErpMap("day", OpenErpType.Integer)]
		public int? Day { get; set; }
		[OpenErpMap("description", OpenErpType.Char)]
		public string Description { get; set; }
		[OpenErpMap("duration", OpenErpType.Float)]
		public double? Duration { get; set; }
		[OpenErpMap("edit_all", OpenErpType.Boolean)]
		public bool EditAll { get; set; }
		[OpenErpMap("email_from", OpenErpType.Char)]
		public string EmailFrom { get; set; }
		[OpenErpMap("end_date", OpenErpType.Date)]
		public DateTime? EndDate { get; set; }
		[OpenErpMap("end_type", OpenErpType.Selection)]
		public string EndType { get; set; }
		[OpenErpMap("exdate", OpenErpType.Char)]
		public string Exdate { get; set; }
		[OpenErpMap("exrule", OpenErpType.Char)]
		public string Exrule { get; set; }
		[OpenErpMap("fr", OpenErpType.Boolean)]
		public bool Fr { get; set; }
		[OpenErpMap("freq", OpenErpType.Selection)]
		public string Freq { get; set; }
		[OpenErpMap("interval", OpenErpType.Integer)]
		public int? Interval { get; set; }
		[OpenErpMap("location", OpenErpType.Char)]
		public string Location { get; set; }
		[OpenErpMap("mo", OpenErpType.Boolean)]
		public bool Mo { get; set; }
		[OpenErpMap("month_list", OpenErpType.Selection)]
		public string MonthList { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("opportunity_id", OpenErpType.Integer)]
		public int? OpportunityId { get; set; }
		[OpenErpMap("organizer", OpenErpType.Char)]
		public string Organizer { get; set; }
		[OpenErpMap("organizer_id", OpenErpType.Integer)]
		public int? OrganizerId { get; set; }
		[OpenErpMap("partner_address_id", OpenErpType.Integer)]
		public int? PartnerAddressId { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("phonecall_id", OpenErpType.Integer)]
		public int? PhonecallId { get; set; }
		[OpenErpMap("recurrency", OpenErpType.Boolean)]
		public bool Recurrency { get; set; }
		[OpenErpMap("recurrent_id", OpenErpType.Datetime)]
		public DateTime? RecurrentId { get; set; }
		[OpenErpMap("recurrent_uid", OpenErpType.Integer)]
		public int? RecurrentUid { get; set; }
		[OpenErpMap("rrule", OpenErpType.Char)]
		public string Rrule { get; set; }
		[OpenErpMap("rrule_type", OpenErpType.Selection)]
		public string RruleType { get; set; }
		[OpenErpMap("sa", OpenErpType.Boolean)]
		public bool Sa { get; set; }
		[OpenErpMap("section_id", OpenErpType.Integer)]
		public int? SectionId { get; set; }
		[OpenErpMap("select1", OpenErpType.Selection)]
		public string Select1 { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
		[OpenErpMap("show_as", OpenErpType.Selection)]
		public string ShowAs { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("su", OpenErpType.Boolean)]
		public bool Su { get; set; }
		[OpenErpMap("th", OpenErpType.Boolean)]
		public bool Th { get; set; }
		[OpenErpMap("tu", OpenErpType.Boolean)]
		public bool Tu { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
		[OpenErpMap("we", OpenErpType.Boolean)]
		public bool We { get; set; }
		[OpenErpMap("week_list", OpenErpType.Selection)]
		public string WeekList { get; set; }
		[OpenErpMap("write_date", OpenErpType.Datetime)]
		public DateTime? WriteDate { get; set; }
		[OpenErpMap("vtimezone", OpenErpType.Selection)]
		public string Vtimezone { get; set; }
	}

	[OpenErpMap("crm.phonecall")]
	public class CrmPhonecall : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("canal_id", OpenErpType.Integer)]
		public int? CanalId { get; set; }
		[OpenErpMap("categ_id", OpenErpType.Integer)]
		public int? CategId { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("create_date", OpenErpType.Datetime)]
		public DateTime? CreateDate { get; set; }
		[OpenErpMap("date", OpenErpType.Datetime)]
		public DateTime? Date { get; set; }
		[OpenErpMap("date_action_last", OpenErpType.Datetime)]
		public DateTime? DateActionLast { get; set; }
		[OpenErpMap("date_action_next", OpenErpType.Datetime)]
		public DateTime? DateActionNext { get; set; }
		[OpenErpMap("date_closed", OpenErpType.Datetime)]
		public DateTime? DateClosed { get; set; }
		[OpenErpMap("date_open", OpenErpType.Datetime)]
		public DateTime? DateOpen { get; set; }
		[OpenErpMap("description", OpenErpType.Char)]
		public string Description { get; set; }
		[OpenErpMap("duration", OpenErpType.Float)]
		public double? Duration { get; set; }
		[OpenErpMap("email_from", OpenErpType.Char)]
		public string EmailFrom { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("opportunity_id", OpenErpType.Integer)]
		public int? OpportunityId { get; set; }
		[OpenErpMap("partner_address_id", OpenErpType.Integer)]
		public int? PartnerAddressId { get; set; }
		[OpenErpMap("partner_contact", OpenErpType.Char)]
		public string PartnerContact { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("partner_mobile", OpenErpType.Char)]
		public string PartnerMobile { get; set; }
		[OpenErpMap("partner_phone", OpenErpType.Char)]
		public string PartnerPhone { get; set; }
		[OpenErpMap("priority", OpenErpType.Selection)]
		public string Priority { get; set; }
		[OpenErpMap("section_id", OpenErpType.Integer)]
		public int? SectionId { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("crm.phonecall.report")]
	public class CrmPhonecallReport : OpenErpEntityBase {
		[OpenErpMap("categ_id", OpenErpType.Integer)]
		public int? CategId { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("create_date", OpenErpType.Datetime)]
		public DateTime? CreateDate { get; set; }
		[OpenErpMap("creation_date", OpenErpType.Date)]
		public DateTime? CreationDate { get; set; }
		[OpenErpMap("date_closed", OpenErpType.Date)]
		public DateTime? DateClosed { get; set; }
		[OpenErpMap("day", OpenErpType.Char)]
		public string Day { get; set; }
		[OpenErpMap("delay_close", OpenErpType.Float)]
		public double? DelayClose { get; set; }
		[OpenErpMap("delay_open", OpenErpType.Float)]
		public double? DelayOpen { get; set; }
		[OpenErpMap("duration", OpenErpType.Float)]
		public double? Duration { get; set; }
		[OpenErpMap("month", OpenErpType.Selection)]
		public string Month { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("nbr", OpenErpType.Integer)]
		public int? Nbr { get; set; }
		[OpenErpMap("opening_date", OpenErpType.Date)]
		public DateTime? OpeningDate { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("priority", OpenErpType.Selection)]
		public string Priority { get; set; }
		[OpenErpMap("section_id", OpenErpType.Integer)]
		public int? SectionId { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("crm.segmentation")]
	public class CrmSegmentation : OpenErpEntityBase {
		[OpenErpMap("categ_id", OpenErpType.Integer)]
		public int? CategId { get; set; }
		[OpenErpMap("description", OpenErpType.Char)]
		public string Description { get; set; }
		[OpenErpMap("exclusif", OpenErpType.Boolean)]
		public bool Exclusif { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("sales_purchase_active", OpenErpType.Boolean)]
		public bool SalesPurchaseActive { get; set; }
		[OpenErpMap("som_interval", OpenErpType.Integer)]
		public int? SomInterval { get; set; }
		[OpenErpMap("som_interval_decrease", OpenErpType.Float)]
		public double? SomIntervalDecrease { get; set; }
		[OpenErpMap("som_interval_default", OpenErpType.Float)]
		public double? SomIntervalDefault { get; set; }
		[OpenErpMap("som_interval_max", OpenErpType.Integer)]
		public int? SomIntervalMax { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
	}

	[OpenErpMap("crm.segmentation.line")]
	public class CrmSegmentationLine : OpenErpEntityBase {
		[OpenErpMap("expr_name", OpenErpType.Selection)]
		public string ExprName { get; set; }
		[OpenErpMap("expr_operator", OpenErpType.Selection)]
		public string ExprOperator { get; set; }
		[OpenErpMap("expr_value", OpenErpType.Float)]
		public double? ExprValue { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("operator", OpenErpType.Selection)]
		public string Operator { get; set; }
		[OpenErpMap("segmentation_id", OpenErpType.Integer)]
		public int? SegmentationId { get; set; }
	}

	[OpenErpMap("decimal.precision")]
	public class DecimalPrecision : OpenErpEntityBase {
		[OpenErpMap("digits", OpenErpType.Integer)]
		public int? Digits { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
	}

	[OpenErpMap("document.directory")]
	public class DocumentDirectory : OpenErpEntityBase {
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("create_date", OpenErpType.Datetime)]
		public DateTime? CreateDate { get; set; }
		[OpenErpMap("create_uid", OpenErpType.Integer)]
		public int? CreateUid { get; set; }
		[OpenErpMap("domain", OpenErpType.Char)]
		public string Domain { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("parent_id", OpenErpType.Integer)]
		public int? ParentId { get; set; }
		[OpenErpMap("resource_field", OpenErpType.Integer)]
		public int? ResourceField { get; set; }
		[OpenErpMap("resource_find_all", OpenErpType.Boolean)]
		public bool ResourceFindAll { get; set; }
		[OpenErpMap("ressource_id", OpenErpType.Integer)]
		public int? RessourceId { get; set; }
		[OpenErpMap("ressource_parent_type_id", OpenErpType.Integer)]
		public int? RessourceParentTypeId { get; set; }
		[OpenErpMap("ressource_tree", OpenErpType.Boolean)]
		public bool RessourceTree { get; set; }
		[OpenErpMap("ressource_type_id", OpenErpType.Integer)]
		public int? RessourceTypeId { get; set; }
		[OpenErpMap("storage_id", OpenErpType.Integer)]
		public int? StorageId { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
		[OpenErpMap("write_date", OpenErpType.Datetime)]
		public DateTime? WriteDate { get; set; }
		[OpenErpMap("write_uid", OpenErpType.Integer)]
		public int? WriteUid { get; set; }
	}

	[OpenErpMap("document.directory.content")]
	public class DocumentDirectoryContent : OpenErpEntityBase {
		[OpenErpMap("directory_id", OpenErpType.Integer)]
		public int? DirectoryId { get; set; }
		[OpenErpMap("extension", OpenErpType.Selection)]
		public string Extension { get; set; }
		[OpenErpMap("include_name", OpenErpType.Boolean)]
		public bool IncludeName { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("prefix", OpenErpType.Char)]
		public string Prefix { get; set; }
		[OpenErpMap("report_id", OpenErpType.Integer)]
		public int? ReportId { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
		[OpenErpMap("suffix", OpenErpType.Char)]
		public string Suffix { get; set; }
	}

	[OpenErpMap("document.directory.content.type")]
	public class DocumentDirectoryContentType : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("code", OpenErpType.Char)]
		public string Code { get; set; }
		[OpenErpMap("mimetype", OpenErpType.Char)]
		public string Mimetype { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
	}

	[OpenErpMap("document.directory.dctx")]
	public class DocumentDirectoryDctx : OpenErpEntityBase {
		[OpenErpMap("dir_id", OpenErpType.Integer)]
		public int? DirId { get; set; }
		[OpenErpMap("expr", OpenErpType.Char)]
		public string Expr { get; set; }
		[OpenErpMap("field", OpenErpType.Char)]
		public string Field { get; set; }
	}

	[OpenErpMap("document.storage")]
	public class DocumentStorage : OpenErpEntityBase {
		[OpenErpMap("create_date", OpenErpType.Datetime)]
		public DateTime? CreateDate { get; set; }
		[OpenErpMap("create_uid", OpenErpType.Integer)]
		public int? CreateUid { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("online", OpenErpType.Boolean)]
		public bool Online { get; set; }
		[OpenErpMap("path", OpenErpType.Char)]
		public string Path { get; set; }
		[OpenErpMap("readonly", OpenErpType.Boolean)]
		public bool Readonly { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
		[OpenErpMap("write_date", OpenErpType.Datetime)]
		public DateTime? WriteDate { get; set; }
		[OpenErpMap("write_uid", OpenErpType.Integer)]
		public int? WriteUid { get; set; }
	}

	[OpenErpMap("hr.action.reason")]
	public class HrActionReason : OpenErpEntityBase {
		[OpenErpMap("action_type", OpenErpType.Selection)]
		public string ActionType { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
	}

	[OpenErpMap("hr.analytic.timesheet")]
	public class HrAnalyticTimesheet : OpenErpEntityBase {
		[OpenErpMap("line_id", OpenErpType.Integer)]
		public int LineId { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("sheet_id", OpenErpType.Integer)]
		public int? SheetId { get; set; }
	}

	[OpenErpMap("hr.applicant")]
	public class HrApplicant : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("availability", OpenErpType.Integer)]
		public int? Availability { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("create_date", OpenErpType.Datetime)]
		public DateTime? CreateDate { get; set; }
		[OpenErpMap("date", OpenErpType.Datetime)]
		public DateTime? Date { get; set; }
		[OpenErpMap("date_action", OpenErpType.Date)]
		public DateTime? DateAction { get; set; }
		[OpenErpMap("date_closed", OpenErpType.Datetime)]
		public DateTime? DateClosed { get; set; }
		[OpenErpMap("date_open", OpenErpType.Datetime)]
		public DateTime? DateOpen { get; set; }
		[OpenErpMap("day_close", OpenErpType.Float)]
		public double? DayClose { get; set; }
		[OpenErpMap("day_open", OpenErpType.Float)]
		public double? DayOpen { get; set; }
		[OpenErpMap("department_id", OpenErpType.Integer)]
		public int? DepartmentId { get; set; }
		[OpenErpMap("description", OpenErpType.Char)]
		public string Description { get; set; }
		[OpenErpMap("email_cc", OpenErpType.Char)]
		public string EmailCc { get; set; }
		[OpenErpMap("email_from", OpenErpType.Char)]
		public string EmailFrom { get; set; }
		[OpenErpMap("job_id", OpenErpType.Integer)]
		public int? JobId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("partner_address_id", OpenErpType.Integer)]
		public int? PartnerAddressId { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("partner_mobile", OpenErpType.Char)]
		public string PartnerMobile { get; set; }
		[OpenErpMap("partner_name", OpenErpType.Char)]
		public string PartnerName { get; set; }
		[OpenErpMap("partner_phone", OpenErpType.Char)]
		public string PartnerPhone { get; set; }
		[OpenErpMap("priority", OpenErpType.Selection)]
		public string Priority { get; set; }
		[OpenErpMap("probability", OpenErpType.Float)]
		public double? Probability { get; set; }
		[OpenErpMap("reference", OpenErpType.Char)]
		public string Reference { get; set; }
		[OpenErpMap("response", OpenErpType.Integer)]
		public int? Response { get; set; }
		[OpenErpMap("salary_expected", OpenErpType.Float)]
		public double? SalaryExpected { get; set; }
		[OpenErpMap("salary_proposed", OpenErpType.Float)]
		public double? SalaryProposed { get; set; }
		[OpenErpMap("stage_id", OpenErpType.Integer)]
		public int? StageId { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("survey", OpenErpType.Integer)]
		public int? Survey { get; set; }
		[OpenErpMap("title_action", OpenErpType.Char)]
		public string TitleAction { get; set; }
		[OpenErpMap("type_id", OpenErpType.Integer)]
		public int? TypeId { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
		[OpenErpMap("write_date", OpenErpType.Datetime)]
		public DateTime? WriteDate { get; set; }
	}

	[OpenErpMap("hr.attendance")]
	public class HrAttendance : OpenErpEntityBase {
		[OpenErpMap("action", OpenErpType.Selection)]
		public string Action { get; set; }
		[OpenErpMap("action_desc", OpenErpType.Integer)]
		public int? ActionDesc { get; set; }
		[OpenErpMap("day", OpenErpType.Char)]
		public string Day { get; set; }
		[OpenErpMap("employee_id", OpenErpType.Integer)]
		public int EmployeeId { get; set; }
		[OpenErpMap("name", OpenErpType.Datetime)]
		public DateTime Name { get; set; }
		[OpenErpMap("sheet_id", OpenErpType.Integer)]
		public int? SheetId { get; set; }
	}

	[OpenErpMap("hr.contract")]
	public class HrContract : OpenErpEntityBase {
		[OpenErpMap("advantages", OpenErpType.Char)]
		public string Advantages { get; set; }
		[OpenErpMap("advantages_gross", OpenErpType.Float)]
		public double? AdvantagesGross { get; set; }
		[OpenErpMap("advantages_net", OpenErpType.Float)]
		public double? AdvantagesNet { get; set; }
		[OpenErpMap("date_end", OpenErpType.Date)]
		public DateTime? DateEnd { get; set; }
		[OpenErpMap("date_start", OpenErpType.Date)]
		public DateTime? DateStart { get; set; }
		[OpenErpMap("department_id", OpenErpType.Integer)]
		public int? DepartmentId { get; set; }
		[OpenErpMap("employee_id", OpenErpType.Integer)]
		public int? EmployeeId { get; set; }
		[OpenErpMap("job_id", OpenErpType.Integer)]
		public int? JobId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("notes", OpenErpType.Char)]
		public string Notes { get; set; }
		[OpenErpMap("trial_date_end", OpenErpType.Date)]
		public DateTime? TrialDateEnd { get; set; }
		[OpenErpMap("trial_date_start", OpenErpType.Date)]
		public DateTime? TrialDateStart { get; set; }
		[OpenErpMap("type_id", OpenErpType.Integer)]
		public int? TypeId { get; set; }
		[OpenErpMap("wage", OpenErpType.Float)]
		public double? Wage { get; set; }
		[OpenErpMap("wage_type_id", OpenErpType.Integer)]
		public int? WageTypeId { get; set; }
		[OpenErpMap("working_hours", OpenErpType.Integer)]
		public int? WorkingHours { get; set; }
	}

	[OpenErpMap("hr.contract.type")]
	public class HrContractType : OpenErpEntityBase {
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
	}

	[OpenErpMap("hr.contract.wage.type")]
	public class HrContractWageType : OpenErpEntityBase {
		[OpenErpMap("factor_type", OpenErpType.Float)]
		public double? FactorType { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("period_id", OpenErpType.Integer)]
		public int? PeriodId { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
	}

	[OpenErpMap("hr.contract.wage.type.period")]
	public class HrContractWageTypePeriod : OpenErpEntityBase {
		[OpenErpMap("factor_days", OpenErpType.Float)]
		public double? FactorDays { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
	}

	[OpenErpMap("hr.department")]
	public class HrDepartment : OpenErpEntityBase {
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("complete_name", OpenErpType.Char)]
		public string CompleteName { get; set; }
		[OpenErpMap("manager_id", OpenErpType.Integer)]
		public int? ManagerId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("note", OpenErpType.Char)]
		public string Note { get; set; }
		[OpenErpMap("parent_id", OpenErpType.Integer)]
		public int? ParentId { get; set; }
	}

	[OpenErpMap("hr.employee")]
	public class HrEmployee : OpenErpEntityBase {
		[OpenErpMap("address_home_id", OpenErpType.Integer)]
		public int? AddressHomeId { get; set; }
		[OpenErpMap("address_id", OpenErpType.Integer)]
		public int? AddressId { get; set; }
		[OpenErpMap("bank_account_id", OpenErpType.Integer)]
		public int? BankAccountId { get; set; }
		[OpenErpMap("birthday", OpenErpType.Date)]
		public DateTime? Birthday { get; set; }
		[OpenErpMap("children", OpenErpType.Integer)]
		public int? Children { get; set; }
		[OpenErpMap("coach_id", OpenErpType.Integer)]
		public int? CoachId { get; set; }
		[OpenErpMap("contract_id", OpenErpType.Integer)]
		public int? ContractId { get; set; }
		[OpenErpMap("country_id", OpenErpType.Integer)]
		public int? CountryId { get; set; }
		[OpenErpMap("department_id", OpenErpType.Integer)]
		public int? DepartmentId { get; set; }
		[OpenErpMap("gender", OpenErpType.Selection)]
		public string Gender { get; set; }
		[OpenErpMap("identification_id", OpenErpType.Char)]
		public string IdentificationId { get; set; }
		[OpenErpMap("job_id", OpenErpType.Integer)]
		public int? JobId { get; set; }
		[OpenErpMap("journal_id", OpenErpType.Integer)]
		public int? JournalId { get; set; }
		[OpenErpMap("manager", OpenErpType.Boolean)]
		public bool Manager { get; set; }
		[OpenErpMap("marital", OpenErpType.Integer)]
		public int? Marital { get; set; }
		[OpenErpMap("medic_exam", OpenErpType.Date)]
		public DateTime? MedicExam { get; set; }
		[OpenErpMap("mobile_phone", OpenErpType.Char)]
		public string MobilePhone { get; set; }
		[OpenErpMap("notes", OpenErpType.Char)]
		public string Notes { get; set; }
		[OpenErpMap("parent_id", OpenErpType.Integer)]
		public int? ParentId { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("passport_id", OpenErpType.Char)]
		public string PassportId { get; set; }
		[OpenErpMap("place_of_birth", OpenErpType.Char)]
		public string PlaceOfBirth { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("resource_id", OpenErpType.Integer)]
		public int ResourceId { get; set; }
		[OpenErpMap("sinid", OpenErpType.Char)]
		public string Sinid { get; set; }
		[OpenErpMap("ssnid", OpenErpType.Char)]
		public string Ssnid { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("vehicle", OpenErpType.Char)]
		public string Vehicle { get; set; }
		[OpenErpMap("vehicle_distance", OpenErpType.Integer)]
		public int? VehicleDistance { get; set; }
		[OpenErpMap("work_email", OpenErpType.Char)]
		public string WorkEmail { get; set; }
		[OpenErpMap("work_location", OpenErpType.Char)]
		public string WorkLocation { get; set; }
		[OpenErpMap("work_phone", OpenErpType.Char)]
		public string WorkPhone { get; set; }
	}

	[OpenErpMap("hr.employee.category")]
	public class HrEmployeeCategory : OpenErpEntityBase {
		[OpenErpMap("complete_name", OpenErpType.Char)]
		public string CompleteName { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("parent_id", OpenErpType.Integer)]
		public int? ParentId { get; set; }
	}

	[OpenErpMap("hr.employee.marital.status")]
	public class HrEmployeeMaritalStatus : OpenErpEntityBase {
		[OpenErpMap("description", OpenErpType.Char)]
		public string Description { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
	}

	[OpenErpMap("hr.expense.expense")]
	public class HrExpenseExpense : OpenErpEntityBase {
		[OpenErpMap("account_move_id", OpenErpType.Integer)]
		public int? AccountMoveId { get; set; }
		[OpenErpMap("amount", OpenErpType.Float)]
		public double? Amount { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("currency_id", OpenErpType.Integer)]
		public int? CurrencyId { get; set; }
		[OpenErpMap("date", OpenErpType.Date)]
		public DateTime? Date { get; set; }
		[OpenErpMap("date_confirm", OpenErpType.Date)]
		public DateTime? DateConfirm { get; set; }
		[OpenErpMap("date_valid", OpenErpType.Date)]
		public DateTime? DateValid { get; set; }
		[OpenErpMap("department_id", OpenErpType.Integer)]
		public int? DepartmentId { get; set; }
		[OpenErpMap("employee_id", OpenErpType.Integer)]
		public int? EmployeeId { get; set; }
		[OpenErpMap("invoice_id", OpenErpType.Integer)]
		public int? InvoiceId { get; set; }
		[OpenErpMap("journal_id", OpenErpType.Integer)]
		public int? JournalId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("note", OpenErpType.Char)]
		public string Note { get; set; }
		[OpenErpMap("ref", OpenErpType.Char)]
		public string Ref { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
		[OpenErpMap("user_valid", OpenErpType.Integer)]
		public int? UserValid { get; set; }
	}

	[OpenErpMap("hr.expense.line")]
	public class HrExpenseLine : OpenErpEntityBase {
		[OpenErpMap("analytic_account", OpenErpType.Integer)]
		public int? AnalyticAccount { get; set; }
		[OpenErpMap("date_value", OpenErpType.Date)]
		public DateTime? DateValue { get; set; }
		[OpenErpMap("description", OpenErpType.Char)]
		public string Description { get; set; }
		[OpenErpMap("expense_id", OpenErpType.Integer)]
		public int? ExpenseId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("ref", OpenErpType.Char)]
		public string Ref { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
		[OpenErpMap("total_amount", OpenErpType.Float)]
		public double? TotalAmount { get; set; }
		[OpenErpMap("unit_amount", OpenErpType.Float)]
		public double? UnitAmount { get; set; }
		[OpenErpMap("unit_quantity", OpenErpType.Float)]
		public double? UnitQuantity { get; set; }
		[OpenErpMap("uom_id", OpenErpType.Integer)]
		public int? UomId { get; set; }
	}

	[OpenErpMap("hr.expense.report")]
	public class HrExpenseReport : OpenErpEntityBase {
		[OpenErpMap("analytic_account", OpenErpType.Integer)]
		public int? AnalyticAccount { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("currency_id", OpenErpType.Integer)]
		public int? CurrencyId { get; set; }
		[OpenErpMap("date", OpenErpType.Date)]
		public DateTime? Date { get; set; }
		[OpenErpMap("date_confirm", OpenErpType.Date)]
		public DateTime? DateConfirm { get; set; }
		[OpenErpMap("date_valid", OpenErpType.Date)]
		public DateTime? DateValid { get; set; }
		[OpenErpMap("day", OpenErpType.Char)]
		public string Day { get; set; }
		[OpenErpMap("delay_confirm", OpenErpType.Float)]
		public double? DelayConfirm { get; set; }
		[OpenErpMap("delay_valid", OpenErpType.Float)]
		public double? DelayValid { get; set; }
		[OpenErpMap("department_id", OpenErpType.Integer)]
		public int? DepartmentId { get; set; }
		[OpenErpMap("employee_id", OpenErpType.Integer)]
		public int? EmployeeId { get; set; }
		[OpenErpMap("invoiced", OpenErpType.Integer)]
		public int? Invoiced { get; set; }
		[OpenErpMap("invoice_id", OpenErpType.Integer)]
		public int? InvoiceId { get; set; }
		[OpenErpMap("journal_id", OpenErpType.Integer)]
		public int? JournalId { get; set; }
		[OpenErpMap("month", OpenErpType.Selection)]
		public string Month { get; set; }
		[OpenErpMap("nbr", OpenErpType.Integer)]
		public int? Nbr { get; set; }
		[OpenErpMap("no_of_account", OpenErpType.Integer)]
		public int? NoOfAccount { get; set; }
		[OpenErpMap("no_of_products", OpenErpType.Integer)]
		public int? NoOfProducts { get; set; }
		[OpenErpMap("price_average", OpenErpType.Float)]
		public double? PriceAverage { get; set; }
		[OpenErpMap("price_total", OpenErpType.Float)]
		public double? PriceTotal { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("product_qty", OpenErpType.Float)]
		public double? ProductQty { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
		[OpenErpMap("year", OpenErpType.Char)]
		public string Year { get; set; }
	}

	[OpenErpMap("hr.holidays")]
	public class HrHolidays : OpenErpEntityBase {
		[OpenErpMap("case_id", OpenErpType.Integer)]
		public int? CaseId { get; set; }
		[OpenErpMap("category_id", OpenErpType.Integer)]
		public int? CategoryId { get; set; }
		[OpenErpMap("date_from", OpenErpType.Datetime)]
		public DateTime? DateFrom { get; set; }
		[OpenErpMap("date_to", OpenErpType.Datetime)]
		public DateTime? DateTo { get; set; }
		[OpenErpMap("department_id", OpenErpType.Integer)]
		public int? DepartmentId { get; set; }
		[OpenErpMap("employee_id", OpenErpType.Integer)]
		public int? EmployeeId { get; set; }
		[OpenErpMap("holiday_status_id", OpenErpType.Integer)]
		public int? HolidayStatusId { get; set; }
		[OpenErpMap("holiday_type", OpenErpType.Selection)]
		public string HolidayType { get; set; }
		[OpenErpMap("manager_id", OpenErpType.Integer)]
		public int? ManagerId { get; set; }
		[OpenErpMap("manager_id2", OpenErpType.Integer)]
		public int? ManagerId2 { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("notes", OpenErpType.Char)]
		public string Notes { get; set; }
		[OpenErpMap("number_of_days", OpenErpType.Float)]
		public double? NumberOfDays { get; set; }
		[OpenErpMap("number_of_days_temp", OpenErpType.Float)]
		public double? NumberOfDaysTemp { get; set; }
		[OpenErpMap("parent_id", OpenErpType.Integer)]
		public int? ParentId { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("hr.holidays.remaining.leaves.user")]
	public class HrHolidaysRemainingLeavesUser : OpenErpEntityBase {
		[OpenErpMap("leave_type", OpenErpType.Char)]
		public string LeaveType { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("no_of_leaves", OpenErpType.Integer)]
		public int? NoOfLeaves { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("hr.holidays.status")]
	public class HrHolidaysStatus : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("categ_id", OpenErpType.Integer)]
		public int? CategId { get; set; }
		[OpenErpMap("color_name", OpenErpType.Selection)]
		public string ColorName { get; set; }
		[OpenErpMap("double_validation", OpenErpType.Boolean)]
		public bool DoubleValidation { get; set; }
		[OpenErpMap("leaves_taken", OpenErpType.Float)]
		public double? LeavesTaken { get; set; }
		[OpenErpMap("limit", OpenErpType.Boolean)]
		public bool Limit { get; set; }
		[OpenErpMap("max_leaves", OpenErpType.Float)]
		public double? MaxLeaves { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("remaining_leaves", OpenErpType.Float)]
		public double? RemainingLeaves { get; set; }
	}

	[OpenErpMap("hr.job")]
	public class HrJob : OpenErpEntityBase {
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("department_id", OpenErpType.Integer)]
		public int? DepartmentId { get; set; }
		[OpenErpMap("description", OpenErpType.Char)]
		public string Description { get; set; }
		[OpenErpMap("expected_employees", OpenErpType.Integer)]
		public int? ExpectedEmployees { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("no_of_employee", OpenErpType.Float)]
		public double? NoOfEmployee { get; set; }
		[OpenErpMap("no_of_recruitment", OpenErpType.Float)]
		public double? NoOfRecruitment { get; set; }
		[OpenErpMap("requirements", OpenErpType.Char)]
		public string Requirements { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("survey_id", OpenErpType.Integer)]
		public int? SurveyId { get; set; }
	}

	[OpenErpMap("hr.recruitment.degree")]
	public class HrRecruitmentDegree : OpenErpEntityBase {
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
	}

	[OpenErpMap("hr.recruitment.report")]
	public class HrRecruitmentReport : OpenErpEntityBase {
		[OpenErpMap("available", OpenErpType.Float)]
		public double? Available { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("date", OpenErpType.Date)]
		public DateTime? Date { get; set; }
		[OpenErpMap("date_closed", OpenErpType.Date)]
		public DateTime? DateClosed { get; set; }
		[OpenErpMap("day", OpenErpType.Char)]
		public string Day { get; set; }
		[OpenErpMap("delay_close", OpenErpType.Float)]
		public double? DelayClose { get; set; }
		[OpenErpMap("delay_open", OpenErpType.Float)]
		public double? DelayOpen { get; set; }
		[OpenErpMap("department_id", OpenErpType.Integer)]
		public int? DepartmentId { get; set; }
		[OpenErpMap("job_id", OpenErpType.Integer)]
		public int? JobId { get; set; }
		[OpenErpMap("month", OpenErpType.Selection)]
		public string Month { get; set; }
		[OpenErpMap("nbr", OpenErpType.Integer)]
		public int? Nbr { get; set; }
		[OpenErpMap("partner_address_id", OpenErpType.Integer)]
		public int? PartnerAddressId { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("priority", OpenErpType.Selection)]
		public string Priority { get; set; }
		[OpenErpMap("salary_exp", OpenErpType.Float)]
		public double? SalaryExp { get; set; }
		[OpenErpMap("salary_prop", OpenErpType.Float)]
		public double? SalaryProp { get; set; }
		[OpenErpMap("salary_prop_avg", OpenErpType.Float)]
		public double? SalaryPropAvg { get; set; }
		[OpenErpMap("stage_id", OpenErpType.Integer)]
		public int? StageId { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("type_id", OpenErpType.Integer)]
		public int? TypeId { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
		[OpenErpMap("year", OpenErpType.Char)]
		public string Year { get; set; }
	}

	[OpenErpMap("hr.recruitment.stage")]
	public class HrRecruitmentStage : OpenErpEntityBase {
		[OpenErpMap("department_id", OpenErpType.Integer)]
		public int? DepartmentId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("requirements", OpenErpType.Char)]
		public string Requirements { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
	}

	[OpenErpMap("hr_timesheet_invoice.factor")]
	public class Hr_timesheet_invoiceFactor : OpenErpEntityBase {
		[OpenErpMap("customer_name", OpenErpType.Char)]
		public string CustomerName { get; set; }
		[OpenErpMap("factor", OpenErpType.Float)]
		public double? Factor { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
	}

	[OpenErpMap("hr.timesheet.report")]
	public class HrTimesheetReport : OpenErpEntityBase {
		[OpenErpMap("account_id", OpenErpType.Integer)]
		public int? AccountId { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("cost", OpenErpType.Float)]
		public double? Cost { get; set; }
		[OpenErpMap("date", OpenErpType.Date)]
		public DateTime? Date { get; set; }
		[OpenErpMap("day", OpenErpType.Char)]
		public string Day { get; set; }
		[OpenErpMap("general_account_id", OpenErpType.Integer)]
		public int? GeneralAccountId { get; set; }
		[OpenErpMap("journal_id", OpenErpType.Integer)]
		public int? JournalId { get; set; }
		[OpenErpMap("month", OpenErpType.Selection)]
		public string Month { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("quantity", OpenErpType.Float)]
		public double? Quantity { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
		[OpenErpMap("year", OpenErpType.Char)]
		public string Year { get; set; }
	}

	[OpenErpMap("hr_timesheet_sheet.sheet")]
	public class Hr_timesheet_sheetSheet : OpenErpEntityBase {
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("date_current", OpenErpType.Date)]
		public DateTime? DateCurrent { get; set; }
		[OpenErpMap("date_from", OpenErpType.Date)]
		public DateTime? DateFrom { get; set; }
		[OpenErpMap("date_to", OpenErpType.Date)]
		public DateTime? DateTo { get; set; }
		[OpenErpMap("department_id", OpenErpType.Integer)]
		public int? DepartmentId { get; set; }
		[OpenErpMap("employee_id", OpenErpType.Integer)]
		public int? EmployeeId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("state_attendance", OpenErpType.Selection)]
		public string StateAttendance { get; set; }
		[OpenErpMap("total_attendance", OpenErpType.Float)]
		public double? TotalAttendance { get; set; }
		[OpenErpMap("total_attendance_day", OpenErpType.Float)]
		public double? TotalAttendanceDay { get; set; }
		[OpenErpMap("total_difference", OpenErpType.Float)]
		public double? TotalDifference { get; set; }
		[OpenErpMap("total_difference_day", OpenErpType.Float)]
		public double? TotalDifferenceDay { get; set; }
		[OpenErpMap("total_timesheet", OpenErpType.Float)]
		public double? TotalTimesheet { get; set; }
		[OpenErpMap("total_timesheet_day", OpenErpType.Float)]
		public double? TotalTimesheetDay { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("hr_timesheet_sheet.sheet.account")]
	public class Hr_timesheet_sheetSheetAccount : OpenErpEntityBase {
		[OpenErpMap("invoice_rate", OpenErpType.Integer)]
		public int? InvoiceRate { get; set; }
		[OpenErpMap("name", OpenErpType.Integer)]
		public int? Name { get; set; }
		[OpenErpMap("sheet_id", OpenErpType.Integer)]
		public int? SheetId { get; set; }
		[OpenErpMap("total", OpenErpType.Float)]
		public double? Total { get; set; }
	}

	[OpenErpMap("hr_timesheet_sheet.sheet.day")]
	public class Hr_timesheet_sheetSheetDay : OpenErpEntityBase {
		[OpenErpMap("name", OpenErpType.Date)]
		public DateTime? Name { get; set; }
		[OpenErpMap("sheet_id", OpenErpType.Integer)]
		public int? SheetId { get; set; }
		[OpenErpMap("total_attendance", OpenErpType.Float)]
		public double? TotalAttendance { get; set; }
		[OpenErpMap("total_difference", OpenErpType.Float)]
		public double? TotalDifference { get; set; }
		[OpenErpMap("total_timesheet", OpenErpType.Float)]
		public double? TotalTimesheet { get; set; }
	}

	[OpenErpMap("idea.category")]
	public class IdeaCategory : OpenErpEntityBase {
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("parent_id", OpenErpType.Integer)]
		public int? ParentId { get; set; }
		[OpenErpMap("summary", OpenErpType.Char)]
		public string Summary { get; set; }
		[OpenErpMap("visibility", OpenErpType.Boolean)]
		public bool Visibility { get; set; }
	}

	[OpenErpMap("idea.comment")]
	public class IdeaComment : OpenErpEntityBase {
		[OpenErpMap("content", OpenErpType.Char)]
		public string Content { get; set; }
		[OpenErpMap("create_date", OpenErpType.Datetime)]
		public DateTime? CreateDate { get; set; }
		[OpenErpMap("idea_id", OpenErpType.Integer)]
		public int? IdeaId { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("idea.idea")]
	public class IdeaIdea : OpenErpEntityBase {
		[OpenErpMap("category_id", OpenErpType.Integer)]
		public int? CategoryId { get; set; }
		[OpenErpMap("count_comments", OpenErpType.Integer)]
		public int? CountComments { get; set; }
		[OpenErpMap("count_votes", OpenErpType.Integer)]
		public int? CountVotes { get; set; }
		[OpenErpMap("created_date", OpenErpType.Datetime)]
		public DateTime? CreatedDate { get; set; }
		[OpenErpMap("description", OpenErpType.Char)]
		public string Description { get; set; }
		[OpenErpMap("my_vote", OpenErpType.Selection)]
		public string MyVote { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("open_date", OpenErpType.Datetime)]
		public DateTime? OpenDate { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
		[OpenErpMap("visibility", OpenErpType.Boolean)]
		public bool Visibility { get; set; }
		[OpenErpMap("vote_avg", OpenErpType.Float)]
		public double? VoteAvg { get; set; }
		[OpenErpMap("vote_limit", OpenErpType.Integer)]
		public int? VoteLimit { get; set; }
	}

	[OpenErpMap("idea.vote")]
	public class IdeaVote : OpenErpEntityBase {
		[OpenErpMap("comment", OpenErpType.Char)]
		public string Comment { get; set; }
		[OpenErpMap("date", OpenErpType.Datetime)]
		public DateTime? Date { get; set; }
		[OpenErpMap("idea_id", OpenErpType.Integer)]
		public int? IdeaId { get; set; }
		[OpenErpMap("score", OpenErpType.Selection)]
		public string Score { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("idea.vote.stat")]
	public class IdeaVoteStat : OpenErpEntityBase {
		[OpenErpMap("idea_id", OpenErpType.Integer)]
		public int? IdeaId { get; set; }
		[OpenErpMap("nbr", OpenErpType.Integer)]
		public int? Nbr { get; set; }
		[OpenErpMap("score", OpenErpType.Selection)]
		public string Score { get; set; }
	}

	[OpenErpMap("ir.actions.actions")]
	public class IrActionsActions : OpenErpEntityBase {
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("type", OpenErpType.Char)]
		public string Type { get; set; }
		[OpenErpMap("usage", OpenErpType.Char)]
		public string Usage { get; set; }
	}

	[OpenErpMap("ir.actions.act_window")]
	public class IrActionsAct_window : OpenErpEntityBase {
		[OpenErpMap("auto_refresh", OpenErpType.Integer)]
		public int? AutoRefresh { get; set; }
		[OpenErpMap("auto_search", OpenErpType.Boolean)]
		public bool AutoSearch { get; set; }
		[OpenErpMap("context", OpenErpType.Char)]
		public string Context { get; set; }
		[OpenErpMap("display_menu_tip", OpenErpType.Boolean)]
		public bool DisplayMenuTip { get; set; }
		[OpenErpMap("domain", OpenErpType.Char)]
		public string Domain { get; set; }
		[OpenErpMap("filter", OpenErpType.Boolean)]
		public bool Filter { get; set; }
		[OpenErpMap("help", OpenErpType.Char)]
		public string Help { get; set; }
		[OpenErpMap("limit", OpenErpType.Integer)]
		public int? Limit { get; set; }
		[OpenErpMap("menus", OpenErpType.Char)]
		public string Menus { get; set; }
		[OpenErpMap("multi", OpenErpType.Boolean)]
		public bool Multi { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("res_model", OpenErpType.Char)]
		public string ResModel { get; set; }
		[OpenErpMap("search_view", OpenErpType.Char)]
		public string SearchView { get; set; }
		[OpenErpMap("search_view_id", OpenErpType.Integer)]
		public int? SearchViewId { get; set; }
		[OpenErpMap("src_model", OpenErpType.Char)]
		public string SrcModel { get; set; }
		[OpenErpMap("target", OpenErpType.Selection)]
		public string Target { get; set; }
		[OpenErpMap("type", OpenErpType.Char)]
		public string Type { get; set; }
		[OpenErpMap("usage", OpenErpType.Char)]
		public string Usage { get; set; }
		[OpenErpMap("view_id", OpenErpType.Integer)]
		public int? ViewId { get; set; }
		[OpenErpMap("view_mode", OpenErpType.Char)]
		public string ViewMode { get; set; }
		[OpenErpMap("view_type", OpenErpType.Selection)]
		public string ViewType { get; set; }
	}

	[OpenErpMap("ir.actions.act_window_close")]
	public class IrActionsAct_window_close : OpenErpEntityBase {
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("type", OpenErpType.Char)]
		public string Type { get; set; }
		[OpenErpMap("usage", OpenErpType.Char)]
		public string Usage { get; set; }
	}

	[OpenErpMap("ir.actions.act_window.view")]
	public class IrActionsAct_windowView : OpenErpEntityBase {
		[OpenErpMap("act_window_id", OpenErpType.Integer)]
		public int? ActWindowId { get; set; }
		[OpenErpMap("multi", OpenErpType.Boolean)]
		public bool Multi { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
		[OpenErpMap("view_id", OpenErpType.Integer)]
		public int? ViewId { get; set; }
		[OpenErpMap("view_mode", OpenErpType.Selection)]
		public string ViewMode { get; set; }
	}

	[OpenErpMap("ir.actions.report.xml")]
	public class IrActionsReportXml : OpenErpEntityBase {
		[OpenErpMap("attachment", OpenErpType.Char)]
		public string Attachment { get; set; }
		[OpenErpMap("attachment_use", OpenErpType.Boolean)]
		public bool AttachmentUse { get; set; }
		[OpenErpMap("auto", OpenErpType.Boolean)]
		public bool Auto { get; set; }
		[OpenErpMap("header", OpenErpType.Boolean)]
		public bool Header { get; set; }
		[OpenErpMap("model", OpenErpType.Char)]
		public string Model { get; set; }
		[OpenErpMap("model_id", OpenErpType.Float)]
		public double? ModelId { get; set; }
		[OpenErpMap("multi", OpenErpType.Boolean)]
		public bool Multi { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("report_file", OpenErpType.Char)]
		public string ReportFile { get; set; }
		[OpenErpMap("report_name", OpenErpType.Char)]
		public string ReportName { get; set; }
		[OpenErpMap("report_rml", OpenErpType.Char)]
		public string ReportRml { get; set; }
		[OpenErpMap("report_sxw", OpenErpType.Char)]
		public string ReportSxw { get; set; }
		[OpenErpMap("report_type", OpenErpType.Char)]
		public string ReportType { get; set; }
		[OpenErpMap("report_xml", OpenErpType.Char)]
		public string ReportXml { get; set; }
		[OpenErpMap("report_xsl", OpenErpType.Char)]
		public string ReportXsl { get; set; }
		[OpenErpMap("type", OpenErpType.Char)]
		public string Type { get; set; }
		[OpenErpMap("usage", OpenErpType.Char)]
		public string Usage { get; set; }
	}

	[OpenErpMap("ir.actions.server")]
	public class IrActionsServer : OpenErpEntityBase {
		[OpenErpMap("action_id", OpenErpType.Integer)]
		public int? ActionId { get; set; }
		[OpenErpMap("code", OpenErpType.Char)]
		public string Code { get; set; }
		[OpenErpMap("condition", OpenErpType.Char)]
		public string Condition { get; set; }
		[OpenErpMap("email", OpenErpType.Char)]
		public string Email { get; set; }
		[OpenErpMap("expression", OpenErpType.Char)]
		public string Expression { get; set; }
		[OpenErpMap("loop_action", OpenErpType.Integer)]
		public int? LoopAction { get; set; }
		[OpenErpMap("message", OpenErpType.Char)]
		public string Message { get; set; }
		[OpenErpMap("mobile", OpenErpType.Char)]
		public string Mobile { get; set; }
		[OpenErpMap("model_id", OpenErpType.Integer)]
		public int? ModelId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("record_id", OpenErpType.Integer)]
		public int? RecordId { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
		[OpenErpMap("sms", OpenErpType.Char)]
		public string Sms { get; set; }
		[OpenErpMap("srcmodel_id", OpenErpType.Integer)]
		public int? SrcmodelId { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("subject", OpenErpType.Char)]
		public string Subject { get; set; }
		[OpenErpMap("trigger_name", OpenErpType.Selection)]
		public string TriggerName { get; set; }
		[OpenErpMap("trigger_obj_id", OpenErpType.Integer)]
		public int? TriggerObjId { get; set; }
		[OpenErpMap("type", OpenErpType.Char)]
		public string Type { get; set; }
		[OpenErpMap("usage", OpenErpType.Char)]
		public string Usage { get; set; }
		[OpenErpMap("wkf_model_id", OpenErpType.Integer)]
		public int? WkfModelId { get; set; }
		[OpenErpMap("write_id", OpenErpType.Char)]
		public string WriteId { get; set; }
	}

	[OpenErpMap("ir.actions.todo")]
	public class IrActionsTodo : OpenErpEntityBase {
		[OpenErpMap("action_id", OpenErpType.Integer)]
		public int? ActionId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("note", OpenErpType.Char)]
		public string Note { get; set; }
		[OpenErpMap("restart", OpenErpType.Selection)]
		public string Restart { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
	}

	[OpenErpMap("ir.actions.url")]
	public class IrActionsUrl : OpenErpEntityBase {
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("target", OpenErpType.Selection)]
		public string Target { get; set; }
		[OpenErpMap("type", OpenErpType.Char)]
		public string Type { get; set; }
		[OpenErpMap("url", OpenErpType.Char)]
		public string Url { get; set; }
	}

	[OpenErpMap("ir.actions.wizard")]
	public class IrActionsWizard : OpenErpEntityBase {
		[OpenErpMap("model", OpenErpType.Char)]
		public string Model { get; set; }
		[OpenErpMap("multi", OpenErpType.Boolean)]
		public bool Multi { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("type", OpenErpType.Char)]
		public string Type { get; set; }
		[OpenErpMap("usage", OpenErpType.Char)]
		public string Usage { get; set; }
		[OpenErpMap("wiz_name", OpenErpType.Char)]
		public string WizName { get; set; }
	}

	[OpenErpMap("ir.attachment")]
	public class IrAttachment : OpenErpEntityBase {
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("create_date", OpenErpType.Datetime)]
		public DateTime? CreateDate { get; set; }
		[OpenErpMap("create_uid", OpenErpType.Integer)]
		public int? CreateUid { get; set; }
		[OpenErpMap("datas_fname", OpenErpType.Char)]
		public string DatasFname { get; set; }
		[OpenErpMap("description", OpenErpType.Char)]
		public string Description { get; set; }
		[OpenErpMap("file_size", OpenErpType.Integer)]
		public int? FileSize { get; set; }
		[OpenErpMap("file_type", OpenErpType.Char)]
		public string FileType { get; set; }
		[OpenErpMap("index_content", OpenErpType.Char)]
		public string IndexContent { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("parent_id", OpenErpType.Integer)]
		public int? ParentId { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("res_id", OpenErpType.Integer)]
		public int? ResId { get; set; }
		[OpenErpMap("res_model", OpenErpType.Char)]
		public string ResModel { get; set; }
		[OpenErpMap("res_name", OpenErpType.Char)]
		public string ResName { get; set; }
		[OpenErpMap("store_fname", OpenErpType.Char)]
		public string StoreFname { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
		[OpenErpMap("url", OpenErpType.Char)]
		public string Url { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
		[OpenErpMap("write_date", OpenErpType.Datetime)]
		public DateTime? WriteDate { get; set; }
		[OpenErpMap("write_uid", OpenErpType.Integer)]
		public int? WriteUid { get; set; }
	}

	[OpenErpMap("ir.config_parameter")]
	public class IrConfig_parameter : OpenErpEntityBase {
		[OpenErpMap("key", OpenErpType.Char)]
		public string Key { get; set; }
		[OpenErpMap("value", OpenErpType.Char)]
		public string Value { get; set; }
	}

	[OpenErpMap("ir.cron")]
	public class IrCron : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("args", OpenErpType.Char)]
		public string Args { get; set; }
		[OpenErpMap("doall", OpenErpType.Boolean)]
		public bool Doall { get; set; }
		[OpenErpMap("function", OpenErpType.Char)]
		public string Function { get; set; }
		[OpenErpMap("interval_number", OpenErpType.Integer)]
		public int? IntervalNumber { get; set; }
		[OpenErpMap("interval_type", OpenErpType.Selection)]
		public string IntervalType { get; set; }
		[OpenErpMap("model", OpenErpType.Char)]
		public string Model { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("nextcall", OpenErpType.Datetime)]
		public DateTime Nextcall { get; set; }
		[OpenErpMap("numbercall", OpenErpType.Integer)]
		public int? Numbercall { get; set; }
		[OpenErpMap("priority", OpenErpType.Integer)]
		public int? Priority { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int UserId { get; set; }
	}

	[OpenErpMap("ir.default")]
	public class IrDefault : OpenErpEntityBase {
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("field_name", OpenErpType.Char)]
		public string FieldName { get; set; }
		[OpenErpMap("field_tbl", OpenErpType.Char)]
		public string FieldTbl { get; set; }
		[OpenErpMap("page", OpenErpType.Char)]
		public string Page { get; set; }
		[OpenErpMap("ref_id", OpenErpType.Integer)]
		public int? RefId { get; set; }
		[OpenErpMap("ref_table", OpenErpType.Char)]
		public string RefTable { get; set; }
		[OpenErpMap("uid", OpenErpType.Integer)]
		public int? Uid { get; set; }
		[OpenErpMap("value", OpenErpType.Char)]
		public string Value { get; set; }
	}

	[OpenErpMap("ir.exports")]
	public class IrExports : OpenErpEntityBase {
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("resource", OpenErpType.Char)]
		public string Resource { get; set; }
	}

	[OpenErpMap("ir.exports.line")]
	public class IrExportsLine : OpenErpEntityBase {
		[OpenErpMap("export_id", OpenErpType.Integer)]
		public int? ExportId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
	}

	[OpenErpMap("ir.filters")]
	public class IrFilters : OpenErpEntityBase {
		[OpenErpMap("context", OpenErpType.Char)]
		public string Context { get; set; }
		[OpenErpMap("domain", OpenErpType.Char)]
		public string Domain { get; set; }
		[OpenErpMap("model_id", OpenErpType.Selection)]
		public string ModelId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("ir.model")]
	public class IrModel : OpenErpEntityBase {
		[OpenErpMap("info", OpenErpType.Char)]
		public string Info { get; set; }
		[OpenErpMap("model", OpenErpType.Char)]
		public string Model { get; set; }
		[OpenErpMap("modules", OpenErpType.Char)]
		public string Modules { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("osv_memory", OpenErpType.Boolean)]
		public bool OsvMemory { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
	}

	[OpenErpMap("ir.model.access")]
	public class IrModelAccess : OpenErpEntityBase {
		[OpenErpMap("group_id", OpenErpType.Integer)]
		public int? GroupId { get; set; }
		[OpenErpMap("model_id", OpenErpType.Integer)]
		public int? ModelId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("perm_create", OpenErpType.Boolean)]
		public bool PermCreate { get; set; }
		[OpenErpMap("perm_read", OpenErpType.Boolean)]
		public bool PermRead { get; set; }
		[OpenErpMap("perm_unlink", OpenErpType.Boolean)]
		public bool PermUnlink { get; set; }
		[OpenErpMap("perm_write", OpenErpType.Boolean)]
		public bool PermWrite { get; set; }
	}

	[OpenErpMap("ir.model.data")]
	public class IrModelData : OpenErpEntityBase {
		[OpenErpMap("date_init", OpenErpType.Datetime)]
		public DateTime? DateInit { get; set; }
		[OpenErpMap("date_update", OpenErpType.Datetime)]
		public DateTime? DateUpdate { get; set; }
		[OpenErpMap("model", OpenErpType.Char)]
		public string Model { get; set; }
		[OpenErpMap("module", OpenErpType.Char)]
		public string Module { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("noupdate", OpenErpType.Boolean)]
		public bool Noupdate { get; set; }
		[OpenErpMap("res_id", OpenErpType.Integer)]
		public int? ResId { get; set; }
	}

	[OpenErpMap("ir.model.fields")]
	public class IrModelFields : OpenErpEntityBase {
		[OpenErpMap("complete_name", OpenErpType.Char)]
		public string CompleteName { get; set; }
		[OpenErpMap("domain", OpenErpType.Char)]
		public string Domain { get; set; }
		[OpenErpMap("field_description", OpenErpType.Char)]
		public string FieldDescription { get; set; }
		[OpenErpMap("model", OpenErpType.Char)]
		public string Model { get; set; }
		[OpenErpMap("model_id", OpenErpType.Integer)]
		public int ModelId { get; set; }
		[OpenErpMap("modules", OpenErpType.Char)]
		public string Modules { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("on_delete", OpenErpType.Selection)]
		public string OnDelete { get; set; }
		[OpenErpMap("readonly", OpenErpType.Boolean)]
		public bool Readonly { get; set; }
		[OpenErpMap("relation", OpenErpType.Char)]
		public string Relation { get; set; }
		[OpenErpMap("relation_field", OpenErpType.Char)]
		public string RelationField { get; set; }
		[OpenErpMap("required", OpenErpType.Boolean)]
		public bool Required { get; set; }
		[OpenErpMap("selectable", OpenErpType.Boolean)]
		public bool Selectable { get; set; }
		[OpenErpMap("selection", OpenErpType.Char)]
		public string Selection { get; set; }
		[OpenErpMap("select_level", OpenErpType.Selection)]
		public string SelectLevel { get; set; }
		[OpenErpMap("size", OpenErpType.Integer)]
		public int? Size { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("translate", OpenErpType.Boolean)]
		public bool Translate { get; set; }
		[OpenErpMap("ttype", OpenErpType.Selection)]
		public string Ttype { get; set; }
		[OpenErpMap("view_load", OpenErpType.Boolean)]
		public bool ViewLoad { get; set; }
	}

	[OpenErpMap("ir.module.category")]
	public class IrModuleCategory : OpenErpEntityBase {
		[OpenErpMap("module_nr", OpenErpType.Integer)]
		public int? ModuleNr { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("parent_id", OpenErpType.Integer)]
		public int? ParentId { get; set; }
	}

	[OpenErpMap("ir.module.module")]
	public class IrModuleModule : OpenErpEntityBase {
		[OpenErpMap("author", OpenErpType.Char)]
		public string Author { get; set; }
		[OpenErpMap("category_id", OpenErpType.Integer)]
		public int? CategoryId { get; set; }
		[OpenErpMap("certificate", OpenErpType.Char)]
		public string Certificate { get; set; }
		[OpenErpMap("contributors", OpenErpType.Char)]
		public string Contributors { get; set; }
		[OpenErpMap("demo", OpenErpType.Boolean)]
		public bool Demo { get; set; }
		[OpenErpMap("description", OpenErpType.Char)]
		public string Description { get; set; }
		[OpenErpMap("installed_version", OpenErpType.Char)]
		public string InstalledVersion { get; set; }
		[OpenErpMap("latest_version", OpenErpType.Char)]
		public string LatestVersion { get; set; }
		[OpenErpMap("license", OpenErpType.Selection)]
		public string License { get; set; }
		[OpenErpMap("maintainer", OpenErpType.Char)]
		public string Maintainer { get; set; }
		[OpenErpMap("menus_by_module", OpenErpType.Char)]
		public string MenusByModule { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("published_version", OpenErpType.Char)]
		public string PublishedVersion { get; set; }
		[OpenErpMap("reports_by_module", OpenErpType.Char)]
		public string ReportsByModule { get; set; }
		[OpenErpMap("shortdesc", OpenErpType.Char)]
		public string Shortdesc { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("url", OpenErpType.Char)]
		public string Url { get; set; }
		[OpenErpMap("web", OpenErpType.Boolean)]
		public bool Web { get; set; }
		[OpenErpMap("website", OpenErpType.Char)]
		public string Website { get; set; }
		[OpenErpMap("views_by_module", OpenErpType.Char)]
		public string ViewsByModule { get; set; }
	}

	[OpenErpMap("ir.module.module.dependency")]
	public class IrModuleModuleDependency : OpenErpEntityBase {
		[OpenErpMap("module_id", OpenErpType.Integer)]
		public int? ModuleId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
	}

	[OpenErpMap("ir.property")]
	public class IrProperty : OpenErpEntityBase {
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("fields_id", OpenErpType.Integer)]
		public int? FieldsId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
		[OpenErpMap("value_datetime", OpenErpType.Datetime)]
		public DateTime? ValueDatetime { get; set; }
		[OpenErpMap("value_float", OpenErpType.Float)]
		public double? ValueFloat { get; set; }
		[OpenErpMap("value_text", OpenErpType.Char)]
		public string ValueText { get; set; }
	}

	[OpenErpMap("ir.rule")]
	public class IrRule : OpenErpEntityBase {
		[OpenErpMap("domain", OpenErpType.Char)]
		public string Domain { get; set; }
		[OpenErpMap("domain_force", OpenErpType.Char)]
		public string DomainForce { get; set; }
		[OpenErpMap("global", OpenErpType.Boolean)]
		public bool Global { get; set; }
		[OpenErpMap("model_id", OpenErpType.Integer)]
		public int? ModelId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("perm_create", OpenErpType.Boolean)]
		public bool PermCreate { get; set; }
		[OpenErpMap("perm_read", OpenErpType.Boolean)]
		public bool PermRead { get; set; }
		[OpenErpMap("perm_unlink", OpenErpType.Boolean)]
		public bool PermUnlink { get; set; }
		[OpenErpMap("perm_write", OpenErpType.Boolean)]
		public bool PermWrite { get; set; }
	}

	[OpenErpMap("ir.sequence")]
	public class IrSequence : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("code", OpenErpType.Selection)]
		public string Code { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("number_increment", OpenErpType.Integer)]
		public int NumberIncrement { get; set; }
		[OpenErpMap("number_next", OpenErpType.Integer)]
		public int NumberNext { get; set; }
		[OpenErpMap("padding", OpenErpType.Integer)]
		public int Padding { get; set; }
		[OpenErpMap("prefix", OpenErpType.Char)]
		public string Prefix { get; set; }
		[OpenErpMap("suffix", OpenErpType.Char)]
		public string Suffix { get; set; }
	}

	[OpenErpMap("ir.sequence.type")]
	public class IrSequenceType : OpenErpEntityBase {
		[OpenErpMap("code", OpenErpType.Char)]
		public string Code { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
	}

	[OpenErpMap("ir.server.object.lines")]
	public class IrServerObjectLines : OpenErpEntityBase {
		[OpenErpMap("col1", OpenErpType.Integer)]
		public int? Col1 { get; set; }
		[OpenErpMap("server_id", OpenErpType.Integer)]
		public int? ServerId { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
		[OpenErpMap("value", OpenErpType.Char)]
		public string Value { get; set; }
	}

	[OpenErpMap("ir.translation")]
	public class IrTranslation : OpenErpEntityBase {
		[OpenErpMap("lang", OpenErpType.Selection)]
		public string Lang { get; set; }
		[OpenErpMap("module", OpenErpType.Char)]
		public string Module { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("res_id", OpenErpType.Integer)]
		public int? ResId { get; set; }
		[OpenErpMap("src", OpenErpType.Char)]
		public string Src { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
		[OpenErpMap("value", OpenErpType.Char)]
		public string Value { get; set; }
		[OpenErpMap("xml_id", OpenErpType.Char)]
		public string XmlId { get; set; }
	}

	[OpenErpMap("ir.ui.menu")]
	public class IrUiMenu : OpenErpEntityBase {
		[OpenErpMap("complete_name", OpenErpType.Char)]
		public string CompleteName { get; set; }
		[OpenErpMap("icon", OpenErpType.Selection)]
		public string Icon { get; set; }
		[OpenErpMap("icon_pict", OpenErpType.Char)]
		public string IconPict { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("parent_id", OpenErpType.Integer)]
		public int? ParentId { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
		[OpenErpMap("web_icon", OpenErpType.Char)]
		public string WebIcon { get; set; }
		[OpenErpMap("web_icon_hover", OpenErpType.Char)]
		public string WebIconHover { get; set; }
	}

	[OpenErpMap("ir.ui.view")]
	public class IrUiView : OpenErpEntityBase {
		[OpenErpMap("arch", OpenErpType.Char)]
		public string Arch { get; set; }
		[OpenErpMap("field_parent", OpenErpType.Char)]
		public string FieldParent { get; set; }
		[OpenErpMap("inherit_id", OpenErpType.Integer)]
		public int? InheritId { get; set; }
		[OpenErpMap("model", OpenErpType.Char)]
		public string Model { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("priority", OpenErpType.Integer)]
		public int? Priority { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
		[OpenErpMap("xml_id", OpenErpType.Char)]
		public string XmlId { get; set; }
	}

	[OpenErpMap("ir.ui.view.custom")]
	public class IrUiViewCustom : OpenErpEntityBase {
		[OpenErpMap("arch", OpenErpType.Char)]
		public string Arch { get; set; }
		[OpenErpMap("ref_id", OpenErpType.Integer)]
		public int? RefId { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("ir.ui.view_sc")]
	public class IrUiView_sc : OpenErpEntityBase {
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("res_id", OpenErpType.Integer)]
		public int? ResId { get; set; }
		[OpenErpMap("resource", OpenErpType.Char)]
		public string Resource { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("ir.values")]
	public class IrValues : OpenErpEntityBase {
		[OpenErpMap("action_id", OpenErpType.Integer)]
		public int? ActionId { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("key", OpenErpType.Selection)]
		public string Key { get; set; }
		[OpenErpMap("key2", OpenErpType.Char)]
		public string Key2 { get; set; }
		[OpenErpMap("meta", OpenErpType.Char)]
		public string Meta { get; set; }
		[OpenErpMap("meta_unpickle", OpenErpType.Char)]
		public string MetaUnpickle { get; set; }
		[OpenErpMap("model", OpenErpType.Char)]
		public string Model { get; set; }
		[OpenErpMap("model_id", OpenErpType.Integer)]
		public int? ModelId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("object", OpenErpType.Boolean)]
		public bool Object { get; set; }
		[OpenErpMap("res_id", OpenErpType.Integer)]
		public int? ResId { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
		[OpenErpMap("value", OpenErpType.Char)]
		public string Value { get; set; }
		[OpenErpMap("value_unpickle", OpenErpType.Char)]
		public string ValueUnpickle { get; set; }
	}

	[OpenErpMap("lunch.cashbox")]
	public class LunchCashbox : OpenErpEntityBase {
		[OpenErpMap("manager", OpenErpType.Integer)]
		public int? Manager { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("sum_remain", OpenErpType.Float)]
		public double? SumRemain { get; set; }
	}

	[OpenErpMap("lunch.cashmove")]
	public class LunchCashmove : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("amount", OpenErpType.Float)]
		public double? Amount { get; set; }
		[OpenErpMap("box", OpenErpType.Integer)]
		public int? Box { get; set; }
		[OpenErpMap("create_date", OpenErpType.Datetime)]
		public DateTime? CreateDate { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("user_cashmove", OpenErpType.Integer)]
		public int? UserCashmove { get; set; }
	}

	[OpenErpMap("lunch.category")]
	public class LunchCategory : OpenErpEntityBase {
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
	}

	[OpenErpMap("lunch.order")]
	public class LunchOrder : OpenErpEntityBase {
		[OpenErpMap("cashmove", OpenErpType.Integer)]
		public int? Cashmove { get; set; }
		[OpenErpMap("category", OpenErpType.Integer)]
		public int? Category { get; set; }
		[OpenErpMap("date", OpenErpType.Date)]
		public DateTime? Date { get; set; }
		[OpenErpMap("descript", OpenErpType.Char)]
		public string Descript { get; set; }
		[OpenErpMap("price", OpenErpType.Float)]
		public double? Price { get; set; }
		[OpenErpMap("product", OpenErpType.Integer)]
		public int? Product { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("lunch.product")]
	public class LunchProduct : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("category_id", OpenErpType.Integer)]
		public int? CategoryId { get; set; }
		[OpenErpMap("description", OpenErpType.Char)]
		public string Description { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("price", OpenErpType.Float)]
		public double? Price { get; set; }
	}

	[OpenErpMap("mailgate.message")]
	public class MailgateMessage : OpenErpEntityBase {
		[OpenErpMap("date", OpenErpType.Datetime)]
		public DateTime? Date { get; set; }
		[OpenErpMap("description", OpenErpType.Char)]
		public string Description { get; set; }
		[OpenErpMap("display_text", OpenErpType.Char)]
		public string DisplayText { get; set; }
		[OpenErpMap("email_bcc", OpenErpType.Char)]
		public string EmailBcc { get; set; }
		[OpenErpMap("email_cc", OpenErpType.Char)]
		public string EmailCc { get; set; }
		[OpenErpMap("email_from", OpenErpType.Char)]
		public string EmailFrom { get; set; }
		[OpenErpMap("email_to", OpenErpType.Char)]
		public string EmailTo { get; set; }
		[OpenErpMap("history", OpenErpType.Boolean)]
		public bool History { get; set; }
		[OpenErpMap("message", OpenErpType.Char)]
		public string Message { get; set; }
		[OpenErpMap("message_id", OpenErpType.Char)]
		public string MessageId { get; set; }
		[OpenErpMap("model", OpenErpType.Char)]
		public string Model { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("references", OpenErpType.Char)]
		public string References { get; set; }
		[OpenErpMap("ref_id", OpenErpType.Char)]
		public string RefId { get; set; }
		[OpenErpMap("res_id", OpenErpType.Integer)]
		public int? ResId { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("mailgate.thread")]
	public class MailgateThread : OpenErpEntityBase {
	}

	[OpenErpMap("mrp.bom")]
	public class MrpBom : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("bom_id", OpenErpType.Integer)]
		public int? BomId { get; set; }
		[OpenErpMap("code", OpenErpType.Char)]
		public string Code { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("date_start", OpenErpType.Date)]
		public DateTime? DateStart { get; set; }
		[OpenErpMap("date_stop", OpenErpType.Date)]
		public DateTime? DateStop { get; set; }
		[OpenErpMap("method", OpenErpType.Selection)]
		public string Method { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("position", OpenErpType.Char)]
		public string Position { get; set; }
		[OpenErpMap("product_efficiency", OpenErpType.Float)]
		public double? ProductEfficiency { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("product_qty", OpenErpType.Float)]
		public double? ProductQty { get; set; }
		[OpenErpMap("product_rounding", OpenErpType.Float)]
		public double? ProductRounding { get; set; }
		[OpenErpMap("product_uom", OpenErpType.Integer)]
		public int? ProductUom { get; set; }
		[OpenErpMap("product_uos", OpenErpType.Integer)]
		public int? ProductUos { get; set; }
		[OpenErpMap("product_uos_qty", OpenErpType.Float)]
		public double? ProductUosQty { get; set; }
		[OpenErpMap("routing_id", OpenErpType.Integer)]
		public int? RoutingId { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
	}

	[OpenErpMap("mrp.bom.revision")]
	public class MrpBomRevision : OpenErpEntityBase {
		[OpenErpMap("author_id", OpenErpType.Integer)]
		public int? AuthorId { get; set; }
		[OpenErpMap("bom_id", OpenErpType.Integer)]
		public int? BomId { get; set; }
		[OpenErpMap("date", OpenErpType.Date)]
		public DateTime? Date { get; set; }
		[OpenErpMap("description", OpenErpType.Char)]
		public string Description { get; set; }
		[OpenErpMap("indice", OpenErpType.Char)]
		public string Indice { get; set; }
		[OpenErpMap("last_indice", OpenErpType.Char)]
		public string LastIndice { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
	}

	[OpenErpMap("mrp.production")]
	public class MrpProduction : OpenErpEntityBase {
		[OpenErpMap("bom_id", OpenErpType.Integer)]
		public int? BomId { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("cycle_total", OpenErpType.Float)]
		public double? CycleTotal { get; set; }
		[OpenErpMap("date_finished", OpenErpType.Datetime)]
		public DateTime? DateFinished { get; set; }
		[OpenErpMap("date_planned", OpenErpType.Datetime)]
		public DateTime? DatePlanned { get; set; }
		[OpenErpMap("date_planned_date", OpenErpType.Date)]
		public DateTime? DatePlannedDate { get; set; }
		[OpenErpMap("date_planned_end", OpenErpType.Date)]
		public DateTime? DatePlannedEnd { get; set; }
		[OpenErpMap("date_start", OpenErpType.Datetime)]
		public DateTime? DateStart { get; set; }
		[OpenErpMap("hour_total", OpenErpType.Float)]
		public double? HourTotal { get; set; }
		[OpenErpMap("location_dest_id", OpenErpType.Integer)]
		public int? LocationDestId { get; set; }
		[OpenErpMap("location_src_id", OpenErpType.Integer)]
		public int? LocationSrcId { get; set; }
		[OpenErpMap("move_prod_id", OpenErpType.Integer)]
		public int? MoveProdId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("origin", OpenErpType.Char)]
		public string Origin { get; set; }
		[OpenErpMap("picking_id", OpenErpType.Integer)]
		public int? PickingId { get; set; }
		[OpenErpMap("priority", OpenErpType.Selection)]
		public string Priority { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("product_qty", OpenErpType.Float)]
		public double? ProductQty { get; set; }
		[OpenErpMap("product_uom", OpenErpType.Integer)]
		public int? ProductUom { get; set; }
		[OpenErpMap("product_uos", OpenErpType.Integer)]
		public int? ProductUos { get; set; }
		[OpenErpMap("product_uos_qty", OpenErpType.Float)]
		public double? ProductUosQty { get; set; }
		[OpenErpMap("routing_id", OpenErpType.Integer)]
		public int? RoutingId { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
	}

	[OpenErpMap("mrp.production.order")]
	public class MrpProductionOrder : OpenErpEntityBase {
		[OpenErpMap("bom_id", OpenErpType.Integer)]
		public int? BomId { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("consumed_products", OpenErpType.Integer)]
		public int? ConsumedProducts { get; set; }
		[OpenErpMap("date", OpenErpType.Date)]
		public DateTime? Date { get; set; }
		[OpenErpMap("date_finished", OpenErpType.Datetime)]
		public DateTime? DateFinished { get; set; }
		[OpenErpMap("date_planned", OpenErpType.Date)]
		public DateTime? DatePlanned { get; set; }
		[OpenErpMap("date_start", OpenErpType.Datetime)]
		public DateTime? DateStart { get; set; }
		[OpenErpMap("day", OpenErpType.Char)]
		public string Day { get; set; }
		[OpenErpMap("location_dest_id", OpenErpType.Integer)]
		public int? LocationDestId { get; set; }
		[OpenErpMap("location_src_id", OpenErpType.Integer)]
		public int? LocationSrcId { get; set; }
		[OpenErpMap("month", OpenErpType.Selection)]
		public string Month { get; set; }
		[OpenErpMap("nbr", OpenErpType.Integer)]
		public int? Nbr { get; set; }
		[OpenErpMap("origin", OpenErpType.Char)]
		public string Origin { get; set; }
		[OpenErpMap("picking_id", OpenErpType.Integer)]
		public int? PickingId { get; set; }
		[OpenErpMap("priority", OpenErpType.Selection)]
		public string Priority { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("product_id2", OpenErpType.Integer)]
		public int? ProductId2 { get; set; }
		[OpenErpMap("product_qty", OpenErpType.Float)]
		public double? ProductQty { get; set; }
		[OpenErpMap("products_to_consume", OpenErpType.Integer)]
		public int? ProductsToConsume { get; set; }
		[OpenErpMap("product_uom", OpenErpType.Integer)]
		public int? ProductUom { get; set; }
		[OpenErpMap("routing_id", OpenErpType.Integer)]
		public int? RoutingId { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("year", OpenErpType.Char)]
		public string Year { get; set; }
	}

	[OpenErpMap("mrp.production.product.line")]
	public class MrpProductionProductLine : OpenErpEntityBase {
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("production_id", OpenErpType.Integer)]
		public int? ProductionId { get; set; }
		[OpenErpMap("product_qty", OpenErpType.Float)]
		public double? ProductQty { get; set; }
		[OpenErpMap("product_uom", OpenErpType.Integer)]
		public int? ProductUom { get; set; }
		[OpenErpMap("product_uos", OpenErpType.Integer)]
		public int? ProductUos { get; set; }
		[OpenErpMap("product_uos_qty", OpenErpType.Float)]
		public double? ProductUosQty { get; set; }
	}

	[OpenErpMap("mrp.production.workcenter.line")]
	public class MrpProductionWorkcenterLine : OpenErpEntityBase {
		[OpenErpMap("cycle", OpenErpType.Float)]
		public double? Cycle { get; set; }
		[OpenErpMap("hour", OpenErpType.Float)]
		public double? Hour { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("production_id", OpenErpType.Integer)]
		public int? ProductionId { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
		[OpenErpMap("workcenter_id", OpenErpType.Integer)]
		public int? WorkcenterId { get; set; }
	}

	[OpenErpMap("mrp.property")]
	public class MrpProperty : OpenErpEntityBase {
		[OpenErpMap("composition", OpenErpType.Selection)]
		public string Composition { get; set; }
		[OpenErpMap("description", OpenErpType.Char)]
		public string Description { get; set; }
		[OpenErpMap("group_id", OpenErpType.Integer)]
		public int? GroupId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
	}

	[OpenErpMap("mrp.property.group")]
	public class MrpPropertyGroup : OpenErpEntityBase {
		[OpenErpMap("description", OpenErpType.Char)]
		public string Description { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
	}

	[OpenErpMap("mrp.routing")]
	public class MrpRouting : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("code", OpenErpType.Char)]
		public string Code { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("location_id", OpenErpType.Integer)]
		public int? LocationId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("note", OpenErpType.Char)]
		public string Note { get; set; }
	}

	[OpenErpMap("mrp.routing.workcenter")]
	public class MrpRoutingWorkcenter : OpenErpEntityBase {
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("cycle_nbr", OpenErpType.Float)]
		public double? CycleNbr { get; set; }
		[OpenErpMap("hour_nbr", OpenErpType.Float)]
		public double? HourNbr { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("note", OpenErpType.Char)]
		public string Note { get; set; }
		[OpenErpMap("routing_id", OpenErpType.Integer)]
		public int? RoutingId { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
		[OpenErpMap("workcenter_id", OpenErpType.Integer)]
		public int? WorkcenterId { get; set; }
	}

	[OpenErpMap("mrp.workcenter")]
	public class MrpWorkcenter : OpenErpEntityBase {
		[OpenErpMap("capacity_per_cycle", OpenErpType.Float)]
		public double? CapacityPerCycle { get; set; }
		[OpenErpMap("costs_cycle", OpenErpType.Float)]
		public double? CostsCycle { get; set; }
		[OpenErpMap("costs_cycle_account_id", OpenErpType.Integer)]
		public int? CostsCycleAccountId { get; set; }
		[OpenErpMap("costs_general_account_id", OpenErpType.Integer)]
		public int? CostsGeneralAccountId { get; set; }
		[OpenErpMap("costs_hour", OpenErpType.Float)]
		public double? CostsHour { get; set; }
		[OpenErpMap("costs_hour_account_id", OpenErpType.Integer)]
		public int? CostsHourAccountId { get; set; }
		[OpenErpMap("costs_journal_id", OpenErpType.Integer)]
		public int? CostsJournalId { get; set; }
		[OpenErpMap("note", OpenErpType.Char)]
		public string Note { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("resource_id", OpenErpType.Integer)]
		public int? ResourceId { get; set; }
		[OpenErpMap("time_cycle", OpenErpType.Float)]
		public double? TimeCycle { get; set; }
		[OpenErpMap("time_start", OpenErpType.Float)]
		public double? TimeStart { get; set; }
		[OpenErpMap("time_stop", OpenErpType.Float)]
		public double? TimeStop { get; set; }
	}

	[OpenErpMap("multi_company.default")]
	public class Multi_companyDefault : OpenErpEntityBase {
		[OpenErpMap("company_dest_id", OpenErpType.Integer)]
		public int? CompanyDestId { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("expression", OpenErpType.Char)]
		public string Expression { get; set; }
		[OpenErpMap("field_id", OpenErpType.Integer)]
		public int? FieldId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("object_id", OpenErpType.Integer)]
		public int? ObjectId { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
	}

	[OpenErpMap("pricelist.partnerinfo")]
	public class PricelistPartnerinfo : OpenErpEntityBase {
		[OpenErpMap("min_quantity", OpenErpType.Float)]
		public double? MinQuantity { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("price", OpenErpType.Float)]
		public double? Price { get; set; }
		[OpenErpMap("suppinfo_id", OpenErpType.Integer)]
		public int? SuppinfoId { get; set; }
	}

	[OpenErpMap("process.condition")]
	public class ProcessCondition : OpenErpEntityBase {
		[OpenErpMap("model_id", OpenErpType.Integer)]
		public int? ModelId { get; set; }
		[OpenErpMap("model_states", OpenErpType.Char)]
		public string ModelStates { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("node_id", OpenErpType.Integer)]
		public int? NodeId { get; set; }
	}

	[OpenErpMap("process.node")]
	public class ProcessNode : OpenErpEntityBase {
		[OpenErpMap("directory_id", OpenErpType.Integer)]
		public int? DirectoryId { get; set; }
		[OpenErpMap("flow_start", OpenErpType.Boolean)]
		public bool FlowStart { get; set; }
		[OpenErpMap("help_url", OpenErpType.Char)]
		public string HelpUrl { get; set; }
		[OpenErpMap("kind", OpenErpType.Selection)]
		public string Kind { get; set; }
		[OpenErpMap("menu_id", OpenErpType.Integer)]
		public int? MenuId { get; set; }
		[OpenErpMap("model_id", OpenErpType.Integer)]
		public int? ModelId { get; set; }
		[OpenErpMap("model_states", OpenErpType.Char)]
		public string ModelStates { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("note", OpenErpType.Char)]
		public string Note { get; set; }
		[OpenErpMap("process_id", OpenErpType.Integer)]
		public int ProcessId { get; set; }
		[OpenErpMap("subflow_id", OpenErpType.Integer)]
		public int? SubflowId { get; set; }
	}

	[OpenErpMap("process.process")]
	public class ProcessProcess : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("model_id", OpenErpType.Integer)]
		public int? ModelId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("note", OpenErpType.Char)]
		public string Note { get; set; }
	}

	[OpenErpMap("process.transition")]
	public class ProcessTransition : OpenErpEntityBase {
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("note", OpenErpType.Char)]
		public string Note { get; set; }
		[OpenErpMap("source_node_id", OpenErpType.Integer)]
		public int? SourceNodeId { get; set; }
		[OpenErpMap("target_node_id", OpenErpType.Integer)]
		public int? TargetNodeId { get; set; }
	}

	[OpenErpMap("process.transition.action")]
	public class ProcessTransitionAction : OpenErpEntityBase {
		[OpenErpMap("action", OpenErpType.Char)]
		public string Action { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("transition_id", OpenErpType.Integer)]
		public int? TransitionId { get; set; }
	}

	[OpenErpMap("procurement.order")]
	public class ProcurementOrder : OpenErpEntityBase {
		[OpenErpMap("bom_id", OpenErpType.Integer)]
		public int? BomId { get; set; }
		[OpenErpMap("close_move", OpenErpType.Boolean)]
		public bool CloseMove { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int CompanyId { get; set; }
		[OpenErpMap("date_close", OpenErpType.Datetime)]
		public DateTime? DateClose { get; set; }
		[OpenErpMap("date_planned", OpenErpType.Datetime)]
		public DateTime DatePlanned { get; set; }
		[OpenErpMap("location_id", OpenErpType.Integer)]
		public int LocationId { get; set; }
		[OpenErpMap("message", OpenErpType.Char)]
		public string Message { get; set; }
		[OpenErpMap("move_id", OpenErpType.Integer)]
		public int? MoveId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("note", OpenErpType.Char)]
		public string Note { get; set; }
		[OpenErpMap("origin", OpenErpType.Char)]
		public string Origin { get; set; }
		[OpenErpMap("priority", OpenErpType.Selection)]
		public string Priority { get; set; }
		[OpenErpMap("procure_method", OpenErpType.Selection)]
		public string ProcureMethod { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int ProductId { get; set; }
		[OpenErpMap("product_qty", OpenErpType.Float)]
		public double ProductQty { get; set; }
		[OpenErpMap("product_uom", OpenErpType.Integer)]
		public int ProductUom { get; set; }
		[OpenErpMap("product_uos", OpenErpType.Integer)]
		public int? ProductUos { get; set; }
		[OpenErpMap("product_uos_qty", OpenErpType.Float)]
		public double? ProductUosQty { get; set; }
		[OpenErpMap("purchase_id", OpenErpType.Integer)]
		public int? PurchaseId { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("task_id", OpenErpType.Integer)]
		public int? TaskId { get; set; }
	}

	[OpenErpMap("product.category")]
	public class ProductCategory : OpenErpEntityBase {
		[OpenErpMap("complete_name", OpenErpType.Char)]
		public string CompleteName { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("parent_id", OpenErpType.Integer)]
		public int? ParentId { get; set; }
		[OpenErpMap("property_account_expense_categ", OpenErpType.Integer)]
		public int? PropertyAccountExpenseCateg { get; set; }
		[OpenErpMap("property_account_income_categ", OpenErpType.Integer)]
		public int? PropertyAccountIncomeCateg { get; set; }
		[OpenErpMap("property_stock_account_input_categ", OpenErpType.Integer)]
		public int? PropertyStockAccountInputCateg { get; set; }
		[OpenErpMap("property_stock_account_output_categ", OpenErpType.Integer)]
		public int? PropertyStockAccountOutputCateg { get; set; }
		[OpenErpMap("property_stock_journal", OpenErpType.Integer)]
		public int? PropertyStockJournal { get; set; }
		[OpenErpMap("property_stock_variation", OpenErpType.Integer)]
		public int? PropertyStockVariation { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
	}

	[OpenErpMap("product.packaging")]
	public class ProductPackaging : OpenErpEntityBase {
		[OpenErpMap("code", OpenErpType.Char)]
		public string Code { get; set; }
		[OpenErpMap("ean", OpenErpType.Char)]
		public string Ean { get; set; }
		[OpenErpMap("height", OpenErpType.Float)]
		public double? Height { get; set; }
		[OpenErpMap("length", OpenErpType.Float)]
		public double? Length { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("qty", OpenErpType.Float)]
		public double? Qty { get; set; }
		[OpenErpMap("rows", OpenErpType.Integer)]
		public int? Rows { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
		[OpenErpMap("ul", OpenErpType.Integer)]
		public int? Ul { get; set; }
		[OpenErpMap("ul_qty", OpenErpType.Integer)]
		public int? UlQty { get; set; }
		[OpenErpMap("weight", OpenErpType.Float)]
		public double? Weight { get; set; }
		[OpenErpMap("weight_ul", OpenErpType.Float)]
		public double? WeightUl { get; set; }
		[OpenErpMap("width", OpenErpType.Float)]
		public double? Width { get; set; }
	}

	[OpenErpMap("product.pricelist")]
	public class ProductPricelist : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("currency_id", OpenErpType.Integer)]
		public int? CurrencyId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
	}

	[OpenErpMap("product.pricelist.item")]
	public class ProductPricelistItem : OpenErpEntityBase {
		[OpenErpMap("base", OpenErpType.Selection)]
		public string Base { get; set; }
		[OpenErpMap("base_pricelist_id", OpenErpType.Integer)]
		public int? BasePricelistId { get; set; }
		[OpenErpMap("categ_id", OpenErpType.Integer)]
		public int? CategId { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("min_quantity", OpenErpType.Integer)]
		public int? MinQuantity { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("price_discount", OpenErpType.Float)]
		public double? PriceDiscount { get; set; }
		[OpenErpMap("price_max_margin", OpenErpType.Float)]
		public double? PriceMaxMargin { get; set; }
		[OpenErpMap("price_min_margin", OpenErpType.Float)]
		public double? PriceMinMargin { get; set; }
		[OpenErpMap("price_round", OpenErpType.Float)]
		public double? PriceRound { get; set; }
		[OpenErpMap("price_surcharge", OpenErpType.Float)]
		public double? PriceSurcharge { get; set; }
		[OpenErpMap("price_version_id", OpenErpType.Integer)]
		public int? PriceVersionId { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("product_tmpl_id", OpenErpType.Integer)]
		public int? ProductTmplId { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
	}

	[OpenErpMap("product.pricelist.type")]
	public class ProductPricelistType : OpenErpEntityBase {
		[OpenErpMap("key", OpenErpType.Char)]
		public string Key { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
	}

	[OpenErpMap("product.pricelist.version")]
	public class ProductPricelistVersion : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("date_end", OpenErpType.Date)]
		public DateTime? DateEnd { get; set; }
		[OpenErpMap("date_start", OpenErpType.Date)]
		public DateTime? DateStart { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("pricelist_id", OpenErpType.Integer)]
		public int? PricelistId { get; set; }
	}

	[OpenErpMap("product.price.type")]
	public class ProductPriceType : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("currency_id", OpenErpType.Integer)]
		public int? CurrencyId { get; set; }
		[OpenErpMap("field", OpenErpType.Selection)]
		public string Field { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
	}

	[OpenErpMap("product.product")]
	public class ProductProduct : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("code", OpenErpType.Char)]
		public string Code { get; set; }
		[OpenErpMap("default_code", OpenErpType.Char)]
		public string DefaultCode { get; set; }
		[OpenErpMap("ean13", OpenErpType.Char)]
		public string Ean13 { get; set; }
		[OpenErpMap("hr_expense_ok", OpenErpType.Boolean)]
		public bool HrExpenseOk { get; set; }
		[OpenErpMap("incoming_qty", OpenErpType.Float)]
		public double? IncomingQty { get; set; }
		[OpenErpMap("location_id", OpenErpType.Integer)]
		public int? LocationId { get; set; }
		[OpenErpMap("lst_price", OpenErpType.Float)]
		public double? LstPrice { get; set; }
		[OpenErpMap("name_template", OpenErpType.Char)]
		public string NameTemplate { get; set; }
		[OpenErpMap("outgoing_qty", OpenErpType.Float)]
		public double? OutgoingQty { get; set; }
		[OpenErpMap("partner_ref", OpenErpType.Char)]
		public string PartnerRef { get; set; }
        [OpenErpMap("price", OpenErpType.Float)]
        public double? Price { get; set; }
		[OpenErpMap("price_extra", OpenErpType.Float)]
		public double? PriceExtra { get; set; }
		[OpenErpMap("pricelist_id", OpenErpType.Integer)]
		public int? PricelistId { get; set; }
		[OpenErpMap("price_margin", OpenErpType.Float)]
		public double? PriceMargin { get; set; }
		[OpenErpMap("product_tmpl_id", OpenErpType.Integer)]
		public int ProductTmplId { get; set; }
		[OpenErpMap("project_id", OpenErpType.Integer)]
		public int? ProjectId { get; set; }
		[OpenErpMap("qty_available", OpenErpType.Float)]
		public double? QtyAvailable { get; set; }
		[OpenErpMap("track_incoming", OpenErpType.Boolean)]
		public bool TrackIncoming { get; set; }
		[OpenErpMap("track_outgoing", OpenErpType.Boolean)]
		public bool TrackOutgoing { get; set; }
		[OpenErpMap("track_production", OpenErpType.Boolean)]
		public bool TrackProduction { get; set; }
		[OpenErpMap("valuation", OpenErpType.Selection)]
		public string Valuation { get; set; }
		[OpenErpMap("variants", OpenErpType.Char)]
		public string Variants { get; set; }
		[OpenErpMap("virtual_available", OpenErpType.Float)]
		public double? VirtualAvailable { get; set; }
	}

	[OpenErpMap("product.supplierinfo")]
	public class ProductSupplierinfo : OpenErpEntityBase {
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("delay", OpenErpType.Integer)]
		public int? Delay { get; set; }
		[OpenErpMap("min_qty", OpenErpType.Float)]
		public double? MinQty { get; set; }
		[OpenErpMap("name", OpenErpType.Integer)]
		public int? Name { get; set; }
		[OpenErpMap("product_code", OpenErpType.Char)]
		public string ProductCode { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("product_name", OpenErpType.Char)]
		public string ProductName { get; set; }
		[OpenErpMap("product_uom", OpenErpType.Integer)]
		public int? ProductUom { get; set; }
		[OpenErpMap("qty", OpenErpType.Float)]
		public double? Qty { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
	}

	[OpenErpMap("product.template")]
	public class ProductTemplate : OpenErpEntityBase {
		[OpenErpMap("categ_id", OpenErpType.Integer)]
		public int CategId { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("cost_method", OpenErpType.Selection)]
		public string CostMethod { get; set; }
		[OpenErpMap("description", OpenErpType.Char)]
		public string Description { get; set; }
		[OpenErpMap("description_purchase", OpenErpType.Char)]
		public string DescriptionPurchase { get; set; }
		[OpenErpMap("description_sale", OpenErpType.Char)]
		public string DescriptionSale { get; set; }
		[OpenErpMap("list_price", OpenErpType.Float)]
		public double? ListPrice { get; set; }
		[OpenErpMap("loc_case", OpenErpType.Char)]
		public string LocCase { get; set; }
		[OpenErpMap("loc_rack", OpenErpType.Char)]
		public string LocRack { get; set; }
		[OpenErpMap("loc_row", OpenErpType.Char)]
		public string LocRow { get; set; }
		[OpenErpMap("mes_type", OpenErpType.Selection)]
		public string MesType { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("procure_method", OpenErpType.Selection)]
		public string ProcureMethod { get; set; }
		[OpenErpMap("produce_delay", OpenErpType.Float)]
		public double? ProduceDelay { get; set; }
		[OpenErpMap("product_manager", OpenErpType.Integer)]
		public int? ProductManager { get; set; }
		[OpenErpMap("property_account_expense", OpenErpType.Integer)]
		public int? PropertyAccountExpense { get; set; }
		[OpenErpMap("property_account_income", OpenErpType.Integer)]
		public int? PropertyAccountIncome { get; set; }
		[OpenErpMap("property_stock_account_input", OpenErpType.Integer)]
		public int? PropertyStockAccountInput { get; set; }
		[OpenErpMap("property_stock_account_output", OpenErpType.Integer)]
		public int? PropertyStockAccountOutput { get; set; }
		[OpenErpMap("property_stock_inventory", OpenErpType.Integer)]
		public int? PropertyStockInventory { get; set; }
		[OpenErpMap("property_stock_procurement", OpenErpType.Integer)]
		public int? PropertyStockProcurement { get; set; }
		[OpenErpMap("property_stock_production", OpenErpType.Integer)]
		public int? PropertyStockProduction { get; set; }
		[OpenErpMap("purchase_ok", OpenErpType.Boolean)]
		public bool PurchaseOk { get; set; }
		[OpenErpMap("rental", OpenErpType.Boolean)]
		public bool Rental { get; set; }
		[OpenErpMap("sale_delay", OpenErpType.Float)]
		public double? SaleDelay { get; set; }
		[OpenErpMap("sale_ok", OpenErpType.Boolean)]
		public bool SaleOk { get; set; }
		[OpenErpMap("seller_delay", OpenErpType.Integer)]
		public int? SellerDelay { get; set; }
		[OpenErpMap("seller_id", OpenErpType.Integer)]
		public int? SellerId { get; set; }
		[OpenErpMap("seller_qty", OpenErpType.Float)]
		public double? SellerQty { get; set; }
		[OpenErpMap("standard_price", OpenErpType.Float)]
		public double StandardPrice { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("supply_method", OpenErpType.Selection)]
		public string SupplyMethod { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
		[OpenErpMap("uom_id", OpenErpType.Integer)]
		public int UomId { get; set; }
		[OpenErpMap("uom_po_id", OpenErpType.Integer)]
		public int UomPoId { get; set; }
		[OpenErpMap("uos_coeff", OpenErpType.Float)]
		public double? UosCoeff { get; set; }
		[OpenErpMap("uos_id", OpenErpType.Integer)]
		public int? UosId { get; set; }
		[OpenErpMap("warranty", OpenErpType.Float)]
		public double? Warranty { get; set; }
		[OpenErpMap("weight", OpenErpType.Float)]
		public double? Weight { get; set; }
		[OpenErpMap("weight_net", OpenErpType.Float)]
		public double? WeightNet { get; set; }
		[OpenErpMap("volume", OpenErpType.Float)]
		public double? Volume { get; set; }
	}

	[OpenErpMap("product.ul")]
	public class ProductUl : OpenErpEntityBase {
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
	}

	[OpenErpMap("product.uom")]
	public class ProductUom : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("category_id", OpenErpType.Integer)]
		public int? CategoryId { get; set; }
		[OpenErpMap("factor", OpenErpType.Float)]
		public double? Factor { get; set; }
		[OpenErpMap("factor_inv", OpenErpType.Float)]
		public double? FactorInv { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("rounding", OpenErpType.Float)]
		public double? Rounding { get; set; }
		[OpenErpMap("uom_type", OpenErpType.Selection)]
		public string UomType { get; set; }
	}

	[OpenErpMap("product.uom.categ")]
	public class ProductUomCateg : OpenErpEntityBase {
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
	}

	[OpenErpMap("project.gtd.context")]
	public class ProjectGtdContext : OpenErpEntityBase {
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
	}

	[OpenErpMap("project.gtd.timebox")]
	public class ProjectGtdTimebox : OpenErpEntityBase {
		[OpenErpMap("icon", OpenErpType.Selection)]
		public string Icon { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
	}

	[OpenErpMap("project.issue")]
	public class ProjectIssue : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("assigned_to", OpenErpType.Integer)]
		public int? AssignedTo { get; set; }
		[OpenErpMap("canal_id", OpenErpType.Integer)]
		public int? CanalId { get; set; }
		[OpenErpMap("categ_id", OpenErpType.Integer)]
		public int? CategId { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("create_date", OpenErpType.Datetime)]
		public DateTime? CreateDate { get; set; }
		[OpenErpMap("date", OpenErpType.Datetime)]
		public DateTime? Date { get; set; }
		[OpenErpMap("date_action_last", OpenErpType.Datetime)]
		public DateTime? DateActionLast { get; set; }
		[OpenErpMap("date_action_next", OpenErpType.Datetime)]
		public DateTime? DateActionNext { get; set; }
		[OpenErpMap("date_closed", OpenErpType.Datetime)]
		public DateTime? DateClosed { get; set; }
		[OpenErpMap("date_deadline", OpenErpType.Date)]
		public DateTime? DateDeadline { get; set; }
		[OpenErpMap("date_open", OpenErpType.Datetime)]
		public DateTime? DateOpen { get; set; }
		[OpenErpMap("day_close", OpenErpType.Float)]
		public double? DayClose { get; set; }
		[OpenErpMap("day_open", OpenErpType.Float)]
		public double? DayOpen { get; set; }
		[OpenErpMap("description", OpenErpType.Char)]
		public string Description { get; set; }
		[OpenErpMap("duration", OpenErpType.Float)]
		public double? Duration { get; set; }
		[OpenErpMap("email_cc", OpenErpType.Char)]
		public string EmailCc { get; set; }
		[OpenErpMap("email_from", OpenErpType.Char)]
		public string EmailFrom { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("partner_address_id", OpenErpType.Integer)]
		public int? PartnerAddressId { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("partner_mobile", OpenErpType.Char)]
		public string PartnerMobile { get; set; }
		[OpenErpMap("partner_name", OpenErpType.Char)]
		public string PartnerName { get; set; }
		[OpenErpMap("partner_phone", OpenErpType.Char)]
		public string PartnerPhone { get; set; }
		[OpenErpMap("priority", OpenErpType.Selection)]
		public string Priority { get; set; }
		[OpenErpMap("progress", OpenErpType.Float)]
		public double? Progress { get; set; }
		[OpenErpMap("project_id", OpenErpType.Integer)]
		public int? ProjectId { get; set; }
		[OpenErpMap("section_id", OpenErpType.Integer)]
		public int? SectionId { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("task_id", OpenErpType.Integer)]
		public int? TaskId { get; set; }
		[OpenErpMap("type_id", OpenErpType.Integer)]
		public int? TypeId { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
		[OpenErpMap("version_id", OpenErpType.Integer)]
		public int? VersionId { get; set; }
		[OpenErpMap("working_hours_close", OpenErpType.Float)]
		public double? WorkingHoursClose { get; set; }
		[OpenErpMap("working_hours_open", OpenErpType.Float)]
		public double? WorkingHoursOpen { get; set; }
		[OpenErpMap("write_date", OpenErpType.Datetime)]
		public DateTime? WriteDate { get; set; }
	}

	[OpenErpMap("project.issue.report")]
	public class ProjectIssueReport : OpenErpEntityBase {
		[OpenErpMap("assigned_to", OpenErpType.Integer)]
		public int? AssignedTo { get; set; }
		[OpenErpMap("canal_id", OpenErpType.Integer)]
		public int? CanalId { get; set; }
		[OpenErpMap("categ_id", OpenErpType.Integer)]
		public int? CategId { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("creation_date", OpenErpType.Date)]
		public DateTime? CreationDate { get; set; }
		[OpenErpMap("date_closed", OpenErpType.Date)]
		public DateTime? DateClosed { get; set; }
		[OpenErpMap("day", OpenErpType.Char)]
		public string Day { get; set; }
		[OpenErpMap("delay_close", OpenErpType.Float)]
		public double? DelayClose { get; set; }
		[OpenErpMap("delay_open", OpenErpType.Float)]
		public double? DelayOpen { get; set; }
		[OpenErpMap("email", OpenErpType.Integer)]
		public int? Email { get; set; }
		[OpenErpMap("month", OpenErpType.Selection)]
		public string Month { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("nbr", OpenErpType.Integer)]
		public int? Nbr { get; set; }
		[OpenErpMap("opening_date", OpenErpType.Date)]
		public DateTime? OpeningDate { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("priority", OpenErpType.Selection)]
		public string Priority { get; set; }
		[OpenErpMap("project_id", OpenErpType.Integer)]
		public int? ProjectId { get; set; }
		[OpenErpMap("section_id", OpenErpType.Integer)]
		public int? SectionId { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("task_id", OpenErpType.Integer)]
		public int? TaskId { get; set; }
		[OpenErpMap("type_id", OpenErpType.Integer)]
		public int? TypeId { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
		[OpenErpMap("version_id", OpenErpType.Integer)]
		public int? VersionId { get; set; }
		[OpenErpMap("working_hours_close", OpenErpType.Float)]
		public double? WorkingHoursClose { get; set; }
		[OpenErpMap("working_hours_open", OpenErpType.Float)]
		public double? WorkingHoursOpen { get; set; }
	}

	[OpenErpMap("project.issue.version")]
	public class ProjectIssueVersion : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
	}

	[OpenErpMap("project.project")]
	public class ProjectProject : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("analytic_account_id", OpenErpType.Integer)]
		public int AnalyticAccountId { get; set; }
		[OpenErpMap("complete_name", OpenErpType.Char)]
		public string CompleteName { get; set; }
		[OpenErpMap("effective_hours", OpenErpType.Float)]
		public double? EffectiveHours { get; set; }
		[OpenErpMap("planned_hours", OpenErpType.Float)]
		public double? PlannedHours { get; set; }
		[OpenErpMap("priority", OpenErpType.Integer)]
		public int? Priority { get; set; }
		[OpenErpMap("product_owner_id", OpenErpType.Integer)]
		public int? ProductOwnerId { get; set; }
		[OpenErpMap("progress_rate", OpenErpType.Float)]
		public double? ProgressRate { get; set; }
		[OpenErpMap("project_escalation_id", OpenErpType.Integer)]
		public int? ProjectEscalationId { get; set; }
		[OpenErpMap("reply_to", OpenErpType.Char)]
		public string ReplyTo { get; set; }
		[OpenErpMap("resource_calendar_id", OpenErpType.Integer)]
		public int? ResourceCalendarId { get; set; }
		[OpenErpMap("scrum", OpenErpType.Integer)]
		public int? Scrum { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
		[OpenErpMap("sprint_size", OpenErpType.Integer)]
		public int? SprintSize { get; set; }
		[OpenErpMap("total_hours", OpenErpType.Float)]
		public double? TotalHours { get; set; }
		[OpenErpMap("warn_customer", OpenErpType.Boolean)]
		public bool WarnCustomer { get; set; }
		[OpenErpMap("warn_footer", OpenErpType.Char)]
		public string WarnFooter { get; set; }
		[OpenErpMap("warn_header", OpenErpType.Char)]
		public string WarnHeader { get; set; }
		[OpenErpMap("warn_manager", OpenErpType.Boolean)]
		public bool WarnManager { get; set; }
	}

	[OpenErpMap("project.scrum.meeting")]
	public class ProjectScrumMeeting : OpenErpEntityBase {
		[OpenErpMap("date", OpenErpType.Date)]
		public DateTime? Date { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("project_id", OpenErpType.Integer)]
		public int? ProjectId { get; set; }
		[OpenErpMap("question_backlog", OpenErpType.Char)]
		public string QuestionBacklog { get; set; }
		[OpenErpMap("question_blocks", OpenErpType.Char)]
		public string QuestionBlocks { get; set; }
		[OpenErpMap("question_today", OpenErpType.Char)]
		public string QuestionToday { get; set; }
		[OpenErpMap("question_yesterday", OpenErpType.Char)]
		public string QuestionYesterday { get; set; }
		[OpenErpMap("sprint_id", OpenErpType.Integer)]
		public int? SprintId { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("project.scrum.product.backlog")]
	public class ProjectScrumProductBacklog : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("create_date", OpenErpType.Datetime)]
		public DateTime? CreateDate { get; set; }
		[OpenErpMap("effective_hours", OpenErpType.Float)]
		public double? EffectiveHours { get; set; }
		[OpenErpMap("expected_hours", OpenErpType.Float)]
		public double? ExpectedHours { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("note", OpenErpType.Char)]
		public string Note { get; set; }
		[OpenErpMap("progress", OpenErpType.Float)]
		public double? Progress { get; set; }
		[OpenErpMap("project_id", OpenErpType.Integer)]
		public int? ProjectId { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
		[OpenErpMap("sprint_id", OpenErpType.Integer)]
		public int? SprintId { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("task_hours", OpenErpType.Float)]
		public double? TaskHours { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("project.scrum.sprint")]
	public class ProjectScrumSprint : OpenErpEntityBase {
		[OpenErpMap("date_start", OpenErpType.Date)]
		public DateTime? DateStart { get; set; }
		[OpenErpMap("date_stop", OpenErpType.Date)]
		public DateTime? DateStop { get; set; }
		[OpenErpMap("effective_hours", OpenErpType.Float)]
		public double? EffectiveHours { get; set; }
		[OpenErpMap("expected_hours", OpenErpType.Float)]
		public double? ExpectedHours { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("product_owner_id", OpenErpType.Integer)]
		public int? ProductOwnerId { get; set; }
		[OpenErpMap("progress", OpenErpType.Float)]
		public double? Progress { get; set; }
		[OpenErpMap("project_id", OpenErpType.Integer)]
		public int? ProjectId { get; set; }
		[OpenErpMap("retrospective", OpenErpType.Char)]
		public string Retrospective { get; set; }
		[OpenErpMap("review", OpenErpType.Char)]
		public string Review { get; set; }
		[OpenErpMap("scrum_master_id", OpenErpType.Integer)]
		public int? ScrumMasterId { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
	}

	[OpenErpMap("project.task")]
	public class ProjectTask : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("context_id", OpenErpType.Integer)]
		public int? ContextId { get; set; }
		[OpenErpMap("create_date", OpenErpType.Datetime)]
		public DateTime? CreateDate { get; set; }
		[OpenErpMap("date_deadline", OpenErpType.Date)]
		public DateTime? DateDeadline { get; set; }
		[OpenErpMap("date_end", OpenErpType.Datetime)]
		public DateTime? DateEnd { get; set; }
		[OpenErpMap("date_start", OpenErpType.Datetime)]
		public DateTime? DateStart { get; set; }
		[OpenErpMap("delay_hours", OpenErpType.Float)]
		public double? DelayHours { get; set; }
		[OpenErpMap("delegated_user_id", OpenErpType.Integer)]
		public int? DelegatedUserId { get; set; }
		[OpenErpMap("description", OpenErpType.Char)]
		public string Description { get; set; }
		[OpenErpMap("effective_hours", OpenErpType.Float)]
		public double? EffectiveHours { get; set; }
		[OpenErpMap("manager_id", OpenErpType.Integer)]
		public int? ManagerId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("notes", OpenErpType.Char)]
		public string Notes { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("planned_hours", OpenErpType.Float)]
		public double? PlannedHours { get; set; }
		[OpenErpMap("priority", OpenErpType.Selection)]
		public string Priority { get; set; }
		[OpenErpMap("procurement_id", OpenErpType.Integer)]
		public int? ProcurementId { get; set; }
		[OpenErpMap("product_backlog_id", OpenErpType.Integer)]
		public int? ProductBacklogId { get; set; }
		[OpenErpMap("progress", OpenErpType.Float)]
		public double? Progress { get; set; }
		[OpenErpMap("project_id", OpenErpType.Integer)]
		public int? ProjectId { get; set; }
		[OpenErpMap("remaining_hours", OpenErpType.Float)]
		public double? RemainingHours { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
		[OpenErpMap("sprint_id", OpenErpType.Integer)]
		public int? SprintId { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("timebox_id", OpenErpType.Integer)]
		public int? TimeboxId { get; set; }
		[OpenErpMap("total_hours", OpenErpType.Float)]
		public double? TotalHours { get; set; }
		[OpenErpMap("type_id", OpenErpType.Integer)]
		public int? TypeId { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("project.task.type")]
	public class ProjectTaskType : OpenErpEntityBase {
		[OpenErpMap("description", OpenErpType.Char)]
		public string Description { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
	}

	[OpenErpMap("project.task.work")]
	public class ProjectTaskWork : OpenErpEntityBase {
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("date", OpenErpType.Datetime)]
		public DateTime? Date { get; set; }
		[OpenErpMap("hours", OpenErpType.Float)]
		public double? Hours { get; set; }
		[OpenErpMap("hr_analytic_timesheet_id", OpenErpType.Integer)]
		public int? HrAnalyticTimesheetId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("task_id", OpenErpType.Integer)]
		public int TaskId { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int UserId { get; set; }
	}

	[OpenErpMap("project.vs.hours")]
	public class ProjectVsHours : OpenErpEntityBase {
		[OpenErpMap("planned_hours", OpenErpType.Float)]
		public double? PlannedHours { get; set; }
		[OpenErpMap("project", OpenErpType.Char)]
		public string Project { get; set; }
		[OpenErpMap("remaining_hours", OpenErpType.Float)]
		public double? RemainingHours { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("total_hours", OpenErpType.Float)]
		public double? TotalHours { get; set; }
	}

	[OpenErpMap("publisher_warranty.contract")]
	public class Publisher_warrantyContract : OpenErpEntityBase {
		[OpenErpMap("check_opw", OpenErpType.Boolean)]
		public bool CheckOpw { get; set; }
		[OpenErpMap("check_support", OpenErpType.Boolean)]
		public bool CheckSupport { get; set; }
		[OpenErpMap("date_start", OpenErpType.Date)]
		public DateTime? DateStart { get; set; }
		[OpenErpMap("date_stop", OpenErpType.Date)]
		public DateTime? DateStop { get; set; }
		[OpenErpMap("kind", OpenErpType.Char)]
		public string Kind { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
	}

	[OpenErpMap("purchase.order")]
	public class PurchaseOrder : OpenErpEntityBase {
		[OpenErpMap("amount_tax", OpenErpType.Float)]
		public double? AmountTax { get; set; }
		[OpenErpMap("amount_total", OpenErpType.Float)]
		public double? AmountTotal { get; set; }
		[OpenErpMap("amount_untaxed", OpenErpType.Float)]
		public double? AmountUntaxed { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("create_uid", OpenErpType.Integer)]
		public int? CreateUid { get; set; }
		[OpenErpMap("date_approve", OpenErpType.Date)]
		public DateTime? DateApprove { get; set; }
		[OpenErpMap("date_order", OpenErpType.Date)]
		public DateTime? DateOrder { get; set; }
		[OpenErpMap("dest_address_id", OpenErpType.Integer)]
		public int? DestAddressId { get; set; }
		[OpenErpMap("fiscal_position", OpenErpType.Integer)]
		public int? FiscalPosition { get; set; }
		[OpenErpMap("invoiced", OpenErpType.Boolean)]
		public bool Invoiced { get; set; }
		[OpenErpMap("invoiced_rate", OpenErpType.Float)]
		public double? InvoicedRate { get; set; }
		[OpenErpMap("invoice_method", OpenErpType.Selection)]
		public string InvoiceMethod { get; set; }
		[OpenErpMap("location_id", OpenErpType.Integer)]
		public int? LocationId { get; set; }
		[OpenErpMap("minimum_planned_date", OpenErpType.Date)]
		public DateTime? MinimumPlannedDate { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("notes", OpenErpType.Char)]
		public string Notes { get; set; }
		[OpenErpMap("origin", OpenErpType.Char)]
		public string Origin { get; set; }
		[OpenErpMap("partner_address_id", OpenErpType.Integer)]
		public int? PartnerAddressId { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("partner_ref", OpenErpType.Char)]
		public string PartnerRef { get; set; }
		[OpenErpMap("pricelist_id", OpenErpType.Integer)]
		public int? PricelistId { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("shipped", OpenErpType.Boolean)]
		public bool Shipped { get; set; }
		[OpenErpMap("shipped_rate", OpenErpType.Float)]
		public double? ShippedRate { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("validator", OpenErpType.Integer)]
		public int? Validator { get; set; }
		[OpenErpMap("warehouse_id", OpenErpType.Integer)]
		public int? WarehouseId { get; set; }
	}

	[OpenErpMap("purchase.order.line")]
	public class PurchaseOrderLine : OpenErpEntityBase {
		[OpenErpMap("account_analytic_id", OpenErpType.Integer)]
		public int? AccountAnalyticId { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("date_order", OpenErpType.Date)]
		public DateTime? DateOrder { get; set; }
		[OpenErpMap("date_planned", OpenErpType.Date)]
		public DateTime? DatePlanned { get; set; }
		[OpenErpMap("invoiced", OpenErpType.Boolean)]
		public bool Invoiced { get; set; }
		[OpenErpMap("move_dest_id", OpenErpType.Integer)]
		public int? MoveDestId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("notes", OpenErpType.Char)]
		public string Notes { get; set; }
		[OpenErpMap("order_id", OpenErpType.Integer)]
		public int? OrderId { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("price_subtotal", OpenErpType.Float)]
		public double? PriceSubtotal { get; set; }
		[OpenErpMap("price_unit", OpenErpType.Float)]
		public double? PriceUnit { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("product_qty", OpenErpType.Float)]
		public double? ProductQty { get; set; }
		[OpenErpMap("product_uom", OpenErpType.Integer)]
		public int? ProductUom { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
	}

	[OpenErpMap("purchase.report")]
	public class PurchaseReport : OpenErpEntityBase {
		[OpenErpMap("category_id", OpenErpType.Integer)]
		public int? CategoryId { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("date", OpenErpType.Date)]
		public DateTime? Date { get; set; }
		[OpenErpMap("date_approve", OpenErpType.Date)]
		public DateTime? DateApprove { get; set; }
		[OpenErpMap("day", OpenErpType.Char)]
		public string Day { get; set; }
		[OpenErpMap("delay", OpenErpType.Float)]
		public double? Delay { get; set; }
		[OpenErpMap("delay_pass", OpenErpType.Float)]
		public double? DelayPass { get; set; }
		[OpenErpMap("dest_address_id", OpenErpType.Integer)]
		public int? DestAddressId { get; set; }
		[OpenErpMap("expected_date", OpenErpType.Date)]
		public DateTime? ExpectedDate { get; set; }
		[OpenErpMap("location_id", OpenErpType.Integer)]
		public int? LocationId { get; set; }
		[OpenErpMap("month", OpenErpType.Selection)]
		public string Month { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("nbr", OpenErpType.Integer)]
		public int? Nbr { get; set; }
		[OpenErpMap("negociation", OpenErpType.Float)]
		public double? Negociation { get; set; }
		[OpenErpMap("partner_address_id", OpenErpType.Integer)]
		public int? PartnerAddressId { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("price_average", OpenErpType.Float)]
		public double? PriceAverage { get; set; }
		[OpenErpMap("pricelist_id", OpenErpType.Integer)]
		public int? PricelistId { get; set; }
		[OpenErpMap("price_standard", OpenErpType.Float)]
		public double? PriceStandard { get; set; }
		[OpenErpMap("price_total", OpenErpType.Float)]
		public double? PriceTotal { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("product_uom", OpenErpType.Integer)]
		public int? ProductUom { get; set; }
		[OpenErpMap("quantity", OpenErpType.Float)]
		public double? Quantity { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
		[OpenErpMap("validator", OpenErpType.Integer)]
		public int? Validator { get; set; }
		[OpenErpMap("warehouse_id", OpenErpType.Integer)]
		public int? WarehouseId { get; set; }
	}

	[OpenErpMap("report.account.analytic.line.to.invoice")]
	public class ReportAccountAnalyticLineToInvoice : OpenErpEntityBase {
		[OpenErpMap("account_id", OpenErpType.Integer)]
		public int? AccountId { get; set; }
		[OpenErpMap("amount", OpenErpType.Float)]
		public double? Amount { get; set; }
		[OpenErpMap("month", OpenErpType.Selection)]
		public string Month { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("product_uom_id", OpenErpType.Integer)]
		public int? ProductUomId { get; set; }
		[OpenErpMap("sale_price", OpenErpType.Float)]
		public double? SalePrice { get; set; }
		[OpenErpMap("unit_amount", OpenErpType.Float)]
		public double? UnitAmount { get; set; }
	}

	[OpenErpMap("report.account.receivable")]
	public class ReportAccountReceivable : OpenErpEntityBase {
		[OpenErpMap("balance", OpenErpType.Float)]
		public double? Balance { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("credit", OpenErpType.Float)]
		public double? Credit { get; set; }
		[OpenErpMap("debit", OpenErpType.Float)]
		public double? Debit { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
	}

	[OpenErpMap("report.account.sales")]
	public class ReportAccountSales : OpenErpEntityBase {
		[OpenErpMap("account_id", OpenErpType.Integer)]
		public int? AccountId { get; set; }
		[OpenErpMap("amount_total", OpenErpType.Float)]
		public double? AmountTotal { get; set; }
		[OpenErpMap("currency_id", OpenErpType.Integer)]
		public int? CurrencyId { get; set; }
		[OpenErpMap("month", OpenErpType.Selection)]
		public string Month { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("period_id", OpenErpType.Integer)]
		public int? PeriodId { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("quantity", OpenErpType.Float)]
		public double? Quantity { get; set; }
	}

	[OpenErpMap("report.account_type.sales")]
	public class ReportAccount_typeSales : OpenErpEntityBase {
		[OpenErpMap("amount_total", OpenErpType.Float)]
		public double? AmountTotal { get; set; }
		[OpenErpMap("currency_id", OpenErpType.Integer)]
		public int? CurrencyId { get; set; }
		[OpenErpMap("month", OpenErpType.Selection)]
		public string Month { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("period_id", OpenErpType.Integer)]
		public int? PeriodId { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("quantity", OpenErpType.Float)]
		public double? Quantity { get; set; }
		[OpenErpMap("user_type", OpenErpType.Integer)]
		public int? UserType { get; set; }
	}

	[OpenErpMap("report.aged.receivable")]
	public class ReportAgedReceivable : OpenErpEntityBase {
		[OpenErpMap("balance", OpenErpType.Float)]
		public double? Balance { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
	}

	[OpenErpMap("report.analytic.account.close")]
	public class ReportAnalyticAccountClose : OpenErpEntityBase {
		[OpenErpMap("balance", OpenErpType.Float)]
		public double? Balance { get; set; }
		[OpenErpMap("date_deadline", OpenErpType.Date)]
		public DateTime? DateDeadline { get; set; }
		[OpenErpMap("name", OpenErpType.Integer)]
		public int? Name { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("quantity", OpenErpType.Float)]
		public double? Quantity { get; set; }
		[OpenErpMap("quantity_max", OpenErpType.Float)]
		public double? QuantityMax { get; set; }
		[OpenErpMap("state", OpenErpType.Char)]
		public string State { get; set; }
	}

	[OpenErpMap("report.auction")]
	public class ReportAuction : OpenErpEntityBase {
		[OpenErpMap("auction", OpenErpType.Integer)]
		public int? Auction { get; set; }
		[OpenErpMap("avg_estimation", OpenErpType.Float)]
		public double? AvgEstimation { get; set; }
		[OpenErpMap("avg_price", OpenErpType.Float)]
		public double? AvgPrice { get; set; }
		[OpenErpMap("buyer", OpenErpType.Integer)]
		public int? Buyer { get; set; }
		[OpenErpMap("buyer_login", OpenErpType.Char)]
		public string BuyerLogin { get; set; }
		[OpenErpMap("date", OpenErpType.Date)]
		public DateTime? Date { get; set; }
		[OpenErpMap("day", OpenErpType.Char)]
		public string Day { get; set; }
		[OpenErpMap("gross_revenue", OpenErpType.Float)]
		public double? GrossRevenue { get; set; }
		[OpenErpMap("lot_type", OpenErpType.Selection)]
		public string LotType { get; set; }
		[OpenErpMap("month", OpenErpType.Selection)]
		public string Month { get; set; }
		[OpenErpMap("net_margin", OpenErpType.Float)]
		public double? NetMargin { get; set; }
		[OpenErpMap("net_revenue", OpenErpType.Float)]
		public double? NetRevenue { get; set; }
		[OpenErpMap("object", OpenErpType.Integer)]
		public int? Object { get; set; }
		[OpenErpMap("seller", OpenErpType.Integer)]
		public int? Seller { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("total_price", OpenErpType.Float)]
		public double? TotalPrice { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
		[OpenErpMap("year", OpenErpType.Char)]
		public string Year { get; set; }
	}

	[OpenErpMap("report.auction.adjudication")]
	public class ReportAuctionAdjudication : OpenErpEntityBase {
		[OpenErpMap("adj_total", OpenErpType.Float)]
		public double? AdjTotal { get; set; }
		[OpenErpMap("date", OpenErpType.Date)]
		public DateTime? Date { get; set; }
		[OpenErpMap("name", OpenErpType.Integer)]
		public int? Name { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("report.auction.object.date")]
	public class ReportAuctionObjectDate : OpenErpEntityBase {
		[OpenErpMap("month", OpenErpType.Date)]
		public DateTime? Month { get; set; }
		[OpenErpMap("name", OpenErpType.Date)]
		public DateTime? Name { get; set; }
		[OpenErpMap("obj_num", OpenErpType.Integer)]
		public int? ObjNum { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("report.document.file")]
	public class ReportDocumentFile : OpenErpEntityBase {
		[OpenErpMap("file_size", OpenErpType.Integer)]
		public int? FileSize { get; set; }
		[OpenErpMap("month", OpenErpType.Char)]
		public string Month { get; set; }
		[OpenErpMap("nbr", OpenErpType.Integer)]
		public int? Nbr { get; set; }
	}

	[OpenErpMap("report.document.user")]
	public class ReportDocumentUser : OpenErpEntityBase {
		[OpenErpMap("change_date", OpenErpType.Datetime)]
		public DateTime? ChangeDate { get; set; }
		[OpenErpMap("create_date", OpenErpType.Datetime)]
		public DateTime? CreateDate { get; set; }
		[OpenErpMap("datas_fname", OpenErpType.Char)]
		public string DatasFname { get; set; }
		[OpenErpMap("directory", OpenErpType.Char)]
		public string Directory { get; set; }
		[OpenErpMap("file_size", OpenErpType.Integer)]
		public int? FileSize { get; set; }
		[OpenErpMap("month", OpenErpType.Selection)]
		public string Month { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("nbr", OpenErpType.Integer)]
		public int? Nbr { get; set; }
		[OpenErpMap("type", OpenErpType.Char)]
		public string Type { get; set; }
		[OpenErpMap("user", OpenErpType.Char)]
		public string User { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("report.document.wall")]
	public class ReportDocumentWall : OpenErpEntityBase {
		[OpenErpMap("last", OpenErpType.Datetime)]
		public DateTime? Last { get; set; }
		[OpenErpMap("month", OpenErpType.Char)]
		public string Month { get; set; }
		[OpenErpMap("name", OpenErpType.Date)]
		public DateTime? Name { get; set; }
		[OpenErpMap("user", OpenErpType.Char)]
		public string User { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("report.files.partner")]
	public class ReportFilesPartner : OpenErpEntityBase {
		[OpenErpMap("file_size", OpenErpType.Integer)]
		public int? FileSize { get; set; }
		[OpenErpMap("month", OpenErpType.Selection)]
		public string Month { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("nbr", OpenErpType.Integer)]
		public int? Nbr { get; set; }
		[OpenErpMap("partner", OpenErpType.Char)]
		public string Partner { get; set; }
	}

	[OpenErpMap("report.invoice.created")]
	public class ReportInvoiceCreated : OpenErpEntityBase {
		[OpenErpMap("amount_total", OpenErpType.Float)]
		public double? AmountTotal { get; set; }
		[OpenErpMap("amount_untaxed", OpenErpType.Float)]
		public double? AmountUntaxed { get; set; }
		[OpenErpMap("create_date", OpenErpType.Datetime)]
		public DateTime? CreateDate { get; set; }
		[OpenErpMap("currency_id", OpenErpType.Integer)]
		public int? CurrencyId { get; set; }
		[OpenErpMap("date_due", OpenErpType.Date)]
		public DateTime? DateDue { get; set; }
		[OpenErpMap("date_invoice", OpenErpType.Date)]
		public DateTime? DateInvoice { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("number", OpenErpType.Char)]
		public string Number { get; set; }
		[OpenErpMap("origin", OpenErpType.Char)]
		public string Origin { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("residual", OpenErpType.Float)]
		public double? Residual { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
	}

	[OpenErpMap("report.lunch.amount")]
	public class ReportLunchAmount : OpenErpEntityBase {
		[OpenErpMap("amount", OpenErpType.Float)]
		public double? Amount { get; set; }
		[OpenErpMap("box", OpenErpType.Integer)]
		public int? Box { get; set; }
		[OpenErpMap("date", OpenErpType.Date)]
		public DateTime? Date { get; set; }
		[OpenErpMap("day", OpenErpType.Char)]
		public string Day { get; set; }
		[OpenErpMap("month", OpenErpType.Selection)]
		public string Month { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
		[OpenErpMap("year", OpenErpType.Char)]
		public string Year { get; set; }
	}

	[OpenErpMap("report.lunch.order")]
	public class ReportLunchOrder : OpenErpEntityBase {
		[OpenErpMap("box_name", OpenErpType.Char)]
		public string BoxName { get; set; }
		[OpenErpMap("date", OpenErpType.Date)]
		public DateTime? Date { get; set; }
		[OpenErpMap("day", OpenErpType.Char)]
		public string Day { get; set; }
		[OpenErpMap("month", OpenErpType.Selection)]
		public string Month { get; set; }
		[OpenErpMap("price_total", OpenErpType.Float)]
		public double? PriceTotal { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
		[OpenErpMap("year", OpenErpType.Char)]
		public string Year { get; set; }
	}

	[OpenErpMap("report.mrp.inout")]
	public class ReportMrpInout : OpenErpEntityBase {
		[OpenErpMap("date", OpenErpType.Char)]
		public string Date { get; set; }
		[OpenErpMap("value", OpenErpType.Float)]
		public double? Value { get; set; }
	}

	[OpenErpMap("report.object.encoded")]
	public class ReportObjectEncoded : OpenErpEntityBase {
		[OpenErpMap("adj", OpenErpType.Integer)]
		public int? Adj { get; set; }
		[OpenErpMap("date", OpenErpType.Date)]
		public DateTime? Date { get; set; }
		[OpenErpMap("estimation", OpenErpType.Float)]
		public double? Estimation { get; set; }
		[OpenErpMap("gross_revenue", OpenErpType.Float)]
		public double? GrossRevenue { get; set; }
		[OpenErpMap("net_revenue", OpenErpType.Float)]
		public double? NetRevenue { get; set; }
		[OpenErpMap("obj_margin", OpenErpType.Float)]
		public double? ObjMargin { get; set; }
		[OpenErpMap("obj_num", OpenErpType.Integer)]
		public int? ObjNum { get; set; }
		[OpenErpMap("obj_ret", OpenErpType.Integer)]
		public int? ObjRet { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("report.project.task.user")]
	public class ReportProjectTaskUser : OpenErpEntityBase {
		[OpenErpMap("closing_days", OpenErpType.Float)]
		public double? ClosingDays { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("date_deadline", OpenErpType.Date)]
		public DateTime? DateDeadline { get; set; }
		[OpenErpMap("date_end", OpenErpType.Date)]
		public DateTime? DateEnd { get; set; }
		[OpenErpMap("date_start", OpenErpType.Date)]
		public DateTime? DateStart { get; set; }
		[OpenErpMap("day", OpenErpType.Char)]
		public string Day { get; set; }
		[OpenErpMap("delay_endings_days", OpenErpType.Float)]
		public double? DelayEndingsDays { get; set; }
		[OpenErpMap("hours_delay", OpenErpType.Float)]
		public double? HoursDelay { get; set; }
		[OpenErpMap("hours_effective", OpenErpType.Float)]
		public double? HoursEffective { get; set; }
		[OpenErpMap("hours_planned", OpenErpType.Float)]
		public double? HoursPlanned { get; set; }
		[OpenErpMap("month", OpenErpType.Selection)]
		public string Month { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("nbr", OpenErpType.Integer)]
		public int? Nbr { get; set; }
		[OpenErpMap("no_of_days", OpenErpType.Integer)]
		public int? NoOfDays { get; set; }
		[OpenErpMap("opening_days", OpenErpType.Float)]
		public double? OpeningDays { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("priority", OpenErpType.Selection)]
		public string Priority { get; set; }
		[OpenErpMap("progress", OpenErpType.Float)]
		public double? Progress { get; set; }
		[OpenErpMap("project_id", OpenErpType.Integer)]
		public int? ProjectId { get; set; }
		[OpenErpMap("remaining_hours", OpenErpType.Float)]
		public double? RemainingHours { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("total_hours", OpenErpType.Float)]
		public double? TotalHours { get; set; }
		[OpenErpMap("type_id", OpenErpType.Integer)]
		public int? TypeId { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
		[OpenErpMap("year", OpenErpType.Char)]
		public string Year { get; set; }
	}

	[OpenErpMap("report.stock.inventory")]
	public class ReportStockInventory : OpenErpEntityBase {
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("date", OpenErpType.Datetime)]
		public DateTime? Date { get; set; }
		[OpenErpMap("location_id", OpenErpType.Integer)]
		public int? LocationId { get; set; }
		[OpenErpMap("location_type", OpenErpType.Selection)]
		public string LocationType { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("prodlot_id", OpenErpType.Integer)]
		public int? ProdlotId { get; set; }
		[OpenErpMap("product_categ_id", OpenErpType.Integer)]
		public int? ProductCategId { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("product_qty", OpenErpType.Float)]
		public double? ProductQty { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("value", OpenErpType.Float)]
		public double? Value { get; set; }
	}

	[OpenErpMap("report.stock.lines.date")]
	public class ReportStockLinesDate : OpenErpEntityBase {
		[OpenErpMap("date", OpenErpType.Datetime)]
		public DateTime? Date { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
	}

	[OpenErpMap("report.stock.move")]
	public class ReportStockMove : OpenErpEntityBase {
		[OpenErpMap("categ_id", OpenErpType.Integer)]
		public int? CategId { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("date", OpenErpType.Date)]
		public DateTime? Date { get; set; }
		[OpenErpMap("day", OpenErpType.Char)]
		public string Day { get; set; }
		[OpenErpMap("day_diff", OpenErpType.Float)]
		public double? DayDiff { get; set; }
		[OpenErpMap("day_diff1", OpenErpType.Float)]
		public double? DayDiff1 { get; set; }
		[OpenErpMap("day_diff2", OpenErpType.Float)]
		public double? DayDiff2 { get; set; }
		[OpenErpMap("location_dest_id", OpenErpType.Integer)]
		public int? LocationDestId { get; set; }
		[OpenErpMap("location_id", OpenErpType.Integer)]
		public int? LocationId { get; set; }
		[OpenErpMap("month", OpenErpType.Selection)]
		public string Month { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("picking_id", OpenErpType.Integer)]
		public int? PickingId { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("product_qty", OpenErpType.Integer)]
		public int? ProductQty { get; set; }
		[OpenErpMap("product_qty_in", OpenErpType.Integer)]
		public int? ProductQtyIn { get; set; }
		[OpenErpMap("product_qty_out", OpenErpType.Integer)]
		public int? ProductQtyOut { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("stock_journal", OpenErpType.Integer)]
		public int? StockJournal { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
		[OpenErpMap("value", OpenErpType.Float)]
		public double? Value { get; set; }
		[OpenErpMap("year", OpenErpType.Char)]
		public string Year { get; set; }
	}

	[OpenErpMap("report_timesheet.account")]
	public class Report_timesheetAccount : OpenErpEntityBase {
		[OpenErpMap("account_id", OpenErpType.Integer)]
		public int? AccountId { get; set; }
		[OpenErpMap("month", OpenErpType.Selection)]
		public string Month { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("quantity", OpenErpType.Float)]
		public double? Quantity { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("report_timesheet.account.date")]
	public class Report_timesheetAccountDate : OpenErpEntityBase {
		[OpenErpMap("account_id", OpenErpType.Integer)]
		public int? AccountId { get; set; }
		[OpenErpMap("month", OpenErpType.Selection)]
		public string Month { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("quantity", OpenErpType.Float)]
		public double? Quantity { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("report_timesheet.invoice")]
	public class Report_timesheetInvoice : OpenErpEntityBase {
		[OpenErpMap("account_id", OpenErpType.Integer)]
		public int? AccountId { get; set; }
		[OpenErpMap("amount_invoice", OpenErpType.Float)]
		public double? AmountInvoice { get; set; }
		[OpenErpMap("manager_id", OpenErpType.Integer)]
		public int? ManagerId { get; set; }
		[OpenErpMap("quantity", OpenErpType.Float)]
		public double? Quantity { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("report.timesheet.line")]
	public class ReportTimesheetLine : OpenErpEntityBase {
		[OpenErpMap("account_id", OpenErpType.Integer)]
		public int? AccountId { get; set; }
		[OpenErpMap("cost", OpenErpType.Float)]
		public double? Cost { get; set; }
		[OpenErpMap("date", OpenErpType.Date)]
		public DateTime? Date { get; set; }
		[OpenErpMap("day", OpenErpType.Char)]
		public string Day { get; set; }
		[OpenErpMap("general_account_id", OpenErpType.Integer)]
		public int? GeneralAccountId { get; set; }
		[OpenErpMap("invoice_id", OpenErpType.Integer)]
		public int? InvoiceId { get; set; }
		[OpenErpMap("month", OpenErpType.Selection)]
		public string Month { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("quantity", OpenErpType.Float)]
		public double? Quantity { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("report.timesheet.task.user")]
	public class ReportTimesheetTaskUser : OpenErpEntityBase {
		[OpenErpMap("month", OpenErpType.Selection)]
		public string Month { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("task_hrs", OpenErpType.Float)]
		public double? TaskHrs { get; set; }
		[OpenErpMap("timesheet_hrs", OpenErpType.Float)]
		public double? TimesheetHrs { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
		[OpenErpMap("year", OpenErpType.Char)]
		public string Year { get; set; }
	}

	[OpenErpMap("report_timesheet.user")]
	public class Report_timesheetUser : OpenErpEntityBase {
		[OpenErpMap("cost", OpenErpType.Float)]
		public double? Cost { get; set; }
		[OpenErpMap("month", OpenErpType.Selection)]
		public string Month { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("quantity", OpenErpType.Float)]
		public double? Quantity { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("report.workcenter.load")]
	public class ReportWorkcenterLoad : OpenErpEntityBase {
		[OpenErpMap("cycle", OpenErpType.Float)]
		public double? Cycle { get; set; }
		[OpenErpMap("hour", OpenErpType.Float)]
		public double? Hour { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("workcenter_id", OpenErpType.Integer)]
		public int? WorkcenterId { get; set; }
	}

	[OpenErpMap("report.vote")]
	public class ReportVote : OpenErpEntityBase {
		[OpenErpMap("category_id", OpenErpType.Integer)]
		public int? CategoryId { get; set; }
		[OpenErpMap("creater_id", OpenErpType.Integer)]
		public int? CreaterId { get; set; }
		[OpenErpMap("date", OpenErpType.Date)]
		public DateTime? Date { get; set; }
		[OpenErpMap("day", OpenErpType.Char)]
		public string Day { get; set; }
		[OpenErpMap("idea_id", OpenErpType.Integer)]
		public int? IdeaId { get; set; }
		[OpenErpMap("idea_state", OpenErpType.Selection)]
		public string IdeaState { get; set; }
		[OpenErpMap("month", OpenErpType.Selection)]
		public string Month { get; set; }
		[OpenErpMap("nbr", OpenErpType.Integer)]
		public int? Nbr { get; set; }
		[OpenErpMap("score", OpenErpType.Integer)]
		public int? Score { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
		[OpenErpMap("year", OpenErpType.Char)]
		public string Year { get; set; }
	}

	[OpenErpMap("res.alarm")]
	public class ResAlarm : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("duration", OpenErpType.Integer)]
		public int? Duration { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("repeat", OpenErpType.Integer)]
		public int? Repeat { get; set; }
		[OpenErpMap("trigger_duration", OpenErpType.Integer)]
		public int? TriggerDuration { get; set; }
		[OpenErpMap("trigger_interval", OpenErpType.Selection)]
		public string TriggerInterval { get; set; }
		[OpenErpMap("trigger_occurs", OpenErpType.Selection)]
		public string TriggerOccurs { get; set; }
		[OpenErpMap("trigger_related", OpenErpType.Selection)]
		public string TriggerRelated { get; set; }
	}

	[OpenErpMap("res.bank")]
	public class ResBank : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("bic", OpenErpType.Char)]
		public string Bic { get; set; }
		[OpenErpMap("city", OpenErpType.Char)]
		public string City { get; set; }
		[OpenErpMap("code", OpenErpType.Char)]
		public string Code { get; set; }
		[OpenErpMap("country", OpenErpType.Integer)]
		public int? Country { get; set; }
		[OpenErpMap("email", OpenErpType.Char)]
		public string Email { get; set; }
		[OpenErpMap("fax", OpenErpType.Char)]
		public string Fax { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("phone", OpenErpType.Char)]
		public string Phone { get; set; }
		[OpenErpMap("state", OpenErpType.Integer)]
		public int? State { get; set; }
		[OpenErpMap("street", OpenErpType.Char)]
		public string Street { get; set; }
		[OpenErpMap("street2", OpenErpType.Char)]
		public string Street2 { get; set; }
		[OpenErpMap("zip", OpenErpType.Char)]
		public string Zip { get; set; }
	}

	[OpenErpMap("res.company")]
	public class ResCompany : OpenErpEntityBase {
		[OpenErpMap("account_no", OpenErpType.Char)]
		public string AccountNo { get; set; }
		[OpenErpMap("currency_id", OpenErpType.Integer)]
		public int CurrencyId { get; set; }
		[OpenErpMap("manufacturing_lead", OpenErpType.Float)]
		public double? ManufacturingLead { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("overdue_msg", OpenErpType.Char)]
		public string OverdueMsg { get; set; }
		[OpenErpMap("pad_index", OpenErpType.Char)]
		public string PadIndex { get; set; }
		[OpenErpMap("parent_id", OpenErpType.Integer)]
		public int? ParentId { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int PartnerId { get; set; }
		[OpenErpMap("po_lead", OpenErpType.Float)]
		public double PoLead { get; set; }
		[OpenErpMap("project_time_mode_id", OpenErpType.Integer)]
		public int? ProjectTimeModeId { get; set; }
		[OpenErpMap("property_reserve_and_surplus_account", OpenErpType.Integer)]
		public int? PropertyReserveAndSurplusAccount { get; set; }
		[OpenErpMap("rml_footer1", OpenErpType.Char)]
		public string RmlFooter1 { get; set; }
		[OpenErpMap("rml_footer2", OpenErpType.Char)]
		public string RmlFooter2 { get; set; }
		[OpenErpMap("rml_header", OpenErpType.Char)]
		public string RmlHeader { get; set; }
		[OpenErpMap("rml_header1", OpenErpType.Char)]
		public string RmlHeader1 { get; set; }
		[OpenErpMap("rml_header2", OpenErpType.Char)]
		public string RmlHeader2 { get; set; }
		[OpenErpMap("rml_header3", OpenErpType.Char)]
		public string RmlHeader3 { get; set; }
		[OpenErpMap("schedule_range", OpenErpType.Float)]
		public double ScheduleRange { get; set; }
		[OpenErpMap("security_lead", OpenErpType.Float)]
		public double SecurityLead { get; set; }
		[OpenErpMap("timesheet_max_difference", OpenErpType.Float)]
		public double? TimesheetMaxDifference { get; set; }
		[OpenErpMap("timesheet_range", OpenErpType.Selection)]
		public string TimesheetRange { get; set; }
	}

	[OpenErpMap("res.country")]
	public class ResCountry : OpenErpEntityBase {
		[OpenErpMap("code", OpenErpType.Char)]
		public string Code { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
	}

	[OpenErpMap("res.country.state")]
	public class ResCountryState : OpenErpEntityBase {
		[OpenErpMap("code", OpenErpType.Char)]
		public string Code { get; set; }
		[OpenErpMap("country_id", OpenErpType.Integer)]
		public int? CountryId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
	}

	[OpenErpMap("res.currency")]
	public class ResCurrency : OpenErpEntityBase {
		[OpenErpMap("accuracy", OpenErpType.Integer)]
		public int? Accuracy { get; set; }
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("base", OpenErpType.Boolean)]
		public bool Base { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("date", OpenErpType.Date)]
		public DateTime? Date { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("rate", OpenErpType.Float)]
		public double? Rate { get; set; }
		[OpenErpMap("rounding", OpenErpType.Float)]
		public double? Rounding { get; set; }
		[OpenErpMap("symbol", OpenErpType.Char)]
		public string Symbol { get; set; }
	}

	[OpenErpMap("res.currency.rate")]
	public class ResCurrencyRate : OpenErpEntityBase {
		[OpenErpMap("currency_id", OpenErpType.Integer)]
		public int? CurrencyId { get; set; }
		[OpenErpMap("name", OpenErpType.Date)]
		public DateTime? Name { get; set; }
		[OpenErpMap("rate", OpenErpType.Float)]
		public double? Rate { get; set; }
	}

	[OpenErpMap("res.groups")]
	public class ResGroups : OpenErpEntityBase {
		[OpenErpMap("comment", OpenErpType.Char)]
		public string Comment { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("share", OpenErpType.Boolean)]
		public bool Share { get; set; }
	}

	[OpenErpMap("res.lang")]
	public class ResLang : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("code", OpenErpType.Char)]
		public string Code { get; set; }
		[OpenErpMap("date_format", OpenErpType.Char)]
		public string DateFormat { get; set; }
		[OpenErpMap("decimal_point", OpenErpType.Char)]
		public string DecimalPoint { get; set; }
		[OpenErpMap("direction", OpenErpType.Selection)]
		public string Direction { get; set; }
		[OpenErpMap("grouping", OpenErpType.Char)]
		public string Grouping { get; set; }
		[OpenErpMap("iso_code", OpenErpType.Char)]
		public string IsoCode { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("thousands_sep", OpenErpType.Char)]
		public string ThousandsSep { get; set; }
		[OpenErpMap("time_format", OpenErpType.Char)]
		public string TimeFormat { get; set; }
		[OpenErpMap("translatable", OpenErpType.Boolean)]
		public bool Translatable { get; set; }
	}

	[OpenErpMap("res.log")]
	public class ResLog : OpenErpEntityBase {
		[OpenErpMap("context", OpenErpType.Char)]
		public string Context { get; set; }
		[OpenErpMap("create_date", OpenErpType.Datetime)]
		public DateTime? CreateDate { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("read", OpenErpType.Boolean)]
		public bool Read { get; set; }
		[OpenErpMap("res_id", OpenErpType.Integer)]
		public int? ResId { get; set; }
		[OpenErpMap("res_model", OpenErpType.Char)]
		public string ResModel { get; set; }
		[OpenErpMap("secondary", OpenErpType.Boolean)]
		public bool Secondary { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("res.log.report")]
	public class ResLogReport : OpenErpEntityBase {
		[OpenErpMap("creation_date", OpenErpType.Date)]
		public DateTime? CreationDate { get; set; }
		[OpenErpMap("day", OpenErpType.Char)]
		public string Day { get; set; }
		[OpenErpMap("month", OpenErpType.Selection)]
		public string Month { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("nbr", OpenErpType.Integer)]
		public int? Nbr { get; set; }
		[OpenErpMap("res_model", OpenErpType.Char)]
		public string ResModel { get; set; }
	}

	[OpenErpMap("resource.calendar")]
	public class ResourceCalendar : OpenErpEntityBase {
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("manager", OpenErpType.Integer)]
		public int? Manager { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
	}

	[OpenErpMap("resource.calendar.attendance")]
	public class ResourceCalendarAttendance : OpenErpEntityBase {
		[OpenErpMap("calendar_id", OpenErpType.Integer)]
		public int? CalendarId { get; set; }
		[OpenErpMap("date_from", OpenErpType.Date)]
		public DateTime? DateFrom { get; set; }
		[OpenErpMap("dayofweek", OpenErpType.Selection)]
		public string Dayofweek { get; set; }
		[OpenErpMap("hour_from", OpenErpType.Float)]
		public double? HourFrom { get; set; }
		[OpenErpMap("hour_to", OpenErpType.Float)]
		public double? HourTo { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
	}

	[OpenErpMap("resource.calendar.leaves")]
	public class ResourceCalendarLeaves : OpenErpEntityBase {
		[OpenErpMap("calendar_id", OpenErpType.Integer)]
		public int? CalendarId { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("date_from", OpenErpType.Datetime)]
		public DateTime DateFrom { get; set; }
		[OpenErpMap("date_to", OpenErpType.Datetime)]
		public DateTime DateTo { get; set; }
		[OpenErpMap("holiday_id", OpenErpType.Integer)]
		public int? HolidayId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("resource_id", OpenErpType.Integer)]
		public int? ResourceId { get; set; }
	}

	[OpenErpMap("resource.resource")]
	public class ResourceResource : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("calendar_id", OpenErpType.Integer)]
		public int? CalendarId { get; set; }
		[OpenErpMap("code", OpenErpType.Char)]
		public string Code { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("resource_type", OpenErpType.Selection)]
		public string ResourceType { get; set; }
		[OpenErpMap("time_efficiency", OpenErpType.Float)]
		public double? TimeEfficiency { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("res.partner")]
	public class ResPartner : OpenErpEntityBase {
        //[OpenErpMap("active", OpenErpType.Boolean)]
        //public bool Active { get; set; }
        //[OpenErpMap("city", OpenErpType.Char)]
        //public string City { get; set; }
        //[OpenErpMap("comment", OpenErpType.Char)]
        //public string Comment { get; set; }
        //[OpenErpMap("company_id", OpenErpType.Integer)]
        //public int? CompanyId { get; set; }
        //[OpenErpMap("country", OpenErpType.Integer)]
        //public int? Country { get; set; }
        //[OpenErpMap("credit", OpenErpType.Float)]
        //public double? Credit { get; set; }
        //[OpenErpMap("credit_limit", OpenErpType.Float)]
        //public double? CreditLimit { get; set; }
        //[OpenErpMap("customer", OpenErpType.Boolean)]
        //public bool Customer { get; set; }
        //[OpenErpMap("date", OpenErpType.Date)]
        //public DateTime? Date { get; set; }
        //[OpenErpMap("debit", OpenErpType.Float)]
        //public double? Debit { get; set; }
        //[OpenErpMap("debit_limit", OpenErpType.Float)]
        //public double? DebitLimit { get; set; }
        //[OpenErpMap("ean13", OpenErpType.Char)]
        //public string Ean13 { get; set; }
        //[OpenErpMap("email", OpenErpType.Char)]
        //public string Email { get; set; }
        //[OpenErpMap("employee", OpenErpType.Boolean)]
        //public bool Employee { get; set; }
        //[OpenErpMap("lang", OpenErpType.Selection)]
        //public string Lang { get; set; }
        //[OpenErpMap("last_reconciliation_date", OpenErpType.Datetime)]
        //public DateTime? LastReconciliationDate { get; set; }
        //[OpenErpMap("mobile", OpenErpType.Char)]
        //public string Mobile { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
        //[OpenErpMap("parent_id", OpenErpType.Integer)]
        //public int? ParentId { get; set; }
        //[OpenErpMap("phone", OpenErpType.Char)]
        //public string Phone { get; set; }
        //[OpenErpMap("property_account_payable", OpenErpType.Integer)]
        //public int PropertyAccountPayable { get; set; }
        //[OpenErpMap("property_account_position", OpenErpType.Integer)]
        //public int? PropertyAccountPosition { get; set; }
        //[OpenErpMap("property_account_receivable", OpenErpType.Integer)]
        //public int PropertyAccountReceivable { get; set; }
        //[OpenErpMap("property_payment_term", OpenErpType.Integer)]
        //public int? PropertyPaymentTerm { get; set; }
        //[OpenErpMap("property_product_pricelist", OpenErpType.Integer)]
        //public int? PropertyProductPricelist { get; set; }
        //[OpenErpMap("property_product_pricelist_purchase", OpenErpType.Integer)]
        //public int? PropertyProductPricelistPurchase { get; set; }
        //[OpenErpMap("property_stock_customer", OpenErpType.Integer)]
        //public int? PropertyStockCustomer { get; set; }
        //[OpenErpMap("property_stock_supplier", OpenErpType.Integer)]
        //public int? PropertyStockSupplier { get; set; }
        //[OpenErpMap("ref", OpenErpType.Char)]
        //public string Ref { get; set; }
        //[OpenErpMap("section_id", OpenErpType.Integer)]
        //public int? SectionId { get; set; }
        //[OpenErpMap("supplier", OpenErpType.Boolean)]
        //public bool Supplier { get; set; }
        //[OpenErpMap("title", OpenErpType.Integer)]
        //public int? Title { get; set; }
        //[OpenErpMap("user_id", OpenErpType.Integer)]
        //public int? UserId { get; set; }
        //[OpenErpMap("vat", OpenErpType.Char)]
        //public string Vat { get; set; }
        //[OpenErpMap("vat_subjected", OpenErpType.Boolean)]
        //public bool VatSubjected { get; set; }
        //[OpenErpMap("website", OpenErpType.Char)]
        //public string Website { get; set; }
	}

	[OpenErpMap("res.partner.address")]
	public class ResPartnerAddress : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("birthdate", OpenErpType.Char)]
		public string Birthdate { get; set; }
		[OpenErpMap("city", OpenErpType.Char)]
		public string City { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("country_id", OpenErpType.Integer)]
		public int? CountryId { get; set; }
		[OpenErpMap("email", OpenErpType.Char)]
		public string Email { get; set; }
		[OpenErpMap("fax", OpenErpType.Char)]
		public string Fax { get; set; }
		[OpenErpMap("function", OpenErpType.Char)]
		public string Function { get; set; }
		[OpenErpMap("is_customer_add", OpenErpType.Boolean)]
		public bool IsCustomerAdd { get; set; }
		[OpenErpMap("is_supplier_add", OpenErpType.Boolean)]
		public bool IsSupplierAdd { get; set; }
		[OpenErpMap("mobile", OpenErpType.Char)]
		public string Mobile { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("phone", OpenErpType.Char)]
		public string Phone { get; set; }
		[OpenErpMap("state_id", OpenErpType.Integer)]
		public int? StateId { get; set; }
		[OpenErpMap("street", OpenErpType.Char)]
		public string Street { get; set; }
		[OpenErpMap("street2", OpenErpType.Char)]
		public string Street2 { get; set; }
		[OpenErpMap("zip", OpenErpType.Char)]
		public string Zip { get; set; }
		[OpenErpMap("title", OpenErpType.Integer)]
		public int? Title { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
	}

	[OpenErpMap("res.partner.bank")]
	public class ResPartnerBank : OpenErpEntityBase {
		[OpenErpMap("acc_number", OpenErpType.Char)]
		public string AccNumber { get; set; }
		[OpenErpMap("bank", OpenErpType.Integer)]
		public int Bank { get; set; }
		[OpenErpMap("city", OpenErpType.Char)]
		public string City { get; set; }
		[OpenErpMap("country_id", OpenErpType.Integer)]
		public int? CountryId { get; set; }
		[OpenErpMap("iban", OpenErpType.Char)]
		public string Iban { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("owner_name", OpenErpType.Char)]
		public string OwnerName { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int PartnerId { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("state_id", OpenErpType.Integer)]
		public int? StateId { get; set; }
		[OpenErpMap("street", OpenErpType.Char)]
		public string Street { get; set; }
		[OpenErpMap("zip", OpenErpType.Char)]
		public string Zip { get; set; }
	}

	[OpenErpMap("res.partner.bank.type")]
	public class ResPartnerBankType : OpenErpEntityBase {
		[OpenErpMap("code", OpenErpType.Char)]
		public string Code { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
	}

	[OpenErpMap("res.partner.bank.type.field")]
	public class ResPartnerBankTypeField : OpenErpEntityBase {
		[OpenErpMap("bank_type_id", OpenErpType.Integer)]
		public int? BankTypeId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("readonly", OpenErpType.Boolean)]
		public bool Readonly { get; set; }
		[OpenErpMap("required", OpenErpType.Boolean)]
		public bool Required { get; set; }
		[OpenErpMap("size", OpenErpType.Integer)]
		public int? Size { get; set; }
	}

	[OpenErpMap("res.partner.canal")]
	public class ResPartnerCanal : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
	}

	[OpenErpMap("res.partner.category")]
	public class ResPartnerCategory : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("complete_name", OpenErpType.Char)]
		public string CompleteName { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("parent_id", OpenErpType.Integer)]
		public int? ParentId { get; set; }
		[OpenErpMap("parent_left", OpenErpType.Integer)]
		public int? ParentLeft { get; set; }
		[OpenErpMap("parent_right", OpenErpType.Integer)]
		public int? ParentRight { get; set; }
	}

	[OpenErpMap("res.partner.event")]
	public class ResPartnerEvent : OpenErpEntityBase {
		[OpenErpMap("date", OpenErpType.Datetime)]
		public DateTime? Date { get; set; }
		[OpenErpMap("description", OpenErpType.Char)]
		public string Description { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("res.partner.title")]
	public class ResPartnerTitle : OpenErpEntityBase {
		[OpenErpMap("domain", OpenErpType.Selection)]
		public string Domain { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("shortcut", OpenErpType.Char)]
		public string Shortcut { get; set; }
	}

	[OpenErpMap("res.payterm")]
	public class ResPayterm : OpenErpEntityBase {
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
	}

	[OpenErpMap("res.request")]
	public class ResRequest : OpenErpEntityBase {
		[OpenErpMap("act_from", OpenErpType.Integer)]
		public int? ActFrom { get; set; }
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("act_to", OpenErpType.Integer)]
		public int? ActTo { get; set; }
		[OpenErpMap("body", OpenErpType.Char)]
		public string Body { get; set; }
		[OpenErpMap("create_date", OpenErpType.Datetime)]
		public DateTime? CreateDate { get; set; }
		[OpenErpMap("date_sent", OpenErpType.Datetime)]
		public DateTime? DateSent { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("priority", OpenErpType.Selection)]
		public string Priority { get; set; }
		[OpenErpMap("ref_partner_id", OpenErpType.Integer)]
		public int? RefPartnerId { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("trigger_date", OpenErpType.Datetime)]
		public DateTime? TriggerDate { get; set; }
	}

	[OpenErpMap("res.request.history")]
	public class ResRequestHistory : OpenErpEntityBase {
		[OpenErpMap("act_from", OpenErpType.Integer)]
		public int? ActFrom { get; set; }
		[OpenErpMap("act_to", OpenErpType.Integer)]
		public int? ActTo { get; set; }
		[OpenErpMap("body", OpenErpType.Char)]
		public string Body { get; set; }
		[OpenErpMap("date_sent", OpenErpType.Datetime)]
		public DateTime? DateSent { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("req_id", OpenErpType.Integer)]
		public int? ReqId { get; set; }
	}

	[OpenErpMap("res.request.link")]
	public class ResRequestLink : OpenErpEntityBase {
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("object", OpenErpType.Char)]
		public string Object { get; set; }
		[OpenErpMap("priority", OpenErpType.Integer)]
		public int? Priority { get; set; }
	}

	[OpenErpMap("res.users")]
	public class ResUsers : OpenErpEntityBase {
		[OpenErpMap("action_id", OpenErpType.Integer)]
		public int? ActionId { get; set; }
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("address_id", OpenErpType.Integer)]
		public int? AddressId { get; set; }
		[OpenErpMap("availability", OpenErpType.Selection)]
		public string Availability { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int CompanyId { get; set; }
		[OpenErpMap("context_department_id", OpenErpType.Integer)]
		public int? ContextDepartmentId { get; set; }
		[OpenErpMap("context_lang", OpenErpType.Selection)]
		public string ContextLang { get; set; }
		[OpenErpMap("context_project_id", OpenErpType.Integer)]
		public int? ContextProjectId { get; set; }
		[OpenErpMap("context_section_id", OpenErpType.Integer)]
		public int? ContextSectionId { get; set; }
		[OpenErpMap("context_tz", OpenErpType.Selection)]
		public string ContextTz { get; set; }
		[OpenErpMap("date", OpenErpType.Datetime)]
		public DateTime? Date { get; set; }
		[OpenErpMap("email", OpenErpType.Char)]
		public string Email { get; set; }
		[OpenErpMap("login", OpenErpType.Char)]
		public string Login { get; set; }
		[OpenErpMap("menu_id", OpenErpType.Integer)]
		public int? MenuId { get; set; }
		[OpenErpMap("menu_tips", OpenErpType.Boolean)]
		public bool MenuTips { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("new_password", OpenErpType.Char)]
		public string NewPassword { get; set; }
		[OpenErpMap("password", OpenErpType.Char)]
		public string Password { get; set; }
		[OpenErpMap("share", OpenErpType.Boolean)]
		public bool Share { get; set; }
		[OpenErpMap("signature", OpenErpType.Char)]
		public string Signature { get; set; }
		[OpenErpMap("user_email", OpenErpType.Char)]
		public string UserEmail { get; set; }
		[OpenErpMap("view", OpenErpType.Selection)]
		public string View { get; set; }
	}

	[OpenErpMap("res.widget")]
	public class ResWidget : OpenErpEntityBase {
		[OpenErpMap("content", OpenErpType.Char)]
		public string Content { get; set; }
		[OpenErpMap("title", OpenErpType.Char)]
		public string Title { get; set; }
	}

	[OpenErpMap("res.widget.user")]
	public class ResWidgetUser : OpenErpEntityBase {
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
		[OpenErpMap("widget_id", OpenErpType.Integer)]
		public int? WidgetId { get; set; }
	}

	[OpenErpMap("sale.order")]
	public class SaleOrder : OpenErpEntityBase {
		[OpenErpMap("amount_tax", OpenErpType.Float)]
		public double? AmountTax { get; set; }
		[OpenErpMap("amount_total", OpenErpType.Float)]
		public double? AmountTotal { get; set; }
		[OpenErpMap("amount_untaxed", OpenErpType.Float)]
		public double? AmountUntaxed { get; set; }
		[OpenErpMap("client_order_ref", OpenErpType.Char)]
		public string ClientOrderRef { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("create_date", OpenErpType.Date)]
		public DateTime? CreateDate { get; set; }
		[OpenErpMap("date_confirm", OpenErpType.Date)]
		public DateTime? DateConfirm { get; set; }
		[OpenErpMap("date_order", OpenErpType.Date)]
		public DateTime DateOrder { get; set; }
		[OpenErpMap("fiscal_position", OpenErpType.Integer)]
		public int? FiscalPosition { get; set; }
		[OpenErpMap("incoterm", OpenErpType.Integer)]
		public int? Incoterm { get; set; }
		[OpenErpMap("invoiced", OpenErpType.Boolean)]
		public bool Invoiced { get; set; }
		[OpenErpMap("invoiced_rate", OpenErpType.Float)]
		public double? InvoicedRate { get; set; }
		[OpenErpMap("invoice_quantity", OpenErpType.Selection)]
		public string InvoiceQuantity { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("note", OpenErpType.Char)]
		public string Note { get; set; }
		[OpenErpMap("order_policy", OpenErpType.Selection)]
		public string OrderPolicy { get; set; }
		[OpenErpMap("origin", OpenErpType.Char)]
		public string Origin { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int PartnerId { get; set; }
		[OpenErpMap("partner_invoice_id", OpenErpType.Integer)]
		public int PartnerInvoiceId { get; set; }
		[OpenErpMap("partner_order_id", OpenErpType.Integer)]
		public int PartnerOrderId { get; set; }
		[OpenErpMap("partner_shipping_id", OpenErpType.Integer)]
		public int PartnerShippingId { get; set; }
		[OpenErpMap("payment_term", OpenErpType.Integer)]
		public int? PaymentTerm { get; set; }
		[OpenErpMap("picked_rate", OpenErpType.Float)]
		public double? PickedRate { get; set; }
		[OpenErpMap("picking_policy", OpenErpType.Selection)]
		public string PickingPolicy { get; set; }
		[OpenErpMap("pricelist_id", OpenErpType.Integer)]
		public int PricelistId { get; set; }
		[OpenErpMap("project_id", OpenErpType.Integer)]
		public int? ProjectId { get; set; }
		[OpenErpMap("section_id", OpenErpType.Integer)]
		public int? SectionId { get; set; }
		[OpenErpMap("shipped", OpenErpType.Boolean)]
		public bool Shipped { get; set; }
		[OpenErpMap("shop_id", OpenErpType.Integer)]
		public int ShopId { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("sale.order.line")]
	public class SaleOrderLine : OpenErpEntityBase {
		[OpenErpMap("address_allotment_id", OpenErpType.Integer)]
		public int? AddressAllotmentId { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("delay", OpenErpType.Float)]
		public double? Delay { get; set; }
		[OpenErpMap("discount", OpenErpType.Float)]
		public double? Discount { get; set; }
		[OpenErpMap("invoiced", OpenErpType.Boolean)]
		public bool Invoiced { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("notes", OpenErpType.Char)]
		public string Notes { get; set; }
		[OpenErpMap("number_packages", OpenErpType.Integer)]
		public int? NumberPackages { get; set; }
		[OpenErpMap("order_id", OpenErpType.Integer)]
		public int? OrderId { get; set; }
		[OpenErpMap("order_partner_id", OpenErpType.Integer)]
		public int? OrderPartnerId { get; set; }
		[OpenErpMap("price_subtotal", OpenErpType.Float)]
		public double? PriceSubtotal { get; set; }
		[OpenErpMap("price_unit", OpenErpType.Float)]
		public double? PriceUnit { get; set; }
		[OpenErpMap("procurement_id", OpenErpType.Integer)]
		public int? ProcurementId { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("product_packaging", OpenErpType.Integer)]
		public int? ProductPackaging { get; set; }
		[OpenErpMap("product_uom", OpenErpType.Integer)]
		public int? ProductUom { get; set; }
		[OpenErpMap("product_uom_qty", OpenErpType.Float)]
		public double? ProductUomQty { get; set; }
		[OpenErpMap("product_uos", OpenErpType.Integer)]
		public int? ProductUos { get; set; }
		[OpenErpMap("product_uos_qty", OpenErpType.Float)]
		public double? ProductUosQty { get; set; }
		[OpenErpMap("salesman_id", OpenErpType.Integer)]
		public int? SalesmanId { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("th_weight", OpenErpType.Float)]
		public double? ThWeight { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
	}

	[OpenErpMap("sale.receipt.report")]
	public class SaleReceiptReport : OpenErpEntityBase {
		[OpenErpMap("account_id", OpenErpType.Integer)]
		public int? AccountId { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("currency_id", OpenErpType.Integer)]
		public int? CurrencyId { get; set; }
		[OpenErpMap("date", OpenErpType.Date)]
		public DateTime? Date { get; set; }
		[OpenErpMap("date_due", OpenErpType.Date)]
		public DateTime? DateDue { get; set; }
		[OpenErpMap("day", OpenErpType.Char)]
		public string Day { get; set; }
		[OpenErpMap("delay_to_pay", OpenErpType.Float)]
		public double? DelayToPay { get; set; }
		[OpenErpMap("due_delay", OpenErpType.Float)]
		public double? DueDelay { get; set; }
		[OpenErpMap("journal_id", OpenErpType.Integer)]
		public int? JournalId { get; set; }
		[OpenErpMap("month", OpenErpType.Selection)]
		public string Month { get; set; }
		[OpenErpMap("nbr", OpenErpType.Integer)]
		public int? Nbr { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("pay_now", OpenErpType.Selection)]
		public string PayNow { get; set; }
		[OpenErpMap("price_total", OpenErpType.Float)]
		public double? PriceTotal { get; set; }
		[OpenErpMap("price_total_tax", OpenErpType.Float)]
		public double? PriceTotalTax { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
		[OpenErpMap("year", OpenErpType.Char)]
		public string Year { get; set; }
	}

	[OpenErpMap("sale.report")]
	public class SaleReport : OpenErpEntityBase {
		[OpenErpMap("analytic_account_id", OpenErpType.Integer)]
		public int? AnalyticAccountId { get; set; }
		[OpenErpMap("categ_id", OpenErpType.Integer)]
		public int? CategId { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("date", OpenErpType.Date)]
		public DateTime? Date { get; set; }
		[OpenErpMap("date_confirm", OpenErpType.Date)]
		public DateTime? DateConfirm { get; set; }
		[OpenErpMap("day", OpenErpType.Char)]
		public string Day { get; set; }
		[OpenErpMap("delay", OpenErpType.Float)]
		public double? Delay { get; set; }
		[OpenErpMap("month", OpenErpType.Selection)]
		public string Month { get; set; }
		[OpenErpMap("nbr", OpenErpType.Integer)]
		public int? Nbr { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("pricelist_id", OpenErpType.Integer)]
		public int? PricelistId { get; set; }
		[OpenErpMap("price_total", OpenErpType.Float)]
		public double? PriceTotal { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("product_uom", OpenErpType.Integer)]
		public int? ProductUom { get; set; }
		[OpenErpMap("product_uom_qty", OpenErpType.Float)]
		public double? ProductUomQty { get; set; }
		[OpenErpMap("shipped", OpenErpType.Boolean)]
		public bool Shipped { get; set; }
		[OpenErpMap("shipped_qty_1", OpenErpType.Integer)]
		public int? ShippedQty1 { get; set; }
		[OpenErpMap("shop_id", OpenErpType.Integer)]
		public int? ShopId { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("uom_name", OpenErpType.Char)]
		public string UomName { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
		[OpenErpMap("year", OpenErpType.Char)]
		public string Year { get; set; }
	}

	[OpenErpMap("sale.shop")]
	public class SaleShop : OpenErpEntityBase {
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("payment_default_id", OpenErpType.Integer)]
		public int? PaymentDefaultId { get; set; }
		[OpenErpMap("pricelist_id", OpenErpType.Integer)]
		public int? PricelistId { get; set; }
		[OpenErpMap("project_id", OpenErpType.Integer)]
		public int? ProjectId { get; set; }
		[OpenErpMap("warehouse_id", OpenErpType.Integer)]
		public int? WarehouseId { get; set; }
	}

	[OpenErpMap("stock.incoterms")]
	public class StockIncoterms : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("code", OpenErpType.Char)]
		public string Code { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
	}

	[OpenErpMap("stock.inventory")]
	public class StockInventory : OpenErpEntityBase {
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("date", OpenErpType.Datetime)]
		public DateTime? Date { get; set; }
		[OpenErpMap("date_done", OpenErpType.Datetime)]
		public DateTime? DateDone { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
	}

	[OpenErpMap("stock.inventory.line")]
	public class StockInventoryLine : OpenErpEntityBase {
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("inventory_id", OpenErpType.Integer)]
		public int? InventoryId { get; set; }
		[OpenErpMap("location_id", OpenErpType.Integer)]
		public int? LocationId { get; set; }
		[OpenErpMap("prod_lot_id", OpenErpType.Integer)]
		public int? ProdLotId { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("product_qty", OpenErpType.Float)]
		public double? ProductQty { get; set; }
		[OpenErpMap("product_uom", OpenErpType.Integer)]
		public int? ProductUom { get; set; }
		[OpenErpMap("state", OpenErpType.Char)]
		public string State { get; set; }
	}

	[OpenErpMap("stock.journal")]
	public class StockJournal : OpenErpEntityBase {
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("stock.location")]
	public class StockLocation : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("address_id", OpenErpType.Integer)]
		public int? AddressId { get; set; }
		[OpenErpMap("chained_auto_packing", OpenErpType.Selection)]
		public string ChainedAutoPacking { get; set; }
		[OpenErpMap("chained_company_id", OpenErpType.Integer)]
		public int? ChainedCompanyId { get; set; }
		[OpenErpMap("chained_delay", OpenErpType.Integer)]
		public int? ChainedDelay { get; set; }
		[OpenErpMap("chained_journal_id", OpenErpType.Integer)]
		public int? ChainedJournalId { get; set; }
		[OpenErpMap("chained_location_id", OpenErpType.Integer)]
		public int? ChainedLocationId { get; set; }
		[OpenErpMap("chained_location_type", OpenErpType.Selection)]
		public string ChainedLocationType { get; set; }
		[OpenErpMap("chained_picking_type", OpenErpType.Selection)]
		public string ChainedPickingType { get; set; }
		[OpenErpMap("comment", OpenErpType.Char)]
		public string Comment { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("complete_name", OpenErpType.Char)]
		public string CompleteName { get; set; }
		[OpenErpMap("icon", OpenErpType.Selection)]
		public string Icon { get; set; }
		[OpenErpMap("location_id", OpenErpType.Integer)]
		public int? LocationId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("parent_left", OpenErpType.Integer)]
		public int? ParentLeft { get; set; }
		[OpenErpMap("parent_right", OpenErpType.Integer)]
		public int? ParentRight { get; set; }
		[OpenErpMap("posz", OpenErpType.Integer)]
		public int? Posz { get; set; }
		[OpenErpMap("posx", OpenErpType.Integer)]
		public int? Posx { get; set; }
		[OpenErpMap("posy", OpenErpType.Integer)]
		public int? Posy { get; set; }
		[OpenErpMap("scrap_location", OpenErpType.Boolean)]
		public bool ScrapLocation { get; set; }
		[OpenErpMap("stock_real", OpenErpType.Float)]
		public double? StockReal { get; set; }
		[OpenErpMap("stock_real_value", OpenErpType.Float)]
		public double? StockRealValue { get; set; }
		[OpenErpMap("stock_virtual", OpenErpType.Float)]
		public double? StockVirtual { get; set; }
		[OpenErpMap("stock_virtual_value", OpenErpType.Float)]
		public double? StockVirtualValue { get; set; }
		[OpenErpMap("usage", OpenErpType.Selection)]
		public string Usage { get; set; }
		[OpenErpMap("valuation_in_account_id", OpenErpType.Integer)]
		public int? ValuationInAccountId { get; set; }
		[OpenErpMap("valuation_out_account_id", OpenErpType.Integer)]
		public int? ValuationOutAccountId { get; set; }
	}

	[OpenErpMap("stock.move")]
	public class StockMove : OpenErpEntityBase {
		[OpenErpMap("location_dest_id", OpenErpType.Integer)]
		public int LocationDestId { get; set; }
		[OpenErpMap("location_id", OpenErpType.Integer)]
		public int LocationId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int ProductId { get; set; }
		[OpenErpMap("product_qty", OpenErpType.Float)]
		public double ProductQty { get; set; }
		[OpenErpMap("product_uom", OpenErpType.Integer)]
		public int ProductUom { get; set; }
	}

	[OpenErpMap("stock.picking")]
	public class StockPicking : OpenErpEntityBase {
		[OpenErpMap("address_id", OpenErpType.Integer)]
		public int? AddressId { get; set; }
		[OpenErpMap("auto_picking", OpenErpType.Boolean)]
		public bool AutoPicking { get; set; }
		[OpenErpMap("backorder_id", OpenErpType.Integer)]
		public int? BackorderId { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int CompanyId { get; set; }
		[OpenErpMap("date", OpenErpType.Datetime)]
		public DateTime? Date { get; set; }
		[OpenErpMap("date_done", OpenErpType.Datetime)]
		public DateTime? DateDone { get; set; }
		[OpenErpMap("invoice_state", OpenErpType.Selection)]
		public string InvoiceState { get; set; }
		[OpenErpMap("location_dest_id", OpenErpType.Integer)]
		public int? LocationDestId { get; set; }
		[OpenErpMap("location_id", OpenErpType.Integer)]
		public int? LocationId { get; set; }
		[OpenErpMap("max_date", OpenErpType.Datetime)]
		public DateTime? MaxDate { get; set; }
		[OpenErpMap("min_date", OpenErpType.Datetime)]
		public DateTime? MinDate { get; set; }
		[OpenErpMap("move_type", OpenErpType.Selection)]
		public string MoveType { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("note", OpenErpType.Char)]
		public string Note { get; set; }
		[OpenErpMap("origin", OpenErpType.Char)]
		public string Origin { get; set; }
		[OpenErpMap("partner_id", OpenErpType.Integer)]
		public int? PartnerId { get; set; }
		[OpenErpMap("purchase_id", OpenErpType.Integer)]
		public int? PurchaseId { get; set; }
		[OpenErpMap("sale_id", OpenErpType.Integer)]
		public int? SaleId { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("stock_journal_id", OpenErpType.Integer)]
		public int? StockJournalId { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
	}

	[OpenErpMap("stock.production.lot")]
	public class StockProductionLot : OpenErpEntityBase {
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("date", OpenErpType.Datetime)]
		public DateTime? Date { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("prefix", OpenErpType.Char)]
		public string Prefix { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("ref", OpenErpType.Char)]
		public string Ref { get; set; }
		[OpenErpMap("stock_available", OpenErpType.Float)]
		public double? StockAvailable { get; set; }
	}

	[OpenErpMap("stock.production.lot.revision")]
	public class StockProductionLotRevision : OpenErpEntityBase {
		[OpenErpMap("author_id", OpenErpType.Integer)]
		public int? AuthorId { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("date", OpenErpType.Date)]
		public DateTime? Date { get; set; }
		[OpenErpMap("description", OpenErpType.Char)]
		public string Description { get; set; }
		[OpenErpMap("indice", OpenErpType.Char)]
		public string Indice { get; set; }
		[OpenErpMap("lot_id", OpenErpType.Integer)]
		public int? LotId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
	}

	[OpenErpMap("stock.report.prodlots")]
	public class StockReportProdlots : OpenErpEntityBase {
		[OpenErpMap("location_id", OpenErpType.Integer)]
		public int? LocationId { get; set; }
		[OpenErpMap("prodlot_id", OpenErpType.Integer)]
		public int? ProdlotId { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("qty", OpenErpType.Float)]
		public double? Qty { get; set; }
	}

	[OpenErpMap("stock.report.tracklots")]
	public class StockReportTracklots : OpenErpEntityBase {
		[OpenErpMap("location_id", OpenErpType.Integer)]
		public int? LocationId { get; set; }
		[OpenErpMap("name", OpenErpType.Float)]
		public double? Name { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("tracking_id", OpenErpType.Integer)]
		public int? TrackingId { get; set; }
	}

	[OpenErpMap("stock.tracking")]
	public class StockTracking : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("date", OpenErpType.Datetime)]
		public DateTime? Date { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("serial", OpenErpType.Char)]
		public string Serial { get; set; }
	}

	[OpenErpMap("stock.warehouse")]
	public class StockWarehouse : OpenErpEntityBase {
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("lot_input_id", OpenErpType.Integer)]
		public int? LotInputId { get; set; }
		[OpenErpMap("lot_output_id", OpenErpType.Integer)]
		public int? LotOutputId { get; set; }
		[OpenErpMap("lot_stock_id", OpenErpType.Integer)]
		public int? LotStockId { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("partner_address_id", OpenErpType.Integer)]
		public int? PartnerAddressId { get; set; }
	}

	[OpenErpMap("stock.warehouse.orderpoint")]
	public class StockWarehouseOrderpoint : OpenErpEntityBase {
		[OpenErpMap("active", OpenErpType.Boolean)]
		public bool Active { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("location_id", OpenErpType.Integer)]
		public int? LocationId { get; set; }
		[OpenErpMap("logic", OpenErpType.Selection)]
		public string Logic { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("procurement_id", OpenErpType.Integer)]
		public int? ProcurementId { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("product_max_qty", OpenErpType.Float)]
		public double? ProductMaxQty { get; set; }
		[OpenErpMap("product_min_qty", OpenErpType.Float)]
		public double? ProductMinQty { get; set; }
		[OpenErpMap("product_uom", OpenErpType.Integer)]
		public int? ProductUom { get; set; }
		[OpenErpMap("qty_multiple", OpenErpType.Integer)]
		public int? QtyMultiple { get; set; }
		[OpenErpMap("warehouse_id", OpenErpType.Integer)]
		public int? WarehouseId { get; set; }
	}

	[OpenErpMap("survey")]
	public class Survey : OpenErpEntityBase {
		[OpenErpMap("date_close", OpenErpType.Datetime)]
		public DateTime? DateClose { get; set; }
		[OpenErpMap("date_open", OpenErpType.Datetime)]
		public DateTime? DateOpen { get; set; }
		[OpenErpMap("max_response_limit", OpenErpType.Integer)]
		public int? MaxResponseLimit { get; set; }
		[OpenErpMap("note", OpenErpType.Char)]
		public string Note { get; set; }
		[OpenErpMap("response_user", OpenErpType.Integer)]
		public int? ResponseUser { get; set; }
		[OpenErpMap("responsible_id", OpenErpType.Integer)]
		public int? ResponsibleId { get; set; }
		[OpenErpMap("send_response", OpenErpType.Boolean)]
		public bool SendResponse { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("title", OpenErpType.Char)]
		public string Title { get; set; }
		[OpenErpMap("tot_comp_survey", OpenErpType.Integer)]
		public int? TotCompSurvey { get; set; }
		[OpenErpMap("tot_start_survey", OpenErpType.Integer)]
		public int? TotStartSurvey { get; set; }
		[OpenErpMap("type", OpenErpType.Integer)]
		public int? Type { get; set; }
	}

	[OpenErpMap("survey.answer")]
	public class SurveyAnswer : OpenErpEntityBase {
		[OpenErpMap("answer", OpenErpType.Char)]
		public string Answer { get; set; }
		[OpenErpMap("average", OpenErpType.Float)]
		public double? Average { get; set; }
		[OpenErpMap("in_visible_answer_type", OpenErpType.Boolean)]
		public bool InVisibleAnswerType { get; set; }
		[OpenErpMap("menu_choice", OpenErpType.Char)]
		public string MenuChoice { get; set; }
		[OpenErpMap("question_id", OpenErpType.Integer)]
		public int? QuestionId { get; set; }
		[OpenErpMap("response", OpenErpType.Float)]
		public double? Response { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
	}

	[OpenErpMap("survey.history")]
	public class SurveyHistory : OpenErpEntityBase {
		[OpenErpMap("date", OpenErpType.Datetime)]
		public DateTime? Date { get; set; }
		[OpenErpMap("survey_id", OpenErpType.Integer)]
		public int? SurveyId { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("survey.page")]
	public class SurveyPage : OpenErpEntityBase {
		[OpenErpMap("note", OpenErpType.Char)]
		public string Note { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
		[OpenErpMap("survey_id", OpenErpType.Integer)]
		public int? SurveyId { get; set; }
		[OpenErpMap("title", OpenErpType.Char)]
		public string Title { get; set; }
	}

	[OpenErpMap("survey.question")]
	public class SurveyQuestion : OpenErpEntityBase {
		[OpenErpMap("allow_comment", OpenErpType.Boolean)]
		public bool AllowComment { get; set; }
		[OpenErpMap("column_name", OpenErpType.Char)]
		public string ColumnName { get; set; }
		[OpenErpMap("comment_column", OpenErpType.Boolean)]
		public bool CommentColumn { get; set; }
		[OpenErpMap("comment_field_type", OpenErpType.Selection)]
		public string CommentFieldType { get; set; }
		[OpenErpMap("comment_label", OpenErpType.Char)]
		public string CommentLabel { get; set; }
		[OpenErpMap("comment_maximum_date", OpenErpType.Date)]
		public DateTime? CommentMaximumDate { get; set; }
		[OpenErpMap("comment_maximum_float", OpenErpType.Float)]
		public double? CommentMaximumFloat { get; set; }
		[OpenErpMap("comment_maximum_no", OpenErpType.Integer)]
		public int? CommentMaximumNo { get; set; }
		[OpenErpMap("comment_minimum_date", OpenErpType.Date)]
		public DateTime? CommentMinimumDate { get; set; }
		[OpenErpMap("comment_minimum_float", OpenErpType.Float)]
		public double? CommentMinimumFloat { get; set; }
		[OpenErpMap("comment_minimum_no", OpenErpType.Integer)]
		public int? CommentMinimumNo { get; set; }
		[OpenErpMap("comment_valid_err_msg", OpenErpType.Char)]
		public string CommentValidErrMsg { get; set; }
		[OpenErpMap("comment_valid_type", OpenErpType.Selection)]
		public string CommentValidType { get; set; }
		[OpenErpMap("descriptive_text", OpenErpType.Char)]
		public string DescriptiveText { get; set; }
		[OpenErpMap("in_visible_answer_type", OpenErpType.Boolean)]
		public bool InVisibleAnswerType { get; set; }
		[OpenErpMap("in_visible_menu_choice", OpenErpType.Boolean)]
		public bool InVisibleMenuChoice { get; set; }
		[OpenErpMap("in_visible_rating_weight", OpenErpType.Boolean)]
		public bool InVisibleRatingWeight { get; set; }
		[OpenErpMap("is_comment_require", OpenErpType.Boolean)]
		public bool IsCommentRequire { get; set; }
		[OpenErpMap("is_require_answer", OpenErpType.Boolean)]
		public bool IsRequireAnswer { get; set; }
		[OpenErpMap("is_validation_require", OpenErpType.Boolean)]
		public bool IsValidationRequire { get; set; }
		[OpenErpMap("make_comment_field", OpenErpType.Boolean)]
		public bool MakeCommentField { get; set; }
		[OpenErpMap("make_comment_field_err_msg", OpenErpType.Char)]
		public string MakeCommentFieldErrMsg { get; set; }
		[OpenErpMap("maximum_req_ans", OpenErpType.Integer)]
		public int? MaximumReqAns { get; set; }
		[OpenErpMap("minimum_req_ans", OpenErpType.Integer)]
		public int? MinimumReqAns { get; set; }
		[OpenErpMap("no_of_rows", OpenErpType.Integer)]
		public int? NoOfRows { get; set; }
		[OpenErpMap("numeric_required_sum", OpenErpType.Integer)]
		public int? NumericRequiredSum { get; set; }
		[OpenErpMap("numeric_required_sum_err_msg", OpenErpType.Char)]
		public string NumericRequiredSumErrMsg { get; set; }
		[OpenErpMap("page_id", OpenErpType.Integer)]
		public int? PageId { get; set; }
		[OpenErpMap("question", OpenErpType.Char)]
		public string Question { get; set; }
		[OpenErpMap("rating_allow_one_column_require", OpenErpType.Boolean)]
		public bool RatingAllowOneColumnRequire { get; set; }
		[OpenErpMap("req_ans", OpenErpType.Integer)]
		public int? ReqAns { get; set; }
		[OpenErpMap("req_error_msg", OpenErpType.Char)]
		public string ReqErrorMsg { get; set; }
		[OpenErpMap("required_type", OpenErpType.Selection)]
		public string RequiredType { get; set; }
		[OpenErpMap("sequence", OpenErpType.Integer)]
		public int? Sequence { get; set; }
		[OpenErpMap("survey", OpenErpType.Integer)]
		public int? Survey { get; set; }
		[OpenErpMap("tot_resp", OpenErpType.Float)]
		public double? TotResp { get; set; }
		[OpenErpMap("type", OpenErpType.Selection)]
		public string Type { get; set; }
		[OpenErpMap("validation_maximum_date", OpenErpType.Date)]
		public DateTime? ValidationMaximumDate { get; set; }
		[OpenErpMap("validation_maximum_float", OpenErpType.Float)]
		public double? ValidationMaximumFloat { get; set; }
		[OpenErpMap("validation_maximum_no", OpenErpType.Integer)]
		public int? ValidationMaximumNo { get; set; }
		[OpenErpMap("validation_minimum_date", OpenErpType.Date)]
		public DateTime? ValidationMinimumDate { get; set; }
		[OpenErpMap("validation_minimum_float", OpenErpType.Float)]
		public double? ValidationMinimumFloat { get; set; }
		[OpenErpMap("validation_minimum_no", OpenErpType.Integer)]
		public int? ValidationMinimumNo { get; set; }
		[OpenErpMap("validation_type", OpenErpType.Selection)]
		public string ValidationType { get; set; }
		[OpenErpMap("validation_valid_err_msg", OpenErpType.Char)]
		public string ValidationValidErrMsg { get; set; }
	}

	[OpenErpMap("survey.question.column.heading")]
	public class SurveyQuestionColumnHeading : OpenErpEntityBase {
		[OpenErpMap("in_visible_menu_choice", OpenErpType.Boolean)]
		public bool InVisibleMenuChoice { get; set; }
		[OpenErpMap("in_visible_rating_weight", OpenErpType.Boolean)]
		public bool InVisibleRatingWeight { get; set; }
		[OpenErpMap("menu_choice", OpenErpType.Char)]
		public string MenuChoice { get; set; }
		[OpenErpMap("question_id", OpenErpType.Integer)]
		public int? QuestionId { get; set; }
		[OpenErpMap("rating_weight", OpenErpType.Integer)]
		public int? RatingWeight { get; set; }
		[OpenErpMap("title", OpenErpType.Char)]
		public string Title { get; set; }
	}

	[OpenErpMap("survey.request")]
	public class SurveyRequest : OpenErpEntityBase {
		[OpenErpMap("date_deadline", OpenErpType.Date)]
		public DateTime? DateDeadline { get; set; }
		[OpenErpMap("email", OpenErpType.Char)]
		public string Email { get; set; }
		[OpenErpMap("response", OpenErpType.Integer)]
		public int? Response { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("survey_id", OpenErpType.Integer)]
		public int? SurveyId { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("survey.response")]
	public class SurveyResponse : OpenErpEntityBase {
		[OpenErpMap("date_create", OpenErpType.Datetime)]
		public DateTime? DateCreate { get; set; }
		[OpenErpMap("response_type", OpenErpType.Selection)]
		public string ResponseType { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("survey_id", OpenErpType.Integer)]
		public int? SurveyId { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
	}

	[OpenErpMap("survey.response.answer")]
	public class SurveyResponseAnswer : OpenErpEntityBase {
		[OpenErpMap("answer", OpenErpType.Char)]
		public string Answer { get; set; }
		[OpenErpMap("answer_id", OpenErpType.Integer)]
		public int? AnswerId { get; set; }
		[OpenErpMap("column_id", OpenErpType.Integer)]
		public int? ColumnId { get; set; }
		[OpenErpMap("comment", OpenErpType.Char)]
		public string Comment { get; set; }
		[OpenErpMap("comment_field", OpenErpType.Char)]
		public string CommentField { get; set; }
		[OpenErpMap("response_id", OpenErpType.Integer)]
		public int? ResponseId { get; set; }
		[OpenErpMap("value_choice", OpenErpType.Char)]
		public string ValueChoice { get; set; }
	}

	[OpenErpMap("survey.response.line")]
	public class SurveyResponseLine : OpenErpEntityBase {
		[OpenErpMap("comment", OpenErpType.Char)]
		public string Comment { get; set; }
		[OpenErpMap("date_create", OpenErpType.Datetime)]
		public DateTime? DateCreate { get; set; }
		[OpenErpMap("page_id", OpenErpType.Integer)]
		public int? PageId { get; set; }
		[OpenErpMap("question_id", OpenErpType.Integer)]
		public int? QuestionId { get; set; }
		[OpenErpMap("response_id", OpenErpType.Integer)]
		public int? ResponseId { get; set; }
		[OpenErpMap("single_text", OpenErpType.Char)]
		public string SingleText { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
	}

	[OpenErpMap("survey.tbl.column.heading")]
	public class SurveyTblColumnHeading : OpenErpEntityBase {
		[OpenErpMap("column_id", OpenErpType.Integer)]
		public int? ColumnId { get; set; }
		[OpenErpMap("name", OpenErpType.Integer)]
		public int? Name { get; set; }
		[OpenErpMap("response_table_id", OpenErpType.Integer)]
		public int? ResponseTableId { get; set; }
		[OpenErpMap("value", OpenErpType.Char)]
		public string Value { get; set; }
	}

	[OpenErpMap("survey.type")]
	public class SurveyType : OpenErpEntityBase {
		[OpenErpMap("code", OpenErpType.Char)]
		public string Code { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
	}

	[OpenErpMap("task.by.days")]
	public class TaskByDays : OpenErpEntityBase {
		[OpenErpMap("day", OpenErpType.Char)]
		public string Day { get; set; }
		[OpenErpMap("project_id", OpenErpType.Integer)]
		public int? ProjectId { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("total_task", OpenErpType.Float)]
		public double? TotalTask { get; set; }
	}

	[OpenErpMap("temp.range")]
	public class TempRange : OpenErpEntityBase {
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
	}

	[OpenErpMap("timesheet.report")]
	public class TimesheetReport : OpenErpEntityBase {
		[OpenErpMap("account_id", OpenErpType.Integer)]
		public int? AccountId { get; set; }
		[OpenErpMap("company_id", OpenErpType.Integer)]
		public int? CompanyId { get; set; }
		[OpenErpMap("cost", OpenErpType.Float)]
		public double? Cost { get; set; }
		[OpenErpMap("date_current", OpenErpType.Date)]
		public DateTime? DateCurrent { get; set; }
		[OpenErpMap("date_from", OpenErpType.Date)]
		public DateTime? DateFrom { get; set; }
		[OpenErpMap("date_to", OpenErpType.Date)]
		public DateTime? DateTo { get; set; }
		[OpenErpMap("day", OpenErpType.Char)]
		public string Day { get; set; }
		[OpenErpMap("department_id", OpenErpType.Integer)]
		public int? DepartmentId { get; set; }
		[OpenErpMap("general_account_id", OpenErpType.Integer)]
		public int? GeneralAccountId { get; set; }
		[OpenErpMap("month", OpenErpType.Selection)]
		public string Month { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("nbr", OpenErpType.Integer)]
		public int? Nbr { get; set; }
		[OpenErpMap("product_id", OpenErpType.Integer)]
		public int? ProductId { get; set; }
		[OpenErpMap("quantity", OpenErpType.Float)]
		public double? Quantity { get; set; }
		[OpenErpMap("state", OpenErpType.Selection)]
		public string State { get; set; }
		[OpenErpMap("to_invoice", OpenErpType.Integer)]
		public int? ToInvoice { get; set; }
		[OpenErpMap("total_attendance", OpenErpType.Float)]
		public double? TotalAttendance { get; set; }
		[OpenErpMap("total_diff", OpenErpType.Float)]
		public double? TotalDiff { get; set; }
		[OpenErpMap("total_timesheet", OpenErpType.Float)]
		public double? TotalTimesheet { get; set; }
		[OpenErpMap("user_id", OpenErpType.Integer)]
		public int? UserId { get; set; }
		[OpenErpMap("year", OpenErpType.Char)]
		public string Year { get; set; }
	}

	[OpenErpMap("workflow")]
	public class Workflow : OpenErpEntityBase {
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("on_create", OpenErpType.Boolean)]
		public bool OnCreate { get; set; }
		[OpenErpMap("osv", OpenErpType.Char)]
		public string Osv { get; set; }
	}

	[OpenErpMap("workflow.activity")]
	public class WorkflowActivity : OpenErpEntityBase {
		[OpenErpMap("action", OpenErpType.Char)]
		public string Action { get; set; }
		[OpenErpMap("action_id", OpenErpType.Integer)]
		public int? ActionId { get; set; }
		[OpenErpMap("flow_start", OpenErpType.Boolean)]
		public bool FlowStart { get; set; }
		[OpenErpMap("flow_stop", OpenErpType.Boolean)]
		public bool FlowStop { get; set; }
		[OpenErpMap("join_mode", OpenErpType.Selection)]
		public string JoinMode { get; set; }
		[OpenErpMap("kind", OpenErpType.Selection)]
		public string Kind { get; set; }
		[OpenErpMap("name", OpenErpType.Char)]
		public string Name { get; set; }
		[OpenErpMap("signal_send", OpenErpType.Char)]
		public string SignalSend { get; set; }
		[OpenErpMap("split_mode", OpenErpType.Selection)]
		public string SplitMode { get; set; }
		[OpenErpMap("subflow_id", OpenErpType.Integer)]
		public int? SubflowId { get; set; }
		[OpenErpMap("wkf_id", OpenErpType.Integer)]
		public int? WkfId { get; set; }
	}

	[OpenErpMap("workflow.instance")]
	public class WorkflowInstance : OpenErpEntityBase {
		[OpenErpMap("res_id", OpenErpType.Integer)]
		public int? ResId { get; set; }
		[OpenErpMap("res_type", OpenErpType.Char)]
		public string ResType { get; set; }
		[OpenErpMap("state", OpenErpType.Char)]
		public string State { get; set; }
		[OpenErpMap("wkf_id", OpenErpType.Integer)]
		public int? WkfId { get; set; }
	}

	[OpenErpMap("workflow.transition")]
	public class WorkflowTransition : OpenErpEntityBase {
		[OpenErpMap("act_from", OpenErpType.Integer)]
		public int? ActFrom { get; set; }
		[OpenErpMap("act_to", OpenErpType.Integer)]
		public int? ActTo { get; set; }
		[OpenErpMap("condition", OpenErpType.Char)]
		public string Condition { get; set; }
		[OpenErpMap("group_id", OpenErpType.Integer)]
		public int? GroupId { get; set; }
		[OpenErpMap("signal", OpenErpType.Char)]
		public string Signal { get; set; }
		[OpenErpMap("trigger_expr_id", OpenErpType.Char)]
		public string TriggerExprId { get; set; }
		[OpenErpMap("trigger_model", OpenErpType.Char)]
		public string TriggerModel { get; set; }
		[OpenErpMap("wkf_id", OpenErpType.Integer)]
		public int? WkfId { get; set; }
	}

	[OpenErpMap("workflow.triggers")]
	public class WorkflowTriggers : OpenErpEntityBase {
		[OpenErpMap("instance_id", OpenErpType.Integer)]
		public int? InstanceId { get; set; }
		[OpenErpMap("model", OpenErpType.Char)]
		public string Model { get; set; }
		[OpenErpMap("res_id", OpenErpType.Integer)]
		public int? ResId { get; set; }
		[OpenErpMap("workitem_id", OpenErpType.Integer)]
		public int? WorkitemId { get; set; }
	}

	[OpenErpMap("workflow.workitem")]
	public class WorkflowWorkitem : OpenErpEntityBase {
		[OpenErpMap("act_id", OpenErpType.Integer)]
		public int? ActId { get; set; }
		[OpenErpMap("inst_id", OpenErpType.Integer)]
		public int? InstId { get; set; }
		[OpenErpMap("state", OpenErpType.Char)]
		public string State { get; set; }
		[OpenErpMap("subflow_id", OpenErpType.Integer)]
		public int? SubflowId { get; set; }
		[OpenErpMap("wkf_id", OpenErpType.Integer)]
		public int? WkfId { get; set; }
	}

}
