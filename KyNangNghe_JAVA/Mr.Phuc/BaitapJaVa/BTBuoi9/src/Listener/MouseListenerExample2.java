package Listener;

import java.awt.Color;
import java.awt.Frame;
import java.awt.Graphics;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;

public class MouseListenerExample2 extends Frame implements MouseListener {
	public MouseListenerExample2() {
		addMouseListener(this);
		setSize(300, 300);
		setLayout(null);
		setVisible(true);
	}

	public void mouseClicked(MouseEvent e) {
		Graphics g = getGraphics();
		g.setColor(Color.RED);
		g.fillOval(e.getX(), e.getY(), 30, 30);
	}

	public void mouseEntered(MouseEvent e) {
	}

	public void mouseExited(MouseEvent e) {
	}

	public void mousePressed(MouseEvent e) {
	}

	public void mouseReleased(MouseEvent e) {
	}

	public static void main(String[] args) {
		new MouseListenerExample2();
	}
}
