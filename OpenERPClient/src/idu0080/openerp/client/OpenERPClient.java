package idu0080.openerp.client;
/**
 * @author Raul Liivrand 
 * @version 1.0  12/03/2013
 * TTU 2013
 */


import java.net.URL;
import java.util.*;
import java.text.SimpleDateFormat;



import org.apache.xmlrpc.XmlRpcException;
import org.apache.xmlrpc.client.XmlRpcClient;
import org.apache.xmlrpc.client.XmlRpcClientConfigImpl;

import idu0080.openerp.data.*;




public class OpenERPClient {

	public OpenERPClient(String client_tinydb, String client_login, String client_password, String host,
			int port) {
		super();
		this.client_tinydb = client_tinydb;
		this.client_login = client_login;
		this.client_password = client_password;
		this.host = host;
		this.port = port;
	}



	String client_tinydb="";
	String client_login="";
	String client_password="";
	String host="";
	int port;
	int client_id;
	public XmlRpcClient XmLRpcOpenERPClient = null;
	public static void main(String[] args) {


	}


	public Vector<String> getDatabaseList()
	{

		Vector<String> res = null;
		XmlRpcClient xmlrpcDb = new XmlRpcClient();

		XmlRpcClientConfigImpl xmlrpcConfigDb = new XmlRpcClientConfigImpl();
		xmlrpcConfigDb.setEnabledForExtensions(true);
		try {
			xmlrpcConfigDb.setServerURL(new URL("http",host,port,"/xmlrpc/db"));

			xmlrpcDb.setConfig(xmlrpcConfigDb);

			//Retrieve databases
			Vector<Object> params = new Vector<Object>();
			Object result = xmlrpcDb.execute("list", params);
			Object[] a = (Object[]) result;

			res = new Vector<String>();
			for (int i = 0; i < a.length; i++) {
				if (a[i] instanceof String)
				{
					res.addElement((String)a[i]);
					System.out.println("openERP database:" + (String)a[i]);
				}
			}

		}
		catch (XmlRpcException e) {
			System.out.println("XmlException Error while retrieving OpenERP Databases: " + e);
			// return -2;
		}
		catch (Exception e)
		{
			System.out.println("getDatabaseList error: "+ e);
			// return -3;
		}

		return res;
	}


	public int Connect()
	{
		XmlRpcClient xmlrpcLogin = new XmlRpcClient();

		XmlRpcClientConfigImpl xmlrpcConfigLogin = new XmlRpcClientConfigImpl();
		xmlrpcConfigLogin.setEnabledForExtensions(true);


		xmlrpcLogin.setConfig(xmlrpcConfigLogin);
		Object [] params;
		int ret_id=0 ;
		try {
			xmlrpcConfigLogin.setServerURL(new URL("http",host,port,"/xmlrpc/common"));
			//Connect
			params = new Object[] {client_tinydb,client_login,client_password};
			Object id = xmlrpcLogin.execute("login", params);
			if (id instanceof Integer)
				ret_id = (int) id;
			client_id = ret_id;
			return ret_id;
			// return -1;
		}
		catch (XmlRpcException e) {
			System.out.println("XmlException Error while logging to OpenERP: "+e);
			return -2;
		}
		catch (Exception e)
		{
			System.out.println("Error while logging to OpenERP: "+e);
			return -3;
		}
	}


	// See on lihtsalt naide OpenERP XML-RPC teenuse valjakutsumise kohta, ei ole vaja kasutada.
	public int purchaseOrder(String host, int port, String tinydb,int id, String password)
	{
		XmlRpcClient xmlrpcLogin = new XmlRpcClient();

		XmlRpcClientConfigImpl xmlrpcConfigLogin = new XmlRpcClientConfigImpl();
		xmlrpcConfigLogin.setEnabledForExtensions(true);


		xmlrpcLogin.setConfig(xmlrpcConfigLogin);
		Object [] params;
		int ret_id=0 ;
		try {
			xmlrpcConfigLogin.setServerURL(new URL("http",host,port,"/xmlrpc/object"));
			Object r[]=new Object[6];
			r[0]=tinydb;
			r[1]=(Integer)id;
			r[2]=password;
			r[3]="purchase.order";
			r[4]="search";

			Object names[]=new Object[3];

			names[0]="state";
			names[1]="=";
			names[2] = "draft";

			System.out.println("SIIN1");

			Vector<Object> param2 = new Vector<Object>();
			param2.addElement(names);
			r[5]=param2;
			Object po_ids;

			po_ids=xmlrpcLogin.execute("execute", r);
			Object[] d = (Object[]) po_ids;

			Integer i=0;

			if (d != null)
			{
				for(i=0; i<d.length; i++)
					System.out.println(d[i]);
			}

			Object r2[]=new Object[7];
			r2[0]=tinydb;
			r2[1]=(Integer)id;
			r2[2]=password;
			r2[3]="purchase.order";
			r2[4] = "purchase_confirm";
			r2[5] = d[0];
			Object po_data;
			po_data=xmlrpcLogin.execute("exec_workflow", r2);

			return 1;

		}
		catch (XmlRpcException e) {
			System.out.println("purchaseOrder: XmlException Error while logging to OpenERP: "+e);
			return -2;
		}
		catch (Exception e)
		{
			System.out.println("purchaseOrder error: "+e);
			return -3;
		}
	}


