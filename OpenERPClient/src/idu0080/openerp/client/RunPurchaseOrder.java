package idu0080.openerp.client;

import java.net.URL;
import java.util.*;

import org.apache.xmlrpc.XmlRpcException;
import org.apache.xmlrpc.client.XmlRpcClient;
import org.apache.xmlrpc.client.XmlRpcClientConfigImpl;

import idu0080.openerp.data.*;

public class RunPurchaseOrder {

	/**
	 * @param args
	 */
	public static void main(String[] args) {


		OpenERPClient client = new OpenERPClient("openerp_eng","admin","openerp_eng","193.40.244.170",1099);

		client.getDatabaseList();
		int id = client.Connect();
		client.XmLRpcOpenERPClient = client.getOpenERPClient();
		System.out.println("connected user id:" + Integer.toString(id));


		// Ostutellimuse otsing

		int[] order_ids=client.searchPurchaseOrder("PO00002");

		int i;
		for(i=0; i<order_ids.length; i++)
		{
			client.readPurchaseOrder(order_ids[i]);
			PurchaseOrder po = client.readPurchaseOrderStudent(order_ids[i]);
			System.out.println("PurachaseObject.getId():" + po.getId());
			System.out.println("PurachaseObject.getName():" + po.getName());
			System.out.println("PurachaseObject.getDate_order():" + po.getDate_order());
			System.out.println("PurachaseObject.getNotes():" + po.getNotes());
			System.out.println("PurachaseObject.getState():" + po.getState());

		}






	}


}
