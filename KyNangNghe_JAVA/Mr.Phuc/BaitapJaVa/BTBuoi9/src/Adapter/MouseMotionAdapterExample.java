package Adapter;

import java.awt.Color;
import java.awt.Frame;
import java.awt.Graphics;
import java.awt.event.MouseEvent;
import java.awt.event.MouseMotionAdapter;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;

public class MouseMotionAdapterExample extends MouseMotionAdapter {
	private Frame frame;

	public MouseMotionAdapterExample() {
		frame = new Frame("Ví dụ MouseMotionAdapter trong Java AWT");
		frame.addMouseMotionListener(this);
		frame.setSize(400, 400);
		frame.setLayout(null);
		frame.setVisible(true);
		// close window
		frame.addWindowListener(new WindowAdapter() {
			public void windowClosing(WindowEvent e) {
				System.exit(1);
			}
		});
	}

	public void mouseDragged(MouseEvent e) {
		Graphics g = frame.getGraphics();
		g.setColor(Color.RED);
		g.fillOval(e.getX(), e.getY(), 10, 10);
	}

	public static void main(String[] args) {
		new MouseMotionAdapterExample();
	}
}
