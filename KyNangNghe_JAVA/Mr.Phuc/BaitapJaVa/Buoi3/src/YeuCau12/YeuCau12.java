package YeuCau12;

import java.util.ArrayList;
import java.util.Scanner;

public class YeuCau12 {
	public static Scanner input = new Scanner (System.in);
	public static void main(String[] args) {
		ArrayList<String> SV= new ArrayList<String>();
		System.out.println("Nhap so luong sv: ");
		int n= input.nextInt();
		String pt;
		for(int i=0;i<n;i++) {
			System.out.println("Nhập tên sinh viên: ");
			pt= input.next();
			SV.add(pt);
		}
		
		System.out.println("Danh sác sinh viên: ");
		for (int i = 0; i < SV.size(); i++) {
			System.out.println("SV"+(i+1)+": "+SV.get(i));
		}
		
		System.out.println("Bạn muốn xóa SV thứ mấy: ");
		n=input.nextInt();
		if(n<=SV.size()) {
			SV.remove(n-1);
			System.out.println("Danh sác sinh viên sau khi xóa: ");
			for (int i = 0; i < SV.size(); i++) {
				System.out.println("SV"+(i+1)+": "+SV.get(i));
			}
		}
		else {
			System.out.println("Không có SV tại vị trí đó: ");
		}
		
		String search="a";
		for(int i=0;i<SV.size();i++) {
			if(SV.get(i).contains(search)){
				System.out.println("Tìm thấy sv An");
			}
			else {
				System.out.println("Không Tìm thấy sv An");
			}
		}
	}

}
