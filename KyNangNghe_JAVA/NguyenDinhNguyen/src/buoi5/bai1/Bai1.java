package buoi5.bai1;

import java.awt.BorderLayout;
import java.awt.Button;
import java.awt.Container;
import java.awt.FlowLayout;
import java.awt.Image;

import javax.swing.*;

public class Bai1 extends JFrame {
	public Bai1(String title) {
		this.setTitle(title);
//		addcontrol();
		addevents();
	}

	private void addevents() {

		JOptionPane.showMessageDialog(this, "Data not accept !!!", "Notice", JOptionPane.ERROR_MESSAGE);
		JOptionPane.showConfirmDialog(this, "Exit App ???", "Choose a action", JOptionPane.YES_NO_OPTION);
		JOptionPane.showInputDialog(this, "Input a char", "Input", JOptionPane.QUESTION_MESSAGE);

	}

	public void Show() {
		this.setSize(500, 160);
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setLocationRelativeTo(null);
		this.setResizable(false);
		this.setVisible(true);
	}

	public static void main(String[] args) {

		new Bai1("Nguyen Dinh Nguyen").Show();
	}
}
