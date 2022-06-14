package Buoi5;

import java.io.Console;

public class ConsoleExample2 {
	public static void main(String args[]) {
		Console c = System.console();
		System.out.println("Enter password: ");
		char[] ch = c.readPassword();
		// convert char array into string
		String pass = String.valueOf(ch);
		System.out.println("Password is: " + pass);
	}
}
