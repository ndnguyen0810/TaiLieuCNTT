package baitap_15_bai;

public class BaiTap_15_Bai {

	public static void GiaiPTB1(double a, double b) {
		if(a==0) {
			if(b==0) {
				System.out.println("Phuong trinh vo so nghiem");
			}
			else {
				System.out.println("PT vo nghiem");
			}
			
		}
		else {
			System.out.println("phuong trinh vo nghiem = "+-b/a);
		}
	}
	
	public static void GiaiPTBac2(double a, double b, double c) {
		if(a==0) {
			GiaiPTBac1(b,c);
		}
		else {
			double delta = b*b-4*a*c;
			if(delta<0) {
				System.out.println("PT vô nghiệm");
			}
			else if(delta>0) {
				double x1=(-b+Math.sqrt(delta))/2*a;
				double x2=(-b-Math.sqrt(delta))/2*a;
				System.out.println("PT có 2 nghiệm phân biệt x1= "+ x1 +"; x2="+x2);
			}
			else
				System.out.println("PT có 1 nghiệm kép: x= "+ -b/2*a);
		}
	}

	public static void main(String[] args) {
		// TODO Auto-generated method stub

	}

}
