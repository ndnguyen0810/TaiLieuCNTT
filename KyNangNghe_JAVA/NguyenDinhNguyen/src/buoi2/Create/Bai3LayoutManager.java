package buoi2.Create;

import java.awt.*;

import javax.swing.*;

public class Bai3LayoutManager extends JFrame {
	public Bai3LayoutManager(String tieude) {
		this.setTitle(tieude);
		this.setSize(400, 400);
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setLocationRelativeTo(null);
		this.setResizable(false);
		
		
		this.setLayout(new FlowLayout());
		for( int i=0;i<=20;i++) {
			add(new JButton("Button "+i));
		}
		this.setVisible(true);
	}



	public static void main(String[] args) {
		new Bai3LayoutManager("This is Bai2LayoutManager 3");
	}
}
