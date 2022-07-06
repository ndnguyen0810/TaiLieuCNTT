package buoi1.Vidu;

import java.awt.*;

import javax.swing.*;

public class Full {
	public JFrame mainFrame;
	public JLabel headerLabel;
	public JLabel statusLabel;
	public JPanel controlPanel;
	public JLabel msglabel;
	public JButton b;

	public void prepareGUI() {

		mainFrame = new JFrame("Vi du JPanel trong Java Swing");
		mainFrame.setSize(400, 200);
		mainFrame.setLayout(new GridLayout(3, 1));
		headerLabel = new JLabel("This's Header", JLabel.CENTER);
		statusLabel = new JLabel("This's Lable", JLabel.CENTER);
		statusLabel.setSize(350, 100);
		msglabel = new JLabel("Chao mung ban den voi VietTuts.Vn", JLabel.CENTER);

		controlPanel = new JPanel();
		controlPanel.setLayout(new FlowLayout());
		mainFrame.add(headerLabel);
		mainFrame.add(controlPanel);
		mainFrame.add(statusLabel);
		mainFrame.setVisible(true);
		mainFrame.setDefaultCloseOperation(WindowConstants.EXIT_ON_CLOSE);

	}

	public void showJPanelDemo() {
		headerLabel.setText("Container in action: JPanel");
		JPanel panel = new JPanel();
		panel.setBackground(Color.magenta);
		panel.setLayout(new FlowLayout());
		panel.add(msglabel);
		controlPanel.add(panel);
		mainFrame.setVisible(true);
	}

}