	public int[] searchPurchaseOrder(String reference)
	{
		Object [] params;
		Object[] d;
		int ret_ids[]=null;
		try {
			Object r[]=new Object[6];
			r[0]=client_tinydb;
			r[1]=(Integer)client_id;
			r[2]=client_password;
			r[3]="purchase.order";
			r[4]="search";

			Object names[]=new Object[3];

			names[0]="name";
			names[1]="ilike";
			names[2] = reference;

			Vector<Object> param2 = new Vector<Object>();
			param2.addElement(names);
			r[5]=param2;
			Object po_ids;

			po_ids=XmLRpcOpenERPClient.execute("execute", r);
			d = (Object[]) po_ids;

			Integer i=0;
			ret_ids = new int[d.length];
			System.out.println("Tellimusi oli:" + d.length);
			if (d != null)
			{
				for(i=0; i<d.length; i++)
				{
					ret_ids[i]= (int) d[i];
					System.out.println("Ostutellimuse id: " + d[i]);
				}
			}




		}
		catch (XmlRpcException e) {
			System.out.println("searchPurchaseOrder: XmlException Error while logging to OpenERP: "+e);
			ret_ids= new int[1];
			ret_ids[0] =-1;


		}
		catch (Exception e)
		{
			System.out.println("searchPurchaseOrder error: "+e);
			ret_ids = new int[1];
			ret_ids[0] =-1;

		}

		return ret_ids;

	}

	public int readPurchaseOrder(int id)
	{

		Object [] params;
		int ret_id=0 ;
		String name="";
		String state="";
		String date_order="";
		String notes="";

		try {
			Object r[]=new Object[7];
			r[0]=client_tinydb;
			r[1]=(Integer)client_id;
			r[2]=client_password;
			r[3]="purchase.order";
			r[4]="read";



			Object p_orders_ids[]=new Object[1];
			p_orders_ids[0]=id;

			Object[] p_order_fields = { "name", "date_order","state","notes" };

			r[5] = p_orders_ids;
			r[6] = p_order_fields;
			Object[] ids ;
			HashMap<String,Object> cdata;

			ids=(Object[]) XmLRpcOpenERPClient.execute("execute", r);

			cdata = (HashMap<String,Object>) ids[0];

			name = (String) cdata.get("name");
			date_order = (String) cdata.get("date_order");
			state = (String) cdata.get("state");
			notes = (String) cdata.get("notes");

			System.out.println("----------purchase_order----------");
			System.out.println("name:" + name);
			System.out.println("date_order:" + date_order);
			System.out.println("state:" + state);
			System.out.println("notes:" + notes);
			System.out.println("-------------------------");

			return id;

		}
		catch (XmlRpcException e) {
			System.out.println("readPurchaseOrder: XmlException Error while logging to OpenERP: "+e);
			return -2;
		}
		catch (Exception e)
		{
			System.out.println("readPurchaseOrder error: "+e);
			return -3;
		}
	}


	public PurchaseOrder readPurchaseOrderStudent(int id)
	{

		Object [] params;
		int ret_id=0 ;
		String name="";
		String state="";
		String date_order="";
		String notes="";
		PurchaseOrder purchase_order=null;
		try {
			Object r[]=new Object[7];
			r[0]=client_tinydb;
			r[1]=(Integer)client_id;
			r[2]=client_password;
			r[3]="purchase.order";
			r[4]="read";



			Object p_orders_ids[]=new Object[1];
			p_orders_ids[0]=id;

			Object[] p_order_fields = { "name", "date_order","state","notes" };

			r[5] = p_orders_ids;
			r[6] = p_order_fields;
			Object[] ids ;
			HashMap<String,Object> cdata;

			ids=(Object[]) XmLRpcOpenERPClient.execute("execute", r);

			cdata = (HashMap<String,Object>) ids[0];

			name = (String) cdata.get("name");
			date_order = (String) cdata.get("date_order");
			state = (String) cdata.get("state");
			notes = (String) cdata.get("notes");
			// Nii on tehtud teile antud OpenERP kliendikoodis - ei tagasta midagi, trükib ainult välja.
			//	System.out.println("----------purchase_order----------");
			//System.out.println("name:" + name);
			//System.out.println("date_order:" + date_order);
			//System.out.println("state:" + state);
			//System.out.println("notes:" + notes);
			//System.out.println("-------------------------");

			// Nii peaksite tegema teie - tagastab ostutellimuse objekti
			purchase_order = new PurchaseOrder();
			purchase_order.setId(id);
			purchase_order.setDate_order(date_order);
			purchase_order.setName(name);
			purchase_order.setNotes(notes);
			purchase_order.setState(state);

			return purchase_order;

		}
		catch (XmlRpcException e) {
			System.out.println("purchaseOrder: XmlException Error while logging to OpenERP: "+e);
			return purchase_order;
		}
		catch (Exception e)
		{
			System.out.println("purchaseOrder error: "+e);
			return purchase_order;
		}
	}

