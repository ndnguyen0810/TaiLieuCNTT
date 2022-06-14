package Buoi5;

import java.io.FileInputStream;
import java.io.IOException;

public class FileInputStreamExample2 {
	public static void main(String args[]) throws IOException {
		FileInputStream fin = null;
		try {
			fin = new FileInputStream("D:\\testout.txt");
			int i = 0;
			while ((i = fin.read()) != -1) {
				System.out.print((char) i);
			}
			fin.close();
		} catch (Exception e) {
			System.out.println(e);
		} finally {
			fin.close();
		}
	}
}
