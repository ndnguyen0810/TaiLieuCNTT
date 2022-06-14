package AWT;

import java.awt.Frame;
import java.awt.List;


public class ListExample1 {
	public ListExample1() {
		Frame frame = new Frame();
		frame.setTitle("Ví dụ List trong Java AWT");
		List list = new List(5);
		list.setBounds(100, 50, 100, 80);
		list.add("C++");
		list.add("Java");
		list.add("PHP");
		list.add("Python");
		list.add("C#");
		list.add("Adroid");
		frame.add(list);
		frame.setSize(400, 250);
		frame.setLayout(null);
		frame.setVisible(true);
	}

	public static void main(String args[]) {
		new ListExample1();
	}
}
