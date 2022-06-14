package Buoi4Lan1;

public class ConNguoi {
	private String hoTen;
	private String chungMinhNhanDan;
	private String gioiTinh;
	private String ngaySinh;
	
	public ConNguoi(String hoTen, String chungMinhNhanDan, String gioiTinh, String ngaySinh) {
		this.hoTen= hoTen;
		this.chungMinhNhanDan= chungMinhNhanDan;
		this.gioiTinh= gioiTinh;
		this.ngaySinh= ngaySinh;
	}
	
	public void inThongTin() {
		System.out.println("Ho ten: "+ this.hoTen);
		System.out.println("Chung minh nhan dan: "+ this.chungMinhNhanDan);
		System.out.println("Gioi tinh: "+ this.gioiTinh);
		System.out.println("Ngay sinh: "+ this.ngaySinh);
	}
	
	


}
