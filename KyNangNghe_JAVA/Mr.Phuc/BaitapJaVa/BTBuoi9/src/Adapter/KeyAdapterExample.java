package Adapter;

import java.awt.Frame;
import java.awt.Label;
import java.awt.TextArea;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;

public class KeyAdapterExample extends KeyAdapter {
	Label label;
	TextArea textArea;
	Frame frame;

	KeyAdapterExample() {
		frame = new Frame("Ví dụ KeyAdapter trong Java AWT");
		label = new Label();
		label.setBounds(20, 50, 200, 20);
		textArea = new TextArea();
		textArea.setBounds(20, 80, 300, 300);
		textArea.addKeyListener(this);
		frame.add(label);
		frame.add(textArea);
		frame.setSize(400, 400);
		frame.setLayout(null);
		frame.setVisible(true);
// close window
		frame.addWindowListener(new WindowAdapter() {
			public void windowClosing(WindowEvent e) {
				System.exit(1);
			}
		});
	}

	public void keyReleased(KeyEvent e) {
		String text = textArea.getText();
		String words[] = text.split("\\s");
		label.setText("Words: " + words.length + " Characters:" + text.length());
	}

	public static void main(String[] args) {
		new KeyAdapterExample();
	}
}