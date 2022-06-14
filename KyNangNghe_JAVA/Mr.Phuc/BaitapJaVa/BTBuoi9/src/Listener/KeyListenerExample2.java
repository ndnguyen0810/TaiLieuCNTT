package Listener;

import java.awt.Frame;
import java.awt.Label;
import java.awt.TextArea;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;

public class KeyListenerExample2 extends Frame implements KeyListener {
	private Label label;
	private TextArea textArea;

	public KeyListenerExample2() {
		label = new Label();
		label.setBounds(20, 50, 200, 20);
		textArea = new TextArea();
		textArea.setBounds(20, 80, 300, 300);
		textArea.addKeyListener(this);
		add(label);
		add(textArea);
		setSize(400, 400);
		setLayout(null);
		setVisible(true);
	}

	public void keyPressed(KeyEvent e) {
	}

	public void keyReleased(KeyEvent e) {
		String text = textArea.getText();
		String words[] = text.split("\\s");
		label.setText("Words: " + words.length + " Characters:" + text.length());
	}

	public void keyTyped(KeyEvent e) {
	}

	public static void main(String[] args) {
		new KeyListenerExample2();
	}
}