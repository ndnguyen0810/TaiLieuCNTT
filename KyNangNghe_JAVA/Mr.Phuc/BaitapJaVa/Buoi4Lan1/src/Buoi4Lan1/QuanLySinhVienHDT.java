package Buoi4Lan1;

import java.util.ArrayList;
import java.util.Scanner;

public class QuanLySinhVienHDT {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		ListSinhVien dssv = new ListSinhVien();
		int luaChon = 0;
		do {
			System.out.println("MENU ---------- ");
			System.out.println("Vui lòng chọn chức năng: ");
			System.out.println(
			  "1.	Thêm sinh viên vào danh sách.\n"
			+ "2.	In danh sách sinh viên ra màn hình.\n"
			+ "3.	Kiểm tra danh sách có rỗng hay không.\n"
			+ "4.	Lấy ra số lượng sinh viên trong danh sách.\n"
			+ "5.	Làm rỗng danh sách sinh viên.\n"
			+ "6.	Kiểm tra sinh viên có tồn tại trong danh sách hay không, dựa trên mã sinh viên.\n"
			+ "7.	Xóa một sinh viên ra khỏi danh sách dựa trên mã sinh viên.\n"
			+ "8.	Tìm kiếm tất cả sinh viên dựa trên Tên được nhập từ bàn phím.\n"
			+ "9.	Xuất ra danh sách sinh viên có điểm từ cao đến thấp.\n"
			+ "0.   Thoát khỏi chương trình");
			luaChon = sc.nextInt();
			sc.nextLine();
			
			if(luaChon==1) {
				System.out.println("Nhập mã sinh viên: "); int mSSV = sc.nextInt();
				System.out.println("Nhập họ và tên: "); String hoTen = sc.next();
				System.out.println("Nhập lop: "); String lop = sc.next();

				SinhVien sv = new SinhVien(mSSV, hoTen, lop);
				dssv.themSinhVien(sv);
				
			}else if(luaChon==2) {
				dssv.inDanhSachSinhVien();
				
			}
		}while(luaChon!=0);
	}
}
	
