
using System;
using System.Collections.Generic;

namespace Jlob.OpenErpNet.Templates{

	public class account_account{

		public int id {get; set;}
		public bool active {get; set;}
		public double? adjusted_balance {get; set;}
		public double? balance {get; set;}
		public ICollection<account_account> child_consol_ids {get; set;}
		public ICollection<account_account> child_id {get; set;}
		public ICollection<account_account> child_parent_ids {get; set;}
		public string code {get; set;}
		public int? company_currency_id {get; set;}
		public int? company_id {get; set;}
		public double? credit {get; set;}
		public int? currency_id {get; set;}
		public String currency_mode {get; set;}
		public double? debit {get; set;}
		public double? exchange_rate {get; set;}
		public ICollection<account_financial_report> financial_report_ids {get; set;}
		public double? foreign_balance {get; set;}
		public int? level {get; set;}
		public string name {get; set;}
		public string note {get; set;}
		public int? parent_id {get; set;}
		public int? parent_left {get; set;}
		public int? parent_right {get; set;}
		public bool reconcile {get; set;}
		public string shortcut {get; set;}
		public ICollection<account_tax> tax_ids {get; set;}
		public String type {get; set;}
		public double? unrealized_gain_loss {get; set;}
		public int? user_type {get; set;}
		[OpenErpForeignKey("company_currency_id")]
		public res_currency CompanyCurrency {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("currency_id")]
		public res_currency Currency {get; set;}
		[OpenErpForeignKey("parent_id")]
		public account_account Parent {get; set;}
		[OpenErpForeignKey("user_type")]
		public account_account_type UserType {get; set;}
	}

	public class account_account_template{

		public int id {get; set;}
		public int? chart_template_id {get; set;}
		public ICollection<account_account_template> child_parent_ids {get; set;}
		public string code {get; set;}
		public int? currency_id {get; set;}
		public ICollection<account_financial_report> financial_report_ids {get; set;}
		public string name {get; set;}
		public bool nocreate {get; set;}
		public string note {get; set;}
		public int? parent_id {get; set;}
		public bool reconcile {get; set;}
		public string shortcut {get; set;}
		public ICollection<account_tax_template> tax_ids {get; set;}
		public String type {get; set;}
		public int? user_type {get; set;}
		[OpenErpForeignKey("chart_template_id")]
		public account_chart_template ChartTemplate {get; set;}
		[OpenErpForeignKey("currency_id")]
		public res_currency Currency {get; set;}
		[OpenErpForeignKey("parent_id")]
		public account_account_template Parent {get; set;}
		[OpenErpForeignKey("user_type")]
		public account_account_type UserType {get; set;}
	}

	public class account_account_type{

		public int id {get; set;}
		public String close_method {get; set;}
		public string code {get; set;}
		public string name {get; set;}
		public string note {get; set;}
		public String report_type {get; set;}
	}

	public class account_analytic_account{

		public int id {get; set;}
		public double? balance {get; set;}
		public ICollection<account_analytic_account> child_complete_ids {get; set;}
		public ICollection<account_analytic_account> child_ids {get; set;}
		public string code {get; set;}
		public int? company_id {get; set;}
		public string complete_name {get; set;}
		public double? credit {get; set;}
		public int? currency_id {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date_start {get; set;}
		public double? debit {get; set;}
		public string description {get; set;}
		public ICollection<account_analytic_line> line_ids {get; set;}
		public int? manager_id {get; set;}
		public ICollection<res_partner> message_follower_ids {get; set;}
		public ICollection<mail_message> message_ids {get; set;}
		public bool message_is_follower {get; set;}
		public string message_summary {get; set;}
		public bool message_unread {get; set;}
		public string name {get; set;}
		public int? parent_id {get; set;}
		public int? partner_id {get; set;}
		public double? quantity {get; set;}
		public double? quantity_max {get; set;}
		public String state {get; set;}
		public int? template_id {get; set;}
		public String type {get; set;}
		public int? user_id {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("currency_id")]
		public res_currency Currency {get; set;}
		[OpenErpForeignKey("manager_id")]
		public res_users Manager {get; set;}
		[OpenErpForeignKey("parent_id")]
		public account_analytic_account Parent {get; set;}
		[OpenErpForeignKey("partner_id")]
		public res_partner Partner {get; set;}
		[OpenErpForeignKey("template_id")]
		public account_analytic_account Template {get; set;}
		[OpenErpForeignKey("user_id")]
		public res_users User {get; set;}
	}

	public class account_analytic_journal{

		public int id {get; set;}
		public bool active {get; set;}
		public string code {get; set;}
		public int? company_id {get; set;}
		public ICollection<account_analytic_line> line_ids {get; set;}
		public string name {get; set;}
		public String type {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
	}

	public class account_analytic_line{

		public int id {get; set;}
		public int account_id {get; set;}
		public double amount {get; set;}
		public double? amount_currency {get; set;}
		public string code {get; set;}
		public int? company_id {get; set;}
		public int? currency_id {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime date {get; set;}
		public int? general_account_id {get; set;}
		public int? journal_id {get; set;}
		public int? move_id {get; set;}
		public string name {get; set;}
		public int? product_id {get; set;}
		public int? product_uom_id {get; set;}
		public string Ref {get; set;}
		public double? unit_amount {get; set;}
		public int? user_id {get; set;}
		[OpenErpForeignKey("account_id")]
		public account_analytic_account Account {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("currency_id")]
		public res_currency Currency {get; set;}
		[OpenErpForeignKey("general_account_id")]
		public account_account GeneralAccount {get; set;}
		[OpenErpForeignKey("journal_id")]
		public account_analytic_journal Journal {get; set;}
		[OpenErpForeignKey("move_id")]
		public account_move_line Move {get; set;}
		[OpenErpForeignKey("product_id")]
		public product_product Product {get; set;}
		[OpenErpForeignKey("product_uom_id")]
		public product_uom ProductUom {get; set;}
		[OpenErpForeignKey("user_id")]
		public res_users User {get; set;}
	}

	public class account_bank_statement{

		public int id {get; set;}
		public int? account_id {get; set;}
		public double? balance_end {get; set;}
		public double? balance_end_real {get; set;}
		public double? balance_start {get; set;}
		[OpenErpMap(OpenErpType.Datetime)]
		public DateTime? closing_date {get; set;}
		public ICollection<account_cashbox_line> closing_details_ids {get; set;}
		public int? company_id {get; set;}
		public int? currency {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime date {get; set;}
		public ICollection<account_cashbox_line> details_ids {get; set;}
		public double? difference {get; set;}
		public int journal_id {get; set;}
		public double? last_closing_balance {get; set;}
		public ICollection<account_bank_statement_line> line_ids {get; set;}
		public ICollection<res_partner> message_follower_ids {get; set;}
		public ICollection<mail_message> message_ids {get; set;}
		public bool message_is_follower {get; set;}
		public string message_summary {get; set;}
		public bool message_unread {get; set;}
		public ICollection<account_move_line> move_line_ids {get; set;}
		public string name {get; set;}
		public ICollection<account_cashbox_line> opening_details_ids {get; set;}
		public int period_id {get; set;}
		public String state {get; set;}
		public double? total_entry_encoding {get; set;}
		public int? user_id {get; set;}
		[OpenErpForeignKey("account_id")]
		public account_account Account {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("currency")]
		public res_currency Currency {get; set;}
		[OpenErpForeignKey("journal_id")]
		public account_journal Journal {get; set;}
		[OpenErpForeignKey("period_id")]
		public account_period Period {get; set;}
		[OpenErpForeignKey("user_id")]
		public res_users User {get; set;}
	}

	public class account_bank_statement_line{

		public int id {get; set;}
		public int account_id {get; set;}
		public double? amount {get; set;}
		public double? amount_reconciled {get; set;}
		public int? analytic_account_id {get; set;}
		public int? company_id {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime date {get; set;}
		public int? journal_id {get; set;}
		public ICollection<account_move> move_ids {get; set;}
		public string name {get; set;}
		public string note {get; set;}
		public int? partner_id {get; set;}
		public string Ref {get; set;}
		public int? sequence {get; set;}
		public int statement_id {get; set;}
		public String type {get; set;}
		public int? voucher_id {get; set;}
		[OpenErpForeignKey("account_id")]
		public account_account Account {get; set;}
		[OpenErpForeignKey("analytic_account_id")]
		public account_analytic_account AnalyticAccount {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("journal_id")]
		public account_journal Journal {get; set;}
		[OpenErpForeignKey("partner_id")]
		public res_partner Partner {get; set;}
		[OpenErpForeignKey("statement_id")]
		public account_bank_statement Statement {get; set;}
		[OpenErpForeignKey("voucher_id")]
		public account_voucher Voucher {get; set;}
	}

	public class account_cashbox_line{

		public int id {get; set;}
		public int? bank_statement_id {get; set;}
		public int? number_closing {get; set;}
		public int? number_opening {get; set;}
		public double? pieces {get; set;}
		public double? subtotal_closing {get; set;}
		public double? subtotal_opening {get; set;}
		[OpenErpForeignKey("bank_statement_id")]
		public account_bank_statement BankStatement {get; set;}
	}

	public class account_chart_template{

		public int id {get; set;}
		public int? account_root_id {get; set;}
		public int? bank_account_view_id {get; set;}
		public int? code_digits {get; set;}
		public bool complete_tax_set {get; set;}
		public string name {get; set;}
		public int? parent_id {get; set;}
		public int? property_account_expense {get; set;}
		public int? property_account_expense_categ {get; set;}
		public int? property_account_expense_opening {get; set;}
		public int? property_account_income {get; set;}
		public int? property_account_income_categ {get; set;}
		public int? property_account_income_opening {get; set;}
		public int? property_account_payable {get; set;}
		public int? property_account_receivable {get; set;}
		public int? tax_code_root_id {get; set;}
		public ICollection<account_tax_template> tax_template_ids {get; set;}
		public bool visible {get; set;}
		[OpenErpForeignKey("account_root_id")]
		public account_account_template AccountRoot {get; set;}
		[OpenErpForeignKey("bank_account_view_id")]
		public account_account_template BankAccountView {get; set;}
		[OpenErpForeignKey("parent_id")]
		public account_chart_template Parent {get; set;}
		[OpenErpForeignKey("property_account_expense")]
		public account_account_template PropertyAccountExpense {get; set;}
		[OpenErpForeignKey("property_account_expense_categ")]
		public account_account_template PropertyAccountExpenseCateg {get; set;}
		[OpenErpForeignKey("property_account_expense_opening")]
		public account_account_template PropertyAccountExpenseOpening {get; set;}
		[OpenErpForeignKey("property_account_income")]
		public account_account_template PropertyAccountIncome {get; set;}
		[OpenErpForeignKey("property_account_income_categ")]
		public account_account_template PropertyAccountIncomeCateg {get; set;}
		[OpenErpForeignKey("property_account_income_opening")]
		public account_account_template PropertyAccountIncomeOpening {get; set;}
		[OpenErpForeignKey("property_account_payable")]
		public account_account_template PropertyAccountPayable {get; set;}
		[OpenErpForeignKey("property_account_receivable")]
		public account_account_template PropertyAccountReceivable {get; set;}
		[OpenErpForeignKey("tax_code_root_id")]
		public account_tax_code_template TaxCodeRoot {get; set;}
	}

	public class account_entries_report{

