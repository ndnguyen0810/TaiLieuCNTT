package buoi8.bai1;

import java.awt.*;
import java.sql.*;
import java.text.SimpleDateFormat;
import java.time.format.DateTimeFormatter;

import javax.swing.*;
import javax.swing.border.*;
import javax.swing.event.*;

import javax.swing.table.*;
import javax.xml.crypto.Data;

import com.google.protobuf.TextFormat.ParseException;

import java.awt.event.*;

public class QuanLyTaiSan extends JFrame {

	private JPanel contentPane;
	public static JTable tableDT;
	public JButton btnThem, btnSua, btnXoa, btnthoat;

	public static String maTS, tenTS, ngayNhap, sonam, triGia;

//	public static Date ngayNhap;
	SimpleDateFormat formatter = new SimpleDateFormat("E, MMM dd yyyy");

	TaiSan ts = new TaiSan();

	public void ShowWindow() {
		this.setSize(1000, 500);
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setLocationRelativeTo(null);
		this.setResizable(false);
		this.setVisible(true);
	}

	public QuanLyTaiSan(String title) {
		this.setTitle(title);
		addcontrols();
		ts.showTB(tableDT);
		addEvents();
	}

	private void addcontrols() {
		contentPane = new JPanel();
		setContentPane(contentPane);
		contentPane.setLayout(new BoxLayout(contentPane, BoxLayout.Y_AXIS));

		JPanel pnTitle = new JPanel();
		JLabel lblTitle = new JLabel("CHƯƠNG TRÌNH QUẢN LÝ TÀI SẢN");
		lblTitle.setFont(new Font("Times New Roman", Font.PLAIN, 30));
		pnTitle.add(lblTitle);
		contentPane.add(pnTitle);

		tableDT = new JTable();
		tableDT.setRowHeight(25);
		tableDT.setFont(new Font("Times New Roman", Font.PLAIN, 20));
//		pnTable.add(tableDT);
		contentPane.add(tableDT);

		JPanel pnBottom = new JPanel(new FlowLayout(FlowLayout.LEFT));
		contentPane.add(pnBottom);

		JPanel pnBTN = new JPanel();
		pnBottom.add(pnBTN);

		btnThem = new JButton("Thêm");
		pnBTN.add(btnThem);

		btnSua = new JButton("Sửa thông tin");
		pnBTN.add(btnSua);

		btnXoa = new JButton("Xoá");
		pnBTN.add(btnXoa);

		btnthoat = new JButton("Thoát");
		pnBTN.add(btnthoat);

	}

	public static void main(String[] args) {
		new QuanLyTaiSan("Nguyễn Đình Nguyên").ShowWindow();

	}

	private void addEvents() {
		tableDT.setSelectionMode(ListSelectionModel.SINGLE_SELECTION);
		ListSelectionModel model = tableDT.getSelectionModel();
		model.addListSelectionListener(new ListSelectionListener() {
			@Override
			public void valueChanged(ListSelectionEvent e) {
				if (e.getValueIsAdjusting()) {
					return;
				}
				ListSelectionModel lsm = (ListSelectionModel) e.getSource();

				if (lsm.isSelectionEmpty()) {
					JOptionPane.showMessageDialog(null, "Bạn chưa chọn");
				} else {
					int selectedRow = lsm.getMinSelectionIndex();
					maTS = tableDT.getModel().getValueAt(selectedRow, 0).toString();
					tenTS = tableDT.getModel().getValueAt(selectedRow, 1).toString();
					ngayNhap = tableDT.getModel().getValueAt(selectedRow, 2).toString();
					sonam = tableDT.getModel().getValueAt(selectedRow, 3).toString();
					triGia = tableDT.getModel().getValueAt(selectedRow, 4).toString();
				}
			}

		});

		btnThem.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				new TaiSanUI("Thêm tài sản").ShowWindow();
			}
		});
		btnSua.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				new TaiSanUI("Thêm tài sản").ShowWindow();

			}
		});
		btnXoa.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				ts.setMaTS(maTS);
				ts.delete(ts);
			}
		});
		btnthoat.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				System.exit(0);
//				if (JOptionPane.showConfirmDialog(this, "Bạn có chắc muốn thoát không?", "Thông báo",
//						JOptionPane.YES_NO_OPTION) == JOptionPane.YES_OPTION) {
//					System.exit(0);
//				}
			}
		});

	}

	public void actionPerformed(ActionEvent e) {
		if (e.getSource() == btnThem) {
			System.err.println("T");
		}

		if (e.getSource() == btnSua) {
			System.err.println("S");
		}
	}

}
