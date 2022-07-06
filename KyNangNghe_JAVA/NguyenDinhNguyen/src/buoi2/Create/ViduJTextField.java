package buoi2.Create;

import java.awt.*;

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;

public class ViduJTextField extends JFrame {
	public ViduJTextField() {

		JPanel pn = new JPanel();
		pn.setLayout(new FlowLayout());
		JLabel jb = new JLabel("Nhap ho ten");

	}

	public void Show() {
		this.setTitle("textfield");
		this.setSize(400, 400);
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setLocationRelativeTo(null);
		this.setResizable(false);

	}

	public static void main(String[] args) {
		// TODO Auto-generated method stub

	}

}
