package AWT;

import java.awt.Button;
import java.awt.Frame;
import java.awt.Label;
import java.awt.TextArea;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class TextAreaExample2 extends Frame implements ActionListener{
	private Label label1, label2;
	private TextArea textArea;
	private Button button;

	public TextAreaExample2() {
		label1 = new Label();
		label1.setBounds(50, 50, 100, 30);
		label2 = new Label();
		label2.setBounds(160, 50, 100, 30);
		textArea = new TextArea();
		textArea.setBounds(20, 100, 300, 300);
		button = new Button("Count Words");
		button.setBounds(100, 400, 100, 30);
		button.addActionListener(this);
		add(label1);
		add(label2);
		add(textArea);
		add(button);
		setSize(400, 450);
		setLayout(null);
		setVisible(true);
	}

	@Override
	public void actionPerformed(ActionEvent e) {
		String text = textArea.getText();
		String words[] = text.split("\\s");
		label1.setText("Words: " + words.length);
		label2.setText("Characters: " + text.length());
	}

	public static void main(String[] args) {
		new TextAreaExample2();
	}

	@Override
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub
		
	}
}
