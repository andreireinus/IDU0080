package idu0080.veebitoorik.web.data;

public class Product {
	public Product(int product_id, String name) {
		super();
		this.id = product_id;
		this.name = name;
	}
	int id;
	String name;

	public int getId() {
		return id;
	}
	public void setId(int id) {
		this.id = id;
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	

}