	// searchCustomer
	public int searchCustomer(String customer_name)
	{
		Object [] params;
		int customer_id=0 ;
		try {
			Object r[]=new Object[6];
			r[0]=client_tinydb;
			r[1]=(Integer)client_id;
			r[2]=client_password;
			r[3]="res.partner";
			r[4]="search";

			Object names[]=new Object[3];

			names[0]="name";
			names[1]="ilike";
			names[2] = customer_name;


			Vector<Object> param2 = new Vector<Object>();

			param2.addElement(names);
			r[5]=param2;
			Object po_ids;

			po_ids=XmLRpcOpenERPClient.execute("execute", r);
			Object[] d = (Object[]) po_ids;

			Integer i=0;

			if (d != null)
			{

				for(i=0; i<d.length; i++)
				{
					System.out.println("customer_id:" + d[i]);
					customer_id = (int) d[i];
				}

			}



			return customer_id;

		}
		catch (XmlRpcException e) {
			System.out.println("searchCustomer:XmlException Error while logging to OpenERP: "+e);
			return -1;
		}
		catch (Exception e)
		{
			System.out.println("searchCustomer error: "+e);
			return -1;
		}
	}

	// searchCustomer


	// getOpenERP server

	public  XmlRpcClient  getOpenERPClient()
	{
		XmlRpcClient xmlrpcLogin = null;


		try
		{
			xmlrpcLogin = new XmlRpcClient();
			XmlRpcClientConfigImpl xmlrpcConfigLogin = new XmlRpcClientConfigImpl();
			xmlrpcConfigLogin.setEnabledForExtensions(true);
			xmlrpcLogin.setConfig(xmlrpcConfigLogin);
			xmlrpcConfigLogin.setServerURL(new URL("http",host,port,"/xmlrpc/object"));


		}
		catch (Exception e)
		{
			System.out.println("getOpenERPClient error: "+e);

		}

		return xmlrpcLogin;


	}
	// End of getOpenERP server

	// readCustomer

	public int readCustomer(int customer_id)
	{
		// Customer customer = null;
		Object [] params;
		int ret_id=0 ;
		try {

			Object r[]=new Object[8];
			r[0]=client_tinydb;
			r[1]=(Integer)client_id;
			r[2]=client_password;
			r[3]="res.partner";
			r[4]="read";

			Object customer_ids[]=new Object[1];


			customer_ids[0]=customer_id;


			Object[] customer_fields = { "city", "name",  "country", "phone", "email" };

			r[5] = customer_ids;
			r[6] = customer_fields;
			Object[] ids ;
			HashMap<String,Object> cdata;
			Object[] country_data;
			ids=(Object[]) XmLRpcOpenERPClient.execute("execute", r);
			// Teie lahenduses loete te kliedni andmed teie oma Customer-i objekti.
			// customer = new Customer();
			cdata = (HashMap<String,Object>) ids[0];

			System.out.println("------customer------");
			// kui country-it ei ole siis annab Booleani (false) vastuseks
			if (!(cdata.get("country") instanceof Boolean))
			{
				// country on tegelikult massiiv, riigi nime saame teisest elemendist
				country_data = (Object[]) cdata.get("country");
				// customer.setCountry((String)country_data[1]);
				System.out.println("country: "+ country_data[1]);
			}


			// customer.setId(customer_id);
			// customer.setName((String)cdata.get("name"));
			System.out.println("name: "+ (String)cdata.get("name"));

			// kui city-it ei ole siis annab Booleani (false) vastuseks
			if (!(cdata.get("city") instanceof Boolean))
			{
				// customer.setCity((String)cdata.get("city"));
				System.out.println("city: "+ (String)cdata.get("city"));
			}

			// kui phone-i ei ole siis annab Booleani (false) vastuseks
			if (!(cdata.get("phone") instanceof Boolean))
			{
				// customer.setPhone((String)cdata.get("phone"));
				System.out.println("phone: "+ (String)cdata.get("phone"));
			}
			if (!(cdata.get("email") instanceof Boolean))
			{
				// customer.setEmail((String)cdata.get("email"));
				System.out.println("email: "+ (String)cdata.get("email"));
			}

			System.out.println("------customer------");	


		}
		catch (XmlRpcException e) {
			System.out.println("readCustomer: XmlException Error while logging to OpenERP:readCustomer: "+e);

		}
		catch (Exception e)
		{
			System.out.println("readCustomer error: "+e);

		}
		return customer_id;
	}

	// readCustomer

	// createInvoice


