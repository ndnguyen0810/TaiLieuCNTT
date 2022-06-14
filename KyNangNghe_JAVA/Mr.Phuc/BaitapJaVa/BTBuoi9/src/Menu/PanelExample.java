package Menu;

import java.awt.Button;
import java.awt.Color;
import java.awt.Frame;
import java.awt.Panel;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;

public class PanelExample {
	PanelExample() {
		Frame frame = new Frame("Ví dụ Panel trong Java AWT");
		Panel panel = new Panel();
		panel.setBounds(40, 80, 200, 200);
		panel.setBackground(Color.gray);
		Button button1 = new Button("Button 1");
		button1.setBounds(50, 100, 80, 30);
		button1.setBackground(Color.yellow);
		Button button2 = new Button("Button 2");
		button2.setBounds(100, 100, 80, 30);
		button2.setBackground(Color.green);
		panel.add(button1);
		panel.add(button2);
		frame.add(panel);
		frame.setSize(400, 400);
		frame.setLayout(null);
		frame.setVisible(true);
		frame.addWindowListener(new WindowAdapter() {
            public void windowClosing(WindowEvent e) {
            	frame.dispose();
            }
        });
	}

	public static void main(String args[]) {
		new PanelExample();
	}
}