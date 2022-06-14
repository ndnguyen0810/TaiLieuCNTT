package Buoi4Lan1;

import java.util.ArrayList;

public class ListSinhVien {
	private ArrayList<SinhVien> SinhVienList;
	
	public ListSinhVien() {
		this.SinhVienList = new ArrayList<SinhVien>();
	}
	
	public ListSinhVien( ArrayList<SinhVien> SinhVienList ) {
		this.SinhVienList = SinhVienList;
	}
	
	public void themSinhVien(SinhVien sv) {
		this.SinhVienList.add(sv);
	}
	
//	2.	In danh sách sinh viên ra màn hình
	public void inDanhSachSinhVien() {
		for (SinhVien sv : SinhVienList) {
			System.out.println(sv);
		}
	}
	
	public boolean xoaSinhVien(SinhVien sv) {
		return this.SinhVienList.remove(sv);
	}
	

	public static void main(String[] args) {
		// TODO Auto-generated method stub

	}

}