	// Teie lahenduses ei ole sisend-parameetreid product_id ja product_name vaja - teie annate sisendiks objekti Product
	// mis juba sisaldab id-d ja name-i.
	public int createInvoice(int customer_id, String product_name,int product_id, Double price, Double quantity)
	{

		int invoice_id=0 ;
		try {

			Object r[]=new Object[8];
			r[0]=client_tinydb;
			r[1]=(Integer)client_id;
			r[2]=client_password;
			r[3]="account.invoice";
			r[4]="create";



			HashMap<Object, Object> invoice_params = new HashMap<Object, Object>();
			List <HashMap> invoice_lines=new ArrayList<HashMap>();
			HashMap<Object, Object> invoice_line_params = new HashMap<Object, Object>();
			invoice_params.put("partner_id", customer_id);
			invoice_params.put("user_id", 1);
			// Viit deebit-kande kontole - 'X11002 Debtors - (test)'
			// Kui arve valideeritakse siis tehakse sellele kontole kanne.
			invoice_params.put("account_id", 9);
			//  invoice_params.put("address_contact_id", 5);
			// Myygi raamatupidamisse lahevad selle arve kanded - 'Sales Journal - (test)'
			invoice_params.put("journal_id", 1);
			// valuutaks EUR
			invoice_params.put("currency_id", 1);
			// Kliendi (naiteks "Agrolait") arve aadressi id , viitab aadressile 'OpenERP England S.A., Belgium Gerompont Chaussee de Namur 40'
			// Et oleks lihtsam anname eksisteeriva aadressi id koodis ette 
			invoice_params.put("address_invoice_id", 1);

			SimpleDateFormat sdfDate = new SimpleDateFormat("yyyy-MM-dd");
			Date now = new Date();
			String strDate = sdfDate.format(now);

			invoice_params.put("date_invoice", strDate);
			// arve nimeks (name) võiks panna toote nime
			invoice_params.put("name", product_name);
			r[5]=invoice_params;

			invoice_id= (int) XmLRpcOpenERPClient.execute("execute", r);
			invoice_line_params.put("invoice_id",invoice_id);
			System.out.println("invoice_id:" + Integer.toString(invoice_id));
			// Teeme ühe-realise arve, ühe toote ostmise arve
			// Arve rea nimeks paneme ka toote nime (product_name).
			// Arve reale märkus me ei pane aga null ei tohi ka olla.Seega ="".
			String line_note = "";
			createInvoiceLine(invoice_id,line_note, product_id,price,quantity,product_name);


		}
		catch (XmlRpcException e) {
			System.out.println("createInvoice:XmlException Error while logging to OpenERP: "+e);

		}
		catch (Exception e)
		{
			System.out.println("createInvoice error: "+e);

		}
		return invoice_id;
	}

	// createInvoice

	// createInvoiceLine


	public int createInvoiceLine(int invoice_id,String note, int product_id, Double price, Double quantity, String name)
	{


		int invoice_line_id=0;
		try {

			Object r[]=new Object[8];
			r[0]=client_tinydb;
			r[1]=(Integer)client_id;
			r[2]=client_password;
			r[3]="account.invoice.line";
			r[4]="create";

			HashMap<Object, Object> invoice_line_params = new HashMap<Object, Object>();


			invoice_line_params.put("account_id",22);
			invoice_line_params.put("name",name);
			invoice_line_params.put("price_unit",price);
			invoice_line_params.put("quantity",quantity);
			invoice_line_params.put("product_id",product_id);
			invoice_line_params.put("note","");
			invoice_line_params.put("invoice_id",invoice_id);

			System.out.println("------new invoice line-----");
			System.out.println("name: "+name);
			System.out.println("price_unit: "+price);
			System.out.println("quantity :"+quantity);
			System.out.println("product_id: "+product_id);
			System.out.println("note: "+ note);
			System.out.println("invoice_id: " + invoice_id);

			r[5]=invoice_line_params;
			invoice_line_id= (int) XmLRpcOpenERPClient.execute("execute", r);

			return invoice_line_id;



		}
		catch (XmlRpcException e) {
			System.out.println("createInvoiceLine:XmlException Error while logging to OpenERP: "+e);

		}
		catch (Exception e)
		{
			System.out.println("createInvoiceLine error: "+e);

		}
		return invoice_line_id;
	}

	// createInvoiceLine

	// validateInvoice


	public int validateInvoice(int invoice_id)
	{

		try {
			Vector<Object> arg = new Vector<Object>();
			arg.add(client_tinydb);
			arg.add((Integer)client_id);
			arg.add(client_password);
			arg.add("account.invoice");
			arg.add("invoice_open");
			arg.add(invoice_id);
			Object po_data;
			po_data = XmLRpcOpenERPClient.execute("exec_workflow", arg);
			return 1;

		}
		catch (XmlRpcException e) {
			System.out.println("validateInvoice:XmlException Error while logging to OpenERP: "+e);
			return -2;
		}
		catch (Exception e)
		{
			System.out.println("validateInvoice error: "+e);
			return -3;
		}
	}

	// validateInvoice

	// createVoucher


