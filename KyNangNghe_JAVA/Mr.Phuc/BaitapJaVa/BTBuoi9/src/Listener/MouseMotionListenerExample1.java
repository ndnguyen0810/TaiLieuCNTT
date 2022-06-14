package Listener;

import java.awt.Color;
import java.awt.Frame;
import java.awt.Graphics;
import java.awt.event.MouseEvent;
import java.awt.event.MouseMotionListener;

public class MouseMotionListenerExample1 extends Frame implements MouseMotionListener {
	public MouseMotionListenerExample1() {
		addMouseMotionListener(this);
		setSize(400, 400);
		setLayout(null);
		setVisible(true);
	}

	public void mouseDragged(MouseEvent e) {
		Graphics g = getGraphics();
		g.setColor(Color.BLUE);
		g.fillOval(e.getX(), e.getY(), 10, 10);
	}

	public void mouseMoved(MouseEvent e) {
	}

	public static void main(String[] args) {
		new MouseMotionListenerExample1();
	}
}
