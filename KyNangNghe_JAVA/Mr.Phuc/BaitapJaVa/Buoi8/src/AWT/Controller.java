package AWT;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Controller implements ActionListener {
	AWTView obj;

	Controller(AWTView obj) {
		this.obj = obj;
	}

	@Override
	public void actionPerformed(ActionEvent e) {
		obj.textField.setText("Welcome to Java AWT");
	}
}