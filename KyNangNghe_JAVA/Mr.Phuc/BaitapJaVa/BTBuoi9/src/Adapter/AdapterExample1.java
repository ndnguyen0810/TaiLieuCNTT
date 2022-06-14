package Adapter;

import java.awt.Frame;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;

public class AdapterExample1 {
	Frame frame;

	AdapterExample1() {
		frame = new Frame("Ví dụ WindowAdapter trong Java AWT");
		frame.addWindowListener(new WindowAdapter() {
			public void windowClosing(WindowEvent e) {
				frame.dispose();
			}
		});
		frame.setSize(400, 250);
		frame.setLayout(null);
		frame.setVisible(true);
	}

	public static void main(String[] args) {
		new AdapterExample1();
	}
}