package BT;

import java.util.Scanner;

public class BT2 {
	public static final Scanner in = new Scanner(System.in);
	public static void main(String[] args) {
		try {
			System.out.println("Nhập số dòng của mảng: ");
			int m = in.nextInt();
			System.out.println("Nhập số cột của mảng: ");
			int n = in.nextInt();
			int[][] A = new int [m][n];
			for(int i = 0 ; i< m ; i++) {
				for(int j = 0;j<n;j++) {
					 System.out.print("Nhập phần tử thứ [" + i + ", " + j + "]: ");
			         A[i][j] = in.nextInt();
				}
			}
			System.out.println("Mảng vừa nhập: ");
		    for (int i = 0; i < m; i++) {
		        for (int j = 0; j < n; j++) {
		            System.out.print(A[i][j] + "\t");
		        }
		        // sau khi viết xong 1 dòng thi xuống hàng
		        System.out.print("\n");
		        
		    }
		}catch(ArrayIndexOutOfBoundsException e) {
			System.out.println("Error :" + e.getMessage());
		}catch(ArithmeticException e) {
			System.out.println("Error :" + e.getMessage());
		}catch(ClassCastException e) {
			System.out.println("Error :" + e.getMessage());
		}catch(RuntimeException e) {
			System.out.println("Error :" + e.getMessage());
		}
		
	}
}
