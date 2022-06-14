package List;

import java.awt.Button;
import java.awt.Frame;
import java.awt.Label;
import java.awt.List;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;

public class ListExample2 {
	ListExample2() {
		Frame frame = new Frame();
		final Label label = new Label();
		label.setAlignment(Label.CENTER);
		label.setSize(500, 100);
		Button button = new Button("Show");
		button.setBounds(200, 150, 80, 30);
// tham so thu hai cua ham khoi tao List = false, không cho phép chọn nhiều
		final List list1 = new List(4, false);
		list1.setBounds(100, 100, 80, 80);
		list1.add("C");
		list1.add("C++");
		list1.add("Java");
		list1.add("PHP");
// tham so thu hai cua ham khoi tao List = true, cho phép chọn nhiều
		final List list2 = new List(4, true);
		list2.setBounds(100, 200, 80, 80);
		list2.add("Struts");
		list2.add("Spring");
		list2.add("Hibernate");
		list2.add("EJB");
//add các thành phần vào frame
		frame.setTitle("Ví dụ List trong Java AWT");
		frame.add(list1);
		frame.add(list2);
		frame.add(label);
		frame.add(button);
		frame.setSize(500, 300);
		frame.setLayout(null);
		frame.setVisible(true);
		frame.addWindowListener(new WindowAdapter() {
            public void windowClosing(WindowEvent e) {
            	frame.dispose();
            }
        });
//đăng ký Listener
		button.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				String data = "Ngôn ngữ lập trình được chọn: " + list1.getItem(list1.getSelectedIndex());
				data += ", Framework được chọn:";
				for (String frame : list2.getSelectedItems()) {
					data += frame + " ";
				}
				label.setText(data);
			}
		});
	}

	public static void main(String args[]) {
		new ListExample2();
	}
}