		public int id {get; set;}
		public int? account_id {get; set;}
		public double? amount_currency {get; set;}
		public int? analytic_account_id {get; set;}
		public double? balance {get; set;}
		public int? company_id {get; set;}
		public double? credit {get; set;}
		public int? currency_id {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date_created {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date_maturity {get; set;}
		public string day {get; set;}
		public double? debit {get; set;}
		public int? fiscalyear_id {get; set;}
		public int? journal_id {get; set;}
		public String month {get; set;}
		public String move_line_state {get; set;}
		public String move_state {get; set;}
		public int? nbr {get; set;}
		public int? partner_id {get; set;}
		public int? period_id {get; set;}
		public int? product_id {get; set;}
		public int? product_uom_id {get; set;}
		public double? quantity {get; set;}
		public int? reconcile_id {get; set;}
		public string Ref {get; set;}
		public String type {get; set;}
		public int? user_type {get; set;}
		public string year {get; set;}
		[OpenErpForeignKey("account_id")]
		public account_account Account {get; set;}
		[OpenErpForeignKey("analytic_account_id")]
		public account_analytic_account AnalyticAccount {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("currency_id")]
		public res_currency Currency {get; set;}
		[OpenErpForeignKey("fiscalyear_id")]
		public account_fiscalyear Fiscalyear {get; set;}
		[OpenErpForeignKey("journal_id")]
		public account_journal Journal {get; set;}
		[OpenErpForeignKey("partner_id")]
		public res_partner Partner {get; set;}
		[OpenErpForeignKey("period_id")]
		public account_period Period {get; set;}
		[OpenErpForeignKey("product_id")]
		public product_product Product {get; set;}
		[OpenErpForeignKey("product_uom_id")]
		public product_uom ProductUom {get; set;}
		[OpenErpForeignKey("reconcile_id")]
		public account_move_reconcile Reconcile {get; set;}
		[OpenErpForeignKey("user_type")]
		public account_account_type UserType {get; set;}
	}

	public class account_financial_report{

		public int id {get; set;}
		public ICollection<account_account> account_ids {get; set;}
		public int? account_report_id {get; set;}
		public ICollection<account_account_type> account_type_ids {get; set;}
		public double? balance {get; set;}
		public ICollection<account_financial_report> children_ids {get; set;}
		public double? credit {get; set;}
		public double? debit {get; set;}
		public String display_detail {get; set;}
		public int? level {get; set;}
		public string name {get; set;}
		public int? parent_id {get; set;}
		public int? sequence {get; set;}
		public String sign {get; set;}
		public String style_overwrite {get; set;}
		public String type {get; set;}
		[OpenErpForeignKey("account_report_id")]
		public account_financial_report AccountReport {get; set;}
		[OpenErpForeignKey("parent_id")]
		public account_financial_report Parent {get; set;}
	}

	public class account_fiscal_position{

		public int id {get; set;}
		public ICollection<account_fiscal_position_account> account_ids {get; set;}
		public bool active {get; set;}
		public int? company_id {get; set;}
		public string name {get; set;}
		public string note {get; set;}
		public ICollection<account_fiscal_position_tax> tax_ids {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
	}

	public class account_fiscal_position_account{

		public int id {get; set;}
		public int? account_dest_id {get; set;}
		public int? account_src_id {get; set;}
		public int? position_id {get; set;}
		[OpenErpForeignKey("account_dest_id")]
		public account_account AccountDest {get; set;}
		[OpenErpForeignKey("account_src_id")]
		public account_account AccountSrc {get; set;}
		[OpenErpForeignKey("position_id")]
		public account_fiscal_position Position {get; set;}
	}

	public class account_fiscal_position_account_template{

		public int id {get; set;}
		public int? account_dest_id {get; set;}
		public int? account_src_id {get; set;}
		public int? position_id {get; set;}
		[OpenErpForeignKey("account_dest_id")]
		public account_account_template AccountDest {get; set;}
		[OpenErpForeignKey("account_src_id")]
		public account_account_template AccountSrc {get; set;}
		[OpenErpForeignKey("position_id")]
		public account_fiscal_position_template Position {get; set;}
	}

	public class account_fiscal_position_tax{

		public int id {get; set;}
		public int? position_id {get; set;}
		public int? tax_dest_id {get; set;}
		public int? tax_src_id {get; set;}
		[OpenErpForeignKey("position_id")]
		public account_fiscal_position Position {get; set;}
		[OpenErpForeignKey("tax_dest_id")]
		public account_tax TaxDest {get; set;}
		[OpenErpForeignKey("tax_src_id")]
		public account_tax TaxSrc {get; set;}
	}

	public class account_fiscal_position_tax_template{

		public int id {get; set;}
		public int? position_id {get; set;}
		public int? tax_dest_id {get; set;}
		public int? tax_src_id {get; set;}
		[OpenErpForeignKey("position_id")]
		public account_fiscal_position_template Position {get; set;}
		[OpenErpForeignKey("tax_dest_id")]
		public account_tax_template TaxDest {get; set;}
		[OpenErpForeignKey("tax_src_id")]
		public account_tax_template TaxSrc {get; set;}
	}

	public class account_fiscal_position_template{

		public int id {get; set;}
		public ICollection<account_fiscal_position_account_template> account_ids {get; set;}
		public int? chart_template_id {get; set;}
		public string name {get; set;}
		public string note {get; set;}
		public ICollection<account_fiscal_position_tax_template> tax_ids {get; set;}
		[OpenErpForeignKey("chart_template_id")]
		public account_chart_template ChartTemplate {get; set;}
	}

	public class account_fiscalyear{

		public int id {get; set;}
		public string code {get; set;}
		public int? company_id {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date_start {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date_stop {get; set;}
		public int? end_journal_period_id {get; set;}
		public string name {get; set;}
		public ICollection<account_period> period_ids {get; set;}
		public String state {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("end_journal_period_id")]
		public account_journal_period EndJournalPeriod {get; set;}
	}

	public class account_invoice{

		public int id {get; set;}
		public int account_id {get; set;}
		public double? amount_tax {get; set;}
		public double? amount_total {get; set;}
		public double? amount_untaxed {get; set;}
		public double? check_total {get; set;}
		public string comment {get; set;}
		public int? commercial_partner_id {get; set;}
		public int company_id {get; set;}
		public int currency_id {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date_due {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date_invoice {get; set;}
		public int? fiscal_position {get; set;}
		public string internal_number {get; set;}
		public ICollection<account_invoice_line> invoice_line {get; set;}
		public int journal_id {get; set;}
		public ICollection<res_partner> message_follower_ids {get; set;}
		public ICollection<mail_message> message_ids {get; set;}
		public bool message_is_follower {get; set;}
		public string message_summary {get; set;}
		public bool message_unread {get; set;}
		public int? move_id {get; set;}
		public ICollection<account_move_line> move_lines {get; set;}
		public string move_name {get; set;}
		public string name {get; set;}
		public string number {get; set;}
		public string origin {get; set;}
		public int? partner_bank_id {get; set;}
		public int partner_id {get; set;}
		public ICollection<account_move_line> payment_ids {get; set;}
		public int? payment_term {get; set;}
		public string paypal_url {get; set;}
		public int? period_id {get; set;}
		public object portal_payment_options {get; set;}
		public bool reconciled {get; set;}
		public string reference {get; set;}
		public String reference_type {get; set;}
		public double? residual {get; set;}
		public bool sent {get; set;}
		public String state {get; set;}
		public string supplier_invoice_number {get; set;}
		public ICollection<account_invoice_tax> tax_line {get; set;}
		public String type {get; set;}
		public int? user_id {get; set;}
		[OpenErpForeignKey("account_id")]
		public account_account Account {get; set;}
		[OpenErpForeignKey("commercial_partner_id")]
		public res_partner CommercialPartner {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("currency_id")]
		public res_currency Currency {get; set;}
		[OpenErpForeignKey("fiscal_position")]
		public account_fiscal_position FiscalPosition {get; set;}
		[OpenErpForeignKey("journal_id")]
		public account_journal Journal {get; set;}
		[OpenErpForeignKey("move_id")]
		public account_move Move {get; set;}
		[OpenErpForeignKey("partner_bank_id")]
		public res_partner_bank PartnerBank {get; set;}
		[OpenErpForeignKey("partner_id")]
		public res_partner Partner {get; set;}
		[OpenErpForeignKey("payment_term")]
		public account_payment_term PaymentTerm {get; set;}
		[OpenErpForeignKey("period_id")]
		public account_period Period {get; set;}
		[OpenErpForeignKey("user_id")]
		public res_users User {get; set;}
	}

	public class account_invoice_line{

		public int id {get; set;}
		public int? account_analytic_id {get; set;}
		public int? account_id {get; set;}
		public int? company_id {get; set;}
		public double? discount {get; set;}
		public int? invoice_id {get; set;}
		public ICollection<account_tax> invoice_line_tax_id {get; set;}
		public string name {get; set;}
		public string origin {get; set;}
		public int? partner_id {get; set;}
		public double? price_subtotal {get; set;}
		public double? price_unit {get; set;}
		public int? product_id {get; set;}
		public double? quantity {get; set;}
		public int? sequence {get; set;}
		public int? uos_id {get; set;}
		[OpenErpForeignKey("account_analytic_id")]
		public account_analytic_account AccountAnalytic {get; set;}
		[OpenErpForeignKey("account_id")]
		public account_account Account {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("invoice_id")]
		public account_invoice Invoice {get; set;}
		[OpenErpForeignKey("partner_id")]
		public res_partner Partner {get; set;}
		[OpenErpForeignKey("product_id")]
		public product_product Product {get; set;}
		[OpenErpForeignKey("uos_id")]
		public product_uom Uos {get; set;}
	}

	public class account_invoice_report{

		public int id {get; set;}
		public int? account_id {get; set;}
		public int? account_line_id {get; set;}
		public int? categ_id {get; set;}
		public int? commercial_partner_id {get; set;}
		public int? company_id {get; set;}
		public int? currency_id {get; set;}
		public double? currency_rate {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date_due {get; set;}
		public string day {get; set;}
		public int? fiscal_position {get; set;}
		public int? journal_id {get; set;}
		public String month {get; set;}
		public int? nbr {get; set;}
		public int? partner_bank_id {get; set;}
		public int? partner_id {get; set;}
		public int? payment_term {get; set;}
		public int? period_id {get; set;}
		public double? price_average {get; set;}
		public double? price_total {get; set;}
		public int? product_id {get; set;}
		public double? product_qty {get; set;}
		public double? residual {get; set;}
		public String state {get; set;}
		public String type {get; set;}
		public string uom_name {get; set;}
		public double? user_currency_price_average {get; set;}
		public double? user_currency_price_total {get; set;}
		public double? user_currency_residual {get; set;}
		public int? user_id {get; set;}
		public string year {get; set;}
		[OpenErpForeignKey("account_id")]
		public account_account Account {get; set;}
		[OpenErpForeignKey("account_line_id")]
		public account_account AccountLine {get; set;}
		[OpenErpForeignKey("categ_id")]
		public product_category Categ {get; set;}
		[OpenErpForeignKey("commercial_partner_id")]
		public res_partner CommercialPartner {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("currency_id")]
		public res_currency Currency {get; set;}
		[OpenErpForeignKey("fiscal_position")]
		public account_fiscal_position FiscalPosition {get; set;}
		[OpenErpForeignKey("journal_id")]
		public account_journal Journal {get; set;}
		[OpenErpForeignKey("partner_bank_id")]
		public res_partner_bank PartnerBank {get; set;}
		[OpenErpForeignKey("partner_id")]
		public res_partner Partner {get; set;}
		[OpenErpForeignKey("payment_term")]
		public account_payment_term PaymentTerm {get; set;}
		[OpenErpForeignKey("period_id")]
		public account_period Period {get; set;}
		[OpenErpForeignKey("product_id")]
		public product_product Product {get; set;}
		[OpenErpForeignKey("user_id")]
		public res_users User {get; set;}
	}

	public class account_invoice_tax{

		public int id {get; set;}
		public int? account_analytic_id {get; set;}
		public int? account_id {get; set;}
		public double? amount {get; set;}
		public double? Base {get; set;}
		public double? base_amount {get; set;}
		public int? base_code_id {get; set;}
		public int? company_id {get; set;}
		public double? factor_base {get; set;}
		public double? factor_tax {get; set;}
		public int? invoice_id {get; set;}
		public bool manual {get; set;}
		public string name {get; set;}
		public int? sequence {get; set;}
		public double? tax_amount {get; set;}
		public int? tax_code_id {get; set;}
		[OpenErpForeignKey("account_analytic_id")]
		public account_analytic_account AccountAnalytic {get; set;}
		[OpenErpForeignKey("account_id")]
		public account_account Account {get; set;}
		[OpenErpForeignKey("base_code_id")]
		public account_tax_code BaseCode {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("invoice_id")]
		public account_invoice Invoice {get; set;}
		[OpenErpForeignKey("tax_code_id")]
		public account_tax_code TaxCode {get; set;}
	}

	public class account_journal{

		public int id {get; set;}
		public ICollection<account_account> account_control_ids {get; set;}
		public bool allow_date {get; set;}
		public int? analytic_journal_id {get; set;}
		public ICollection<account_journal_cashbox_line> cashbox_line_ids {get; set;}
		public bool cash_control {get; set;}
		public bool centralisation {get; set;}
		public string code {get; set;}
		public int? company_id {get; set;}
		public int? currency {get; set;}
		public int? default_credit_account_id {get; set;}
		public int? default_debit_account_id {get; set;}
		public bool entry_posted {get; set;}
		public bool group_invoice_lines {get; set;}
		public ICollection<res_groups> groups_id {get; set;}
		public int? internal_account_id {get; set;}
		public int? loss_account_id {get; set;}
		public string name {get; set;}
		public int? profit_account_id {get; set;}
		public int? sequence_id {get; set;}
		public String type {get; set;}
		public ICollection<account_account_type> type_control_ids {get; set;}
		public bool update_posted {get; set;}
		public int? user_id {get; set;}
		public bool with_last_closing_balance {get; set;}
		[OpenErpForeignKey("analytic_journal_id")]
		public account_analytic_journal AnalyticJournal {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("currency")]
		public res_currency Currency {get; set;}
		[OpenErpForeignKey("default_credit_account_id")]
		public account_account DefaultCreditAccount {get; set;}
		[OpenErpForeignKey("default_debit_account_id")]
		public account_account DefaultDebitAccount {get; set;}
		[OpenErpForeignKey("internal_account_id")]
		public account_account InternalAccount {get; set;}
		[OpenErpForeignKey("loss_account_id")]
		public account_account LossAccount {get; set;}
		[OpenErpForeignKey("profit_account_id")]
		public account_account ProfitAccount {get; set;}
		[OpenErpForeignKey("sequence_id")]
		public ir_sequence Sequence {get; set;}
		[OpenErpForeignKey("user_id")]
		public res_users User {get; set;}
	}

	public class account_journal_cashbox_line{

		public int id {get; set;}
		public int? journal_id {get; set;}
		public double? pieces {get; set;}
		[OpenErpForeignKey("journal_id")]
		public account_journal Journal {get; set;}
	}

	public class account_journal_period{

		public int id {get; set;}
		public bool active {get; set;}
		public int? company_id {get; set;}
		public int? fiscalyear_id {get; set;}
		public string icon {get; set;}
		public int? journal_id {get; set;}
		public string name {get; set;}
		public int? period_id {get; set;}
		public String state {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("fiscalyear_id")]
		public account_fiscalyear Fiscalyear {get; set;}
		[OpenErpForeignKey("journal_id")]
		public account_journal Journal {get; set;}
		[OpenErpForeignKey("period_id")]
		public account_period Period {get; set;}
	}

	public class account_model{

		public int id {get; set;}
		public int? company_id {get; set;}
		public int? journal_id {get; set;}
		public string legend {get; set;}
		public ICollection<account_model_line> lines_id {get; set;}
		public string name {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("journal_id")]
		public account_journal Journal {get; set;}
	}

	public class account_model_line{

		public int id {get; set;}
		public int? account_id {get; set;}
		public double? amount_currency {get; set;}
		public int? analytic_account_id {get; set;}
		public double? credit {get; set;}
		public int? currency_id {get; set;}
		public String date_maturity {get; set;}
		public double? debit {get; set;}
		public int? model_id {get; set;}
		public string name {get; set;}
		public int? partner_id {get; set;}
		public double? quantity {get; set;}
		public int? sequence {get; set;}
		[OpenErpForeignKey("account_id")]
		public account_account Account {get; set;}
		[OpenErpForeignKey("analytic_account_id")]
		public account_analytic_account AnalyticAccount {get; set;}
		[OpenErpForeignKey("currency_id")]
		public res_currency Currency {get; set;}
		[OpenErpForeignKey("model_id")]
		public account_model Model {get; set;}
		[OpenErpForeignKey("partner_id")]
		public res_partner Partner {get; set;}
	}

	public class account_move{

		public int id {get; set;}
		public double? amount {get; set;}
		public double? balance {get; set;}
		public int? company_id {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date {get; set;}
		public int? journal_id {get; set;}
		public ICollection<account_move_line> line_id {get; set;}
		public string name {get; set;}
		public string narration {get; set;}
		public int? partner_id {get; set;}
		public int? period_id {get; set;}
		public string Ref {get; set;}
		public String state {get; set;}
		public bool to_check {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("journal_id")]
		public account_journal Journal {get; set;}
		[OpenErpForeignKey("partner_id")]
		public res_partner Partner {get; set;}
		[OpenErpForeignKey("period_id")]
		public account_period Period {get; set;}
	}

	public class account_move_line{

		public int id {get; set;}
		public int? account_id {get; set;}
		public int? account_tax_id {get; set;}
		public double? amount_currency {get; set;}
		public double? amount_residual {get; set;}
		public double? amount_residual_currency {get; set;}
		public int? analytic_account_id {get; set;}
		public ICollection<account_analytic_line> analytic_lines {get; set;}
		public double? balance {get; set;}
		public bool blocked {get; set;}
		public String centralisation {get; set;}
		public int? company_id {get; set;}
		public double? credit {get; set;}
		public int? currency_id {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date_created {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date_maturity {get; set;}
		public double? debit {get; set;}
		public int? invoice {get; set;}
		public int? journal_id {get; set;}
		public int? move_id {get; set;}
		public string name {get; set;}
		public string narration {get; set;}
		public int? partner_id {get; set;}
		public int? period_id {get; set;}
		public int? product_id {get; set;}
		public int? product_uom_id {get; set;}
		public double? quantity {get; set;}
		public string reconcile {get; set;}
		public int? reconcile_id {get; set;}
		public int? reconcile_partial_id {get; set;}
		public string Ref {get; set;}
		public String state {get; set;}
		public int? statement_id {get; set;}
		public double? tax_amount {get; set;}
		public int? tax_code_id {get; set;}
		[OpenErpForeignKey("account_id")]
		public account_account Account {get; set;}
		[OpenErpForeignKey("account_tax_id")]
		public account_tax AccountTax {get; set;}
		[OpenErpForeignKey("analytic_account_id")]
		public account_analytic_account AnalyticAccount {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("currency_id")]
		public res_currency Currency {get; set;}
		[OpenErpForeignKey("invoice")]
		public account_invoice Invoice {get; set;}
		[OpenErpForeignKey("journal_id")]
		public account_journal Journal {get; set;}
		[OpenErpForeignKey("move_id")]
		public account_move Move {get; set;}
		[OpenErpForeignKey("partner_id")]
		public res_partner Partner {get; set;}
		[OpenErpForeignKey("period_id")]
		public account_period Period {get; set;}
		[OpenErpForeignKey("product_id")]
		public product_product Product {get; set;}
		[OpenErpForeignKey("product_uom_id")]
		public product_uom ProductUom {get; set;}
		[OpenErpForeignKey("reconcile_id")]
		public account_move_reconcile Reconcile {get; set;}
		[OpenErpForeignKey("reconcile_partial_id")]
		public account_move_reconcile ReconcilePartial {get; set;}
		[OpenErpForeignKey("statement_id")]
		public account_bank_statement Statement {get; set;}
		[OpenErpForeignKey("tax_code_id")]
		public account_tax_code TaxCode {get; set;}
	}

	public class account_move_reconcile{

		public int id {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? create_date {get; set;}
		public ICollection<account_move_line> line_id {get; set;}
		public ICollection<account_move_line> line_partial_ids {get; set;}
		public string name {get; set;}
		public bool opening_reconciliation {get; set;}
		public string type {get; set;}
	}

	public class account_payment_term{

		public int id {get; set;}
		public bool active {get; set;}
		public ICollection<account_payment_term_line> line_ids {get; set;}
		public string name {get; set;}
		public string note {get; set;}
	}

	public class account_payment_term_line{

		public int id {get; set;}
		public int? days {get; set;}
		public int? days2 {get; set;}
		public int? payment_id {get; set;}
		public String value {get; set;}
		public double? value_amount {get; set;}
		[OpenErpForeignKey("payment_id")]
		public account_payment_term Payment {get; set;}
	}

	public class account_period{

		public int id {get; set;}
		public string code {get; set;}
		public int? company_id {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date_start {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date_stop {get; set;}
		public int? fiscalyear_id {get; set;}
		public string name {get; set;}
		public bool special {get; set;}
		public String state {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("fiscalyear_id")]
		public account_fiscalyear Fiscalyear {get; set;}
	}

	public class account_sequence_fiscalyear{

		public int id {get; set;}
		public int? fiscalyear_id {get; set;}
		public int? sequence_id {get; set;}
		public int? sequence_main_id {get; set;}
		[OpenErpForeignKey("fiscalyear_id")]
		public account_fiscalyear Fiscalyear {get; set;}
		[OpenErpForeignKey("sequence_id")]
		public ir_sequence Sequence {get; set;}
		[OpenErpForeignKey("sequence_main_id")]
		public ir_sequence SequenceMain {get; set;}
	}

	public class account_subscription{

		public int id {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date_start {get; set;}
		public ICollection<account_subscription_line> lines_id {get; set;}
		public int? model_id {get; set;}
		public string name {get; set;}
		public int? period_nbr {get; set;}
		public int? period_total {get; set;}
		public String period_type {get; set;}
		public string Ref {get; set;}
		public String state {get; set;}
		[OpenErpForeignKey("model_id")]
		public account_model Model {get; set;}
	}

	public class account_subscription_line{

		public int id {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date {get; set;}
		public int? move_id {get; set;}
		public int? subscription_id {get; set;}
		[OpenErpForeignKey("move_id")]
		public account_move Move {get; set;}
		[OpenErpForeignKey("subscription_id")]
		public account_subscription Subscription {get; set;}
	}

	public class account_tax{

		public int id {get; set;}
		public int? account_analytic_collected_id {get; set;}
		public int? account_analytic_paid_id {get; set;}
		public int? account_collected_id {get; set;}
		public int? account_paid_id {get; set;}
		public bool active {get; set;}
		public double? amount {get; set;}
		public String applicable_type {get; set;}
		public int? base_code_id {get; set;}
		public double? base_sign {get; set;}
		public bool child_depend {get; set;}
		public ICollection<account_tax> child_ids {get; set;}
		public int? company_id {get; set;}
		public string description {get; set;}
		public string domain {get; set;}
		public bool include_base_amount {get; set;}
		public string name {get; set;}
		public int? parent_id {get; set;}
		public bool price_include {get; set;}
		public string python_applicable {get; set;}
		public string python_compute {get; set;}
		public string python_compute_inv {get; set;}
		public int? ref_base_code_id {get; set;}
		public double? ref_base_sign {get; set;}
		public int? ref_tax_code_id {get; set;}
		public double? ref_tax_sign {get; set;}
		public int? sequence {get; set;}
		public int? tax_code_id {get; set;}
		public double? tax_sign {get; set;}
		public String type {get; set;}
		public String type_tax_use {get; set;}
		[OpenErpForeignKey("account_analytic_collected_id")]
		public account_analytic_account AccountAnalyticCollected {get; set;}
		[OpenErpForeignKey("account_analytic_paid_id")]
		public account_analytic_account AccountAnalyticPa {get; set;}
		[OpenErpForeignKey("account_collected_id")]
		public account_account AccountCollected {get; set;}
		[OpenErpForeignKey("account_paid_id")]
		public account_account AccountPa {get; set;}
		[OpenErpForeignKey("base_code_id")]
		public account_tax_code BaseCode {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("parent_id")]
		public account_tax Parent {get; set;}
		[OpenErpForeignKey("ref_base_code_id")]
		public account_tax_code RefBaseCode {get; set;}
		[OpenErpForeignKey("ref_tax_code_id")]
		public account_tax_code RefTaxCode {get; set;}
		[OpenErpForeignKey("tax_code_id")]
		public account_tax_code TaxCode {get; set;}
	}

	public class account_tax_code{

		public int id {get; set;}
		public ICollection<account_tax_code> child_ids {get; set;}
		public string code {get; set;}
		public int? company_id {get; set;}
		public string info {get; set;}
		public ICollection<account_move_line> line_ids {get; set;}
		public string name {get; set;}
		public bool notprintable {get; set;}
		public int? parent_id {get; set;}
		public int? sequence {get; set;}
		public double? sign {get; set;}
		public double? sum {get; set;}
		public double? sum_period {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("parent_id")]
		public account_tax_code Parent {get; set;}
	}

	public class account_tax_code_template{

		public int id {get; set;}
		public ICollection<account_tax_code_template> child_ids {get; set;}
		public string code {get; set;}
		public string info {get; set;}
		public string name {get; set;}
		public bool notprintable {get; set;}
		public int? parent_id {get; set;}
		public double? sign {get; set;}
		[OpenErpForeignKey("parent_id")]
		public account_tax_code_template Parent {get; set;}
	}

	public class account_tax_template{

		public int id {get; set;}
		public int? account_collected_id {get; set;}
		public int? account_paid_id {get; set;}
		public double? amount {get; set;}
		public String applicable_type {get; set;}
		public int? base_code_id {get; set;}
		public double? base_sign {get; set;}
		public int? chart_template_id {get; set;}
		public bool child_depend {get; set;}
		public string description {get; set;}
		public string domain {get; set;}
		public bool include_base_amount {get; set;}
		public string name {get; set;}
		public int? parent_id {get; set;}
		public bool price_include {get; set;}
		public string python_applicable {get; set;}
		public string python_compute {get; set;}
		public string python_compute_inv {get; set;}
		public int? ref_base_code_id {get; set;}
		public double? ref_base_sign {get; set;}
		public int? ref_tax_code_id {get; set;}
		public double? ref_tax_sign {get; set;}
		public int? sequence {get; set;}
		public int? tax_code_id {get; set;}
		public double? tax_sign {get; set;}
		public String type {get; set;}
		public String type_tax_use {get; set;}
		[OpenErpForeignKey("account_collected_id")]
		public account_account_template AccountCollected {get; set;}
		[OpenErpForeignKey("account_paid_id")]
		public account_account_template AccountPa {get; set;}
		[OpenErpForeignKey("base_code_id")]
		public account_tax_code_template BaseCode {get; set;}
		[OpenErpForeignKey("chart_template_id")]
		public account_chart_template ChartTemplate {get; set;}
		[OpenErpForeignKey("parent_id")]
		public account_tax_template Parent {get; set;}
		[OpenErpForeignKey("ref_base_code_id")]
		public account_tax_code_template RefBaseCode {get; set;}
		[OpenErpForeignKey("ref_tax_code_id")]
		public account_tax_code_template RefTaxCode {get; set;}
		[OpenErpForeignKey("tax_code_id")]
		public account_tax_code_template TaxCode {get; set;}
	}

	public class account_treasury_report{

		public int id {get; set;}
		public double? balance {get; set;}
		public int? company_id {get; set;}
		public double? credit {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date {get; set;}
		public double? debit {get; set;}
		public double? ending_balance {get; set;}
		public int? fiscalyear_id {get; set;}
		public int? period_id {get; set;}
		public double? starting_balance {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("fiscalyear_id")]
		public account_fiscalyear Fiscalyear {get; set;}
		[OpenErpForeignKey("period_id")]
		public account_period Period {get; set;}
	}

	public class account_voucher{

		public int id {get; set;}
		public int? account_id {get; set;}
		public bool active {get; set;}
		public double? amount {get; set;}
		public int? analytic_id {get; set;}
		public bool audit {get; set;}
		public string comment {get; set;}
		public int? company_id {get; set;}
		public string currency_help_label {get; set;}
		public int? currency_id {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date_due {get; set;}
		public bool is_multi_currency {get; set;}
		public int? journal_id {get; set;}
		public ICollection<account_voucher_line> line_cr_ids {get; set;}
		public ICollection<account_voucher_line> line_dr_ids {get; set;}
		public ICollection<account_voucher_line> line_ids {get; set;}
		public ICollection<res_partner> message_follower_ids {get; set;}
		public ICollection<mail_message> message_ids {get; set;}
		public bool message_is_follower {get; set;}
		public string message_summary {get; set;}
		public bool message_unread {get; set;}
		public int? move_id {get; set;}
		public ICollection<account_move_line> move_ids {get; set;}
		public string name {get; set;}
		public string narration {get; set;}
		public string number {get; set;}
		public bool paid {get; set;}
		public double? paid_amount_in_company_currency {get; set;}
		public int? partner_id {get; set;}
		public String payment_option {get; set;}
		public double? payment_rate {get; set;}
		public int? payment_rate_currency_id {get; set;}
		public String pay_now {get; set;}
		public int? period_id {get; set;}
		public bool pre_line {get; set;}
		public string reference {get; set;}
		public String state {get; set;}
		public double? tax_amount {get; set;}
		public int? tax_id {get; set;}
		public String type {get; set;}
		public int? writeoff_acc_id {get; set;}
		public double? writeoff_amount {get; set;}
		[OpenErpForeignKey("account_id")]
		public account_account Account {get; set;}
		[OpenErpForeignKey("analytic_id")]
		public account_analytic_account Analytic {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("currency_id")]
		public res_currency Currency {get; set;}
		[OpenErpForeignKey("journal_id")]
		public account_journal Journal {get; set;}
		[OpenErpForeignKey("move_id")]
		public account_move Move {get; set;}
		[OpenErpForeignKey("partner_id")]
		public res_partner Partner {get; set;}
		[OpenErpForeignKey("payment_rate_currency_id")]
		public res_currency PaymentRateCurrency {get; set;}
		[OpenErpForeignKey("period_id")]
		public account_period Period {get; set;}
		[OpenErpForeignKey("tax_id")]
		public account_tax Tax {get; set;}
		[OpenErpForeignKey("writeoff_acc_id")]
		public account_account WriteoffAcc {get; set;}
	}

	public class account_voucher_line{

		public int id {get; set;}
		public int? account_analytic_id {get; set;}
		public int? account_id {get; set;}
		public double? amount {get; set;}
		public double? amount_original {get; set;}
		public double? amount_unreconciled {get; set;}
		public int? company_id {get; set;}
		public int? currency_id {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date_due {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date_original {get; set;}
		public int? move_line_id {get; set;}
		public string name {get; set;}
		public int? partner_id {get; set;}
		public bool reconcile {get; set;}
		public String type {get; set;}
		public double? untax_amount {get; set;}
		public int? voucher_id {get; set;}
		[OpenErpForeignKey("account_analytic_id")]
		public account_analytic_account AccountAnalytic {get; set;}
		[OpenErpForeignKey("account_id")]
		public account_account Account {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("currency_id")]
		public res_currency Currency {get; set;}
		[OpenErpForeignKey("move_line_id")]
		public account_move_line MoveLine {get; set;}
		[OpenErpForeignKey("partner_id")]
		public res_partner Partner {get; set;}
		[OpenErpForeignKey("voucher_id")]
		public account_voucher Voucher {get; set;}
	}

	public class analytic_entries_report{

		public int id {get; set;}
		public int? account_id {get; set;}
		public double? amount {get; set;}
		public int? company_id {get; set;}
		public int? currency_id {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date {get; set;}
		public string day {get; set;}
		public int? general_account_id {get; set;}
		public int? journal_id {get; set;}
		public String month {get; set;}
		public int? move_id {get; set;}
		public string name {get; set;}
		public int? nbr {get; set;}
		public int? partner_id {get; set;}
		public int? product_id {get; set;}
		public int? product_uom_id {get; set;}
		public double? unit_amount {get; set;}
		public int? user_id {get; set;}
		public string year {get; set;}
		[OpenErpForeignKey("account_id")]
		public account_analytic_account Account {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("currency_id")]
		public res_currency Currency {get; set;}
		[OpenErpForeignKey("general_account_id")]
		public account_account GeneralAccount {get; set;}
		[OpenErpForeignKey("journal_id")]
		public account_analytic_journal Journal {get; set;}
		[OpenErpForeignKey("move_id")]
		public account_move_line Move {get; set;}
		[OpenErpForeignKey("partner_id")]
		public res_partner Partner {get; set;}
		[OpenErpForeignKey("product_id")]
		public product_product Product {get; set;}
		[OpenErpForeignKey("product_uom_id")]
		public product_uom ProductUom {get; set;}
		[OpenErpForeignKey("user_id")]
		public res_users User {get; set;}
	}

	public class board_board{

		public int id {get; set;}
	}

	public class decimal_precision{

		public int id {get; set;}
		public int digits {get; set;}
		public string name {get; set;}
	}

	public class edi_edi{

		public int id {get; set;}
	}

	public class email_template{

		public int id {get; set;}
		public ICollection<ir_attachment> attachment_ids {get; set;}
		public bool auto_delete {get; set;}
		public string body_html {get; set;}
		public string copyvalue {get; set;}
		public string email_cc {get; set;}
		public string email_from {get; set;}
		public string email_recipients {get; set;}
		public string email_to {get; set;}
		public string lang {get; set;}
		public int? mail_server_id {get; set;}
		public string model {get; set;}
		public int? model_id {get; set;}
		public int? model_object_field {get; set;}
		public string name {get; set;}
		public string null_value {get; set;}
		public int? ref_ir_act_window {get; set;}
		public int? ref_ir_value {get; set;}
		public string reply_to {get; set;}
		public string report_name {get; set;}
		public int? report_template {get; set;}
		public string subject {get; set;}
		public int? sub_model_object_field {get; set;}
		public int? sub_object {get; set;}
		public bool user_signature {get; set;}
		[OpenErpForeignKey("mail_server_id")]
		public ir_mail_server MailServer {get; set;}
		[OpenErpForeignKey("model_id")]
		public ir_model Model {get; set;}
		[OpenErpForeignKey("model_object_field")]
		public ir_model_fields ModelObjectField {get; set;}
		[OpenErpForeignKey("ref_ir_act_window")]
		public ir_actions_act_window RefIrActWindow {get; set;}
		[OpenErpForeignKey("ref_ir_value")]
		public ir_values RefIrValue {get; set;}
		[OpenErpForeignKey("report_template")]
		public ir_actions_report_xml ReportTemplate {get; set;}
		[OpenErpForeignKey("sub_model_object_field")]
		public ir_model_fields SubModelObjectField {get; set;}
		[OpenErpForeignKey("sub_object")]
		public ir_model SubObject {get; set;}
	}

	public class fetchmail_server{

		public int id {get; set;}
		public int? action_id {get; set;}
		public bool active {get; set;}
		public bool attach {get; set;}
		public string configuration {get; set;}
		[OpenErpMap(OpenErpType.Datetime)]
		public DateTime? date {get; set;}
		public bool is_ssl {get; set;}
		public ICollection<mail_mail> message_ids {get; set;}
		public string name {get; set;}
		public int? object_id {get; set;}
		public bool original {get; set;}
		public string password {get; set;}
		public int? port {get; set;}
		public int? priority {get; set;}
		public string script {get; set;}
		public string server {get; set;}
		public String state {get; set;}
		public String type {get; set;}
		public string user {get; set;}
		[OpenErpForeignKey("action_id")]
		public ir_actions_server Action {get; set;}
		[OpenErpForeignKey("object_id")]
		public ir_model Object {get; set;}
	}

	public class hr_department{

		public int id {get; set;}
		public ICollection<hr_department> child_ids {get; set;}
		public int? company_id {get; set;}
		public string complete_name {get; set;}
		public int? manager_id {get; set;}
		public ICollection<hr_employee> member_ids {get; set;}
		public string name {get; set;}
		public string note {get; set;}
		public int? parent_id {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("manager_id")]
		public hr_employee Manager {get; set;}
		[OpenErpForeignKey("parent_id")]
		public hr_department Parent {get; set;}
	}

	public class hr_employee{

		public int id {get; set;}
		public int? address_home_id {get; set;}
		public int? address_id {get; set;}
		public int? bank_account_id {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? birthday {get; set;}
		public ICollection<hr_employee_category> category_ids {get; set;}
		public ICollection<hr_employee> child_ids {get; set;}
		public string city {get; set;}
		public int? coach_id {get; set;}
		public int? color {get; set;}
		public int? country_id {get; set;}
		public int? department_id {get; set;}
		public String gender {get; set;}
		public string identification_id {get; set;}
		public Object image {get; set;}
		public Object image_medium {get; set;}
		public Object image_small {get; set;}
		public int? job_id {get; set;}
		[OpenErpMap(OpenErpType.Datetime)]
		public DateTime? last_login {get; set;}
		public string login {get; set;}
		public String marital {get; set;}
		public string mobile_phone {get; set;}
		public string name_related {get; set;}
		public string notes {get; set;}
		public string otherid {get; set;}
		public int? parent_id {get; set;}
		public string passport_id {get; set;}
		public int? resource_id {get; set;}
		public string sinid {get; set;}
		public string ssnid {get; set;}
		public string work_email {get; set;}
		public string work_location {get; set;}
		public string work_phone {get; set;}
		[OpenErpForeignKey("address_home_id")]
		public res_partner AddressHome {get; set;}
		[OpenErpForeignKey("address_id")]
		public res_partner Address {get; set;}
		[OpenErpForeignKey("bank_account_id")]
		public res_partner_bank BankAccount {get; set;}
		[OpenErpForeignKey("coach_id")]
		public hr_employee Coach {get; set;}
		[OpenErpForeignKey("country_id")]
		public res_country Country {get; set;}
		[OpenErpForeignKey("department_id")]
		public hr_department Department {get; set;}
		[OpenErpForeignKey("job_id")]
		public hr_job Job {get; set;}
		[OpenErpForeignKey("parent_id")]
		public hr_employee Parent {get; set;}
		[OpenErpForeignKey("resource_id")]
		public resource_resource Resource {get; set;}
	}

	public class hr_employee_category{

		public int id {get; set;}
		public ICollection<hr_employee_category> child_ids {get; set;}
		public string complete_name {get; set;}
		public ICollection<hr_employee> employee_ids {get; set;}
		public string name {get; set;}
		public int? parent_id {get; set;}
		[OpenErpForeignKey("parent_id")]
		public hr_employee_category Parent {get; set;}
	}

	public class hr_job{

		public int id {get; set;}
		public int? company_id {get; set;}
		public int? department_id {get; set;}
		public string description {get; set;}
		public ICollection<hr_employee> employee_ids {get; set;}
		public double? expected_employees {get; set;}
		public ICollection<res_partner> message_follower_ids {get; set;}
		public ICollection<mail_message> message_ids {get; set;}
		public bool message_is_follower {get; set;}
		public string message_summary {get; set;}
		public bool message_unread {get; set;}
		public string name {get; set;}
		public double? no_of_employee {get; set;}
		public double? no_of_recruitment {get; set;}
		public string requirements {get; set;}
		public String state {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("department_id")]
		public hr_department Department {get; set;}
	}

	public class ir_actions_actions{

		public int id {get; set;}
		public string help {get; set;}
		public string name {get; set;}
		public string type {get; set;}
		public string usage {get; set;}
	}

	public class ir_actions_act_url{

		public int id {get; set;}
		public string help {get; set;}
		public string name {get; set;}
		public String target {get; set;}
		public string type {get; set;}
		public string url {get; set;}
		public string usage {get; set;}
	}

	public class ir_actions_act_window{

		public int id {get; set;}
		public int? auto_refresh {get; set;}
		public bool auto_search {get; set;}
		public string context {get; set;}
		public string domain {get; set;}
		public bool filter {get; set;}
		public ICollection<res_groups> groups_id {get; set;}
		public string help {get; set;}
		public int? limit {get; set;}
		public bool multi {get; set;}
		public string name {get; set;}
		public int? res_id {get; set;}
		public string res_model {get; set;}
		public string search_view {get; set;}
		public int? search_view_id {get; set;}
		public string src_model {get; set;}
		public String target {get; set;}
		public string type {get; set;}
		public string usage {get; set;}
		public int? view_id {get; set;}
		public ICollection<ir_actions_act_window_view> view_ids {get; set;}
		public string view_mode {get; set;}
		public Object views {get; set;}
		public String view_type {get; set;}
		[OpenErpForeignKey("search_view_id")]
		public ir_ui_view SearchView {get; set;}
		[OpenErpForeignKey("view_id")]
		public ir_ui_view View {get; set;}
	}

	public class ir_actions_act_window_close{

		public int id {get; set;}
		public string help {get; set;}
		public string name {get; set;}
		public string type {get; set;}
		public string usage {get; set;}
	}

	public class ir_actions_act_window_view{

		public int id {get; set;}
		public int? act_window_id {get; set;}
		public bool multi {get; set;}
		public int? sequence {get; set;}
		public int? view_id {get; set;}
		public String view_mode {get; set;}
		[OpenErpForeignKey("act_window_id")]
		public ir_actions_act_window ActWindow {get; set;}
		[OpenErpForeignKey("view_id")]
		public ir_ui_view View {get; set;}
	}

	public class ir_actions_client{

		public int id {get; set;}
		public string context {get; set;}
		public string help {get; set;}
		public string name {get; set;}
		public Object Params {get; set;}
		public Object params_store {get; set;}
		public string res_model {get; set;}
		public string tag {get; set;}
		public string type {get; set;}
		public string usage {get; set;}
	}

	public class ir_actions_report_xml{

		public int id {get; set;}
		public string attachment {get; set;}
		public bool attachment_use {get; set;}
		public bool auto {get; set;}
		public ICollection<res_groups> groups_id {get; set;}
		public bool header {get; set;}
		public string help {get; set;}
		public string model {get; set;}
		public bool multi {get; set;}
		public string name {get; set;}
		public string report_file {get; set;}
		public string report_name {get; set;}
		public string report_rml {get; set;}
		public Object report_rml_content {get; set;}
		public Object report_rml_content_data {get; set;}
		public string report_sxw {get; set;}
		public Object report_sxw_content {get; set;}
		public Object report_sxw_content_data {get; set;}
		public string report_type {get; set;}
		public string report_xml {get; set;}
		public string report_xsl {get; set;}
		public string type {get; set;}
		public string usage {get; set;}
	}

	public class ir_actions_server{

		public int id {get; set;}
		public int? action_id {get; set;}
		public ICollection<ir_actions_server> child_ids {get; set;}
		public string code {get; set;}
		public string condition {get; set;}
		public object copy_object {get; set;}
		public string email {get; set;}
		public string expression {get; set;}
		public ICollection<ir_server_object_lines> fields_lines {get; set;}
		public string help {get; set;}
		public int? loop_action {get; set;}
		public string message {get; set;}
		public string mobile {get; set;}
		public int? model_id {get; set;}
		public string name {get; set;}
		public int? record_id {get; set;}
		public int? sequence {get; set;}
		public string sms {get; set;}
		public int? srcmodel_id {get; set;}
		public String state {get; set;}
		public string subject {get; set;}
		public String trigger_name {get; set;}
		public int? trigger_obj_id {get; set;}
		public string type {get; set;}
		public string usage {get; set;}
		public int? wkf_model_id {get; set;}
		public string write_id {get; set;}
		[OpenErpForeignKey("action_id")]
		public ir_actions_actions Action {get; set;}
		[OpenErpForeignKey("loop_action")]
		public ir_actions_server LoopAction {get; set;}
		[OpenErpForeignKey("model_id")]
		public ir_model Model {get; set;}
		[OpenErpForeignKey("record_id")]
		public ir_model_fields Record {get; set;}
		[OpenErpForeignKey("srcmodel_id")]
		public ir_model Srcmodel {get; set;}
		[OpenErpForeignKey("trigger_obj_id")]
		public ir_model_fields TriggerObj {get; set;}
		[OpenErpForeignKey("wkf_model_id")]
		public ir_model WkfModel {get; set;}
	}

	public class ir_actions_todo{

		public int id {get; set;}
		public int? action_id {get; set;}
		public ICollection<res_groups> groups_id {get; set;}
		public string name {get; set;}
		public string note {get; set;}
		public int? sequence {get; set;}
		public String state {get; set;}
		public String type {get; set;}
		[OpenErpForeignKey("action_id")]
		public ir_actions_actions Action {get; set;}
	}

	public class ir_actions_wizard{

		public int id {get; set;}
		public ICollection<res_groups> groups_id {get; set;}
		public string help {get; set;}
		public string model {get; set;}
		public bool multi {get; set;}
		public string name {get; set;}
		public string type {get; set;}
		public string usage {get; set;}
		public string wiz_name {get; set;}
	}

	public class ir_attachment{

		public int id {get; set;}
		public int? company_id {get; set;}
		[OpenErpMap(OpenErpType.Datetime)]
		public DateTime? create_date {get; set;}
		public int? create_uid {get; set;}
		public Object datas {get; set;}
		public string datas_fname {get; set;}
		public Object db_datas {get; set;}
		public string description {get; set;}
		public int? file_size {get; set;}
		public string name {get; set;}
		public int? res_id {get; set;}
		public string res_model {get; set;}
		public string res_name {get; set;}
		public string store_fname {get; set;}
		public String type {get; set;}
		public string url {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("create_uid")]
		public res_users CreateU {get; set;}
	}

	public class ir_config_parameter{

		public int id {get; set;}
		public string key {get; set;}
		public string value {get; set;}
	}

	public class ir_cron{

		public int id {get; set;}
		public bool active {get; set;}
		public string args {get; set;}
		public bool doall {get; set;}
		public string function {get; set;}
		public int? interval_number {get; set;}
		public String interval_type {get; set;}
		public string model {get; set;}
		public string name {get; set;}
		[OpenErpMap(OpenErpType.Datetime)]
		public DateTime? nextcall {get; set;}
		public int? numbercall {get; set;}
		public int? priority {get; set;}
		public int? user_id {get; set;}
		[OpenErpForeignKey("user_id")]
		public res_users User {get; set;}
	}

	public class ir_default{

		public int id {get; set;}
		public int? company_id {get; set;}
		public string field_name {get; set;}
		public string field_tbl {get; set;}
		public string page {get; set;}
		public int? ref_id {get; set;}
		public string ref_table {get; set;}
		public int? uid {get; set;}
		public string value {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("uid")]
		public res_users U {get; set;}
	}

	public class ir_exports{

		public int id {get; set;}
		public ICollection<ir_exports_line> export_fields {get; set;}
		public string name {get; set;}
		public string resource {get; set;}
	}

	public class ir_exports_line{

		public int id {get; set;}
		public int? export_id {get; set;}
		public string name {get; set;}
		[OpenErpForeignKey("export_id")]
		public ir_exports Export {get; set;}
	}

	public class ir_fields_converter{

		public int id {get; set;}
	}

	public class ir_filters{

		public int id {get; set;}
		public string context {get; set;}
		public string domain {get; set;}
		public bool is_default {get; set;}
		public String model_id {get; set;}
		public string name {get; set;}
		public int? user_id {get; set;}
		[OpenErpForeignKey("user_id")]
		public res_users User {get; set;}
	}

	public class ir_mail_server{

		public int id {get; set;}
		public bool active {get; set;}
		public string name {get; set;}
		public int? sequence {get; set;}
		public bool smtp_debug {get; set;}
		public String smtp_encryption {get; set;}
		public string smtp_host {get; set;}
		public string smtp_pass {get; set;}
		public int? smtp_port {get; set;}
		public string smtp_user {get; set;}
	}

	public class ir_model{

		public int id {get; set;}
		public ICollection<ir_model_access> access_ids {get; set;}
		public ICollection<ir_model_fields> field_id {get; set;}
		public string info {get; set;}
		public string model {get; set;}
		public string modules {get; set;}
		public string name {get; set;}
		public bool osv_memory {get; set;}
		public String state {get; set;}
		public ICollection<ir_ui_view> view_ids {get; set;}
	}

	public class ir_model_access{

		public int id {get; set;}
		public bool active {get; set;}
		public int? group_id {get; set;}
		public int model_id {get; set;}
		public string name {get; set;}
		public bool perm_create {get; set;}
		public bool perm_read {get; set;}
		public bool perm_unlink {get; set;}
		public bool perm_write {get; set;}
		[OpenErpForeignKey("group_id")]
		public res_groups Group {get; set;}
		[OpenErpForeignKey("model_id")]
		public ir_model Model {get; set;}
	}

	public class ir_model_constraint{

		public int id {get; set;}
		[OpenErpMap(OpenErpType.Datetime)]
		public DateTime? date_init {get; set;}
		[OpenErpMap(OpenErpType.Datetime)]
		public DateTime? date_update {get; set;}
		public int? model {get; set;}
		public int? module {get; set;}
		public string name {get; set;}
		public string type {get; set;}
		[OpenErpForeignKey("model")]
		public ir_model Model {get; set;}
		[OpenErpForeignKey("module")]
		public ir_module_module Module {get; set;}
	}

	public class ir_model_data{

		public int id {get; set;}
		public string complete_name {get; set;}
		[OpenErpMap(OpenErpType.Datetime)]
		public DateTime? date_init {get; set;}
		[OpenErpMap(OpenErpType.Datetime)]
		public DateTime? date_update {get; set;}
		public string display_name {get; set;}
		public string model {get; set;}
		public string module {get; set;}
		public string name {get; set;}
		public bool noupdate {get; set;}
		public int? res_id {get; set;}
	}

	public class ir_model_fields{

		public int id {get; set;}
		public string complete_name {get; set;}
		public string domain {get; set;}
		public string field_description {get; set;}
		public ICollection<res_groups> groups {get; set;}
		public string model {get; set;}
		public int? model_id {get; set;}
		public string modules {get; set;}
		public string name {get; set;}
		public String on_delete {get; set;}
		public bool Readonly {get; set;}
		public string relation {get; set;}
		public string relation_field {get; set;}
		public bool required {get; set;}
		public bool selectable {get; set;}
		public string selection {get; set;}
		public String select_level {get; set;}
		public int? serialization_field_id {get; set;}
		public int? size {get; set;}
		public String state {get; set;}
		public bool translate {get; set;}
		public String ttype {get; set;}
		public bool view_load {get; set;}
		[OpenErpForeignKey("model_id")]
		public ir_model Model {get; set;}
		[OpenErpForeignKey("serialization_field_id")]
		public ir_model_fields SerializationField {get; set;}
	}

	public class ir_model_relation{

		public int id {get; set;}
		[OpenErpMap(OpenErpType.Datetime)]
		public DateTime? date_init {get; set;}
		[OpenErpMap(OpenErpType.Datetime)]
		public DateTime? date_update {get; set;}
		public int? model {get; set;}
		public int? module {get; set;}
		public string name {get; set;}
		[OpenErpForeignKey("model")]
		public ir_model Model {get; set;}
		[OpenErpForeignKey("module")]
		public ir_module_module Module {get; set;}
	}

	public class ir_module_category{

		public int id {get; set;}
		public ICollection<ir_module_category> child_ids {get; set;}
		public string description {get; set;}
		public ICollection<ir_module_module> module_ids {get; set;}
		public int? module_nr {get; set;}
		public string name {get; set;}
		public int? parent_id {get; set;}
		public int? sequence {get; set;}
		public bool visible {get; set;}
		public string xml_id {get; set;}
		[OpenErpForeignKey("parent_id")]
		public ir_module_category Parent {get; set;}
	}

	public class ir_module_module{

		public int id {get; set;}
		public bool application {get; set;}
		public string author {get; set;}
		public bool auto_install {get; set;}
		public int? category_id {get; set;}
		public string contributors {get; set;}
		public bool demo {get; set;}
		public ICollection<ir_module_module_dependency> dependencies_id {get; set;}
		public string description {get; set;}
		public object description_html {get; set;}
		public string icon {get; set;}
		public Object icon_image {get; set;}
		public string installed_version {get; set;}
		public string latest_version {get; set;}
		public String license {get; set;}
		public string maintainer {get; set;}
		public string menus_by_module {get; set;}
		public string name {get; set;}
		public string published_version {get; set;}
		public string reports_by_module {get; set;}
		public int? sequence {get; set;}
		public string shortdesc {get; set;}
		public String state {get; set;}
		public string summary {get; set;}
		public string url {get; set;}
		public string views_by_module {get; set;}
		public string website {get; set;}
		[OpenErpForeignKey("category_id")]
		public ir_module_category Category {get; set;}
	}

	public class ir_module_module_dependency{

		public int id {get; set;}
		public int? module_id {get; set;}
		public string name {get; set;}
		public String state {get; set;}
		[OpenErpForeignKey("module_id")]
		public ir_module_module Module {get; set;}
	}

	public class ir_needaction_mixin{

		public int id {get; set;}
	}

	public class ir_property{

		public int id {get; set;}
		public int? company_id {get; set;}
		public int? fields_id {get; set;}
		public string name {get; set;}
		public object res_id {get; set;}
		public String type {get; set;}
		public Object value_binary {get; set;}
		[OpenErpMap(OpenErpType.Datetime)]
		public DateTime? value_datetime {get; set;}
		public double? value_float {get; set;}
		public int? value_integer {get; set;}
		public object value_reference {get; set;}
		public string value_text {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("fields_id")]
		public ir_model_fields Fields {get; set;}
	}

	public class ir_rule{

		public int id {get; set;}
		public bool active {get; set;}
		public string domain {get; set;}
		public string domain_force {get; set;}
		public bool global {get; set;}
		public ICollection<res_groups> groups {get; set;}
		public int? model_id {get; set;}
		public string name {get; set;}
		public bool perm_create {get; set;}
		public bool perm_read {get; set;}
		public bool perm_unlink {get; set;}
		public bool perm_write {get; set;}
		[OpenErpForeignKey("model_id")]
		public ir_model Model {get; set;}
	}

	public class ir_sequence{

		public int id {get; set;}
		public bool active {get; set;}
		public String code {get; set;}
		public int? company_id {get; set;}
		public ICollection<account_sequence_fiscalyear> fiscal_ids {get; set;}
		public String implementation {get; set;}
		public string name {get; set;}
		public int number_increment {get; set;}
		public int number_next {get; set;}
		public int number_next_actual {get; set;}
		public int padding {get; set;}
		public string prefix {get; set;}
		public string suffix {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
	}

	public class ir_sequence_type{

		public int id {get; set;}
		public string code {get; set;}
		public string name {get; set;}
	}

	public class ir_server_object_lines{

		public int id {get; set;}
		public int? col1 {get; set;}
		public int? server_id {get; set;}
		public String type {get; set;}
		public string value {get; set;}
		[OpenErpForeignKey("col1")]
		public ir_model_fields Col1 {get; set;}
		[OpenErpForeignKey("server_id")]
		public ir_actions_server Server {get; set;}
	}

	public class ir_translation{

		public int id {get; set;}
		public string comments {get; set;}
		public String lang {get; set;}
		public string module {get; set;}
		public string name {get; set;}
		public int? res_id {get; set;}
		public string source {get; set;}
		public string src {get; set;}
		public String state {get; set;}
		public String type {get; set;}
		public string value {get; set;}
	}

	public class ir_ui_menu{

		public int id {get; set;}
		public object action {get; set;}
		public ICollection<ir_ui_menu> child_id {get; set;}
		public string complete_name {get; set;}
		public ICollection<res_groups> groups_id {get; set;}
		public String icon {get; set;}
		public string icon_pict {get; set;}
		public int? mail_group_id {get; set;}
		public string name {get; set;}
		public bool needaction_enabled {get; set;}
		public int? parent_id {get; set;}
		public int? parent_left {get; set;}
		public int? parent_right {get; set;}
		public int? sequence {get; set;}
		public string web_icon {get; set;}
		public Object web_icon_data {get; set;}
		public string web_icon_hover {get; set;}
		public Object web_icon_hover_data {get; set;}
		[OpenErpForeignKey("mail_group_id")]
		public mail_group MailGroup {get; set;}
		[OpenErpForeignKey("parent_id")]
		public ir_ui_menu Parent {get; set;}
	}

	public class ir_ui_view{

		public int id {get; set;}
		public string arch {get; set;}
		public string field_parent {get; set;}
		public ICollection<res_groups> groups_id {get; set;}
		public int? inherit_id {get; set;}
		public string model {get; set;}
		public string name {get; set;}
		public int? priority {get; set;}
		public String type {get; set;}
		public string xml_id {get; set;}
		[OpenErpForeignKey("inherit_id")]
		public ir_ui_view Inherit {get; set;}
	}

	public class ir_ui_view_custom{

		public int id {get; set;}
		public string arch {get; set;}
		public int? ref_id {get; set;}
		public int? user_id {get; set;}
		[OpenErpForeignKey("ref_id")]
		public ir_ui_view Ref {get; set;}
		[OpenErpForeignKey("user_id")]
		public res_users User {get; set;}
	}

	public class ir_ui_view_sc{

		public int id {get; set;}
		public string name {get; set;}
		public int? res_id {get; set;}
		public string resource {get; set;}
		public int? sequence {get; set;}
		public int? user_id {get; set;}
		[OpenErpForeignKey("user_id")]
		public res_users User {get; set;}
	}

	public class ir_values{

		public int id {get; set;}
		public int? action_id {get; set;}
		public int? company_id {get; set;}
		public String key {get; set;}
		public string key2 {get; set;}
		public string model {get; set;}
		public int? model_id {get; set;}
		public string name {get; set;}
		public int? res_id {get; set;}
		public int? user_id {get; set;}
		public string value {get; set;}
		public string value_unpickle {get; set;}
		[OpenErpForeignKey("action_id")]
		public ir_actions_actions Action {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("model_id")]
		public ir_model Model {get; set;}
		[OpenErpForeignKey("user_id")]
		public res_users User {get; set;}
	}

	public class mail_alias{

		public int id {get; set;}
		public string alias_defaults {get; set;}
		public string alias_domain {get; set;}
		public int? alias_force_thread_id {get; set;}
		public int? alias_model_id {get; set;}
		public string alias_name {get; set;}
		public int? alias_user_id {get; set;}
		[OpenErpForeignKey("alias_model_id")]
		public ir_model AliasModel {get; set;}
		[OpenErpForeignKey("alias_user_id")]
		public res_users AliasUser {get; set;}
	}

	public class mail_followers{

		public int id {get; set;}
		public int? partner_id {get; set;}
		public int? res_id {get; set;}
		public string res_model {get; set;}
		public ICollection<mail_message_subtype> subtype_ids {get; set;}
		[OpenErpForeignKey("partner_id")]
		public res_partner Partner {get; set;}
	}

	public class mail_group{

		public int id {get; set;}
		public int? alias_id {get; set;}
		public string description {get; set;}
		public ICollection<res_groups> group_ids {get; set;}
		public int? group_public_id {get; set;}
		public Object image {get; set;}
		public Object image_medium {get; set;}
		public Object image_small {get; set;}
		public int? menu_id {get; set;}
		public ICollection<res_partner> message_follower_ids {get; set;}
		public ICollection<mail_message> message_ids {get; set;}
		public bool message_is_follower {get; set;}
		public string message_summary {get; set;}
		public bool message_unread {get; set;}
		public string name {get; set;}
		public String Public {get; set;}
		[OpenErpForeignKey("alias_id")]
		public mail_alias Alias {get; set;}
		[OpenErpForeignKey("group_public_id")]
		public res_groups GroupPublic {get; set;}
		[OpenErpForeignKey("menu_id")]
		public ir_ui_menu Menu {get; set;}
	}

	public class mail_mail{

		public int id {get; set;}
		public bool auto_delete {get; set;}
		public string body_html {get; set;}
		public string email_cc {get; set;}
		public string email_from {get; set;}
		public string email_to {get; set;}
		public int? fetchmail_server_id {get; set;}
		public int mail_message_id {get; set;}
		public int? mail_server_id {get; set;}
		public bool notification {get; set;}
		public string references {get; set;}
		public string reply_to {get; set;}
		public String state {get; set;}
		[OpenErpForeignKey("fetchmail_server_id")]
		public fetchmail_server FetchmailServer {get; set;}
		[OpenErpForeignKey("mail_message_id")]
		public mail_message MailMessage {get; set;}
		[OpenErpForeignKey("mail_server_id")]
		public ir_mail_server MailServer {get; set;}
	}

	public class mail_message{

		public int id {get; set;}
		public ICollection<ir_attachment> attachment_ids {get; set;}
		public int? author_id {get; set;}
		public object body {get; set;}
		public ICollection<mail_message> child_ids {get; set;}
		[OpenErpMap(OpenErpType.Datetime)]
		public DateTime? date {get; set;}
		public string email_from {get; set;}
		public string message_id {get; set;}
		public string model {get; set;}
		public ICollection<mail_notification> notification_ids {get; set;}
		public ICollection<res_partner> notified_partner_ids {get; set;}
		public int? parent_id {get; set;}
		public ICollection<res_partner> partner_ids {get; set;}
		public string record_name {get; set;}
		public int? res_id {get; set;}
		public bool starred {get; set;}
		public string subject {get; set;}
		public int? subtype_id {get; set;}
		public bool to_read {get; set;}
		public String type {get; set;}
		public ICollection<res_users> vote_user_ids {get; set;}
		[OpenErpForeignKey("author_id")]
		public res_partner Author {get; set;}
		[OpenErpForeignKey("parent_id")]
		public mail_message Parent {get; set;}
		[OpenErpForeignKey("subtype_id")]
		public mail_message_subtype Subtype {get; set;}
	}

	public class mail_message_subtype{

		public int id {get; set;}
		public bool Default {get; set;}
		public string description {get; set;}
		public string name {get; set;}
		public int? parent_id {get; set;}
		public string relation_field {get; set;}
		public string res_model {get; set;}
		[OpenErpForeignKey("parent_id")]
		public mail_message_subtype Parent {get; set;}
	}

	public class mail_notification{

		public int id {get; set;}
		public int? message_id {get; set;}
		public int? partner_id {get; set;}
		public bool read {get; set;}
		public bool starred {get; set;}
		[OpenErpForeignKey("message_id")]
		public mail_message Message {get; set;}
		[OpenErpForeignKey("partner_id")]
		public res_partner Partner {get; set;}
	}

	public class mail_thread{

		public int id {get; set;}
		public ICollection<res_partner> message_follower_ids {get; set;}
		public ICollection<mail_message> message_ids {get; set;}
		public bool message_is_follower {get; set;}
		public string message_summary {get; set;}
		public bool message_unread {get; set;}
	}

	public class multi_company_default{

		public int id {get; set;}
		public int? company_dest_id {get; set;}
		public int? company_id {get; set;}
		public string expression {get; set;}
		public int? field_id {get; set;}
		public string name {get; set;}
		public int? object_id {get; set;}
		public int? sequence {get; set;}
		[OpenErpForeignKey("company_dest_id")]
		public res_company CompanyDest {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("field_id")]
		public ir_model_fields Field {get; set;}
		[OpenErpForeignKey("object_id")]
		public ir_model Object {get; set;}
	}

	public class portal_payment_acquirer{

		public int id {get; set;}
		public string form_template {get; set;}
		public string name {get; set;}
		public bool visible {get; set;}
	}

	public class pricelist_partnerinfo{

		public int id {get; set;}
		public double? min_quantity {get; set;}
		public string name {get; set;}
		public double? price {get; set;}
		public int? suppinfo_id {get; set;}
		[OpenErpForeignKey("suppinfo_id")]
		public product_supplierinfo Suppinfo {get; set;}
	}

	public class process_condition{

		public int id {get; set;}
		public int? model_id {get; set;}
		public string model_states {get; set;}
		public string name {get; set;}
		public int? node_id {get; set;}
		[OpenErpForeignKey("model_id")]
		public ir_model Model {get; set;}
		[OpenErpForeignKey("node_id")]
		public process_node Node {get; set;}
	}

	public class process_node{

		public int id {get; set;}
		public ICollection<process_condition> condition_ids {get; set;}
		public bool flow_start {get; set;}
		public string help_url {get; set;}
		public String kind {get; set;}
		public int? menu_id {get; set;}
		public int? model_id {get; set;}
		public string model_states {get; set;}
		public string name {get; set;}
		public string note {get; set;}
		public int? process_id {get; set;}
		public int? subflow_id {get; set;}
		public ICollection<process_transition> transition_in {get; set;}
		public ICollection<process_transition> transition_out {get; set;}
		[OpenErpForeignKey("menu_id")]
		public ir_ui_menu Menu {get; set;}
		[OpenErpForeignKey("model_id")]
		public ir_model Model {get; set;}
		[OpenErpForeignKey("process_id")]
		public process_process Process {get; set;}
		[OpenErpForeignKey("subflow_id")]
		public process_process Subflow {get; set;}
	}

	public class process_process{

		public int id {get; set;}
		public bool active {get; set;}
		public int? model_id {get; set;}
		public string name {get; set;}
		public ICollection<process_node> node_ids {get; set;}
		public string note {get; set;}
		[OpenErpForeignKey("model_id")]
		public ir_model Model {get; set;}
	}

	public class process_transition{

		public int id {get; set;}
		public ICollection<process_transition_action> action_ids {get; set;}
		public ICollection<res_groups> group_ids {get; set;}
		public string name {get; set;}
		public string note {get; set;}
		public int? source_node_id {get; set;}
		public int? target_node_id {get; set;}
		public ICollection<workflow_transition> transition_ids {get; set;}
		[OpenErpForeignKey("source_node_id")]
		public process_node SourceNode {get; set;}
		[OpenErpForeignKey("target_node_id")]
		public process_node TargetNode {get; set;}
	}

	public class process_transition_action{

		public int id {get; set;}
		public string action {get; set;}
		public string name {get; set;}
		public String state {get; set;}
		public int? transition_id {get; set;}
		[OpenErpForeignKey("transition_id")]
		public process_transition Transition {get; set;}
	}

	public class product_category{

		public int id {get; set;}
		public ICollection<product_category> child_id {get; set;}
		public string complete_name {get; set;}
		public string name {get; set;}
		public int? parent_id {get; set;}
		public int? parent_left {get; set;}
		public int? parent_right {get; set;}
		public int? property_account_expense_categ {get; set;}
		public int? property_account_income_categ {get; set;}
		public int? sequence {get; set;}
		public String type {get; set;}
		[OpenErpForeignKey("parent_id")]
		public product_category Parent {get; set;}
		[OpenErpForeignKey("property_account_expense_categ")]
		public account_account PropertyAccountExpenseCateg {get; set;}
		[OpenErpForeignKey("property_account_income_categ")]
		public account_account PropertyAccountIncomeCateg {get; set;}
	}

	public class product_packaging{

		public int id {get; set;}
		public string code {get; set;}
		public string ean {get; set;}
		public double? height {get; set;}
		public double? length {get; set;}
		public string name {get; set;}
		public int? product_id {get; set;}
		public double? qty {get; set;}
		public int? rows {get; set;}
		public int? sequence {get; set;}
		public int? ul {get; set;}
		public int? ul_qty {get; set;}
		public double? weight {get; set;}
		public double? weight_ul {get; set;}
		public double? width {get; set;}
		[OpenErpForeignKey("product_id")]
		public product_product Product {get; set;}
		[OpenErpForeignKey("ul")]
		public product_ul Ul {get; set;}
	}

	public class product_pricelist{

		public int id {get; set;}
		public bool active {get; set;}
		public int? company_id {get; set;}
		public int? currency_id {get; set;}
		public string name {get; set;}
		public String type {get; set;}
		public ICollection<product_pricelist_version> version_id {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("currency_id")]
		public res_currency Currency {get; set;}
	}

	public class product_pricelist_item{

		public int id {get; set;}
		public String Base {get; set;}
		public int? base_pricelist_id {get; set;}
		public int? categ_id {get; set;}
		public int? company_id {get; set;}
		public int? min_quantity {get; set;}
		public string name {get; set;}
		public double? price_discount {get; set;}
		public double? price_max_margin {get; set;}
		public double? price_min_margin {get; set;}
		public double? price_round {get; set;}
		public double? price_surcharge {get; set;}
		public int? price_version_id {get; set;}
		public int? product_id {get; set;}
		public int? product_tmpl_id {get; set;}
		public int? sequence {get; set;}
		[OpenErpForeignKey("base_pricelist_id")]
		public product_pricelist BasePricelist {get; set;}
		[OpenErpForeignKey("categ_id")]
		public product_category Categ {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("price_version_id")]
		public product_pricelist_version PriceVersion {get; set;}
		[OpenErpForeignKey("product_id")]
		public product_product Product {get; set;}
		[OpenErpForeignKey("product_tmpl_id")]
		public product_template ProductTmpl {get; set;}
	}

	public class product_pricelist_type{

		public int id {get; set;}
		public string key {get; set;}
		public string name {get; set;}
	}

	public class product_pricelist_version{

		public int id {get; set;}
		public bool active {get; set;}
		public int? company_id {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date_end {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date_start {get; set;}
		public ICollection<product_pricelist_item> items_id {get; set;}
		public string name {get; set;}
		public int? pricelist_id {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("pricelist_id")]
		public product_pricelist Pricelist {get; set;}
	}

	public class product_price_type{

		public int id {get; set;}
		public bool active {get; set;}
		public int? currency_id {get; set;}
		public String field {get; set;}
		public string name {get; set;}
		[OpenErpForeignKey("currency_id")]
		public res_currency Currency {get; set;}
	}

	public class product_product{

		public int id {get; set;}
		public bool active {get; set;}
		public string code {get; set;}
		public int? color {get; set;}
		public string default_code {get; set;}
		public string ean13 {get; set;}
		public Object image {get; set;}
		public Object image_medium {get; set;}
		public Object image_small {get; set;}
		public double? incoming_qty {get; set;}
		public double? lst_price {get; set;}
		public ICollection<res_partner> message_follower_ids {get; set;}
		public ICollection<mail_message> message_ids {get; set;}
		public bool message_is_follower {get; set;}
		public string message_summary {get; set;}
		public bool message_unread {get; set;}
		public string name_template {get; set;}
		public double? outgoing_qty {get; set;}
		public ICollection<product_packaging> packaging {get; set;}
		public string partner_ref {get; set;}
		public double? price {get; set;}
		public double? price_extra {get; set;}
		public int? pricelist_id {get; set;}
		public double? price_margin {get; set;}
		public int? product_tmpl_id {get; set;}
		public double? qty_available {get; set;}
		public int? seller_delay {get; set;}
		public int? seller_id {get; set;}
		public int? seller_info_id {get; set;}
		public double? seller_qty {get; set;}
		public string variants {get; set;}
		public double? virtual_available {get; set;}
		[OpenErpForeignKey("pricelist_id")]
		public product_pricelist Pricelist {get; set;}
		[OpenErpForeignKey("product_tmpl_id")]
		public product_template ProductTmpl {get; set;}
		[OpenErpForeignKey("seller_id")]
		public res_partner Seller {get; set;}
		[OpenErpForeignKey("seller_info_id")]
		public product_supplierinfo SellerInfo {get; set;}
	}

	public class product_supplierinfo{

		public int id {get; set;}
		public int? company_id {get; set;}
		public int? delay {get; set;}
		public double? min_qty {get; set;}
		public int? name {get; set;}
		public ICollection<pricelist_partnerinfo> pricelist_ids {get; set;}
		public string product_code {get; set;}
		public int? product_id {get; set;}
		public string product_name {get; set;}
		public int? product_uom {get; set;}
		public double? qty {get; set;}
		public int? sequence {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("name")]
		public res_partner Name {get; set;}
		[OpenErpForeignKey("product_id")]
		public product_template Product {get; set;}
		[OpenErpForeignKey("product_uom")]
		public product_uom ProductUom {get; set;}
	}

	public class product_template{

		public int id {get; set;}
		public int categ_id {get; set;}
		public int? company_id {get; set;}
		public String cost_method {get; set;}
		public string description {get; set;}
		public string description_purchase {get; set;}
		public string description_sale {get; set;}
		public double? list_price {get; set;}
		public String mes_type {get; set;}
		public string name {get; set;}
		public double? produce_delay {get; set;}
		public int? product_manager {get; set;}
		public int? property_account_expense {get; set;}
		public int? property_account_income {get; set;}
		public bool rental {get; set;}
		public bool sale_ok {get; set;}
		public ICollection<product_supplierinfo> seller_ids {get; set;}
		public double? standard_price {get; set;}
		public String state {get; set;}
		public ICollection<account_tax> supplier_taxes_id {get; set;}
		public ICollection<account_tax> taxes_id {get; set;}
		public String type {get; set;}
		public int uom_id {get; set;}
		public int uom_po_id {get; set;}
		public double? uos_coeff {get; set;}
		public int? uos_id {get; set;}
		public double? volume {get; set;}
		public double? warranty {get; set;}
		public double? weight {get; set;}
		public double? weight_net {get; set;}
		[OpenErpForeignKey("categ_id")]
		public product_category Categ {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("product_manager")]
		public res_users ProductManager {get; set;}
		[OpenErpForeignKey("property_account_expense")]
		public account_account PropertyAccountExpense {get; set;}
		[OpenErpForeignKey("property_account_income")]
		public account_account PropertyAccountIncome {get; set;}
		[OpenErpForeignKey("uom_id")]
		public product_uom Uom {get; set;}
		[OpenErpForeignKey("uom_po_id")]
		public product_uom UomPo {get; set;}
		[OpenErpForeignKey("uos_id")]
		public product_uom Uos {get; set;}
	}

	public class product_ul{

		public int id {get; set;}
		public string name {get; set;}
		public String type {get; set;}
	}

	public class product_uom{

		public int id {get; set;}
		public bool active {get; set;}
		public int? category_id {get; set;}
		public double? factor {get; set;}
		public double? factor_inv {get; set;}
		public string name {get; set;}
		public double? rounding {get; set;}
		public String uom_type {get; set;}
		[OpenErpForeignKey("category_id")]
		public product_uom_categ Category {get; set;}
	}

	public class product_uom_categ{

		public int id {get; set;}
		public string name {get; set;}
	}

	public class publisher_warranty_contract{

		public int id {get; set;}
	}

	public class ram_city{

		public int id {get; set;}
		public bool active {get; set;}
		public bool districtcheck {get; set;}
		public string name {get; set;}
	}

	public class ram_city_district{

		public int id {get; set;}
		public int? city_id {get; set;}
		public int? district_id {get; set;}
		public string name {get; set;}
		[OpenErpForeignKey("city_id")]
		public ram_city City {get; set;}
	}

	public class ram_contract{

		public int id {get; set;}
		public bool check_waste_output_plate {get; set;}
		public int? company_id {get; set;}
		public string name {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_partner Company {get; set;}
	}

	public class ram_recycling_area{

		public int id {get; set;}
		public int? city {get; set;}
		public int? contract_id {get; set;}
		public string name {get; set;}
		[OpenErpForeignKey("city")]
		public ram_city City {get; set;}
		[OpenErpForeignKey("contract_id")]
		public ram_contract Contract {get; set;}
	}

	public class ram_vehicle_access{

		public int id {get; set;}
		public bool allowed_in {get; set;}
		public bool allowed_out {get; set;}
		public bool banned_in {get; set;}
		public bool banned_out {get; set;}
		public string plate {get; set;}
		public string reason {get; set;}
		public int? user_id {get; set;}
		[OpenErpMap(OpenErpType.Datetime)]
		public DateTime? when {get; set;}
		[OpenErpForeignKey("user_id")]
		public res_users User {get; set;}
	}

	public class ram_waste_category{

		public int id {get; set;}
		public bool active {get; set;}
		public string name {get; set;}
	}

	public class ram_waste_input{

		public int id {get; set;}
		public string citizien_address {get; set;}
		public string citizien_id {get; set;}
		public string citizien_name {get; set;}
		public string citizien_phone {get; set;}
		public int? city_id {get; set;}
		public string code {get; set;}
		public ICollection<ram_waste_input_detail> details {get; set;}
		public int? district_id {get; set;}
		public string observations {get; set;}
		public string plate {get; set;}
		public int? recyclingarea_id {get; set;}
		public int? source_id {get; set;}
		public int? user_id {get; set;}
		[OpenErpMap(OpenErpType.Datetime)]
		public DateTime? when {get; set;}
		[OpenErpForeignKey("city_id")]
		public ram_city City {get; set;}
		[OpenErpForeignKey("district_id")]
		public ram_city_district District {get; set;}
		[OpenErpForeignKey("recyclingarea_id")]
		public ram_recycling_area Recyclingarea {get; set;}
		[OpenErpForeignKey("source_id")]
		public ram_waste_source Source {get; set;}
		[OpenErpForeignKey("user_id")]
		public res_users User {get; set;}
	}

	public class ram_waste_input_detail{

		public int id {get; set;}
		public bool approved {get; set;}
		public double? quantity {get; set;}
		public int? waste_id {get; set;}
		public int? waste_input_id {get; set;}
		[OpenErpForeignKey("waste_id")]
		public ram_waste_type Waste {get; set;}
		[OpenErpForeignKey("waste_input_id")]
		public ram_waste_input WasteInput {get; set;}
	}

	public class ram_waste_management{

		public int id {get; set;}
		public int? company_id {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date_from {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date_to {get; set;}
		public int? waste_type_id {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_partner Company {get; set;}
		[OpenErpForeignKey("waste_type_id")]
		public ram_waste_type WasteType {get; set;}
	}

	public class ram_waste_output{

		public int id {get; set;}
		public string code {get; set;}
		public ICollection<ram_waste_output_detail> details {get; set;}
		public string observations {get; set;}
		public string plate {get; set;}
		public int? recyclingarea_id {get; set;}
		public int? user_id {get; set;}
		[OpenErpMap(OpenErpType.Datetime)]
		public DateTime? when {get; set;}
		[OpenErpForeignKey("recyclingarea_id")]
		public ram_recycling_area Recyclingarea {get; set;}
		[OpenErpForeignKey("user_id")]
		public res_users User {get; set;}
	}

	public class ram_waste_output_detail{

		public int id {get; set;}
		public int? company_id {get; set;}
		public double? quantity {get; set;}
		public int? waste_id {get; set;}
		public int? waste_output_id {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_partner Company {get; set;}
		[OpenErpForeignKey("waste_id")]
		public ram_waste_type Waste {get; set;}
		[OpenErpForeignKey("waste_output_id")]
		public ram_waste_output WasteOutput {get; set;}
	}

	public class ram_waste_source{

		public int id {get; set;}
		public string name {get; set;}
	}

	public class ram_waste_type{

		public int id {get; set;}
		public bool active {get; set;}
		public int? alertdays {get; set;}
		public bool allowin {get; set;}
		public bool allowout {get; set;}
		public double? amount {get; set;}
		public bool billable {get; set;}
		public int? category_id {get; set;}
		public int? maxdays {get; set;}
		public string name {get; set;}
		public bool unitcontrol {get; set;}
		public bool unitin {get; set;}
		public int? unitmax {get; set;}
		public bool unitout {get; set;}
		public ICollection<ram_waste_management> waste_management_ids {get; set;}
		[OpenErpForeignKey("category_id")]
		public ram_waste_category Category {get; set;}
	}

	public class report_account_receivable{

		public int id {get; set;}
		public double? balance {get; set;}
		public double? credit {get; set;}
		public double? debit {get; set;}
		public string name {get; set;}
		public String type {get; set;}
	}

	public class report_account_sales{

		public int id {get; set;}
		public int? account_id {get; set;}
		public double? amount_total {get; set;}
		public int? currency_id {get; set;}
		public String month {get; set;}
		public string name {get; set;}
		public int? period_id {get; set;}
		public int? product_id {get; set;}
		public double? quantity {get; set;}
		[OpenErpForeignKey("account_id")]
		public account_account Account {get; set;}
		[OpenErpForeignKey("currency_id")]
		public res_currency Currency {get; set;}
		[OpenErpForeignKey("period_id")]
		public account_period Period {get; set;}
		[OpenErpForeignKey("product_id")]
		public product_product Product {get; set;}
	}

	public class report_account_type_sales{

		public int id {get; set;}
		public double? amount_total {get; set;}
		public int? currency_id {get; set;}
		public String month {get; set;}
		public string name {get; set;}
		public int? period_id {get; set;}
		public int? product_id {get; set;}
		public double? quantity {get; set;}
		public int? user_type {get; set;}
		[OpenErpForeignKey("currency_id")]
		public res_currency Currency {get; set;}
		[OpenErpForeignKey("period_id")]
		public account_period Period {get; set;}
		[OpenErpForeignKey("product_id")]
		public product_product Product {get; set;}
		[OpenErpForeignKey("user_type")]
		public account_account_type UserType {get; set;}
	}

	public class report_aged_receivable{

		public int id {get; set;}
		public double? balance {get; set;}
		public string name {get; set;}
	}

	public class report_invoice_created{

		public int id {get; set;}
		public double? amount_total {get; set;}
		public double? amount_untaxed {get; set;}
		[OpenErpMap(OpenErpType.Datetime)]
		public DateTime? create_date {get; set;}
		public int? currency_id {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date_due {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date_invoice {get; set;}
		public string name {get; set;}
		public string number {get; set;}
		public string origin {get; set;}
		public int? partner_id {get; set;}
		public double? residual {get; set;}
		public String state {get; set;}
		public String type {get; set;}
		[OpenErpForeignKey("currency_id")]
		public res_currency Currency {get; set;}
		[OpenErpForeignKey("partner_id")]
		public res_partner Partner {get; set;}
	}

	public class res_bank{

		public int id {get; set;}
		public bool active {get; set;}
		public string bic {get; set;}
		public string city {get; set;}
		public int? country {get; set;}
		public string email {get; set;}
		public string fax {get; set;}
		public string name {get; set;}
		public string phone {get; set;}
		public int? state {get; set;}
		public string street {get; set;}
		public string street2 {get; set;}
		public string zip {get; set;}
		[OpenErpForeignKey("country")]
		public res_country Country {get; set;}
		[OpenErpForeignKey("state")]
		public res_country_state State {get; set;}
	}

	public class res_company{

		public int id {get; set;}
		public string account_no {get; set;}
		public ICollection<res_partner_bank> bank_ids {get; set;}
		public ICollection<res_company> child_ids {get; set;}
		public string city {get; set;}
		public string company_registry {get; set;}
		public int? country_id {get; set;}
		public int currency_id {get; set;}
		public ICollection<res_currency> currency_ids {get; set;}
		public bool custom_footer {get; set;}
		public string email {get; set;}
		public bool expects_chart_of_accounts {get; set;}
		public int? expense_currency_exchange_account_id {get; set;}
		public string fax {get; set;}
		public int? income_currency_exchange_account_id {get; set;}
		public Object logo {get; set;}
		public Object logo_web {get; set;}
		public string name {get; set;}
		public string overdue_msg {get; set;}
		public String paper_format {get; set;}
		public int? parent_id {get; set;}
		public int partner_id {get; set;}
		public string paypal_account {get; set;}
		public string phone {get; set;}
		public string rml_footer {get; set;}
		public string rml_footer_readonly {get; set;}
		public string rml_header {get; set;}
		public string rml_header1 {get; set;}
		public string rml_header2 {get; set;}
		public string rml_header3 {get; set;}
		public int? state_id {get; set;}
		public string street {get; set;}
		public string street2 {get; set;}
		public String tax_calculation_rounding_method {get; set;}
		public ICollection<res_users> user_ids {get; set;}
		public string vat {get; set;}
		public bool vat_check_vies {get; set;}
		public string website {get; set;}
		public string zip {get; set;}
		[OpenErpForeignKey("country_id")]
		public res_country Country {get; set;}
		[OpenErpForeignKey("currency_id")]
		public res_currency Currency {get; set;}
		[OpenErpForeignKey("expense_currency_exchange_account_id")]
		public account_account ExpenseCurrencyExchangeAccount {get; set;}
		[OpenErpForeignKey("income_currency_exchange_account_id")]
		public account_account IncomeCurrencyExchangeAccount {get; set;}
		[OpenErpForeignKey("parent_id")]
		public res_company Parent {get; set;}
		[OpenErpForeignKey("partner_id")]
		public res_partner Partner {get; set;}
		[OpenErpForeignKey("state_id")]
		public res_country_state State {get; set;}
	}

	public class res_country{

		public int id {get; set;}
		public string address_format {get; set;}
		public string code {get; set;}
		public int? currency_id {get; set;}
		public string name {get; set;}
		[OpenErpForeignKey("currency_id")]
		public res_currency Currency {get; set;}
	}

	public class res_country_state{

		public int id {get; set;}
		public string code {get; set;}
		public int? country_id {get; set;}
		public string name {get; set;}
		[OpenErpForeignKey("country_id")]
		public res_country Country {get; set;}
	}

	public class res_currency{

		public int id {get; set;}
		public int? accuracy {get; set;}
		public bool active {get; set;}
		public bool Base {get; set;}
		public int? company_id {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date {get; set;}
		public string name {get; set;}
		public String position {get; set;}
		public double? rate {get; set;}
		public ICollection<res_currency_rate> rate_ids {get; set;}
		public double? rate_silent {get; set;}
		public double? rounding {get; set;}
		public string symbol {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
	}

	public class res_currency_rate{

		public int id {get; set;}
		public int? currency_id {get; set;}
		public int? currency_rate_type_id {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? name {get; set;}
		public double? rate {get; set;}
		[OpenErpForeignKey("currency_id")]
		public res_currency Currency {get; set;}
		[OpenErpForeignKey("currency_rate_type_id")]
		public res_currency_rate_type CurrencyRateType {get; set;}
	}

	public class res_currency_rate_type{

		public int id {get; set;}
		public string name {get; set;}
	}

	public class res_groups{

		public int id {get; set;}
		public int? category_id {get; set;}
		public string comment {get; set;}
		public string full_name {get; set;}
		public ICollection<res_groups> implied_ids {get; set;}
		public bool is_portal {get; set;}
		public ICollection<ir_ui_menu> menu_access {get; set;}
		public ICollection<ir_model_access> model_access {get; set;}
		public string name {get; set;}
		public ICollection<ir_rule> rule_groups {get; set;}
		public bool share {get; set;}
		public ICollection<res_groups> trans_implied_ids {get; set;}
		public ICollection<res_users> users {get; set;}
		public ICollection<ir_ui_view> view_access {get; set;}
		[OpenErpForeignKey("category_id")]
		public ir_module_category Category {get; set;}
	}

	public class res_lang{

		public int id {get; set;}
		public bool active {get; set;}
		public string code {get; set;}
		public string date_format {get; set;}
		public string decimal_point {get; set;}
		public String direction {get; set;}
		public string grouping {get; set;}
		public string iso_code {get; set;}
		public string name {get; set;}
		public string thousands_sep {get; set;}
		public string time_format {get; set;}
		public bool translatable {get; set;}
	}

	public class resource_calendar{

		public int id {get; set;}
		public ICollection<resource_calendar_attendance> attendance_ids {get; set;}
		public int? company_id {get; set;}
		public int? manager {get; set;}
		public string name {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("manager")]
		public res_users Manager {get; set;}
	}

	public class resource_calendar_attendance{

		public int id {get; set;}
		public int? calendar_id {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date_from {get; set;}
		public String dayofweek {get; set;}
		public double? hour_from {get; set;}
		public double? hour_to {get; set;}
		public string name {get; set;}
		[OpenErpForeignKey("calendar_id")]
		public resource_calendar Calendar {get; set;}
	}

	public class resource_calendar_leaves{

		public int id {get; set;}
		public int? calendar_id {get; set;}
		public int? company_id {get; set;}
		[OpenErpMap(OpenErpType.Datetime)]
		public DateTime? date_from {get; set;}
		[OpenErpMap(OpenErpType.Datetime)]
		public DateTime? date_to {get; set;}
		public string name {get; set;}
		public int? resource_id {get; set;}
		[OpenErpForeignKey("calendar_id")]
		public resource_calendar Calendar {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("resource_id")]
		public resource_resource Resource {get; set;}
	}

	public class resource_resource{

		public int id {get; set;}
		public bool active {get; set;}
		public int? calendar_id {get; set;}
		public string code {get; set;}
		public int? company_id {get; set;}
		public string name {get; set;}
		public String resource_type {get; set;}
		public double? time_efficiency {get; set;}
		public int? user_id {get; set;}
		[OpenErpForeignKey("calendar_id")]
		public resource_calendar Calendar {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("user_id")]
		public res_users User {get; set;}
	}

	public class res_partner{

		public int id {get; set;}
		public bool active {get; set;}
		public ICollection<res_partner_bank> bank_ids {get; set;}
		public string birthdate {get; set;}
		public ICollection<res_partner_category> category_id {get; set;}
		public ICollection<res_partner> child_ids {get; set;}
		public string city {get; set;}
		public int? color {get; set;}
		public string comment {get; set;}
		public int? commercial_partner_id {get; set;}
		public int? company_id {get; set;}
		public string contact_address {get; set;}
		public ICollection<account_analytic_account> contract_ids {get; set;}
		public int? country {get; set;}
		public int? country_id {get; set;}
		public double? credit {get; set;}
		public double? credit_limit {get; set;}
		public bool customer {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date {get; set;}
		public double? debit {get; set;}
		public double? debit_limit {get; set;}
		public string display_name {get; set;}
		public string ean13 {get; set;}
		public string email {get; set;}
		public bool employee {get; set;}
		public string fax {get; set;}
		public string function {get; set;}
		public bool has_image {get; set;}
		public Object image {get; set;}
		public Object image_medium {get; set;}
		public Object image_small {get; set;}
		public ICollection<account_invoice_line> invoice_ids {get; set;}
		public bool is_company {get; set;}
		public String lang {get; set;}
		[OpenErpMap(OpenErpType.Datetime)]
		public DateTime? last_reconciliation_date {get; set;}
		public ICollection<res_partner> message_follower_ids {get; set;}
		public ICollection<mail_message> message_ids {get; set;}
		public bool message_is_follower {get; set;}
		public string message_summary {get; set;}
		public bool message_unread {get; set;}
		public string mobile {get; set;}
		public string name {get; set;}
		public String notification_email_send {get; set;}
		public bool opt_out {get; set;}
		public int? parent_id {get; set;}
		public string phone {get; set;}
		public int property_account_payable {get; set;}
		public int? property_account_position {get; set;}
		public int property_account_receivable {get; set;}
		public int? property_payment_term {get; set;}
		public int? property_product_pricelist {get; set;}
		public int? property_supplier_payment_term {get; set;}
		public string Ref {get; set;}
		public ICollection<res_company> ref_companies {get; set;}
		public int? sale_order_count {get; set;}
		public ICollection<sale_order> sale_order_ids {get; set;}
		[OpenErpMap(OpenErpType.Datetime)]
		public DateTime? signup_expiration {get; set;}
		public string signup_token {get; set;}
		public string signup_type {get; set;}
		public string signup_url {get; set;}
		public bool signup_valid {get; set;}
		public int? state_id {get; set;}
		public string street {get; set;}
		public string street2 {get; set;}
		public bool supplier {get; set;}
		public int? title {get; set;}
		public String type {get; set;}
		public String tz {get; set;}
		public string tz_offset {get; set;}
		public bool use_parent_address {get; set;}
		public int? user_id {get; set;}
		public ICollection<res_users> user_ids {get; set;}
		public string vat {get; set;}
		public bool vat_subjected {get; set;}
		public bool waste_service {get; set;}
		public string website {get; set;}
		public string zip {get; set;}
		[OpenErpForeignKey("commercial_partner_id")]
		public res_partner CommercialPartner {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("country")]
		public res_country Country {get; set;}
		[OpenErpForeignKey("country_id")]
		public res_country Country1 {get; set;}
		[OpenErpForeignKey("parent_id")]
		public res_partner Parent {get; set;}
		[OpenErpForeignKey("property_account_payable")]
		public account_account PropertyAccountPayable {get; set;}
		[OpenErpForeignKey("property_account_position")]
		public account_fiscal_position PropertyAccountPosition {get; set;}
		[OpenErpForeignKey("property_account_receivable")]
		public account_account PropertyAccountReceivable {get; set;}
		[OpenErpForeignKey("property_payment_term")]
		public account_payment_term PropertyPaymentTerm {get; set;}
		[OpenErpForeignKey("property_product_pricelist")]
		public product_pricelist PropertyProductPricelist {get; set;}
		[OpenErpForeignKey("property_supplier_payment_term")]
		public account_payment_term PropertySupplierPaymentTerm {get; set;}
		[OpenErpForeignKey("state_id")]
		public res_country_state State {get; set;}
		[OpenErpForeignKey("title")]
		public res_partner_title Title {get; set;}
		[OpenErpForeignKey("user_id")]
		public res_users User {get; set;}
	}

	public class res_partner_bank{

		public int id {get; set;}
		public string acc_number {get; set;}
		public int? bank {get; set;}
		public string bank_bic {get; set;}
		public string bank_name {get; set;}
		public string city {get; set;}
		public int? company_id {get; set;}
		public int? country_id {get; set;}
		public int? currency_id {get; set;}
		public bool footer {get; set;}
		public string iban {get; set;}
		public int? journal_id {get; set;}
		public string name {get; set;}
		public string owner_name {get; set;}
		public int partner_id {get; set;}
		public int? sequence {get; set;}
		public String state {get; set;}
		public int? state_id {get; set;}
		public string street {get; set;}
		public string zip {get; set;}
		[OpenErpForeignKey("bank")]
		public res_bank Bank {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("country_id")]
		public res_country Country {get; set;}
		[OpenErpForeignKey("currency_id")]
		public res_currency Currency {get; set;}
		[OpenErpForeignKey("journal_id")]
		public account_journal Journal {get; set;}
		[OpenErpForeignKey("partner_id")]
		public res_partner Partner {get; set;}
		[OpenErpForeignKey("state_id")]
		public res_country_state State {get; set;}
	}

	public class res_partner_bank_type{

		public int id {get; set;}
		public string code {get; set;}
		public ICollection<res_partner_bank_type_field> field_ids {get; set;}
		public string format_layout {get; set;}
		public string name {get; set;}
	}

	public class res_partner_bank_type_field{

		public int id {get; set;}
		public int? bank_type_id {get; set;}
		public string name {get; set;}
		public bool Readonly {get; set;}
		public bool required {get; set;}
		public int? size {get; set;}
		[OpenErpForeignKey("bank_type_id")]
		public res_partner_bank_type BankType {get; set;}
	}

	public class res_partner_category{

		public int id {get; set;}
		public bool active {get; set;}
		public ICollection<res_partner_category> child_ids {get; set;}
		public string complete_name {get; set;}
		public string name {get; set;}
		public int? parent_id {get; set;}
		public int? parent_left {get; set;}
		public int? parent_right {get; set;}
		public ICollection<res_partner> partner_ids {get; set;}
		[OpenErpForeignKey("parent_id")]
		public res_partner_category Parent {get; set;}
	}

	public class res_partner_title{

		public int id {get; set;}
		public String domain {get; set;}
		public string name {get; set;}
		public string shortcut {get; set;}
	}

	public class res_request{

		public int id {get; set;}
		public int? act_from {get; set;}
		public bool active {get; set;}
		public int? act_to {get; set;}
		public string body {get; set;}
		[OpenErpMap(OpenErpType.Datetime)]
		public DateTime? create_date {get; set;}
		[OpenErpMap(OpenErpType.Datetime)]
		public DateTime? date_sent {get; set;}
		public ICollection<res_request_history> history {get; set;}
		public string name {get; set;}
		public String priority {get; set;}
		public object ref_doc1 {get; set;}
		public object ref_doc2 {get; set;}
		public int? ref_partner_id {get; set;}
		public String state {get; set;}
		[OpenErpMap(OpenErpType.Datetime)]
		public DateTime? trigger_date {get; set;}
		[OpenErpForeignKey("act_from")]
		public res_users ActFrom {get; set;}
		[OpenErpForeignKey("act_to")]
		public res_users ActTo {get; set;}
		[OpenErpForeignKey("ref_partner_id")]
		public res_partner RefPartner {get; set;}
	}

	public class res_request_history{

		public int id {get; set;}
		public int? act_from {get; set;}
		public int? act_to {get; set;}
		public string body {get; set;}
		[OpenErpMap(OpenErpType.Datetime)]
		public DateTime? date_sent {get; set;}
		public string name {get; set;}
		public int? req_id {get; set;}
		[OpenErpForeignKey("act_from")]
		public res_users ActFrom {get; set;}
		[OpenErpForeignKey("act_to")]
		public res_users ActTo {get; set;}
		[OpenErpForeignKey("req_id")]
		public res_request Req {get; set;}
	}

	public class res_request_link{

		public int id {get; set;}
		public string name {get; set;}
		public string Object {get; set;}
		public int? priority {get; set;}
	}

	public class res_users{

		public int id {get; set;}
		public int? action_id {get; set;}
		public bool active {get; set;}
		public int? alias_id {get; set;}
		public int company_id {get; set;}
		public ICollection<res_company> company_ids {get; set;}
		public int? defaul_recycling_area_id {get; set;}
		public ICollection<hr_employee> employee_ids {get; set;}
		public ICollection<res_groups> groups_id {get; set;}
		public string login {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? login_date {get; set;}
		public int? menu_id {get; set;}
		public string new_password {get; set;}
		public int partner_id {get; set;}
		public string password {get; set;}
		public int? ramcontract_id {get; set;}
		public bool share {get; set;}
		public string signature {get; set;}
		public String state {get; set;}
		public string user_email {get; set;}
		[OpenErpForeignKey("action_id")]
		public ir_actions_actions Action {get; set;}
		[OpenErpForeignKey("alias_id")]
		public mail_alias Alias {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("defaul_recycling_area_id")]
		public ram_recycling_area DefaulRecyclingArea {get; set;}
		[OpenErpForeignKey("menu_id")]
		public ir_actions_actions Menu {get; set;}
		[OpenErpForeignKey("partner_id")]
		public res_partner Partner {get; set;}
		[OpenErpForeignKey("ramcontract_id")]
		public ram_contract Ramcontract {get; set;}
	}

	public class sale_order{

		public int id {get; set;}
		public double? amount_tax {get; set;}
		public double? amount_total {get; set;}
		public double? amount_untaxed {get; set;}
		public string client_order_ref {get; set;}
		public int? company_id {get; set;}
		[OpenErpMap(OpenErpType.Datetime)]
		public DateTime? create_date {get; set;}
		public int currency_id {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date_confirm {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime date_order {get; set;}
		public int? fiscal_position {get; set;}
		public bool invoiced {get; set;}
		public double? invoiced_rate {get; set;}
		public bool invoice_exists {get; set;}
		public ICollection<account_invoice> invoice_ids {get; set;}
		public String invoice_quantity {get; set;}
		public ICollection<res_partner> message_follower_ids {get; set;}
		public ICollection<mail_message> message_ids {get; set;}
		public bool message_is_follower {get; set;}
		public string message_summary {get; set;}
		public bool message_unread {get; set;}
		public string name {get; set;}
		public string note {get; set;}
		public ICollection<sale_order_line> order_line {get; set;}
		public String order_policy {get; set;}
		public string origin {get; set;}
		public int partner_id {get; set;}
		public int partner_invoice_id {get; set;}
		public int partner_shipping_id {get; set;}
		public int? payment_term {get; set;}
		public string paypal_url {get; set;}
		public object portal_payment_options {get; set;}
		public int pricelist_id {get; set;}
		public int? project_id {get; set;}
		public int shop_id {get; set;}
		public String state {get; set;}
		public int? user_id {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("currency_id")]
		public res_currency Currency {get; set;}
		[OpenErpForeignKey("fiscal_position")]
		public account_fiscal_position FiscalPosition {get; set;}
		[OpenErpForeignKey("partner_id")]
		public res_partner Partner {get; set;}
		[OpenErpForeignKey("partner_invoice_id")]
		public res_partner PartnerInvoice {get; set;}
		[OpenErpForeignKey("partner_shipping_id")]
		public res_partner PartnerShipping {get; set;}
		[OpenErpForeignKey("payment_term")]
		public account_payment_term PaymentTerm {get; set;}
		[OpenErpForeignKey("pricelist_id")]
		public product_pricelist Pricelist {get; set;}
		[OpenErpForeignKey("project_id")]
		public account_analytic_account Project {get; set;}
		[OpenErpForeignKey("shop_id")]
		public sale_shop Shop {get; set;}
		[OpenErpForeignKey("user_id")]
		public res_users User {get; set;}
	}

	public class sale_order_line{

		public int id {get; set;}
		public int? address_allotment_id {get; set;}
		public int? company_id {get; set;}
		public double? discount {get; set;}
		public bool invoiced {get; set;}
		public ICollection<account_invoice_line> invoice_lines {get; set;}
		public string name {get; set;}
		public int? order_id {get; set;}
		public int? order_partner_id {get; set;}
		public double? price_subtotal {get; set;}
		public double? price_unit {get; set;}
		public int? product_id {get; set;}
		public int? product_uom {get; set;}
		public double? product_uom_qty {get; set;}
		public int? product_uos {get; set;}
		public double? product_uos_qty {get; set;}
		public int? salesman_id {get; set;}
		public int? sequence {get; set;}
		public String state {get; set;}
		public ICollection<account_tax> tax_id {get; set;}
		public double? th_weight {get; set;}
		public String type {get; set;}
		[OpenErpForeignKey("address_allotment_id")]
		public res_partner AddressAllotment {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("order_id")]
		public sale_order Order {get; set;}
		[OpenErpForeignKey("order_partner_id")]
		public res_partner OrderPartner {get; set;}
		[OpenErpForeignKey("product_id")]
		public product_product Product {get; set;}
		[OpenErpForeignKey("product_uom")]
		public product_uom ProductUom {get; set;}
		[OpenErpForeignKey("product_uos")]
		public product_uom ProductUos {get; set;}
		[OpenErpForeignKey("salesman_id")]
		public res_users Salesman {get; set;}
	}

	public class sale_receipt_report{

		public int id {get; set;}
		public int? account_id {get; set;}
		public int? company_id {get; set;}
		public int? currency_id {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date_due {get; set;}
		public string day {get; set;}
		public double? delay_to_pay {get; set;}
		public double? due_delay {get; set;}
		public int? journal_id {get; set;}
		public String month {get; set;}
		public int? nbr {get; set;}
		public int? partner_id {get; set;}
		public String pay_now {get; set;}
		public double? price_total {get; set;}
		public double? price_total_tax {get; set;}
		public String state {get; set;}
		public String type {get; set;}
		public int? user_id {get; set;}
		public string year {get; set;}
		[OpenErpForeignKey("account_id")]
		public account_account Account {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("currency_id")]
		public res_currency Currency {get; set;}
		[OpenErpForeignKey("journal_id")]
		public account_journal Journal {get; set;}
		[OpenErpForeignKey("partner_id")]
		public res_partner Partner {get; set;}
		[OpenErpForeignKey("user_id")]
		public res_users User {get; set;}
	}

	public class sale_report{

		public int id {get; set;}
		public int? analytic_account_id {get; set;}
		public int? categ_id {get; set;}
		public int? company_id {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date {get; set;}
		[OpenErpMap(OpenErpType.Date)]
		public DateTime? date_confirm {get; set;}
		public string day {get; set;}
		public double? delay {get; set;}
		public String month {get; set;}
		public int? nbr {get; set;}
		public int? partner_id {get; set;}
		public int? pricelist_id {get; set;}
		public double? price_total {get; set;}
		public int? product_id {get; set;}
		public int? product_uom {get; set;}
		public double? product_uom_qty {get; set;}
		public int? shop_id {get; set;}
		public String state {get; set;}
		public int? user_id {get; set;}
		public string year {get; set;}
		[OpenErpForeignKey("analytic_account_id")]
		public account_analytic_account AnalyticAccount {get; set;}
		[OpenErpForeignKey("categ_id")]
		public product_category Categ {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("partner_id")]
		public res_partner Partner {get; set;}
		[OpenErpForeignKey("pricelist_id")]
		public product_pricelist Pricelist {get; set;}
		[OpenErpForeignKey("product_id")]
		public product_product Product {get; set;}
		[OpenErpForeignKey("product_uom")]
		public product_uom ProductUom {get; set;}
		[OpenErpForeignKey("shop_id")]
		public sale_shop Shop {get; set;}
		[OpenErpForeignKey("user_id")]
		public res_users User {get; set;}
	}

	public class sale_shop{

		public int id {get; set;}
		public int? company_id {get; set;}
		public string name {get; set;}
		public int? payment_default_id {get; set;}
		public int? pricelist_id {get; set;}
		public int? project_id {get; set;}
		[OpenErpForeignKey("company_id")]
		public res_company Company {get; set;}
		[OpenErpForeignKey("payment_default_id")]
		public account_payment_term PaymentDefault {get; set;}
		[OpenErpForeignKey("pricelist_id")]
		public product_pricelist Pricelist {get; set;}
		[OpenErpForeignKey("project_id")]
		public account_analytic_account Project {get; set;}
	}

	public class temp_range{

		public int id {get; set;}
		public string name {get; set;}
	}

	public class workflow{

		public int id {get; set;}
		public ICollection<workflow_activity> activities {get; set;}
		public string name {get; set;}
		public bool on_create {get; set;}
		public string osv {get; set;}
	}

	public class workflow_activity{

		public int id {get; set;}
		public string action {get; set;}
		public int? action_id {get; set;}
		public bool flow_start {get; set;}
		public bool flow_stop {get; set;}
		public ICollection<workflow_transition> in_transitions {get; set;}
		public String join_mode {get; set;}
		public String kind {get; set;}
		public string name {get; set;}
		public ICollection<workflow_transition> out_transitions {get; set;}
		public string signal_send {get; set;}
		public String split_mode {get; set;}
		public int? subflow_id {get; set;}
		public int? wkf_id {get; set;}
		[OpenErpForeignKey("action_id")]
		public ir_actions_server Action {get; set;}
		[OpenErpForeignKey("subflow_id")]
		public workflow Subflow {get; set;}
		[OpenErpForeignKey("wkf_id")]
		public workflow Wkf {get; set;}
	}

	public class workflow_instance{

		public int id {get; set;}
		public int? res_id {get; set;}
		public string res_type {get; set;}
		public string state {get; set;}
		public int? wkf_id {get; set;}
		[OpenErpForeignKey("wkf_id")]
		public workflow Wkf {get; set;}
	}

	public class workflow_transition{

		public int id {get; set;}
		public int? act_from {get; set;}
		public int? act_to {get; set;}
		public string condition {get; set;}
		public int? group_id {get; set;}
		public string signal {get; set;}
		public string trigger_expr_id {get; set;}
		public string trigger_model {get; set;}
		public int? wkf_id {get; set;}
		[OpenErpForeignKey("act_from")]
		public workflow_activity ActFrom {get; set;}
		[OpenErpForeignKey("act_to")]
		public workflow_activity ActTo {get; set;}
		[OpenErpForeignKey("group_id")]
		public res_groups Group {get; set;}
		[OpenErpForeignKey("wkf_id")]
		public workflow Wkf {get; set;}
	}

	public class workflow_triggers{

		public int id {get; set;}
		public int? instance_id {get; set;}
		public string model {get; set;}
		public int? res_id {get; set;}
		public int? workitem_id {get; set;}
		[OpenErpForeignKey("instance_id")]
		public workflow_instance Instance {get; set;}
		[OpenErpForeignKey("workitem_id")]
		public workflow_workitem Workitem {get; set;}
	}

	public class workflow_workitem{

		public int id {get; set;}
		public int? act_id {get; set;}
		public int? inst_id {get; set;}
		public string state {get; set;}
		public int? subflow_id {get; set;}
		public int? wkf_id {get; set;}
		[OpenErpForeignKey("act_id")]
		public workflow_activity Act {get; set;}
		[OpenErpForeignKey("inst_id")]
		public workflow_instance Inst {get; set;}
		[OpenErpForeignKey("subflow_id")]
		public workflow_instance Subflow {get; set;}
		[OpenErpForeignKey("wkf_id")]
		public workflow Wkf {get; set;}
	}
}