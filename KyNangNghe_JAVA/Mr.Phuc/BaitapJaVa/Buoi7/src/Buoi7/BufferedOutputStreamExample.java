package Buoi5;

import java.io.BufferedOutputStream;
import java.io.FileOutputStream;
import java.io.IOException;

public class BufferedOutputStreamExample {
	public static void main(String args[]) throws IOException {
		FileOutputStream fout = null;
		BufferedOutputStream bout = null;
		try {
			fout = new FileOutputStream("src/buoi5/testout.txt");
			bout = new BufferedOutputStream(fout);
			String s = "Welcome to java.";
			byte b[] = s.getBytes();
			bout.write(b);
			bout.flush();
		} catch (IOException ex) {
			ex.printStackTrace();
		} finally {
			bout.close();
			fout.close();
		}
		System.out.println("success!");
	}
}
