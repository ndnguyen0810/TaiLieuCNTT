package buoi4;

import java.awt.*;
import java.awt.event.*;

import javax.swing.*;

public class CTNC extends JFrame {
	public CTNC(String title) {
		this.setTitle(title);
		addcontrol();
		addevents();
	}

	JButton btnGiai, btnXoa, btnThoat;
	JTextField txtNhapA, txtNhapB, txtKetQua;
	JRadioButton rdCong, rdTru, rdNhan, rdChia;
	

	public void addcontrol() {
		Container con = getContentPane();
		JPanel pnBorder = new JPanel();
		con.add(pnBorder);

		// top
		pnBorder.setLayout(new BorderLayout());
		JPanel pnNorth = new JPanel();
		JLabel lbltitle = new JLabel("CỘNG TRỪ NHÂN CHIA");
		pnNorth.add(lbltitle);
		pnBorder.add(pnNorth, BorderLayout.NORTH);

		// ===============================================
		// ben trai
		JPanel pnWest = new JPanel();
		pnWest.setLayout(new BoxLayout(pnWest, BoxLayout.Y_AXIS));
		pnWest.setBorder(BorderFactory.createTitledBorder("Chọn tác vụ"));
		btnGiai = new JButton("Giải");
		btnXoa = new JButton("Xóa");
		btnThoat = new JButton("Thoát");
		pnWest.add(btnGiai);
		pnWest.add(btnXoa);
		pnWest.add(btnThoat);
		pnBorder.add(pnWest, BorderLayout.WEST);

		// ben phai
		JPanel pnCenter = new JPanel();
		pnCenter.setLayout(new BoxLayout(pnCenter, BoxLayout.Y_AXIS));
		pnCenter.setBorder(BorderFactory.createTitledBorder("Nhập 2 số a và b"));

		// nhap A
		JPanel pnNhapA = new JPanel(new FlowLayout());
		JLabel lblA = new JLabel("Nhap a: ");
		txtNhapA = new JTextField(20);
		pnNhapA.add(lblA);
		pnNhapA.add(txtNhapA);
		pnCenter.add(pnNhapA);

		// Nhap B
		JPanel pnNhapB = new JPanel(new FlowLayout());
		JLabel lblB = new JLabel("Nhap b: ");
		txtNhapB = new JTextField(20);
		pnNhapB.add(lblB);
		pnNhapB.add(txtNhapB);
		pnCenter.add(pnNhapB);

		// Phep toan
		JPanel pnPhepToan = new JPanel();
		pnPhepToan.setLayout(new GridLayout(2, 2));
		pnPhepToan.setBorder(BorderFactory.createTitledBorder("chon phep toan"));

		rdCong = new JRadioButton("Cong");
		rdTru = new JRadioButton("Tru");
		rdNhan = new JRadioButton("Nhan");
		rdChia = new JRadioButton("Chia");
		pnPhepToan.add(rdCong);
		pnPhepToan.add(rdTru);
		pnPhepToan.add(rdNhan);
		pnPhepToan.add(rdChia);
		pnCenter.add(pnPhepToan);
		pnBorder.add(pnCenter, BorderLayout.CENTER);
		ButtonGroup	group=new ButtonGroup();
		group.add(rdCong);group.add(rdTru);
		group.add(rdNhan);group.add(rdChia);
		
		// ket qua
		JPanel pnKq = new JPanel(new FlowLayout());
		JLabel lblkq = new JLabel("Ket qua: ");
		txtKetQua = new JTextField(20);
		txtKetQua.setEditable(false);
		pnKq.add(lblkq);
		pnKq.add(txtKetQua);
		pnCenter.add(pnKq);

		// duoi
		JPanel pnSouth = new JPanel();
		pnBorder.add(pnSouth, BorderLayout.SOUTH);
		pnSouth.setPreferredSize(new Dimension(0,	30));
		pnSouth.setBackground(Color.PINK);		
		JPanel	pnBlue=new JPanel();
		pnBlue.setBackground(Color.BLUE);
		pnSouth.add(pnBlue);
		JPanel	pnRed=new JPanel();
		pnRed.setBackground(Color.RED);
		pnSouth.add(pnRed);
		JPanel	pns3=new JPanel();
		pns3.setBackground(Color.YELLOW);
		pnSouth.add(pns3);
		//enevent
		
//		Container con = getContentPane();
//		con.add(pnBorder);

	}

	public void Show() {
		this.setSize(400, 300);
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setLocationRelativeTo(null);
		this.setResizable(false);
		this.setVisible(true);
	}

	public void addevents() {

		btnThoat.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				int ret = JOptionPane.showConfirmDialog(null, "Muốn	thoát	hả?", "Thoát", JOptionPane.YES_NO_OPTION);
				if (ret == JOptionPane.YES_OPTION)
					System.exit(0);
			}
		});

		btnXoa.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				txtNhapA.setText("");
				txtNhapB.setText("");
				// txtKetQua.setText("");
				// txtNhapA.requestFocus();
			}
		});

		btnGiai.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				String sa = txtNhapA.getText();
				String sb= txtNhapB.getText();

				int a = 0, b = 0;
				try {
					a = Integer.parseInt(sa);
				} catch (Exception ex) {
					JOptionPane.showMessageDialog(null, "a	nhập	sai	định	dạng!");
					txtNhapA.selectAll();
					txtNhapA.requestFocus();
					return;
				}
				try {
					b = Integer.parseInt(sb);
				} catch (Exception ex) {
					JOptionPane.showMessageDialog(null, "b	nhập	sai	định	dạng!");
					txtNhapB.selectAll();
					txtNhapB.requestFocus();
					return;
				}
				double kq = 0;
				if (rdCong.isSelected()) {
					kq = (a + b);
				} else if (rdTru.isSelected()) {
					kq = (a - b);
				} else if (rdNhan.isSelected()) {
					kq = (a * b);
				} else {
					kq = a * 1.0 / b * 1.0;
				}
				txtKetQua.setText(kq + "");
			}
		});
	}

	
	
	public static void main(String[] args) {

		new CTNC("Nguyễn Đình Nguyên").Show();
	}
}
