package AWT;

import java.awt.Canvas;
import java.awt.Color;
import java.awt.Frame;
import java.awt.Graphics;

public class CanvasExample {
	public CanvasExample() {
		Frame f = new Frame("Ví dụ Canvas trong Java AWT");
		f.add(new MyCanvas());
		f.setLayout(null);
		f.setSize(400, 400);
		f.setVisible(true);
		}
		public static void main(String args[]) {
		new CanvasExample();
		}
		}
		class MyCanvas extends Canvas {
		public MyCanvas() {
		setBackground(Color.GRAY);
		setSize(300, 300);
		}
		@Override
		public void paint(Graphics g) {
		// vẽ hình tròn
		g.setColor(Color.red);
		g.fillOval(100, 75, 100, 100);
		// vẽ hình vuông
		g.setColor(Color.green);
		g.fillRect(150, 150, 100, 100);
		}
}
