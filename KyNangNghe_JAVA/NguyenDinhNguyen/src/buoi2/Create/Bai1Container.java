package buoi2.Create;

import java.awt.*;

import javax.swing.*;

public class Bai1Container extends JFrame {
	public Bai1Container(String tieude) {
		this.setTitle(tieude);
		
	}

	
	public void Show() {
		this.setSize(400, 400);
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setLocationRelativeTo(null);
		this.setResizable(false);
		this.setVisible(true);
	}

	public static void main(String[] args) {
		new Bai1Container("This is Container 1").Show();
	}

}
