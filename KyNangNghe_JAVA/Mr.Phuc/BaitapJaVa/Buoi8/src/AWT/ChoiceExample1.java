package AWT;

import java.awt.Choice;
import java.awt.Frame;

public class ChoiceExample1 {
	public ChoiceExample1() {
		Frame frame = new Frame("Ví dụ Java AWT Choice");
		Choice choice = new Choice();
		choice.setBounds(100, 100, 150, 150);
		choice.add("C++");
		choice.add("Java");
		choice.add("PHP");
		choice.add("Python");
		choice.add("C#");
		frame.add(choice);
		frame.setSize(400, 250);
		frame.setLayout(null);
		frame.setVisible(true);
	}

	public static void main(String args[]) {
		new ChoiceExample1();
	}
}
