package Listener;

import java.awt.Checkbox;
import java.awt.CheckboxGroup;
import java.awt.Frame;
import java.awt.Label;
import java.awt.event.ItemEvent;
import java.awt.event.ItemListener;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;

public class ItemListenerExample {
	public ItemListenerExample() {
		Frame frame = new Frame("Ví dụ ItemListener trong Java AWT");
		frame.addWindowListener(new WindowAdapter() {
            public void windowClosing(WindowEvent e) {
            	frame.dispose();
            }
        });
		final Label label1 = new Label();
		label1.setBounds(50, 50, 200, 20);
		CheckboxGroup cbg = new CheckboxGroup();
		Checkbox checkbox1 = new Checkbox("C++", cbg, false);
		checkbox1.setBounds(100, 80, 50, 20);
		Checkbox checkbox2 = new Checkbox("Java", cbg, true);
		checkbox2.setBounds(100, 100, 50, 20);
		frame.add(checkbox1);
		frame.add(checkbox2);
		frame.add(label1);
		checkbox1.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent e) {
				label1.setText("C++ Checkbox: " + (e.getStateChange() == 1 ? "checked" : "unchecked"));
			}
		});
		checkbox2.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent e) {
				label1.setText("Java Checkbox: " + (e.getStateChange() == 1 ? "checked" : "unchecked"));
			}
		});
		frame.setSize(400, 200);
		frame.setLayout(null);
		frame.setVisible(true);
	}

	public static void main(String args[]) {
		new ItemListenerExample();
	}
}
