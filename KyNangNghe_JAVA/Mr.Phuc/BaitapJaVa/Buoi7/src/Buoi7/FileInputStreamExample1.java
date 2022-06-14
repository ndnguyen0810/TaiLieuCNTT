package Buoi5;

import java.io.FileInputStream;
import java.io.IOException;

public class FileInputStreamExample1 {
	public static void main(String args[]) throws IOException {
		FileInputStream fin = null;
		try {
			fin = new FileInputStream("D:\\testout.txt");
			int i = fin.read();
			System.out.print((char) i);
			fin.close();
		} catch (Exception e) {
			System.out.println(e);
		} finally {
			fin.close();
		}
	}
}
