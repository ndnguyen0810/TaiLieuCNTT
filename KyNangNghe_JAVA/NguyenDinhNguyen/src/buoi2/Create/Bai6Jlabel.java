package buoi2.Create;

import java.awt.*;

import javax.swing.*;

public class Bai6Jlabel extends JFrame {
	public Bai6Jlabel() {
		this.setTitle("JLabel");
		this.setSize(400, 500);
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setResizable(false);
		this.setFocusableWindowState(true);

		Dimension dimension = Toolkit.getDefaultToolkit().getScreenSize();
		int x = (int) ((dimension.getWidth() - this.getWidth()) / 2);
		int y = (int) ((dimension.getHeight() - this.getHeight()) / 2);
		this.setLocation(x, y);

		ImageIcon icon = new ImageIcon(getClass().getResource("icon.png"));
		
		this.setLayout(new FlowLayout());

		
	
	}

	public static void main(String[] args) {
		new Bai6Jlabel().setVisible(true);;
	}
}
