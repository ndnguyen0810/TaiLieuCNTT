package AWT;

import java.awt.Button;
import java.awt.TextField;

import java.awt.Frame;

public class AWTView extends Frame {
	TextField textField;

	AWTView() {
// tạo các thành phần
		textField = new TextField();
		textField.setBounds(60, 80, 170, 20);
		Button button = new Button("click me");
		button.setBounds(100, 120, 80, 30);
// đăng ký listener
		Controller obj = new Controller(this);
		button.addActionListener(obj);
// thêm thành phần, kích thước, layout, khả năng hiển thị
		setTitle("Vi du xu ly su kien Java AWT");
		add(button);
		add(textField);
		setSize(400, 300);
		setLayout(null);
		setVisible(true);
	}
}