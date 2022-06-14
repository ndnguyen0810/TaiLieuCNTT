package Window;

import java.awt.Frame;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;

public class CloseWindowExample2 extends WindowAdapter {
	private Frame frame;

	public CloseWindowExample2() {
		frame = new Frame();
		frame.addWindowListener(this);
		frame.setSize(400, 400);
		frame.setLayout(null);
		frame.setVisible(true);
	}

	public void windowClosing(WindowEvent e) {
		frame.dispose();
	}

	/**
	 * main
	 *
	 * @param args
	 */
	public static void main(String[] args) {
		new CloseWindowExample2();
	}
}