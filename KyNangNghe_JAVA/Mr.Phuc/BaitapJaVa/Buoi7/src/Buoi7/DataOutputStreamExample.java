package Buoi5;

import java.io.DataOutputStream;
import java.io.FileOutputStream;
import java.io.IOException;

public class DataOutputStreamExample {
	public static void main(String[] args) throws IOException {
		FileOutputStream file = null;
		DataOutputStream data = null;
		try {
			file = new FileOutputStream("D:\\testout.txt");
			data = new DataOutputStream(file);
			data.writeInt(65);
			data.flush();
			System.out.println("Succcess...");
		} catch (IOException ex) {
		} finally {
			data.close();
		}
	}
}
