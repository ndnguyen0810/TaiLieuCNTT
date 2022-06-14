package Buoi5;

import java.io.File;

public class ReadDir {
	public static void main(String[] args) {
		File file = null;
		String[] paths;
		try {
			// Tao doi tuong file moi
			file = new File("/tmp");
			// mang cac file va thu muc
			paths = file.list();
			// voi moi ten trong path array
			for (String path : paths) {
				// in ten file va ten thu muc
				System.out.println(path);
			}
		} catch (Exception e) {
			// neu co bat cu error nao xuat hien
			e.printStackTrace();
		}
	}
}