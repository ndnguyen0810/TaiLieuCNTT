package BT5_NDNguyen_QLSV;
import java.util.Comparator;

public class SortStudentByName implements Comparator<Student>{
	@Override
	 public int compare(Student std1, Student std2) {
	 return std1.getName().compareTo(std2.getName());
	 }


}
