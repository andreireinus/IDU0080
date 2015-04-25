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


public class InvoiceWorkFlow {

	/**
	 * @author: Raul Liivrand
	 * TTU 2013
	 * Arve forkflow kaivitamine- arve tegemisest kuni maksmise pealekandmiseni.
	 */
	public static void main(String[] args) {


		OpenERPClient client = new OpenERPClient("openerp_eng","admin","openerp_eng","193.40.244.170",1099);
		client.Connect();
		System.out.println("user id" + Integer.toString(client.client_id));
		// client.OpenERPClient = client.getOpenERPClient();
		client.XmLRpcOpenERPClient = client.getOpenERPClient();

		// Arve tegemine ja maksmise pealekandmine, arvega matchimine
		// NB! Lisab OpenEP-i arve, arve read, makse (voucher) ja matchib arve maksega (et arve on makstud).

		// Peab olema eksisteeriva customer-i nimi, sisestage OpenERP-i oma customer ja kasutage seda nime.
		// Teie lahenduses sisestab kliendi nime otsinguvormile kasutaja.

		//---------KLIENDI OTSING------------
		int customer_id = client.searchCustomer("Ryhm322klient");
		// client.readCustomer(customer_id);
		// Teie lahenduses valib toote otsingutulemuste hulgast välja kasutaja veebivormil.
		// Siin praegu tuleb võtta lihtsalt otsingutulemuste hulgast esimene toode.

		//---------TOOTE OTSING JA ESIMESE TOOTE VÄLJAVALIMINE------------
		int product_id = client.getFirstProductId(client.searchProducts("rootor"));
		String productName = client.readProduct(product_id);
		// Teie lahenduses saate hinna toote andmetest: product.getPrice(). Praegu tuleb ette anda
		// kuna meil on ainult toote nimi.

		//----------------------ARVE TEGEMINE--------------------------
		Double price=450.0;
		// Teie lahenduses saate toote arvu (mid aarvega müüakse) veebivormilt, kasutaja sisestab.
		// Praegu tuleb ette anda.
		Double invoice_product_qty=1.0;
		int invoice_id = client.createInvoice(customer_id,productName,product_id,price,invoice_product_qty);
		client.validateInvoice(invoice_id);

		// ----------MAKSMINE-------------
		// Makse summa anname ette, teie lahenduses tuleb see vormilt (payment.jsp).
		String amount = "300";
		int move_line_id = client.readInvoiceMoveLineId(invoice_id);
		String invoice_number=client.readInvoice(invoice_id);
		int voucher_id = client.createVoucher(customer_id,invoice_number,amount,invoice_id,move_line_id);
		// kinnitame ka kohe makse.
		client.validatePayment(voucher_id);


		//------KAUBA VÄLJAANDMINE----------
		// OpenERP ega see käesolev Java klient (klassi OpenERPClient meetodid)
		// ei kontrolli kas arve on makstud,kas selle arvega seotud kaup on juba välja antud (arve märkuses "KAUP KAES"), kas laos kaupa on.	
		// Seda kontrolli peab tegema teie veebteenus enne kui allpool olevaid OpenERPClient klassi meetodeid välja kutsub.	
		Double delivery_product_qty=1.0;
		client.registerProductDelivery(product_id, delivery_product_qty,productName,customer_id);
		// Arve kommentaari salvestamine, OpenERP-is näeb vormil "Additional information".
		// Selle kommentaari järgi saame kontrollida kas oleme kauba juba kätte andnud (et mitu korda ei annaks)
		client.writeInvoiceComment(invoice_id, "KAUP KAES");
		System.out.println("ARVE, MAKSE ja KAUBA KÄTTEANDMINE LAOST tehtud.");
		System.out.println("ARVE NUMBER OLI:"+invoice_number);
		// workflow lopp, arve on makstud

	}

}
