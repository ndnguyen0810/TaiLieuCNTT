package AWT;

import java.awt.Button;
import java.awt.Frame;
import java.awt.TextField;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class AWTEventHandling3 extends Frame {
	TextField textField;

	AWTEventHandling3() {
		textField = new TextField();
		textField.setBounds(60, 50, 170, 20);
		Button button = new Button("click me");
		button.setBounds(50, 120, 80, 30);
		button.addActionListener(new ActionListener() {
			@Override
			public void actionPerformed(ActionEvent e) {
				textField.setText("Hello World!");
			}
		});
		setTitle("Vi du xu ly su kien Java AWT");
		add(button);
		add(textField);
		setSize(400, 300);
		setLayout(null);
		setVisible(true);
	}

	public static void main(String args[]) {
		new AWTEventHandling3();
	}
}