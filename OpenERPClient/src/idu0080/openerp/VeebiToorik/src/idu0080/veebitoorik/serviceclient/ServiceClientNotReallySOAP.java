/** See klass emuleerib SOAP-teenuse klienti
 * Tegelikult tuleks siia panna geneeritud veebteenuse kliendiklasside väljakutsed
 * nii nagu tegite ülesandes 2 ja ülesandes 5.
 **/
package idu0080.veebitoorik.serviceclient;

import idu0080.veebitoorik.web.data.*;

public class ServiceClientNotReallySOAP {

	public Product[] searchProductsByName(String product_name)
	{
		Product[] products = null;
		// Sisendiga "no" saame emuleerida otsingut mis ei anna tooteid vastuseks
		if (!(product_name.equals("no")))
		{	
			products = new Product[4];
			products[0] = new Product(1,"HDD Seagate 7200.8 120GB");
			products[1] = new Product(2,"Dell Poweredge 1800");
			products[2] = new Product(3,"MS SQL Server 2008");
			products[3] = new Product(4,"Dysan CD");
		}
		return products;
	}

	public Product getProductById(int product_id)
	{
		Product product = null;

		switch(product_id) {
		case 1:
			product = new Product(1,"HDD Seagate 7200.8 120GB");
			break;
		case 2:
			product = new Product(2,"Dell Poweredge 1800");
			break;
		case 3:
			product = new Product(3,"MS SQL Server 2008");
			break;
		case 4:
			product = new Product(4,"Dysan CD");
			break;
		default:
			product = new Product(5,"SomeProduct");

		}

		return product;

	}

	public Customer searchCustomerByName(String customer_name)
	{
		Customer customer = null;


		switch(customer_name) {
		case "Axelor":
			customer = new Customer(1,"Axelor");
			break;
		case "Agrolait":
			customer = new Customer(2,"Agrolait");
			break;
		case "Maxtor":
			customer = new Customer(3,"Maxtor");
			break;
		case "ASUStek":
			customer = new Customer(4,"ASUStek");
			break;


		}


		return customer;
	}

}
