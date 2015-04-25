package idu0080.openerp.data;

public class PurchaseOrder {
	int id;
	String name="";
	String state="";
	String date_order="";
	String notes="";
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
	public String getState() {
		return state;
	}
	public void setState(String state) {
		this.state = state;
	}
	public String getDate_order() {
		return date_order;
	}
	public void setDate_order(String date_order) {
		this.date_order = date_order;
	}
	public String getNotes() {
		return notes;
	}
	public void setNotes(String notes) {
		this.notes = notes;
	}

}
