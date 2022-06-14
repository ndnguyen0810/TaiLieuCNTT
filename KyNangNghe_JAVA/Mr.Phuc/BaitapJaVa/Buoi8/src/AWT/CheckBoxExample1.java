package AWT;

import java.awt.Checkbox;
import java.awt.CheckboxGroup;
import java.awt.Frame;

public class CheckBoxExample1 {
//	public CheckBoxExample1() {
//		Frame f = new Frame("Ví dụ AWT Checkbox");
//		Checkbox checkbox1 = new Checkbox("C++");
//		checkbox1.setBounds(100, 50, 50, 50);
//
//		Checkbox checkbox2 = new Checkbox("Java", true);
//		checkbox2.setBounds(100, 90, 50, 50);
//
//		f.add(checkbox1);
//		f.add(checkbox2);
//		f.setSize(400, 200);
//		f.setLayout(null);
//		f.setVisible(true);
//	}

	public CheckBoxExample1() {
		Frame f = new Frame("Ví dụ AWT CheckboxGroup");
		CheckboxGroup cbg = new CheckboxGroup();
		Checkbox checkbox1 = new Checkbox("C++", cbg, false);
		checkbox1.setBounds(100, 50, 50, 50);
		Checkbox checkbox2 = new Checkbox("Java", cbg, true);
		checkbox2.setBounds(100, 90, 50, 50);
		f.add(checkbox1);
		f.add(checkbox2);
		f.setSize(400, 200);
		f.setLayout(null);
		f.setVisible(true);
	}

	public static void main(String args[]) {
		new CheckBoxExample1();
	}
}
