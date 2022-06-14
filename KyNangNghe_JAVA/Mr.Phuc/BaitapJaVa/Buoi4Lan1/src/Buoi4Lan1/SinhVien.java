package Buoi4Lan1;

import java.util.Scanner;

public class SinhVien {


	private int mSSV;
	private String hoTen;
	private String lop;
//	public static Scanner input= new Scanner();
	


	public  SinhVien(int mSSV, String hoTen, String lop) {
		this.mSSV= mSSV;
		this.hoTen= hoTen;
		this.lop= lop;
	}
	
	public int getmSSV() {
		return mSSV;
	}

	public void setmSSV(int mSSV) {
		this.mSSV = mSSV;
	}

	public String getHoTen() {
		return hoTen;
	}

	public void setHoTen(String hoTen) {
		this.hoTen = hoTen;
	}

	public String getLop() {
		return lop;
	}

	public void setLop(String lop) {
		this.lop = lop;
	}
	
	public void nhapThongTinh(Scanner sc) {
		System.out.println("MSSV: "); mSSV=sc.nextInt();
		System.out.println("Ho Ten: ");hoTen= sc.next();
		System.out.println("Lop: "); lop=sc.next();		
	}
	
    public void hienThiThongTin() {
        System.out.println("MSSV: " + mSSV);
        System.out.println("Ho Ten: " + hoTen);
        System.out.println("Lop: " + lop);
    }
	
}
