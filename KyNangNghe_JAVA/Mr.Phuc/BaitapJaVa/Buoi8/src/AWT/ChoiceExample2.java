package AWT;

import java.awt.Button;
import java.awt.Choice;
import java.awt.Frame;
import java.awt.Label;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class ChoiceExample2 {
	public ChoiceExample2() {
		Frame frame = new Frame("Ví dụ Java AWT Choice");
		final Label label = new Label();
		label.setAlignment(Label.CENTER);
		label.setSize(400, 100);
		Button button = new Button("Show");
		button.setBounds(200, 100, 50, 20);
		final Choice choice = new Choice();
		choice.setBounds(100, 100, 75, 75);
		choice.add("C++");
		choice.add("Java");
		choice.add("PHP");
		choice.add("Python");
		choice.add("C#");
		frame.add(choice);
		frame.add(label);
		frame.add(button);
		frame.setSize(400, 250);
		frame.setLayout(null);
		frame.setVisible(true);
		button.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				String data = "Ngôn ngữ lập trình được ch�?n: " + choice.getItem(choice.getSelectedIndex());
				label.setText(data);
			}
		});
	}

	public static void main(String args[]) {
		new ChoiceExample2();
	}
}
