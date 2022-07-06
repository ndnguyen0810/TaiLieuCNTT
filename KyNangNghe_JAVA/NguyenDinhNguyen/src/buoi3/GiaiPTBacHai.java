package buoi3;

import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.*;

public class GiaiPTBacHai extends JFrame {
	JTextField txtHSA, txtHSB, txtHSC, txtKetqua;
	JButton btnGiai, btnThoat, btnHelp;

	ActionListener enventGiai = new ActionListener() {

		@Override
		public void actionPerformed(ActionEvent e) {
			// TODO Auto-generated method stub
			XuLyGiaiPT();
		}

		public void XuLyGiaiPT() {
			Double hsa = Double.parseDouble(txtHSA.getText());
			Double hsb = Double.parseDouble(txtHSB.getText());
			Double hsc = Double.parseDouble(txtHSC.getText());
			
			Double denta = hsb * hsb - 4 * hsa * hsc;
			Float canDenta = (float) Math.sqrt(denta);
			Float x = (float) (-hsb / (2*hsa));
			Float x1= (float) ((-hsb+canDenta)/(2*hsa));
			Float x2= (float) ((-hsb-canDenta)/(2*hsa));
			
			if (hsa == 0 && hsb == 0 && hsc != 0) {
				JOptionPane.showMessageDialog(null, "Phương trình vô nghiệm!");
				
			} else if (hsa == 0 && hsb != 0 && hsc != 0) {
				JOptionPane.showMessageDialog(null, "Phương trình có nghiệm x = " + -hsc / hsb);
				
			} else {
				if(denta>0) {
					JOptionPane.showMessageDialog(null, "Phương trình 2 nghiệm: x1= "+x1+", x2= "+x2);
					
				}if(denta==0) {
					JOptionPane.showMessageDialog(null, "Phương trình 2 nghiệm kep: x1= x2= "+x);
					
				}
				else {
					JOptionPane.showMessageDialog(null, "Phương trình vô nghiệm!");
				}
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
	
	private void addEvents() {
		btnGiai.addActionListener(enventGiai);
		btnHelp.addActionListener(enventHelp);
		btnThoat.addActionListener(enventClose);
	}

	private GiaiPTBacHai() {
		this.setTitle("Nguyễn Đình Nguyên");
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
		JLabel lblTieuDe = new JLabel("Giải phương trình bậc 2");
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

		JPanel pnHSC = new JPanel();
		pnHSA.setLayout(new FlowLayout());
		JLabel lblHSC = new JLabel("Hệ số c: ");
		txtHSC = new JTextField(15);
		pnHSC.add(lblHSC);
		pnHSC.add(txtHSC);
		pnMain.add(pnHSC);

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
		this.setSize(500, 300);
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setLocationRelativeTo(null);
		this.setResizable(false);
		this.setVisible(true);

	}

	public static void main(String[] args) {
		new GiaiPTBacHai().Show();
	}
}
