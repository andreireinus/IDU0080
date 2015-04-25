package idu0080.veebitoorik.web;



import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import java.util.*;

import idu0080.veebitoorik.web.data.*;
import idu0080.veebitoorik.serviceclient.*;

/**
 * Servlet implementation class arve
 */
@WebServlet("/invoice")
public class InvoiceServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;

	/**
	 * @see HttpServlet#HttpServlet()
	 */
	public InvoiceServlet() {
		super();
		// TODO Auto-generated constructor stub
	}

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// Kui keegi pöördub otse servleti aadressile (HTTP-GET) siis suuname POST-päringu töötlemise meetodile,
		// GET-pöördumisega me midagi ei tee.
		doPost(request,response);
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		String s_customer_name =null;
		String s_product_name =null;
		String selected_product_id = null;

		Customer received_customer=null;
		Product [] received_products = null;
		ServiceClientNotReallySOAP soapclient = new ServiceClientNotReallySOAP();
		Product selected_product = null;

		try {


			// Kui kasutaja valis toote vormil välja siis otsime selle toote üles ja paneme request-i et lehel invoice.jsp
			// saaksime seda väljavalitud toodet juba uue arve andmete juures näidata.

			// Selleks et lehe ümberlaadimiste käigus (uus otsing ja sellega seotud uued POST-pöördumised serverile)	
			// väljavalitud toote id säiliks "peidame" HTML vormi peidetud välja ja loeme iga postituse korral servletis selle välja
			// väärtuse requestist ning kirjutame requesti atribuudina tagasi - et saaksime seda invoice.jsp lehel uuesti 
			// trükkida HTML vormi välja "selected_product_id" väärtuseks. 
			// Vt. <input type=hidden name=selected_product_id value="<%=selected_product_id%>">	
			if ((request.getParameter("selected_product_id")!=null) && (!(request.getParameter("selected_product_id").equals(""))))
			{
				selected_product_id = (String) request.getParameter("selected_product_id");
				selected_product = soapclient.getProductById(Integer.parseInt(selected_product_id)) ;
				request.setAttribute ("selected_product_id",selected_product_id );
				request.setAttribute ("selected_product",selected_product );	
			}




			if ((request.getParameter("s_customer_name")!=null) && (!(request.getParameter("s_customer_name").equals(""))))
			{
				s_customer_name = request.getParameter("s_customer_name");
				// kutsume välja kliendi otsingu SOAP-teenuse läbi meie enda soapclient-klassi
				received_customer = soapclient.searchCustomerByName(s_customer_name);
			}
			if ((request.getParameter("s_product_name")!=null) && (!(request.getParameter("s_product_name").equals(""))))
			{
				s_product_name = request.getParameter("s_product_name");
				received_products = soapclient.searchProductsByName(s_product_name);
			}

			// Paneme otsinguvormi sisu request-i et vormi väljade väärtused lehe peal säiliksid,vt. invoice.jsp otsinguvormi.
			request.setAttribute ("s_customer_name", s_customer_name);
			request.setAttribute ("s_product_name", s_product_name);


			if (received_products !=null)
			{
				// Otsinguvormis oli selline kliendi nimi et leidsime (ülevalpool) sellisele nimele vastava kliendi,
				// tekitasime objekti "invoice" ja paneme selle nüüd request-i et invoice.jsp lehel näidata.
				request.setAttribute ("received_products", received_products);	
			}

			if (received_customer !=null)
			{
				// Otsinguvormis oli selline kliendi nimi et leidsime (ülevalpool) sellisele nimele vastava kliendi,
				// tekitasime objekti "received_customer" ja paneme selle nüüd request-i et invoice.jsp lehel näidata.				
				request.setAttribute ("received_customer", received_customer);
			}



			getServletConfig().getServletContext().getRequestDispatcher("/invoice.jsp").forward(request, response);
		} catch (Exception e) {
			// TODO Auto-generated catch block
			System.out.println("InvoiceServlet error:" + e);
		}
		// TODO Auto-generated method stub
	}

}
