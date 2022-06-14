package Listener;

import java.awt.Button;
import java.awt.Frame;
import java.awt.TextField;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;

public class ActionListenerExample {
	public static void main(String[] args) {
		Frame frame = new Frame("Ví dụ ActionListener trong Java AWT");
		final TextField textField = new TextField();
		textField.setBounds(50, 50, 150, 20);
		Button button = new Button("Click Here");
		button.setBounds(50, 100, 60, 30);
		button.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				textField.setText("Welcome to Plpsoft.Vn");
			}
		});
		frame.add(button);
		frame.add(textField);
		frame.setSize(450, 200);
		frame.setLayout(null);
		frame.setVisible(true);
		frame.addWindowListener(new WindowAdapter() {
            public void windowClosing(WindowEvent e) {
            	frame.dispose();
            }
        });
	}
}