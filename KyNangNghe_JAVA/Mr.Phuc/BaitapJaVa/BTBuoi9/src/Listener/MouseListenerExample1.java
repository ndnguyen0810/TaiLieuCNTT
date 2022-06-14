package Listener;

import java.awt.Frame;
import java.awt.Label;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;

public class MouseListenerExample1 extends Frame implements MouseListener {
	private Label label;

	public MouseListenerExample1() {
		addMouseListener(this);
		label = new Label();
		label.setBounds(20, 50, 100, 20);
		add(label);
		setSize(300, 300);
		setLayout(null);
		setVisible(true);
	}

	public void mouseClicked(MouseEvent e) {
		label.setText("Mouse Clicked");
	}

	public void mouseEntered(MouseEvent e) {
		label.setText("Mouse Entered");
	}

	public void mouseExited(MouseEvent e) {
		label.setText("Mouse Exited");
	}

	public void mousePressed(MouseEvent e) {
		label.setText("Mouse Pressed");
	}

	public void mouseReleased(MouseEvent e) {
		label.setText("Mouse Released");
	}

	public static void main(String[] args) {
		new MouseListenerExample1();
	}
}