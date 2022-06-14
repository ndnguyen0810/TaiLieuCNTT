package AWT;

import java.awt.Button;
import java.awt.Frame;

public class AWTExample2 {
	AWTExample2() {
		Frame f = new Frame();
		f.setTitle("Vi du 2 AWT trong java");
		Button b = new Button("click me");
		b.setBounds(30, 50, 80, 30);
		f.add(b);
		f.setSize(300, 300);
		f.setLayout(null);
		f.setVisible(true);
	}

	public static void main(String args[]) {
		new AWTExample2();
	}
}
