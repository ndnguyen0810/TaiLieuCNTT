package Buoi5;

import java.io.File;

public class CreateDir {
	public static void main(String args[]) {
		String dirname = "/tmp/user/java/bin";
		File d = new File(dirname);
		// Bay gio tao thu muc.
		d.mkdirs();
	}
}
