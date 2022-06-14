package AWT;

import java.awt.Button;
import java.awt.Frame;
import java.awt.Label;
import java.awt.TextField;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;


public class LabelExample2 extends Frame implements ActionListener {
	private TextField textField;
	private Label label;
	private Button button;

	public LabelExample2() {
		addWindowListener(new WindowAdapter() {
            public void windowClosing(WindowEvent e) {
                dispose();
            }
        });
		textField = new TextField();
		textField.setBounds(50, 50, 150, 20);
		label = new Label();
		label.setBounds(50, 100, 250, 20);
		button = new Button("Find IP");
		button.setBounds(50, 150, 60, 30);
		button.addActionListener(this);
		add(button);
		add(textField);
		add(label);
		setSize(400, 200);
		setLayout(null);
		setVisible(true);
	}

	
	@Override
	public void actionPerformed(ActionEvent e) {
		try {
			String host = textField.getText();
			String ip = java.net.InetAddress.getByName(host).getHostAddress();
			label.setText("IP of " + host + " is: " + ip);
		} catch (Exception ex) {
			System.out.println(ex);
		}
	}

	public static void main(String[] args) {
		new LabelExample2();
	}
}