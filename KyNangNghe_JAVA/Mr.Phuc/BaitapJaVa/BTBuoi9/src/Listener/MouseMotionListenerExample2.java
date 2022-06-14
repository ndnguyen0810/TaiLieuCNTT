package Listener;

import java.awt.Color;
import java.awt.Frame;
import java.awt.Graphics;
import java.awt.Label;
import java.awt.event.MouseEvent;
import java.awt.event.MouseMotionListener;

public class MouseMotionListenerExample2 extends Frame implements MouseMotionListener {
	Label label;
	Color color = Color.BLUE;

	public MouseMotionListenerExample2() {
		label = new Label();
		label.setBounds(20, 40, 100, 20);
		add(label);
		addMouseMotionListener(this);
		setSize(400, 400);
		setLayout(null);
		setVisible(true);
	}

	public void mouseDragged(MouseEvent e) {
		label.setText("X=" + e.getX() + ", Y=" + e.getY());
		Graphics g = getGraphics();
		g.setColor(Color.RED);
		g.fillOval(e.getX(), e.getY(), 10, 10);
	}

	public void mouseMoved(MouseEvent e) {
		label.setText("X=" + e.getX() + ", Y=" + e.getY());
	}

	public static void main(String[] args) {
		new MouseMotionListenerExample2();
	}
}