package Toolkit;

import java.awt.Frame;
import java.awt.Image;
import java.awt.Toolkit;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;

public class ToolkitExample3 {
	public ToolkitExample3() {
		Frame frame = new Frame();
		Image icon = Toolkit.getDefaultToolkit().getImage("D:\\icon.png");
		frame.setIconImage(icon);
		frame.setLayout(null);
		frame.setSize(400, 400);
		frame.setVisible(true);
		frame.addWindowListener(new WindowAdapter() {
			public void windowClosing(WindowEvent e) {
				frame.dispose();
			}
		});
	}

	public static void main(String args[]) {
		new ToolkitExample3();
	}
}