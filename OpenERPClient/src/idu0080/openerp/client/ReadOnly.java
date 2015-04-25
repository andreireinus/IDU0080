/**
 * @author Raul Liivrand 
 * @version 1.0  12/03/2013
 * TTU 2013
 */

package idu0080.openerp.client;

import java.net.URL;
import java.util.*;

import org.apache.xmlrpc.XmlRpcException;
import org.apache.xmlrpc.client.XmlRpcClient;
import org.apache.xmlrpc.client.XmlRpcClientConfigImpl;


public class ReadOnly {

	/**
	 * @param args
	 */
	public static void main(String[] args) {


		OpenERPClient client = new OpenERPClient("openerp_eng","admin","openerp_eng","193.40.244.170",1099);

		client.getDatabaseList();
		int id = client.Connect();
		client.XmLRpcOpenERPClient = client.getOpenERPClient();
		System.out.println("connected user id:" + Integer.toString(id));


		// Toote otsing
		client.readProducts(client.searchProducts("HD"));

		// Arve andmete lugemine arve id järgi


		// Kliendi otsing. Anda ette selline olemasolev kliendi (tapne) nimi mis annab ainult yhe kliendi vastuseks.
		int customer_id = client.searchCustomer("Syleam");
		// Trykib kliendi andmed konsoolile
		client.readCustomer(customer_id);
		int invoice_id = client.searchInvoiceByNumber("SAJ/2013/018");
		System.out.println("invoice_id:" + invoice_id);
		// arve andmete lugemine arve id järgi
		client.readInvoice(invoice_id);




	}

}
