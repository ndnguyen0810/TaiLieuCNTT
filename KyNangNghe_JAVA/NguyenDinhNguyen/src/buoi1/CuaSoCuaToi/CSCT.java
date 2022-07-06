package buoi1.CuaSoCuaToi;

import java.awt.*;

import javax.swing.*;

public class CSCT extends JFrame {

	public CSCT(String tieude) {
		this.setTitle(tieude);

		addControler();
	}

	private void addControler() {
		Container con = getContentPane();
		JPanel pn = new JPanel();
		pn.setBackground(Color.BLUE);
		JButton btn = new JButton("Click here!");
		pn.add(btn);
		con.add(pn);

	}

	public void Show() {
		this.setSize(400, 400);
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setLocationRelativeTo(null);
		this.setResizable(false);
		this.setVisible(true);
	}
}
