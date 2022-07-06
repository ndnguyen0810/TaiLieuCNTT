package buoi2.Create;

import javax.swing.*;

public class Bai4BoxLayout extends JFrame {

	public Bai4BoxLayout() {
		this.setTitle("This is BorderLayout 4");
		this.setSize(400, 400);

		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setLocationRelativeTo(null);
		this.setResizable(false);
		this.setVisible(true);
		Box bv, bh1, bh2, bv1;
		add(bv = Box.createVerticalBox());
		bv.add(bh1 = Box.createHorizontalBox());
		bv.add(bh2 = Box.createHorizontalBox());
		bv.add(bv1 = Box.createVerticalBox());

		for (int i = 0; i <= 3; i++) {
			bh1.add(Box.createHorizontalGlue());
			bh1.add(new JButton("Button " + i));
		}
		bv1.add(Box.createHorizontalGlue());
		
		for (int i = 0; i <= 3; i++) {
			
			bh2.add(new JButton("Button " + i));
		}
		
		for (int i = 0; i <= 3; i++) {
			bh1.add(Box.createHorizontalStrut(5));
			bh1.add(new JButton("Button " + i));
		}
		bv1.add(Box.createHorizontalStrut(5));
		
	}

	public static void main(String[] args) {
		new Bai4BoxLayout().setVisible(true);;

	}

}
