package Adapter;

import java.awt.Color;
import java.awt.Frame;
import java.awt.Graphics;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;

public class MouseAdapterExample extends MouseAdapter {
	private Frame frame;

	public MouseAdapterExample() {
		frame = new Frame("Ví dụ MouseAdapter trong Java AWT");
		frame.addMouseListener(this);
		frame.setSize(400, 300);
		frame.setLayout(null);
		frame.setVisible(true);
// close window
		frame.addWindowListener(new WindowAdapter() {
			public void windowClosing(WindowEvent e) {
				System.exit(1);
			}
		});
	}

	public void mouseClicked(MouseEvent e) {
		Graphics g = frame.getGraphics();
		g.setColor(Color.BLUE);
		g.fillOval(e.getX(), e.getY(), 20, 20);
	}

	/**
	 * main
	 *
	 * @param args
	 */
	public static void main(String[] args) {
		new MouseAdapterExample();
	}
}
