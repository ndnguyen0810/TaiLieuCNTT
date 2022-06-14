package AWT;

import java.awt.Checkbox;
import java.awt.CheckboxGroup;
import java.awt.Frame;
import java.awt.Label;
import java.awt.event.ItemEvent;
import java.awt.event.ItemListener;

public class CheckBoxExample2 {
//	public CheckBoxExample2() {
//		Frame f = new Frame("Ví dụ AWT Checkbox");
//		final Label label1 = new Label();
//		final Label label2 = new Label();
//		label1.setBounds(50, 20, 200, 50);
//		label2.setBounds(50, 50, 200, 50);
//		Checkbox checkbox1 = new Checkbox("C++");
//		checkbox1.setBounds(100, 80, 50, 50);
//		Checkbox checkbox2 = new Checkbox("Java");
//		checkbox2.setBounds(100, 120, 50, 50);
//		f.add(checkbox1);
//		f.add(checkbox2);
//		f.add(label1);
//		f.add(label2);
//		checkbox1.addItemListener(new ItemListener() {
//			public void itemStateChanged(ItemEvent e) {
//				label1.setText("C++ Checkbox: " + (e.getStateChange() == 1 ? "checked" : "unchecked"));
//			}
//		});
//		checkbox2.addItemListener(new ItemListener() {
//			public void itemStateChanged(ItemEvent e) {
//				label2.setText("Java Checkbox: " + (e.getStateChange() == 1 ? "checked" : "unchecked"));
//			}
//		});
//		f.setSize(400, 200);
//		f.setLayout(null);
//		f.setVisible(true);
//	}

	public CheckBoxExample2() {
		Frame f = new Frame("Ví dụ AWT CheckboxGroup");
		final Label label1 = new Label();
		label1.setBounds(50, 50, 200, 20);
		CheckboxGroup cbg = new CheckboxGroup();
		Checkbox checkbox1 = new Checkbox("C++", cbg, false);
		checkbox1.setBounds(100, 80, 50, 20);
		Checkbox checkbox2 = new Checkbox("Java", cbg, true);
		checkbox2.setBounds(100, 100, 50, 20);
		f.add(checkbox1);
		f.add(checkbox2);
		f.add(label1);
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
		f.setSize(400, 200);
		f.setLayout(null);
		f.setVisible(true);
	}

	public static void main(String args[]) {
		new CheckBoxExample2();
	}
}
