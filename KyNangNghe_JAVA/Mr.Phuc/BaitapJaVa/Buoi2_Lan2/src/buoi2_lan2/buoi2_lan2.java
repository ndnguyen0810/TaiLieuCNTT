package buoi2_lan2;

import java.util.Scanner;

public class buoi2_lan2 {
	public static Scanner s=new Scanner(System.in);
	
	public static void LayName() {
		String duongdan="D:/music/bolero/muaxuan.mp3";
		String[] mang= duongdan.split("/");
		System.out.println(mang[mang.length-1]);
	}
	
	public static void Panlyndrome() {
		String chuoi;
	    char kyTu;	         
	    System.out.println("Nhập vào chuỗi bất kỳ: ");
	    chuoi = s.nextLine();       
	    for (int i = 0; i < chuoi.length(); i++) {
	        kyTu = chuoi.charAt(chuoi.length() - i - 1);
	        if (chuoi.charAt(i) == kyTu) {
	            System.out.println("chuoi Panlyndrome");
	            break;
	        } else {
	            System.out.println("khong la chuoi Panlyndrome");
	            break;
	        }
	    }
	}
	
	
	public static void ToiUu() {
		String chuoi;      
	    System.out.println("Nhập vào chuỗi bất kỳ: ");
	    chuoi = s.nextLine(); 
		chuoi=chuoi.replaceAll("( )+", " ");
	    String arr[]= chuoi.split(" ");
	    String strFull = "";
	    for(String name:arr) {
	    	name=name.toLowerCase();
	    	strFull = strFull + (name.substring(0, 1).toUpperCase() + name.substring(1));
	    	strFull = strFull + " ";
	    }
	    System.out.println(strFull);
	}
	
	
	public static void main(String[] args) {
		ToiUu();

	}

}
