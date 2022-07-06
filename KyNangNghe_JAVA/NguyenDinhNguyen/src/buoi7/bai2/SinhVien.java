package buoi7.bai2;

import java.sql.*;

import buoi6.bai2.Myconnect;

public class SinhVien {
	public static Myconnect con;
	// Myconnect connect = new Myconnect();

	public SinhVien() {
		con.getConnection();
	}

	public static ResultSet getInfo(String sql) {
		ResultSet rs = null;
		try {
			
			Statement stmt = con.getConnection().createStatement();
			stmt.executeQuery(sql);
			rs = stmt.getResultSet();
		} catch (SQLException ex) {
			ex.printStackTrace();
		}
		return rs;
	}

	public static ResultSet getInfo_ByMaNganh(String ma) {
		ResultSet rs = null;
		try {
			Statement stmt = con.getConnection().createStatement();
			String sql = String.format("select * from sinhvien where manganh='%s'", ma);
			stmt.executeQuery(sql);
			System.out.printf(sql);

			rs = stmt.getResultSet();
		} catch (SQLException ex) {
			ex.printStackTrace();
		}
		return rs;
	}

	public static void ShowAll() {
		try {

			ResultSet rs = getInfo("select * from sinhvien");

			while (rs.next()) {
				if (rs.getBoolean(3) == true) {
					String gt = "Nam";
					System.out.printf("%-10s %-20s %-10s %-10s\n", rs.getInt(1), rs.getString(2), gt, rs.getString(4));

				} else {
					String gt = "Nu";
					System.out.printf("%-10s %-20s %-10s %-10s\n", rs.getInt(1), rs.getString(2), gt, rs.getString(4));

				}
			}
			rs.close();

		} catch (Exception ex) {
			ex.printStackTrace();
		}
	}

	public static void ShowSV_byMN(String ma) {
		try {

			ResultSet rs = getInfo(String.format("select * from sinhvien where manganh='%s'", ma));

			while (rs.next()) {
				if (rs.getBoolean(3) == true) {
					String gt = "Nam";
					System.out.printf("%-10s %-20s %-10s %-10s \n", rs.getInt(1), rs.getString(2), gt,
							rs.getString(4));

				} else {
					String gt = "Nu";
					System.out.printf("%-10s %-20s %-10s %-10s\n", rs.getInt(1), rs.getString(2), gt,
							rs.getString(4));

				}
			}
			rs.close();

		} catch (Exception ex) {
			ex.printStackTrace();
		}
	}

	public static void ShowSV() {
		try {

			ResultSet rs = getInfo("select * from sinhvien");

			while (rs.next()) {
				if (rs.getBoolean(3) == true) {
					String gt = "Nam";
					System.out.printf("%-10s %-20s %-10s %-10s \n", rs.getInt(1), rs.getString(2), gt,
							rs.getString(4));

				} else {
					String gt = "Nu";
					System.out.printf("%-10s %-20s %-10s \n", rs.getInt(1), rs.getString(2), gt, rs.getString(4));

				}
			}
			rs.close();

		} catch (Exception ex) {
			ex.printStackTrace();
		}
	}

	
	
	public static void insert_SV(String MSSV, String Ten, int gt, String MaNganh) {
		try {
			Statement stmt = con.getConnection().createStatement();
			String sql = String.format("insert into sinhvien values('%s', '%s',%d,'%s')", MSSV, Ten, gt, MaNganh);
			System.err.println(sql);
			PreparedStatement s = con.getConnection().prepareStatement(sql);

			if (s.executeUpdate() > 0) {
				System.out.println("Thêm thành công");
			} else {
				System.out.println("Thêm thất bại");

			}
		} catch (SQLException ex) {
			ex.printStackTrace();

		}

	}

	public static void main(String[] args) {
		ShowAll();
		//ShowSV();
		//ShowSV_byMN("CNTT");;
		//insert_SV("13455","pham hoang khoi",0,"CNTT");
	}
}
