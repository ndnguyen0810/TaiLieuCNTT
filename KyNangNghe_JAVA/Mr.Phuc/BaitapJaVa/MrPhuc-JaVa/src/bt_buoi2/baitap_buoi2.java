package bt_buoi2;

import java.util.Scanner;

public class baitap_buoi2 {

	
	public  static String Bai1(double a) {		
		String s = (a>=0)? "So duong":"so am";
		return s;
	}
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		String s = new Scanner(System.in).nextLine();
		double x =new Scanner(System.in).nextDouble();
		Bai1(x);
	}

}
