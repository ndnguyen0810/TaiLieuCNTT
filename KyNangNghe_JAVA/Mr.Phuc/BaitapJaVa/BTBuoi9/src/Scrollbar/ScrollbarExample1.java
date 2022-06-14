package Scrollbar;

import java.awt.Frame;
import java.awt.Scrollbar;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;

public class ScrollbarExample1 {
	public ScrollbarExample1() {
		Frame f = new Frame("Ví dụ Scrollbar trong Java AWT");
		Scrollbar s = new Scrollbar();
		s.setBounds(350, 150, 15, 200);
		f.add(s);
		f.setSize(400, 400);
		f.setLayout(null);
		f.setVisible(true);
		f.addWindowListener(new WindowAdapter() {
            public void windowClosing(WindowEvent e) {
            	f.dispose();
            }
        });
	}

	public static void main(String args[]) {
		new ScrollbarExample1();
	}
}