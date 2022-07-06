package buoi7.bai2;

import java.sql.*;

public class Nganh {
	private Connection con;
	PublicCon MyCon = new PublicCon();

	private String maNganh;
	private String tenNganh;

	public Nganh(String maNganh, String tenNganh) {
		super();
		this.setMaNganh(maNganh);
		this.setTenNganh(tenNganh);
	}

	public Nganh() {
		con = MyCon.getConnection();
	}

	public String getTenNganh() {
		return tenNganh;
	}

	public void setTenNganh(String tenNganh) {
		this.tenNganh = tenNganh;
	}

	public String getMaNganh() {
		return maNganh;
	}

	public void setMaNganh(String maNganh) {
		this.maNganh = maNganh;
	}

	// ==============================================

	public ResultSet getInfo_Ma(String ma) {
		ResultSet rs = null;
		try {
			Statement stmt = con.createStatement();
			String sql = "select * from nganh where MANGANH = '" + ma + "' ";
			stmt.executeQuery(sql);
			rs = stmt.getResultSet();
		} catch (SQLException ex) {
			ex.printStackTrace();
		}
		return rs;
	}

	public void Show() {
		try {

			ResultSet rs = MyCon.getInfo("select * from nganh");

			while (rs.next()) {
				System.out.printf("%-10s %-20s \n", rs.getString(1), rs.getString(2));
			}
			rs.close();

		} catch (Exception ex) {
			ex.printStackTrace();
		}
	}

	public void insert(Nganh ng) {
		try {
			Statement stmt = con.createStatement();
			String sql = String.format("insert into Nganh(manganh, tennganh) values ('%s', '%s')", ng.maNganh,
					ng.tenNganh);
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

	public void update(String ma, String ten) {
		try {
			Statement stmt = con.createStatement();
			String sql = "update  nganh set TENNGANH='" + ten + "' where MANGANH = '" + ma + "'";
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

	public void delete(Nganh ng) {
		try {
			Statement stmt = con.createStatement();
			String sql = String.format("delete from nganh where manganh='%s'", ng.maNganh);
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

	public static void main(String[] args) {
		Nganh ng = new Nganh();
		//ng.maNganh = "LKT";
		//ng.tenNganh = "Luat Kinh Te";
		
		//ng.insert(ng);
//		ng.maNganh="xxx";
//		ng.delete(ng);
		ng.Show();
	}
}