	public int createVoucher(int customer_id,String invoice_name, String amount, int invoice_id, int move_line_id)
	{

		int voucher_id=0 ;
		try {

			Object r[]=new Object[8];
			r[0]=client_tinydb;
			r[1]=(Integer)client_id;
			r[2]=client_password;
			r[3]="account.voucher";
			r[4]="create";

			HashMap<Object, Object> invoice_params = new HashMap<Object, Object>();
			List <HashMap> invoice_lines=new ArrayList<HashMap>();	            
			// Myygi raamatupidamisse lahevad selle arve maksmise kanded - 'Cash Journal - (test)'
			invoice_params.put("journal_id", 7);
			// Kui arve valideeritakse siis tehakse sellele kontole kanne.
			// Viit kreedit-kande kontole - 'X2001 Product Sales - (test)'
			invoice_params.put("account_id", 12);
			// valuutaks EUR
			invoice_params.put("currency_id", 1);
			SimpleDateFormat sdfDate = new SimpleDateFormat("yyyy-MM-dd");
			Date now = new Date();
			String strDate = sdfDate.format(now);
			invoice_params.put("date", strDate);     
			invoice_params.put("partner_id", customer_id);
			invoice_params.put("company_id",1);
			invoice_params.put("payment_option", "without_writeoff");
			invoice_params.put("comment", "draft");
			invoice_params.put("type","receipt");
			invoice_params.put("name", invoice_name);
			invoice_params.put("reference", invoice_name);
			invoice_params.put("invoice_id", invoice_id);
			invoice_params.put("amount", amount);

			r[5]=invoice_params;

			voucher_id= (int) XmLRpcOpenERPClient.execute("execute", r);
			System.out.println("voucher_id:" + Integer.toString(voucher_id));

			createVoucherLine(voucher_id,amount,customer_id,invoice_id,move_line_id);

			return voucher_id;

		}
		catch (XmlRpcException e) {
			System.out.println("createVoucher:XmlException Error while logging to OpenERP: "+e);
			return -1;
		}
		catch (Exception e)
		{
			System.out.println("createVoucher error: "+e);
			return -1;
		}
	}

	// createVoucher

	// createVoucherLine


	public int createVoucherLine(int voucher_id, String amount,int customer_id, int invoice_id,int move_line_id)
	{

		int voucher_line_id=0 ;
		try {

			Object r[]=new Object[8];
			r[0]=client_tinydb;
			r[1]=(Integer)client_id;
			r[2]=client_password;
			r[3]="account.voucher.line";
			r[4]="create";
			HashMap<Object, Object> invoice_params = new HashMap<Object, Object>();
			List <HashMap> invoice_lines=new ArrayList<HashMap>();
			invoice_params.put("amount", amount);
			invoice_params.put("name", "Web payment");
			invoice_params.put("voucher_id", voucher_id);
			invoice_params.put("payment_option", "without_writeoff");
			invoice_params.put("type", "cr");
			invoice_params.put("account_id", 9);   
			invoice_params.put("partner_id", customer_id);
			invoice_params.put("move_line_id", move_line_id);
			invoice_params.put("invoice_id", invoice_id);
			r[5]=invoice_params;
			XmLRpcOpenERPClient.execute("execute", r);

			return voucher_id;

		}
		catch (XmlRpcException e) {
			System.out.println("createVoucherLine: XmlException Error while logging to OpenERP: "+e);
			return -1;
		}
		catch (Exception e)
		{
			System.out.println("createVoucherLine error: "+e);
			return -1;
		}
	}

	// createVoucherLine

	// validatePayment


	public int validatePayment(int voucher_id)
	{

		try {
			Vector<Object> arg = new Vector<Object>();
			arg.add(client_tinydb);
			arg.add((Integer)client_id);
			arg.add(client_password);
			arg.add("account.voucher");
			arg.add("proforma_voucher");
			arg.add(voucher_id);
			Object po_data;
			po_data = XmLRpcOpenERPClient.execute("exec_workflow", arg);
			return 1;

		}
		catch (XmlRpcException e) {
			System.out.println("validatePayment:XmlException Error while logging to OpenERP: "+e);
			return -2;
		}
		catch (Exception e)
		{
			System.out.println("validatePayment error: "+e);
			return -3;
		}
	}

	// validatePayment	

	// readInvoiceMoveLineId

	/** "Maagline" , (invoice andmetest voetud) move_line_id on vajalik makse (voucher-i) tegemisel anda sisendiks
	 * muidu ei matchi makse kinnitamisel arvega makset kokku.
	 */

	public int readInvoiceMoveLineId(int invoice_id)
	{

		String move_id="" ;
		int move_line_id ;
		try {

			Object r[]=new Object[8];
			r[0]=client_tinydb;
			r[1]=(Integer)client_id;
			r[2]=client_password;
			r[3]="account.invoice";
			r[4]="read";
			Object invoice_ids[]=new Object[1];
			invoice_ids[0]=invoice_id;
			Object[] invoice_fields = { "internal_number" };
			r[5] = invoice_ids;
			r[6] = invoice_fields;
			Object[] ids ;
			HashMap<String,Object> cdata;
			ids=(Object[]) XmLRpcOpenERPClient.execute("execute", r);
			cdata = (HashMap<String,Object>) ids[0];
			String move_data;
			move_data = (String) cdata.get("internal_number");
			move_id = move_data;
			move_line_id = readMove_line_id(move_id);
			return move_line_id;

		}
		catch (XmlRpcException e) {
			System.out.println("readInvoiceMoveLineId:XmlException Error while logging to OpenERP: "+e);
			return -2;
		}
		catch (Exception e)
		{
			System.out.println("readInvoiceMoveLineId error: "+e);
			return -3;
		}
	}

	// readInvoice


	// readMove_line_id

	/** "Maagline" , (invoice andmetest voetud) move_line_id on vajalik makse (voucher-i) tegemisel anda sisendiks
	 * muidu ei matchi makse kinnitamisel arvega makset kokku.
	 */

