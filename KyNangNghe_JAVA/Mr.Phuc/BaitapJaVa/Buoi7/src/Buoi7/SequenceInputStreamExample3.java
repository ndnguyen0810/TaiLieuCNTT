package Buoi5;

import java.io.FileInputStream;
import java.io.IOException;
import java.io.SequenceInputStream;
import java.util.Enumeration;
import java.util.Vector;

public class SequenceInputStreamExample3 {
	public static void main(String args[]) throws IOException {
		// tạo các đối tượng FileInputStream cho tất cả các file
		FileInputStream fin1 = new FileInputStream("D:\\a.txt");
		FileInputStream fin2 = new FileInputStream("D:\\b.txt");
		FileInputStream fin3 = new FileInputStream("D:\\c.txt");
		FileInputStream fin4 = new FileInputStream("D:\\d.txt");
		// Tạo đối tượng Vector để lưu các stram
		Vector<FileInputStream> v = new Vector<FileInputStream>();
		v.add(fin1);
		v.add(fin2);
		v.add(fin3);
		v.add(fin4);
		// Tạo đối Enumeration bởi việc gọi phương thức elements
		Enumeration<FileInputStream> e = v.elements();
		// Truyền đối tượng Enumeration tới constructor
		SequenceInputStream bin = new SequenceInputStream(e);
		int i = 0;
		while ((i = bin.read()) != -1) {
			System.out.print((char) i);
		}
		bin.close();
		fin1.close();
		fin2.close();
		fin3.close();
		fin4.close();
	}
}
