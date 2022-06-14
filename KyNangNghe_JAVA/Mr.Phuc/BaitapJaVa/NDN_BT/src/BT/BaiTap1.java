package BT;

import java.util.Scanner;

public class BaiTap1 {
	public static final Scanner in = new Scanner(System.in);
	public static void main(String[] args) {
		try {
			System.out.println("Biểu thức : A = sqrt(((5*x)-y)/((2*x)+(7*y)))");
			System.out.println("Nhập giá trị của x: ");
			int x = in.nextInt();
			System.out.println("Nhập giá trị của y: ");
			int y = in.nextInt();
			int A = ((5*x)-y);
			int B = ((2*x)+(7*y));
			double KQ =Math.sqrt(A/B);
			System.out.println("Kết quả của biểu thức A = "+ KQ);
		}catch(ArithmeticException e) {
			System.out.println("Error :" + e.getMessage());
		}
	}	
}
