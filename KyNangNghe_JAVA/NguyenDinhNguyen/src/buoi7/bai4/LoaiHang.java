package buoi7.bai4;

import java.sql.*;

import buoi7.bai4.PublicCon;

public class LoaiHang {

	private Connection con;
	PublicCon MyCon = new PublicCon();

	public LoaiHang(String maLoai, String tenLoai) {
		super();
		this.maLoai = maLoai;
		this.tenLoai = tenLoai;
	}

	public LoaiHang() {
		con = MyCon.getConnection();
	}

	private String maLoai;
	private String tenLoai;

	public String getMaLoai() {
		return maLoai;
	}

	public void setMaLoai(String maLoai) {
		this.maLoai = maLoai;
	}

	public String getTenLoai() {
		return tenLoai;
	}

	public void setTenLoai(String tenLoai) {
		this.tenLoai = tenLoai;
	}

//==============================

	public void Show() {
		try {

			ResultSet rs = MyCon.getInfo("select * from loaihang");

			while (rs.next()) {
				System.out.printf("%-10s %-20s \n", rs.getString(1), rs.getString(2));
			}
			rs.close();

		} catch (Exception ex) {
			ex.printStackTrace();
		}
	}

	public void Find(String key) {
		try {
			String sql = String.format("select * from loaihang where maloai like '%s' or tenloai like '%s'",
					'%' + key + '%', '%' + key + '%');
			ResultSet rs = MyCon.getInfo(sql);

			while (rs.next()) {
				System.out.printf("%-10s %-20s \n", rs.getString(1), rs.getString(2));
			}
			rs.close();

		} catch (Exception ex) {
			ex.printStackTrace();
		}
	}

	public void insert(LoaiHang lh) {
		try {
			Statement stmt = con.createStatement();
			String sql = String.format("insert into loaihang(maloai, tenloai) values ('%s', '%s')", lh.maLoai,
					lh.tenLoai);
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

	public void update(LoaiHang lh) {
		try {
			Statement stmt = con.createStatement();
			String sql = String.format("update loaihang set maloai='%s', tenloai='%s' where maloai='%s'", lh.maLoai,
					lh.tenLoai, lh.maLoai);
			PreparedStatement s = con.prepareStatement(sql);

			if (s.executeUpdate() > 0) {
				System.out.println("Sửa thành công");
			} else {
				System.out.println("Sửa thất bại");

			}
		} catch (SQLException ex) {
			ex.printStackTrace();

		}
	}

	public void delete(LoaiHang lh) {
		try {
			Statement stmt = con.createStatement();
			String sql = String.format("delete from loaihang where maloai='%s'", lh.maLoai);
			PreparedStatement s = con.prepareStatement(sql);
			if (s.executeUpdate() > 0) {
				System.out.println("Xóa thành công");
			} else {
				System.out.println("Xóa thất bại");
			}
		} catch (SQLException ex) {
			ex.printStackTrace();

		}
	}

}
