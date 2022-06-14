package Buoi4Lan1;

public class GiangVien extends ConNguoi {
	private String maSo;
	private String namCongTac;
	
	
	public GiangVien(String hoTen, String chungMinhNhanDan, String gioiTinh, String ngaySinh, String maSo, String namCongTac) {
		super(hoTen, chungMinhNhanDan, gioiTinh, ngaySinh);
		this.maSo= maSo;
		this.namCongTac= namCongTac;
	}
	
	public void hienThiThongTin() {
		super.inThongTin();
		System.out.println("Ma so: "+this.maSo);
		System.out.println("Nam cong tac: "+ this.namCongTac);
	}
	

}
