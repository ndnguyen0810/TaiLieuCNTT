package NhanVien;
public class NhanVien {
	public String getho() {
		return ho;
	}
	public void setho(String ho) {
		this.ho = ho;
	}
	public String getten() {
		return ten;
	}
	public void setten(String ten) {
		this.ten = ten;
	}
	public int getSoSP() {
		return soSP;
	}
	public void setSoSP(int soSP) {
		this.soSP = soSP;
	}
	private String ho;
	private String ten;
	private int soSP;
	
	public NhanVien(String ho, String ten, int soSP) {
		this.ho= ho;
		this.ten= ten;
		if(soSP<0) {
			this.soSP=0;
		}
		else {
			this.soSP= soSP;
		}			
	}
	public NhanVien() {}
	
	public double getLuong() {		
		if( this.soSP<200) {
			return this.soSP*0.5;
		}
		else if(this.soSP<400){
			return this.soSP*0.55;

		}
		else if(this.soSP<600) {
			return this.soSP*0.6;

		}
		else {
			return this.soSP*0.65;
		}
	}
	
	boolean LonHon(NhanVien nv2) {
		if(this.soSP> nv2.soSP) {
			return true;
		}
		else {
			return false;
		}
	}
	private void hienThiNV() {
		  System.out.println("Họ: " + ho);
	      System.out.println("Tên: " + ten);
	      System.out.println("Số sản phẩm: " + soSP);
	}
	
	public static void main(String[] args) {
		NhanVien nv1= new NhanVien("Nguyen","Dinh Nguyen", 455);
		NhanVien nv2= new NhanVien("Lam","Tac",10);

		nv1.hienThiNV();
		nv2.hienThiNV();
		System.out.println("Lương nhân viên 1: "+nv1.getLuong());
		System.out.println("Lương nhân viên 2: "+nv2.getLuong());
		System.out.println("so sánh: "+nv2.LonHon(nv1));
	}
}
