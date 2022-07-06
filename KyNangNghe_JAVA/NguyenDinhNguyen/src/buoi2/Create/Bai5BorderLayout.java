package buoi2.Create;

import java.awt.BorderLayout;
import java.awt.Color;

import javax.swing.*;

public class Bai5BorderLayout extends JFrame {
	private JButton bn = new JButton("North"),
			bs = new JButton("South"), 
			bw = new JButton("West"),
			be= new JButton("East"),
			bc = new JButton("Center");

	public Bai5BorderLayout() {
		this.setTitle("Border Layout");
		this.setSize(600, 400);
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setLocale(null);
		this.setResizable(false);

		add(BorderLayout.NORTH, bn);
		add(BorderLayout.SOUTH, bs);
		add(BorderLayout.EAST, be);
		add(BorderLayout.WEST, bw);
		add(BorderLayout.CENTER, bc);
		
		bn.setBackground(Color.red);
		bs.setBackground(Color.BLUE);
		be.setBackground(Color.YELLOW);
		bw.setBackground(Color.GRAY);
		bc.setBackground(Color.ORANGE);
		

	}

	public static void main(String[] args) {
		new Bai5BorderLayout().setVisible(true);
		
	}
}
