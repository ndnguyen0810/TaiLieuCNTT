package Buoi3;

import java.util.Arrays;
import java.util.Scanner;

public class Buoi3 {
	public static Scanner input = new Scanner (System.in);
//	trang 163
	public static void NhapMang(int Arr[]) {
		for(int i=0;i<Arr.length;i++) {
			System.out.println("Nhập vào phần tử thứ "+(i + 1) +" trong mảng: " );
			Arr[i]= input.nextInt();
		}
		
	}
	
	public static void XuatMang(int Arr[]) {
		System.out.println("Các phần tử chứa trong mang là: ");
		for (int i = 0; i < Arr.length; i++) {
			System.out.print(Arr[i]+"\t");
		}
		System.out.println();
	}
		
//	TRang 167
	public static void TimPhanTu(int M[], int k) { //Tìm phần tử k có trong mảng hay không
		boolean timThay=false;
		for (int i = 0; i < M.length; i++) {
			if(M[i]==k) {
				timThay=true;
					break;
		}
		}
		if(timThay==true) {
			System.out.println("Có tìm thấy "+k+" trong mảng");
		}
		else {
			System.out.println("Không tim thấy "+k+" trong mảng");
		}
	}

	public static void TimSoLanXuatHienPhanTu(int M[], int k) { //Tìm số lần xuất hiện của phần tử k
		String s="";
		int solan=0;
		for (int i = 0; i < M.length; i++) {
			if(M[i]==k) {
				s+=i+";";
				solan++;
			}
		}
		if(s.length()>0) {
			System.out.println("Tìm thấy "+k+" xuất hiên "+solan+" lần");
			System.out.println("Các vị trí này là: "+s);
		}
		else {
			System.out.println("Không tìm thấy "+k);
		}
	}
//BubbleSort
	public static void BubbleSort(int []M){
	      int i, j;
	      for(i=0; i<M.length -1; i++){
	            for(j=M.length -1; j>i; j--){
		     if(M[j] < M[j-1]) {//nếu có nghịch thế
		     	 int temp = M[j];
		      	M[j] = M[j-1];
		      	M[j-1] = temp;
		      }
		}
	      }
	}

//Trang 175
	public static void Sort_BubbleSort(int []M) {
		System.out.println("Mảng sau khi sắp xếp bằng BubbleSort là: \t");
		BubbleSort(M);
		XuatMang(M);
	}
	
	public static void Sort_ArraySort(int []M) {
		System.out.println("Mảng sau khi sắp xếp bằng ArraySort là: \t");
		Arrays.sort(M);
		XuatMang(M);
	}
	
//Trang 178
	public static void NhapMang2Chieu(int [][]M2) {
		System.out.println("Nhập vào số dòng của mảng 2 chiều: ");
		int n= input.nextInt();
		for(int i=0;i<n;i++) {
			M2[i]=new int [i+1];
			for(int j=0;i<i+1;j++) {
				M2[i][j]=i+1;
			}
		}
	}
	public static void XuatMang2Chieu(int [][]M2) {
		for(int i=0;i<M2.length;i++) {
			for(int j=0;j<M2[i].length;j++) {
				System.out.println(M2[i][j]+ " ");
			}
			System.out.println();
		}
	}
	

//Trang 180
	public static void NhapArrRand(int []Arr) {//Nhập vào 1 mảng N số ngẫu nhiêm	
		for(int i=0;i< Arr.length;i++) {
			Arr[i]= (int) (Math.random()*100);	
		}
	}
	
	public static void XuatArrRand(int []Arr) {//Xuat vào 1 mảng N số ngẫu nhiêm
		System.out.println("Các phần tử chứa trong mang là: ");
		for (int i = 0; i < Arr.length; i++) {
			System.out.print(Arr[i]+"\t");
		}
		System.out.println();
	}
	
	public static int SumArr(int []Arr) { //Tính tổng
		int sum=0;
		for( int num : Arr) {
            sum = sum+num;
        }     
		return sum;
	}
	
	public static int MaxArr(int []Arr) { //Tìm phần tử lớn nhất
		int max= Arr[0];
		for(int num:Arr) {
			if(max < num)
		        max = num;
		}
		return max;
	}
	
	public static int MinArr(int []Arr) { //Tìm phần tử nhỏ nhất
		int min= Arr[0];
		for(int num:Arr) {
			if(min > num)
		        min = num;
		}
		return min;
	}
	
	public static  boolean checkNguyenTo(int n){ //Check số nguyên tố
		if(n<=2){
			   return true;
		}else {
			for(int i =2;i<=Math.sqrt(n);i++){
				if(n % i == 0)
					return false;
			}
		}
		return true;
	}
	public static void InSNT(int []M) {
		String NT="";
		for(int i=0;i<M.length;i++) {
			if(checkNguyenTo(M[i])==true) {
				NT= M[i]+" ;";
			}
		}
		System.out.println("Danh sách số nguyên tố trong mảng: " + NT);
	}
	
	public static void sortASC(int [] Arr) { //Tăng dần
        int temp = Arr[0];
        for (int i = 0 ; i < Arr.length - 1; i++) {
            for (int j = i + 1; j < Arr.length; j++) {
                if (Arr[i] > Arr[j]) {
                    temp = Arr[j];
                    Arr[j] = Arr[i];
                    Arr[i] = temp;
                }
            }
        }
        System.out.println("Mảng sau khi sắp xếp tăng dần là: \t");
		XuatMang(Arr);
    }
	
    public static void sortDESC(int [] Arr) { //Giảm dần
        int temp = Arr[0];
        for (int i = 0 ; i < Arr.length - 1; i++) {
            for (int j = i + 1; j < Arr.length; j++) {
                if (Arr[i] < Arr[j]) {
                    temp = Arr[j];
                    Arr[j] = Arr[i];
                    Arr[i] = temp;
                }
            }
        }
        System.out.println("Mảng sau khi sắp xếp giảm dần là: \t");
		XuatMang(Arr);
	
    }
    
//Trang 181
    
    
    
    
//Trang 182
	public static void main(String[] args) {
		System.out.println("Nhập số phần tử của mảng:");
		int n=input.nextInt();
		int []M=new int[n];
//		System.out.println("Nhập giá trị cho mảng:");
//		NhapMang(M);
//		XuatMang(M);
//		Sort_BubbleSort(M);
		NhapArrRand(M);
		XuatArrRand(M);
		System.out.println("Tổng: "+SumArr(M));
		System.out.println("Nhập phần tử cần tìm:");
		int k=input.nextInt();
		TimSoLanXuatHienPhanTu(M,k);
		System.out.println("Max: "+MaxArr(M));
		System.out.println("Min: "+MinArr(M));
		InSNT(M);
		sortASC(M);
		sortDESC(M);
	}

}
