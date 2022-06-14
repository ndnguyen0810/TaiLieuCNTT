package BT5_NDNguyen_QLSV;
import java.util.Scanner;

public class Main {
	public static Scanner scanner = new Scanner(System.in);
	public static void main(String[] args) {
	 String choose = null;
	 boolean exit = false;
	 StudentManager studentManager = new StudentManager();
	 int studentId;
	 // show menu
	 showMenu();
	while (true) {
		choose = scanner.nextLine();
		 switch (choose) {
		 case "1":
			 studentManager.add();
			 break;
		 case "2":
			 studentId = studentManager.inputId();
			 studentManager.edit(studentId);
			 break;
		 case "3":
			 studentId = studentManager.inputId();
			 studentManager.delete(studentId);
			 break;
		 case "4":
			 studentManager.sortStudentByGPA();
			 break;
		 case "5":
			 studentManager.sortStudentByName();
			 break;
		 case "6":
			 studentManager.show();
			 break;
		 case "0":
			 System.out.println("exited!");
			 exit = true;
			 break;
		 default:
			 System.out.println("Không tồn tại! Vui lòng chọn trong menu:");
		 break;
	}
	if (exit) {
		 break;
	 }
	 	showMenu();
	}
}
	 /**
	 * create menu
	 */
	
	 public static void showMenu() {
	 System.out.println("-----------MENU------------");
	 System.out.println("1. Thêm sinh viên");
	 System.out.println("2. Chỉnh sửa sinh viên");
	 System.out.println("3. Xóa sinh viên");
	 System.out.println("4. Sắp xếp theo điểm trung bình");
	 System.out.println("5. Sắp xếp theo tên");
	 System.out.println("6. Hiển thị sinh viên");
	 System.out.println("0. Thoát");
	 System.out.println("---------------------------");
	 System.out.print("Vui lòng chọn: ");
	 }

}
