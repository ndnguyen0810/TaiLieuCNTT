package AWT;

import java.awt.Frame;
import java.awt.TextArea;

public class TextAreaExample1 {
	public TextAreaExample1() {
		Frame f = new Frame();
		TextArea area = new TextArea("Welcome to Plpsoft.Vn\n" + "Ví dụ AWT TextArea");
		area.setBounds(20, 30, 300, 300);
		f.setTitle("Ví dụ AWT TextArea");
		f.add(area);
		f.setSize(400, 400);
		f.setLayout(null);
		f.setVisible(true);
	}

	public static void main(String args[]) {
		new TextAreaExample1();
	}
}
