package buoi7.bai3;

import java.sql.*;




public class ChucVu {

	private int maCV;
	public int getMaCV() {
		return maCV;
	}

	public void setMaCV(int maCV) {
		this.maCV = maCV;
	}

	public String getTenCV() {
		return tenCV;
	}

	public void setTenCV(String tenCV) {
		this.tenCV = tenCV;
	}

	private String tenCV;

	public ChucVu(int maCV, String tenCV) {
		super();
		this.maCV = maCV;
		this.tenCV = tenCV;
	}

	public ChucVu() {
		con = MyCon.getConnection();
	}
	
	private Connection con;
	MyConnection MyCon = new MyConnection();
	
	public void Show() {
		try {

			ResultSet rs = MyCon.getInfo("select * from chucvu");

			while (rs.next()) {
				System.out.printf("%-10s %-20s \n", rs.getString(1), rs.getString(2) );
			}
			rs.close();

		} catch (Exception ex) {
			ex.printStackTrace();
		}
	}

	public void Find(String key) {
		try {
			String sql = String.format("select * from chucvu where macv like '%s' or tencv like '%s'",
					'%' + key + '%', '%' + key);
			ResultSet rs = MyCon.getInfo(sql);

			while (rs.next()) {
				System.out.printf("%-10s %-20s \n", rs.getString(1), rs.getString(2));
			}
			rs.close();

		} catch (Exception ex) {
			ex.printStackTrace();
		}
	}

	public void insert(ChucVu cv) {
		try {
			//Statement stmt = con.createStatement();
			String sql = String.format("insert into chucvu(macv, tencv) values ('%s', '%s')", cv.maCV,
					cv.tenCV);
			PreparedStatement s = con.prepareStatement(sql);
			if (s.executeUpdate() > 0) {
				System.out.println();
			} else {
				System.out.println("Thêm thất bại");
			}
		} catch (SQLException ex) {
			ex.printStackTrace();
		}
	}

	public void update(ChucVu cv) {
		try {
			//Statement stmt = con.createStatement();
			String sql = String.format("update chucvu set macv='%s', Tencv='%s' where macv='%s'",   cv.maCV,
					cv.tenCV,cv.maCV);
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

	public void delete(ChucVu cv) {
		try {
//			Statement stmt = con.createStatement();
			String sql = String.format("delete from chucvu where macv='%s'", cv.maCV);
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
