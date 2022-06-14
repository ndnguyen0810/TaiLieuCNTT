package Buoi5;

import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.SequenceInputStream;

public class SequenceInputStreamExample2 {
	public static void main(String args[]) throws IOException {
		FileInputStream fin1 = new FileInputStream("D:\\testin.txt");
		FileInputStream fin2 = new FileInputStream("D:\\testout.txt");
		FileOutputStream fout = new FileOutputStream("D:\\testout2.txt");
		SequenceInputStream sis = new SequenceInputStream(fin1, fin2);
		int i;
		while ((i = sis.read()) != -1) {
			fout.write(i);
		}
		sis.close();
		fout.close();
		fin1.close();
		fin2.close();
		System.out.println("Success..");
	}
}