	public int readMove_line_id(String move_id)
	{

		int move_line_id=0 ;
		try {

			Object r[]=new Object[8];
			r[0]=client_tinydb;
			r[1]=(Integer)client_id;
			r[2]=client_password;
			r[3]="account.move.line";						
			r[4]="search";

			Object criteria[]=new Object[3];

			criteria[0]="move_id";
			criteria[1]="=";
			criteria[2] = move_id;

			Vector<Object> param2 = new Vector<Object>();
			param2.addElement(criteria);
			r[5] = param2;
			Object[] ids ;
			System.out.println("ENNE:");
			ids=(Object[]) XmLRpcOpenERPClient.execute("execute", r);
			System.out.println("move_line_id:" + ids[0]);
			move_line_id = (int) ids[0];
			return move_line_id;

		}
		catch (XmlRpcException e) {
			System.out.println("readMove_line_id:XmlException Error while logging to OpenERP: "+e);
			return -2;
		}
		catch (Exception e)
		{
			System.out.println("readMove_line_id error: "+e);
			return -3;
		}
	}

	// readMove_line_id


	// searchProducts

	/** Toote otsing nime jargi.
	/* Annab vastuseks ainult leitud toodete id-d , toodete andmed tuleb votta eraldi "read"-paringuga
	/* mille argumendiks on toote id..
	 */

	public List<Integer> searchProducts(String name)
	{
		int product_id=0;
		List<Integer> productList = new ArrayList<Integer>();

		try {
			Object r[]=new Object[6];
			r[0]=client_tinydb;
			r[1]=(Integer)client_id;
			r[2]=client_password;
			r[3]="product.product";
			r[4]="search";

			Object names[]=new Object[3];

			names[0]="name";
			names[1]="ilike";
			names[2] = name;

			Vector<Object> param2 = new Vector<Object>();
			param2.addElement(names);

			r[5]=param2;
			Object[] po_ids=null;

			po_ids=(Object[]) XmLRpcOpenERPClient.execute("execute", r);


			for (Object obj : po_ids) {
				product_id = Integer.parseInt(obj.toString());
				productList.add(product_id);
			}

		}
		catch (XmlRpcException e) {
			System.out.println("searchProducts:XmlException Error while logging to OpenERP: "+e);

		}
		catch (Exception e)
		{
			System.out.println("searchProducts error: "+e);
		}

		return productList;
	}

	// searchProducts

	// readProduct	
	// Toote andmed id jargi

	public String readProduct(int product_id)
	{

		// Product product = null;
		String name="";
		try {

			Object r[]=new Object[8];
			r[0]=client_tinydb;
			r[1]=(Integer)client_id;
			r[2]=client_password;
			r[3]="product.product";
			r[4]="read";

			Object product_ids[]=new Object[1];
			product_ids[0]=product_id;

			Object[] product_fields = { "name", "type", "qty_available", "list_price","default_code" };

			r[5] = product_ids;
			r[6] = product_fields;
			Object[] ids ;
			HashMap<String,Object> cdata;

			ids=(Object[]) XmLRpcOpenERPClient.execute("execute", r);
			cdata = (HashMap<String,Object>) ids[0];

			Double qty_available;
			Double price;
			String default_code;
			name = (String) cdata.get("name");
			price = (Double) cdata.get("list_price");
			qty_available = (Double) cdata.get("qty_available");
			default_code = (String) cdata.get("default_code");

			//	product = new Product();
			//	product.setId(product_id);
			// ja nii edasi....	

			System.out.println("----------product----------");
			System.out.println("product_id:" + product_id);
			System.out.println("name:" + name);
			System.out.println("price:" + price);
			System.out.println("qty_available:" + qty_available);
			System.out.println("default_code:" + default_code);
			System.out.println("-------------------------");



		}
		catch (XmlRpcException e) {
			System.out.println("readProduct:XmlException Error while logging to OpenERP: "+e);

		}
		catch (Exception e)
		{
			System.out.println("readProduct error: "+e);

		}

		return name;
	}

	// readProduct			

	// readProductList
	public void readProducts(List<Integer> products)
	{
		for (Object obj :  products) {
			int product_id = Integer.parseInt(obj.toString());
			System.out.println("product_id:" + product_id);
			readProduct(product_id);
		}


	}

	// getFirstProductId	
	public int getFirstProductId(List<Integer> products)
	{
		int i = 0;
		int product_id=0;
		for (Object obj :  products) {
			product_id = Integer.parseInt(obj.toString());
			return product_id; 		
		}

		return 0;
	}

	// readInvoice

	// arve andmete paring id jargi

