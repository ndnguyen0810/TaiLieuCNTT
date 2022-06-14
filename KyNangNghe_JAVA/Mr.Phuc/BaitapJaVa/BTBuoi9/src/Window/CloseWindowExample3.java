package Window;

import java.awt.Frame;
import java.awt.event.WindowEvent;
import java.awt.event.WindowListener;

public class CloseWindowExample3 extends Frame implements WindowListener {
	public CloseWindowExample3() {
		addWindowListener(this);
		setSize(400, 400);
		setLayout(null);
		setVisible(true);
	}

	public void windowActivated(WindowEvent e) {
	}

	public void windowClosed(WindowEvent e) {
	}

	public void windowClosing(WindowEvent e) {
		dispose();
	}

	public void windowDeactivated(WindowEvent e) {
	}

	public void windowDeiconified(WindowEvent e) {
	}

	public void windowIconified(WindowEvent e) {
	}

	public void windowOpened(WindowEvent arg0) {
	}

	/**
	 * main
	 *
	 * @param args
	 */
	public static void main(String[] args) {
		new CloseWindowExample3();
	}
}
