package Buoi5;

import java.io.IOException;
import java.io.InputStreamReader;

public class ReadConsole {
	public static void main(String args[]) throws IOException {
		InputStreamReader cin = null;
		try {
			cin = new InputStreamReader(System.in);
			System.out.println("Nhap cac ky tu, 'q' de thoat.");
			char c;
			do {
				c = (char) cin.read();
				System.out.print(c);
			} while (c != 'q');
		} finally {
			if (cin != null) {
				cin.close();
			}
		}
	}
}
