package Buoi5;

import java.io.FileOutputStream;
import java.io.IOException;

public class FileOutputStreamExample2 {
	public static void main(String args[]) throws IOException {
		FileOutputStream fout = null;
		try {
			fout = new FileOutputStream("D:\\testout.txt");
			String s = "Welcome to java.";
			byte b[] = s.getBytes();// converting string into byte array
			fout.write(b);
			fout.close();
			System.out.println("success...");
		} catch (Exception e) {
			System.out.println(e);
		} finally {
			fout.close();
		}
	}
}