	public String readInvoice(int invoice_id)
	{


		String invoice_number="";
		try {

			// Teie lahendus tagastav Invoice objekti		
			//		invoice = new Invoice();

			Object r[]=new Object[8];
			r[0]=client_tinydb;
			r[1]=(Integer)client_id;
			r[2]=client_password;
			r[3]="account.invoice";
			r[4]="read";

			Object invoice_ids[]=new Object[1];


			invoice_ids[0]=invoice_id;

			// invoice_line - massiiv mis sisaldab arve ridu. Kui arvega osteti ainult yks kaup siis on siin yks element
			// Arve rea andmed tuleb kysida eraldi funktsiooniga (vt. alt) 
			Object[] invoice_fields = { "number","internal_number","residual","amount_total","invoice_line","state","reconciled","partner_id","comment" };


			r[5] = invoice_ids;
			r[6] = invoice_fields;
			Object[] ids ;
			HashMap<String,Object> cdata;
			ids=(Object[]) XmLRpcOpenERPClient.execute("execute", r);
			cdata = (HashMap<String,Object>) ids[0];
			Double residual;
			Double amount_total;
			String state;
			Boolean reconciled;
			int partner_id;
			amount_total = (Double) cdata.get("amount_total");
			invoice_number = (String) cdata.get("number");
			residual = (Double) cdata.get("residual");
			state = (String) cdata.get("state");
			reconciled = (Boolean) cdata.get("reconciled");
			Object[] partner = (Object[]) cdata.get("partner_id");
			// kliendi id paneme ka invoice objekti
			partner_id = (Integer) partner[0];
			Object[] invoice_line = (Object[]) cdata.get("invoice_line");
			String note="";

			// Uuel arvel ei ole veel kommentaari ja siis ei anna tagasi mitte String-i vaid Booleani (false).
			if (!(cdata.get("comment") instanceof Boolean))
			{
				note = (String) cdata.get("comment");
			}
			//	  invoice.setAmount_total(amount_total);
			//    invoice.setId(invoice_id);
			//    invoice.setResidual(residual);
			// ja nii edasi..Invoice objekti andmetega täitmine.

			System.out.println("-------invoice---------");
			System.out.println("invoice_number:" + invoice_number);
			// residual - naitab kui suur summa arvest on maksmata
			System.out.println("residual:" + residual);
			System.out.println("state:" + state);
			System.out.println("reconciled:" + reconciled);
			System.out.println("note:" + note);



			for (Object obj :  invoice_line) {
				// line_id - arve rea id, arve rida sisaldab yhte arvega ostetud kaupa ja hinda
				int line_id = Integer.parseInt(obj.toString());
				System.out.println("invoice_line_id:" + line_id);
				// Teie lahenduses tuleb leitud arve read (invoice_line, maksimaalselt on meie arvel 1 rida) 
				// lugeda sisse Invoice objekti mingisse atribuuti.
				readInvoiceLine(line_id);

			}
			System.out.println("-----------------------");
			// invoice.setInvoice_lines(invoice_lines);

		}
		catch (XmlRpcException e) {
			System.out.println("readInvoice:XmlException Error while logging to OpenERP: "+e);
		}
		catch (Exception e)
		{
			System.out.println("readInvoice error: "+e);

		}
		return invoice_number;
	}

	// readInvoice				

	// readInvoiceLine		
	// Teie lahenduses: public InvoiceLine readInvoiceLine(int line_id)
	public int readInvoiceLine(int line_id)
	{
		//  InvoiceLine invoice_line = null;

		try {

			//	invoice_line = new InvoiceLine();

			Object r[]=new Object[8];
			r[0]=client_tinydb;
			r[1]=(Integer)client_id;
			r[2]=client_password;
			r[3]="account.invoice.line";
			r[4]="read";

			Object invoice_ids[]=new Object[1];


			invoice_ids[0]=line_id;

			Object[] invoice_fields = { "price_subtotal", "name", "discount", "quantity","product_id" };


			r[5] = invoice_ids;
			r[6] = invoice_fields;
			Object[] ids ;
			HashMap<String,Object> cdata;

			ids=(Object[]) XmLRpcOpenERPClient.execute("execute", r);
			cdata = (HashMap<String,Object>) ids[0];
			String line_name;
			Double quantity;
			Double price_subtotal;
			int product_id;
			line_name = (String) cdata.get("name");
			price_subtotal = (Double) cdata.get("price_subtotal");
			quantity = (Double) cdata.get("quantity");
			Object [] products = (Object []) cdata.get("product_id");
			product_id = (int) products[0]; 
			// Teie lahenduses tuleb tekitada arve rea objekt ja andmed sinna sisse lugeda ning tagastada.		
			//		invoice_line.setName(line_name);

			System.out.println("----invoice_line----");
			System.out.println("line_name:" + line_name);
			System.out.println("price_subtotal:" + price_subtotal);
			System.out.println("quantity:" + quantity);
			System.out.println("product_id:" + product_id);
			System.out.println("------------------");
			return line_id;


		}
		catch (XmlRpcException e) {
			System.out.println("readInvoiceLine:XmlException Error while logging to OpenERP: "+e);
		}
		catch (Exception e)
		{
			System.out.println("readInvoiceLine error: "+e);
		}
		return line_id;
	}

	// readInvoiceLine				

	// writeInvoiceComment


	public int writeInvoiceComment(int invoice_id,String comment)
	{

		try {
			System.out.println("Arve valideerimine:1 ");
			Vector<Object> arg = new Vector<Object>();
			arg.add(client_tinydb);
			arg.add((Integer)client_id);
			arg.add(client_password);
			arg.add("account.invoice");
			arg.add("write");

			Object invoice_ids[]=new Object[1];
			invoice_ids[0]=invoice_id;
			arg.add(invoice_ids);
			HashMap<Object, Object> invoice_params = new HashMap<Object, Object>();
			invoice_params.put("comment", comment);
			arg.add(invoice_params);
			XmLRpcOpenERPClient.execute("execute", arg);           
			return 1;

		}
		catch (XmlRpcException e) {
			System.out.println("writeInvoiceComment:XmlException Error while logging to OpenERP: "+e);
			return -2;
		}
		catch (Exception e)
		{
			System.out.println("writeInvoiceComment error: "+e);
			return -3;
		}
	}

