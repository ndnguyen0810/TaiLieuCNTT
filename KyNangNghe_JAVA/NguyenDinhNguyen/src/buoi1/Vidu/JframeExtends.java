package buoi1.Vidu;

import java.awt.Button;
import java.awt.Color;
import java.awt.event.ActionEvent;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;

public class JframeExtends extends JFrame {
	Button b;
	public JframeExtends() {
		setLocation(300, 200);
		setResizable(false);
		setSize(300, 300);
		setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
		setVisible(true);
		setTitle("Nguyễn Đình Nguyên");
		JLabel l1;
		l1 = new JLabel("Đây là giao diện nè hihi");
		l1.setBounds(10, 50, 200, 50);
		add(l1);
		
		
		add(b);
		
	}
	// @Override
	    public void actionPerformed(ActionEvent ae) {
//	        if (ae.getSource()== b)
	            

	       
	    }

}
