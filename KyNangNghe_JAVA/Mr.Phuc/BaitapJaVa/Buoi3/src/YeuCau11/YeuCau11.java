package YeuCau11;


import java.util.HashMap;

import java.util.Scanner;

public class YeuCau11 {

	public static Scanner input = new Scanner (System.in);


	public static void main(String[] args) {
		HashMap<Integer, String> Book = new HashMap<>();
		String Name;
		int ID;
		
		System.out.println("Nhập số lượng sách: ");
		int n= input.nextInt();
		for (int i=1;i<=n;i++) {
			System.out.println("Nhập ID: ");
			ID=input.nextInt();
			System.out.println("Nhập tên sách: ");
			Name = input.nextLine();
			Book.put(ID, Name);
		}
		

	}

}
