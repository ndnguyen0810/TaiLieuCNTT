package buoi8.bai1;

import java.sql.*;
import java.text.DateFormat;
import java.util.Vector;

import javax.swing.*;
import javax.swing.table.DefaultTableModel;
import javax.xml.crypto.Data;

public class TaiSan {

	public String getMaTS() {
		return maTS;
	}

	public void setMaTS(String maTS) {
		this.maTS = maTS;
	}

	public String getTenTS() {
		return tenTS;
	}

	public void setTenTS(String tenTS) {
		this.tenTS = tenTS;
	}

	public String getNgayNhap() {
		return ngayNhap;
	}

	public void setNgayNhap(String ngayNhap) {
		this.ngayNhap = ngayNhap;
	}

	public int getKhauTruhao() {
		return khauTruhao;
	}

	public void setKhauTruhao(int khauTruhao) {
		this.khauTruhao = khauTruhao;
	}

	public int getTriGia() {
		return triGia;
	}

	public void setTriGia(int triGia) {
		this.triGia = triGia;
	}

	private String maTS;
	private String tenTS;
	private String ngayNhap;
	private int khauTruhao;
	private int triGia;

	public TaiSan(String maTS, String tenTS, String ngayNhap, int khauTruhao, int triGia) {
		super();
		this.maTS = maTS;
		this.tenTS = tenTS;
		this.ngayNhap = ngayNhap;
		this.khauTruhao = khauTruhao;
		this.triGia = triGia;
	}

	private Connection con;
	MyConnecting MyCon = new MyConnecting();

	public TaiSan() {
		con = MyCon.getConnection();
	}

	// TaiSan ts = new TaiSan();

//xửl lý

	public void showTB(JTable tb) {
		try {
			DefaultTableModel dtm = new DefaultTableModel();
			ResultSet rs = MyCon.getInfo("select * from taisan");
			Vector<String> colName = new Vector<>();
			colName.add("Mã tài sản");
			colName.add("Tên tài sản");
			colName.add("Ngày nhập");
			colName.add("Khấu trừ");
			colName.add("Trị giá");

			ResultSetMetaData data = rs.getMetaData();
			int count = data.getColumnCount();
			Vector<String> row;

			dtm.setColumnIdentifiers(colName);
			dtm.addRow(colName);
			while (rs.next()) {
				row = new Vector<>();
				row.add(rs.getString("MaTS"));
				row.add(rs.getString("TenTS"));
				row.add(rs.getString("NgayNhap"));
				row.add(rs.getString("SoNamKhauhao").toString());
				row.add(rs.getString("TriGia").toString());

				dtm.addRow(row);
			}

			tb.setModel(dtm);

		} catch (Exception ex) {
			ex.printStackTrace();
		}

	}

	public void insert(TaiSan ts) {
		try {
			Statement stmt = con.createStatement();
			String sql = String.format(
					"insert into taisan(mats, tents, ngaynhap, sonamkhauhao, trigia) values ('%s', '%s','%s',%d,%d)",
					ts.maTS, ts.tenTS, ts.ngayNhap, ts.khauTruhao, ts.triGia);
			
			PreparedStatement s = con.prepareStatement(sql);
			
			if (s.executeUpdate() > 0) {
				System.out.println("Thêm thành công");
			} else {
				System.out.println("Thêm thất bại");
			}
		} catch (SQLException ex) {
			ex.printStackTrace();
		}
	}

	public void delete(TaiSan ts) {
		try {
			Statement stmt = con.createStatement();
			String sql = String.format("delete from taisan where mats='%s'", ts.maTS);
			PreparedStatement s = con.prepareStatement(sql);
			if (s.executeUpdate() > 0) {
				System.out.println("Xoá thành công");
			} else {
				System.out.println("Xoá thất bại");
			}
		} catch (SQLException ex) {
			ex.printStackTrace();
		}
	}

	public void Update(TaiSan ts) {
		try {
			Statement stmt = con.createStatement();
			String sql = String.format(
					"update taisan set mats='%s', tents='%s', ngaynhap='%s', sonamkhauhao='%s', trigia='%s' where mats=%s'",
					ts.maTS, ts.tenTS, ts.ngayNhap, ts.khauTruhao, ts.triGia);
			PreparedStatement s = con.prepareStatement(sql);
			if (s.executeUpdate() > 0) {
				System.out.println("Cập nhật thành công");
			} else {
				System.out.println("Cập nhật thất bại");
			}
		} catch (SQLException ex) {
			ex.printStackTrace();
		}
	}

}