	// writeInvoiceComment	

	// registerProductDelivery


	public int registerProductDelivery(int product_id, Double product_qty,String product_name, int partner_id)
	{


		try
		{
			Vector<Object> arg = new Vector<Object>();
			arg.add(client_tinydb);
			arg.add((Integer)client_id);
			arg.add(client_password);
			arg.add("stock.move");
			arg.add("create");
			HashMap<Object, Object> delivery_params = new HashMap<Object, Object>();
			delivery_params.put("product_id", product_id);
			delivery_params.put("product_qty", product_qty);
			delivery_params.put("product_uom", 1);
			delivery_params.put("location_id", 12);
			delivery_params.put("location_dest_id", 9);
			delivery_params.put("name", product_name);
			delivery_params.put("partner_id", partner_id);
			arg.add(delivery_params);
			Object po_ids=null;
			po_ids = XmLRpcOpenERPClient.execute("execute", arg);   
			int delivery_id;

			delivery_id = Integer.parseInt(po_ids.toString());
			confirmProductDelivery(delivery_id );
			System.out.println("delivery_id:" + delivery_id);

			return delivery_id;

		}
		catch (XmlRpcException e) {
			System.out.println("registerProductDelivery:XmlException Error while logging to OpenERP: "+e);
			return -2;
		}
		catch (Exception e)
		{
			System.out.println("registerProductDelivery error "+e);
			return -3;
		}
	}

	// registerProductDelivery	

	//  confirmProductDelivery
	public int confirmProductDelivery(int delivery_id)
	{


		try
		{
			Vector<Object> arg = new Vector<Object>();
			arg.add(client_tinydb);
			arg.add((Integer)client_id);
			arg.add(client_password);
			arg.add("stock.move");
			arg.add("action_done");
			Object delivery_ids[]=new Object[1];
			delivery_ids[0]=delivery_id;
			arg.add(delivery_ids);
			XmLRpcOpenERPClient.execute("execute", arg);   

			return 1;

		}
		catch (XmlRpcException e) {
			System.out.println("confirmProductDelivery:XmlException Error while logging to OpenERP: "+e);
			return -2;
		}
		catch (Exception e)
		{
			System.out.println("confirmProductDelivery error: "+e);
			return -3;
		}
	}

	//  confirmProductDelivery

	//searchInvoiceByNumber



	public int searchInvoiceByNumber(String invoice_number)
	{
		int invoice_id=0;
		List<Integer> invoiceList = new ArrayList<Integer>();

		try {
			Object r[]=new Object[6];
			r[0]=client_tinydb;
			r[1]=(Integer)client_id;
			r[2]=client_password;
			r[3]="account.invoice";
			r[4]="search";

			Object names[]=new Object[3];

			names[0]="number";
			names[1]="ilike";
			names[2] = invoice_number;

			Vector<Object> param2 = new Vector<Object>();
			param2.addElement(names);

			r[5]=param2;
			Object[] po_ids=null;

			po_ids=(Object[]) XmLRpcOpenERPClient.execute("execute", r);

			// Tegelikult annab viimase kui otsingutulemusi rohkem kui 1, seega tuleb sisendiks anda ainult tapne invoice number.
			for (Object obj : po_ids) {
				invoice_id = Integer.parseInt(obj.toString());
			}

		}
		catch (XmlRpcException e) {
			System.out.println("searchInvoiceByNumber: XmlException Error while logging to OpenERP: "+e);

		}
		catch (Exception e)
		{
			System.out.println("searchInvoiceByNumber error: "+e);
		}

		return invoice_id;
	}

	// searchInvoiceByNumber

	// Makse (voucher) andmete paring id jargi
	// Ega meil pole peale makse numbri suurt midagi vaja sealt makse andmetest

	public int readVoucher(int voucher_id)
	{
		//	Voucher voucher = null;

		String voucher_number;
		try {

			// voucher = new Voucher();

			Object r[]=new Object[8];
			r[0]=client_tinydb;
			r[1]=(Integer)client_id;
			r[2]=client_password;
			r[3]="account.voucher";
			r[4]="read";
			Object voucher_ids[]=new Object[1];
			voucher_ids[0]=voucher_id;
			Object[] voucher_fields = { "number" };

			r[5] = voucher_ids;
			r[6] = voucher_fields;
			Object[] ids ;
			HashMap<String,Object> cdata;

			System.out.println("readCustomer");
			ids=(Object[]) XmLRpcOpenERPClient.execute("execute", r);
			cdata = (HashMap<String,Object>) ids[0];
			voucher_number = (String) cdata.get("number");

			//  voucher.setId(voucher_id);
			//   voucher.setNumber(voucher_number);

			System.out.println("-------voucher---------");
			System.out.println("voucher_number:" + voucher_number);
			System.out.println("-----------------------");


		}
		catch (XmlRpcException e) {
			System.out.println("readVoucher: XmlException Error while logging to OpenERP: "+e);
		}
		catch (Exception e)
		{
			System.out.println("readVoucher error: "+e);

		}
		return voucher_id;
	}

	// readVoucher				

}
