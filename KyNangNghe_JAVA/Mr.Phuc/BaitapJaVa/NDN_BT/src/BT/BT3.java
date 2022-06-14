package BT;

import java.util.InputMismatchException;
import java.util.Scanner;

public class BT3 {
	private int ngay;
	private int thang;
	private int nam;

	public int getNgay() {
		return ngay;
	}
	
	public void setNgay(int ngay) throws DateException {
	
		if (ngay < 1 || ngay > 31) {
			throw new DateException();
		}
		this.ngay = ngay;
	}
	
	public int getThang() {
		return thang;
	}

	public void setThang(int thang) throws DateException {
		if (thang < 1 || thang > 12) {
			throw new DateException();
		}
		this.thang = thang;
	}
	
	public int getNam() {
		return nam;
	}
	
	public void setNam(int nam) throws DateException {
		if (nam > 2099) {
			throw new DateException();
		}
		this.nam = nam;
	}

	public static void main(String[] args) {
		BT3 sva = new BT3();
		boolean check = false;
		while (!check) {
			try {
				System.out.println("Nhập ngày sinh: ");
				sva.setNgay(new Scanner(System.in).nextInt());
				System.out.println("Nhập tháng: ");
				sva.setThang(new Scanner(System.in).nextInt());
				System.out.println("Nhập năm: ");
				sva.setNam(new Scanner(System.in).nextInt());
				check = true;
			} catch (DateException e) {
				System.out.println(e.getMessage());
			} catch (InputMismatchException e) {
				System.out.println("Lỗi , mời nhập lại");
			}
		}
		System.out.println("Ngày tháng năm sinh vừa nhập là: " + sva.getNgay() + "-" + sva.getThang() + "-" + sva.getNam());
	}
	    public class DateException extends Exception {
	    	public DateException() {	    		
	    	}
	    	@Override
	    	public String getMessage() {
	    		// TODO Auto-generated method stub
	    		return ("Lỗi, Cần phải nhập đúng ngày, tháng, năm");
	    	}
	    }
}
