package buoi8.bai1;

import java.awt.*;
import javax.swing.*;
import javax.swing.border.*;
import java.awt.event.ActionListener;
import java.sql.Date;
import java.awt.event.ActionEvent;

public class TaiSanUI extends JFrame {

	private JPanel pnMain;
	public static  JTextField txtMaTS,txtTenTS,txtNgayNhap,txtSoNam,txtGiaTri;
	private JLabel lbltenTS,lblNgayNhap,lblSoNam,lblGiaTri;


	private JButton btnLuu;
	TaiSan ts= new TaiSan();
	
	public TaiSanUI(String title) {

		this.setTitle(title);
		addcontrols();
		addEvents();
	}

	public void addEvents() {
		txtMaTS.setText(QuanLyTaiSan.maTS);
		txtTenTS.setText(QuanLyTaiSan.tenTS);
		txtNgayNhap.setText(QuanLyTaiSan.ngayNhap);
		txtSoNam.setText(QuanLyTaiSan.sonam);
		txtGiaTri.setText(QuanLyTaiSan.triGia);
		
		btnLuu.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				//insert into taisan(mats, tents, ngaynhap, sonamkhauhao, trigia) values ('TS003', 'TS003','TS003',22,34533)
				ts.setMaTS(txtMaTS.getText());
				ts.setTenTS(txtTenTS.getText());
				ts.setKhauTruhao(Integer.parseInt(txtSoNam.getText()));
				ts.setTriGia(Integer.parseInt(txtGiaTri.getText()));
				ts.setNgayNhap(txtNgayNhap.getText());
				ts.insert(ts);
			}
		});
		
	}

	public void ShowWindow() {
		this.setSize(400, 300);
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setLocationRelativeTo(null);
		this.setResizable(false);
		this.setVisible(true);
	}

	private void addcontrols() {

		Container con = getContentPane();
		JPanel pnMain = new JPanel();
		JPanel pnCha = new JPanel();// (setLayout(new BorderLayout()));

		con.add(pnCha, BorderLayout.CENTER);
		pnCha.setLayout(new BoxLayout(pnCha, BoxLayout.Y_AXIS));
		pnCha.add(pnMain);

		GridLayout gl_pnMain = new GridLayout(6, 2);

		gl_pnMain.setHgap(20);
		gl_pnMain.setVgap(20);
		pnMain.setLayout(gl_pnMain);

		JLabel lblMaTS = new JLabel("Mã TS:");
		lblMaTS.setFont(new Font("Times New Roman", Font.PLAIN, 13));
		txtMaTS = new JTextField(20);
//		txtMaTS.setEditable(false);
		txtMaTS.setFont(new Font("Times New Roman", Font.PLAIN, 13));
		pnMain.add(lblMaTS);
		pnMain.add(txtMaTS);

		lbltenTS = new JLabel("Tên TS");
		lbltenTS.setFont(new Font("Times New Roman", Font.PLAIN, 13));
		txtTenTS = new JTextField(20);
		txtTenTS.setFont(new Font("Times New Roman", Font.PLAIN, 13));
		pnMain.add(lbltenTS);
		pnMain.add(txtTenTS);

		lblNgayNhap = new JLabel("Ngày nhập");
		lblNgayNhap.setFont(new Font("Times New Roman", Font.PLAIN, 13));
		txtNgayNhap = new JTextField(20);
		txtNgayNhap.setFont(new Font("Times New Roman", Font.PLAIN, 13));
		pnMain.add(lblNgayNhap);
		pnMain.add(txtNgayNhap);

		lblSoNam = new JLabel("Số năm khấu hao");
		lblSoNam.setFont(new Font("Times New Roman", Font.PLAIN, 13));
		pnMain.add(lblSoNam);

		txtSoNam = new JTextField();
		txtSoNam.setFont(new Font("Times New Roman", Font.PLAIN, 13));
		pnMain.add(txtSoNam);

		lblGiaTri = new JLabel("Giá trị");
		lblGiaTri.setFont(new Font("Times New Roman", Font.PLAIN, 13));
		pnMain.add(lblGiaTri);

		txtGiaTri = new JTextField();
		txtGiaTri.setFont(new Font("Times New Roman", Font.PLAIN, 13));
		pnMain.add(txtGiaTri);

		btnLuu = new JButton("Lưu tài sản");
		
		btnLuu.setVerticalAlignment(SwingConstants.TOP);
		btnLuu.setFont(new Font("Times New Roman", Font.PLAIN, 13));
		pnMain.add(btnLuu);

	}

	public static void main(String[] args) {
		//new TaiSanUI("NDN").ShowWindow();
		
		
	}

}
