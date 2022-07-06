package buoi3;

import java.awt.*;
import java.awt.event.*;

import javax.swing.*;

public class TinhLai extends JFrame implements ActionListener {

	JTextField txtTienGui, txtTienLai, txtLaiSuat, txtThang;
	JButton btnTinh, btnNhapLai;

	public TinhLai(String title) {
		this.setTitle(title);
		addControl();
	}

	protected void XuLyTinhLai() {
		String tg = txtTienGui.getText();
		String ls = txtLaiSuat.getText();
		String t = txtThang.getText();
		double tiengui = Double.parseDouble(tg);
		double laisuat = Double.parseDouble(ls);
		double thang = Double.parseDouble(t);
		double tienlai = tiengui * laisuat * thang;
		txtTienLai.setText("" + tienlai);
	}

	@Override
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub
		XuLyTinhLai();
	}

	public void addControl() {
		Container con = getContentPane();
		JPanel pn = new JPanel();
		pn.setLayout(new GridLayout(5, 2, 5, 5));

		JLabel lblTienGui = new JLabel("Tiền gửi :");
		lblTienGui.setForeground(Color.BLACK);
		lblTienGui.setSize(150, 180);
		lblTienGui.setFont(new Font("VNI", Font.PLAIN, 18));

		txtTienGui = new JTextField(30);
		txtTienGui.setSize(150, 180);
		txtTienGui.setFont(new Font("VNI", Font.PLAIN, 18));
		txtTienGui.setForeground(Color.GRAY);
		JLabel lblLaiSuat = new JLabel("Lãi suất/Tháng :");
		lblLaiSuat.setForeground(Color.BLACK);
		lblLaiSuat.setSize(150, 180);
		lblLaiSuat.setFont(new Font("VNI", Font.PLAIN, 18));

		txtLaiSuat = new JTextField(30);
		txtLaiSuat.setSize(150, 180);
		txtLaiSuat.setFont(new Font("VNI", Font.PLAIN, 18));
		txtLaiSuat.setForeground(Color.GRAY);

		txtThang = new JTextField(30);
		txtThang.setSize(150, 180);
		txtThang.setFont(new Font("VNI", Font.PLAIN, 18));
		txtThang.setForeground(Color.GRAY);
		JLabel lblThang = new JLabel("Tháng :");
		lblThang.setForeground(Color.BLACK);
		lblThang.setSize(150, 180);
		lblThang.setFont(new Font("VNI", Font.PLAIN, 18));

		txtTienLai = new JTextField(30);
		txtTienLai.setSize(150, 180);
		txtTienLai.setFont(new Font("VNI", Font.PLAIN, 18));
		txtTienLai.setForeground(Color.GRAY);
		JLabel lblTienLai = new JLabel("Tiền lãi :");
		lblTienLai.setForeground(Color.BLACK);
		lblTienLai.setSize(150, 180);
		lblTienLai.setFont(new Font("VNI", Font.PLAIN, 18));
		txtTienLai.setEditable(false);

		btnTinh = new JButton("Tính");
		btnNhapLai = new JButton("Nhập lại");

		btnTinh.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				// TODO Auto-generated method stub
				XuLyTinhLai();
			}
		});

		btnNhapLai.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				// TODO Auto-generated method stub
				txtTienGui.setText("");
				txtTienGui.requestFocus();
				txtTienLai.setText("");
				txtLaiSuat.setText("");
				txtThang.setText("");
			}

		});

		pn.add(lblTienGui);
		pn.add(txtTienGui);
		pn.add(lblLaiSuat);
		pn.add(txtLaiSuat);
		pn.add(lblThang);
		pn.add(txtThang);
		pn.add(lblTienLai);
		pn.add(txtTienLai);
		pn.add(btnTinh);
		pn.add(btnNhapLai);
		con.add(pn);

	}

	public void ShowWindow() {
		this.setSize(600, 300);
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setLocationRelativeTo(null);
		this.setResizable(false);
		this.setVisible(true);
	}
public static void main(String[] args) {
	new TinhLai("Nguyen DinhNguyen").ShowWindow();
}
}