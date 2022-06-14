package Buoi5;

import java.io.ByteArrayOutputStream;
import java.io.FileOutputStream;
import java.io.IOException;

public class ByteArrayOutputStreamExample {
	public static void main(String args[]) throws Exception {
		FileOutputStream fout1 = null;
		FileOutputStream fout2 = null;
		ByteArrayOutputStream bout = null;
		try {
			fout1 = new FileOutputStream("D:\\f1.txt");
			fout2 = new FileOutputStream("D:\\f2.txt");
			bout = new ByteArrayOutputStream();
			String data = "Hello";
			bout.write(data.getBytes());
			bout.writeTo(fout1);
			bout.writeTo(fout2);
			bout.flush();
			System.out.println("Success...");
		} catch (IOException ex) {
			ex.printStackTrace();
		} finally {
			fout1.close();
			fout2.close();
			bout.close();
		}
	}
}