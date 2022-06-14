package BT5_NDNguyen_QLSV;
import java.util.Comparator;

public class SortStudentByGPA implements Comparator<Student>{
	@Override
	public int compare (Student std1, Student std2) {
		if (std1.getGpa() > std2.getGpa()) {
			 return 1;
			 }
			 return -1;

	}
	

}
