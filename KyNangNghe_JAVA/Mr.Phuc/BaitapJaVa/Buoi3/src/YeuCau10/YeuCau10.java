package YeuCau10;

import java.util.ArrayList;
import java.util.Scanner;

public class YeuCau10 {
	public static Scanner input = new Scanner (System.in);
	public static void main(String[] args) {
		ArrayList<String> ds= new ArrayList<String>();
		System.out.println("Nhap so luong: ");
		int n= input.nextInt();
		String pt;
		for(int i=0;i<n;i++) {
			System.out.println("Nhap phan tư: ");
			pt= input.next();
			ds.add(pt);
		}
		
		
		for (int i = 0; i < ds.size(); i++) {
			System.out.println(ds.get(i));
			}

	}

}
