package AWT;
import java.awt.Button;
import java.awt.Frame;

public class AWTExample1 extends Frame {
	AWTExample1() {
		setTitle("Vi du 1 AWT trong java");
		Button b = new Button("click me");
		b.setBounds(30, 100, 80, 30); // cai dat vi tri button
		add(b); // them doi tuong button vao frame
		setSize(300, 300); // kich thuoc frame voi width = 300 va height = 300
		setLayout(null); // khong trinh quan ly layout
		setVisible(true); // hien thi frame
	}

	public static void main(String args[]) {
		new AWTExample1();
	}
}
