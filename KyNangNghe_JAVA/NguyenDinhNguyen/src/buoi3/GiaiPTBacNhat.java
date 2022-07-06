package buoi3;

import java.awt.Color;
import java.awt.Container;
import java.awt.FlowLayout;
import java.awt.Font;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.print.attribute.AttributeSet;
import javax.swing.*;
import javax.swing.text.BadLocationException;

public class GiaiPTBacNhat extends JFrame {
	JTextField txtHSA, txtHSB, txtKetqua;
	JButton btnGiai, btnThoat, btnHelp;

	ActionListener enventGiai = new ActionListener() {

		@Override
		public void actionPerformed(ActionEvent e) {
			// TODO Auto-generated method stub
			XuLyGiaiPT();
		}

		private void XuLyGiaiPT() {
			Double hsa = Double.parseDouble(txtHSA.getText());
			Double hsb = Double.parseDouble(txtHSB.getText());

			if (hsa == 0 && hsb != 0) {
				JOptionPane.showMessageDialog(null, "Phương trình vô nghiệm!");

			} else {
				JOptionPane.showMessageDialog(null, "Phương trình có nghiệm x = " + -hsb / hsa);

			}

		}

	};

	ActionListener enventHelp = new ActionListener() {

		@Override
		public void actionPerformed(ActionEvent e) {
			help();

		}

		public void help() {
			JOptionPane.showMessageDialog(null, "Lien He Co Trinh");

		}
	};

	ActionListener enventClose = new ActionListener() {

		@Override
		public void actionPerformed(ActionEvent e) {
			help();

		}

		public void help() {
			System.exit(0);

		}
	};

	public void addEvents() {
		btnGiai.addActionListener(enventGiai);
		btnHelp.addActionListener(enventHelp);
		btnThoat.addActionListener(enventClose);
	}

	public GiaiPTBacNhat() {
		this.setTitle("Nguyễn ĐÌnh Nguyên");
		addControler();
		addEvents();
	}

	private void addControler() {
		Container con = getContentPane();
		JPanel pnMain = new JPanel();
		pnMain.setLayout(new BoxLayout(pnMain, BoxLayout.Y_AXIS));
		con.add(pnMain);

		JPanel pnTitle = new JPanel();
		pnTitle.setLayout(new FlowLayout());
		JLabel lblTieuDe = new JLabel("Giải phương trình bậc 1");
		pnTitle.add(lblTieuDe);
		lblTieuDe.setForeground(Color.BLUE);
		Font fontTitle = new Font("arial", Font.BOLD, 20);
		lblTieuDe.setFont(fontTitle);
		pnMain.add(pnTitle);
		con.add(pnMain);

		JPanel pnHSA = new JPanel();
		pnHSA.setLayout(new FlowLayout());
		JLabel lblHSA = new JLabel("Hệ số a: ");
		txtHSA = new JTextField(15);
		pnHSA.add(lblHSA);
		pnHSA.add(txtHSA);
		pnMain.add(pnHSA);

		JPanel pnHSB = new JPanel();
		pnHSA.setLayout(new FlowLayout());
		JLabel lblHSB = new JLabel("Hệ số b: ");
		txtHSB = new JTextField(15);
		pnHSB.add(lblHSB);
		pnHSB.add(txtHSB);
		pnMain.add(pnHSB);

		JPanel pnButton = new JPanel();
		pnButton.setLayout(new FlowLayout());
		btnGiai = new JButton("Giải");
		btnThoat = new JButton("Thoát");

		btnHelp = new JButton("Help");
		pnButton.add(btnGiai);
		pnButton.add(btnThoat);
		pnButton.add(btnHelp);
		pnMain.add(pnButton);

		JPanel pnKetQua = new JPanel();
		pnKetQua.setLayout(new FlowLayout());
		JLabel lblKetQua = new JLabel("Kết quả :");
		txtKetqua = new JTextField(15);
		txtKetqua.setEditable(false);
		pnKetQua.add(lblKetQua);
		pnKetQua.add(txtKetqua);
		pnMain.add(pnKetQua);
	}

	public void Show() {
		this.setSize(500, 200);
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setLocationRelativeTo(null);
		this.setResizable(false);
		this.setVisible(true);

	}

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		new GiaiPTBacNhat().Show();

	}

}
