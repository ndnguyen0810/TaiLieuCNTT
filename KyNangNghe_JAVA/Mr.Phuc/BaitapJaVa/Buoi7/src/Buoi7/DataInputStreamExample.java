package Buoi5;

import java.io.DataInputStream;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStream;

public class DataInputStreamExample {
	public static void main(String[] args) throws IOException {
		InputStream input = null;
		DataInputStream dis = null;
		try {
			input = new FileInputStream("D:\\testout.txt");
			dis = new DataInputStream(input);
			int count = input.available();
			byte[] arr = new byte[count];
			dis.read(arr);
			for (byte bt : arr) {
				char k = (char) bt;
				System.out.print(k + "-");
			}
		} catch (IOException ex) {
		} finally {
			dis.close();
		}
	}
}
