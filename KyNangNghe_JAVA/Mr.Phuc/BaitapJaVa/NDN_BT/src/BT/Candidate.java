package BT;

import java.io.Serializable;

public class Candidate implements Serializable {
	private int id;
	private String name;
	private float DToan;
	private float DAnh;
	private float DVan;
	
	public Candidate() {}
	
	public Candidate(int id,String name,float DToan,float DAnh,float DVan) {
		super();
		this.id = id;
		this.name = name;
		this.DToan = DToan;
		this.DAnh = DAnh;
		this.DVan = DVan;
	}
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
	public float getDToan() {
		return DToan;
	}
	public void setDToan(float DToan) {
		this.DToan = DToan;
	}
	public float getDAnh() {
		return DAnh;
	}
	public void setDAnh(float DAnh) {
		this.DAnh = DAnh;
	}
	public float getDVan() {
		return DVan;
	}
	public void setDVan(float DVan) {
		this.DVan = DVan;
	}
}
