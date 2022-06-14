package Listener;

import java.awt.Frame;
import java.awt.Label;
import java.awt.event.WindowEvent;
import java.awt.event.WindowListener;

public class WindowListenerExample1 extends Frame implements WindowListener {
	private Label label;

	public WindowListenerExample1() {
		label = new Label();
		label.setBounds(20, 50, 200, 20);
		addWindowListener(this);
		add(label);
		setSize(400, 400);
		setLayout(null);
		setVisible(true);
	}

	public void windowActivated(WindowEvent arg0) {
		label.setText("activated");
	}

	public void windowClosed(WindowEvent arg0) {
		System.out.println("closed");
	}

	public void windowClosing(WindowEvent arg0) {
		System.out.println("closing");
		dispose();
	}

	public void windowDeactivated(WindowEvent arg0) {
		label.setText("deactivated");
	}

	public void windowDeiconified(WindowEvent arg0) {
		System.out.println("deiconified");
	}

	public void windowIconified(WindowEvent arg0) {
		System.out.println("iconified");
	}

	public void windowOpened(WindowEvent arg0) {
		System.out.println("opened");
	}

	public static void main(String[] args) {
		new WindowListenerExample1();
	}
}
