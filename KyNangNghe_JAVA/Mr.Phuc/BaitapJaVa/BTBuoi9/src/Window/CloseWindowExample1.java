package Window;

import java.awt.Frame;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;

public class CloseWindowExample1 extends Frame {
	public CloseWindowExample1() {
		addWindowListener(new WindowAdapter() {
			public void windowClosing(WindowEvent e) {
				dispose();
			}
		});
		setSize(400, 400);
		setLayout(null);
		setVisible(true);
	}

	/**
	 * * main
	 *
	 * @param args
	 */
	public static void main(String[] args) {
		new CloseWindowExample1();
	}
}
