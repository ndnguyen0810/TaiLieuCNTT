package BT;

import java.util.Scanner;

public class CandidateManager {
	public static Scanner scanner = new Scanner(System.in);
	Candidate cand ;
	public void add() {
		int id = inputId(); 
		String name = inputName();
		float DToan = inputDToan();
		float DAnh = inputDAnh();
		float DVan = inputDVan();
		cand = new Candidate(id, name, DToan, DAnh, DVan);
	}
	
	public void show() {
		System.out.format("%5d | ", cand.getId());
		System.out.format("%20s | ", cand.getName());
		System.out.format("%10.1f%n| ", cand.getDToan());
		System.out.format("%10.1f%n| ", cand.getDAnh());
		System.out.format("%10.1f%n", cand.getDVan());
	}
	
	public int inputId() {
		System.out.print("Nhập ID Sinh viên: ");
		while (true) {
			try {
				int id = Integer.parseInt((scanner.nextLine()));
				return id;
			} catch (NumberFormatException ex) {
				System.out.print("Không hợp lệ! Nhập lại Mã Thí Sinh: ");
			}
		}
	}

	private String inputName() {
		System.out.print("Nhập Tên Thí Sinh: ");
		int check = 0;
		while (true) {
			try {
				String s = scanner.nextLine();
				String[] output = s.split(" ");
			    for(int i =0 ;i< output.length;i++) {
			    	for (int j = 0; j < output[i].length(); j++) {
			            if (Character.isLetter(output[i].charAt(j))) {
			                check+=1;
			            }else {
							throw new NumberFormatException();
			            }
			        } 
			    }
				if(check > 0) {
					return s;
				}
			} catch (NumberFormatException ex) {
				System.out.print("Không hợp lệ!\nNhập lại Tên Thí Sinh: ");
			}
		}
		
	}
	
	private float inputDToan() {
		System.out.print("Nhập Điểm Toán: ");
		while (true) {
			try {
				float Dtoan = Float.parseFloat((scanner.nextLine()));
				if (Dtoan < 0.0 || Dtoan > 10.0) {
					throw new NumberFormatException();
				}
				return Dtoan;
			} catch (NumberFormatException ex) {
				System.out.print("Không hợp lệ !! Phải trên 0 và dưới 10!\n Nhập lại Điểm Toán: ");
			}
		}
	}
	
	private float inputDAnh() {
		System.out.print("Nhập Điểm Anh: ");
		while (true) {
			try {
				float DAnh = Float.parseFloat((scanner.nextLine()));
				if (DAnh < 0.0 || DAnh > 10.0) {
					throw new NumberFormatException();
				}
				return DAnh;
			} catch (NumberFormatException ex) {
				System.out.print("Không hợp lệ !! Phải trên 0 và dưới 10 !\n Nhập lại Điểm Anh: ");
			}
		}
	}
	
	private float inputDVan() {
		System.out.print("Nhập Điểm Văn: ");
		while (true) {
			try {
				float DVan = Float.parseFloat((scanner.nextLine()));
				if (DVan < 0.0 || DVan > 10.0) {
					throw new NumberFormatException();
				}
				return DVan;
			} catch (NumberFormatException ex) {
				System.out.print("Không hợp lệ !! Phải trên 0 và dưới 10 !\n Nhập lại Điểm Văn: ");
			}
		}
	}
}