package BT5_NDNguyen_QLSV;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;

public class StudentManager {
	public static Scanner scanner = new Scanner(System.in);
	 private List<Student> studentList;
	 private StudentDao studentDao;
	 
	 /**
	 * init StudentDao object and
	 * đọc danh sách sinh viên khi được thêm từ đối tượng StudentManager
	 */
	 
	 public StudentManager() {
		 studentDao = new StudentDao();
		 studentList = studentDao.read();
	 }
	 
	 /**
	 *Thêm sinh viên
	 *
	 * @param student
	 */
	 
	 public void add() {
		 int id = (studentList.size() > 0) ? (studentList.size() + 1):1;
		 System.out.println("ID Sinh Viên = " + id);
		 String name = inputName();
		 byte age = inputAge();
		 String address = inputAddress();
		 float gpa = inputGpa();
		 Student student = new Student(id, name, age, address, gpa);
		 studentList.add(student);
		 
		 studentDao.write(studentList);
	 }
	 
	 public void edit(int id) {
		 boolean isExisted = false;
		 int size = studentList.size();
		 for (int i = 0; i < size; i++) {
			 if (studentList.get(i).getId() == id) {
				 isExisted = true;
				 studentList.get(i).setName(inputName());
				 studentList.get(i).setAge(inputAge());
				 studentList.get(i).setAddress(inputAddress());
				 studentList.get(i).setGpa(inputGpa());
				 break;
			 }
		 }
		 
		 if (!isExisted) {
			 System.out.printf("ID = %d không tồn tại.\n", id);
		 } 
		 else {
			 studentDao.write(studentList);
		 }
	}

	public void delete(int id) {
		 Student student = null;
		 int size = studentList.size();
		 for (int i = 0; i < size; i++) {
			 if (studentList.get(i).getId() == id) {
				 student = studentList.get(i);
				 break;
			 }
		 }
		 if (student != null) {
			 studentList.remove(student);
			 studentDao.write(studentList);
		 } else {
			 System.out.printf("ID = %d không tồn tại.\n", id);
		 }
	}

	public void sortStudentByName() {
		 Collections.sort(studentList, new SortStudentByName());
	}
		 /**
		 * sort student by id
		 */
	public void sortStudentByGPA() {
		 Collections.sort(studentList, new SortStudentByGPA());
	}
		 /**
		 * Hiển thị sinh viên ra màn hình
		 */
	public void show() {
		 for (Student student : studentList) {
			 System.out.format("%5d | ", student.getId());
			 System.out.format("%20s | ", student.getName());
			 System.out.format("%5d | ", student.getAge());
			 System.out.format("%20s | ", student.getAddress());
			 System.out.format("%10.1f%n", student.getGpa());
		 }
	}
		 /**
		 * Nhập sinh viên
		 *
		 * @return trả về ID sinh viên
		 */
	
	public int inputId() {
		 System.out.print("Nhập ID Sinh viên: ");
		 while (true) {
			 try {
				 int id = Integer.parseInt((scanner.nextLine()));
				 return id;
			 } 
			 catch (NumberFormatException ex) {
				 System.out.print("Không tồn tại! Vui lòng nhập lại ID sinh viên: ");
			 }
		 }
	}

		 /**
		 * Nhập tên sinh viên
		 *
		 * @return student name
		 */
	 private String inputName() {
		 System.out.print("Nhập tên sinh viên: ");
		 return scanner.nextLine();
	 }

	 /**
		 * Nhập tuổi sinh viên
		 *
		 * @return student name
		 */
	 
	 private String inputAddress() {
		 System.out.print("Nhập địa chỉ sinh viên: ");
		 return scanner.nextLine();
	}
		 /**
		 * Nhập tuổi sinh viên
		 *
		 * @return student age
		 */
	 private byte inputAge() {
		 System.out.print("Nhập tuổi: ");
		 while (true) {
			 try {
				 byte age = Byte.parseByte((scanner.nextLine()));
				if (age < 0 && age > 100) {
				 throw new NumberFormatException();
			 }
				return age;
			 } 
			 catch (NumberFormatException ex) {
				 System.out.print("Không tồn tại! Nhập tuổi sinh viên: ");
			 }
		 }
	 }
			 /**
			 * input student gpa
			 *
			 * @return gpa
			 */
	 private float inputGpa() {
		 System.out.print("Nhập điểm trung bình: ");
		 while (true) {
			 try {
				 float gpa = Float.parseFloat((scanner.nextLine()));
				 if (gpa < 0.0 && gpa > 10.0) {
				 throw new NumberFormatException();
			 }
				 return gpa;
			 } 
			 catch (NumberFormatException ex) {
				 System.out.print("Không tồn tại! Nhập điểm trung bình: ");
			 }
		 }
	}
			 // getter && setter
	 public List<Student> getStudentList() {
		 return studentList;
	 }
	 
	 public void setStudentList(List<Student> studentList) {
		 this.studentList = studentList;
	 }

	 
}
