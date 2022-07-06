package buoi6.bai1;

import java.sql.*;

public class Bai1 {

	private static String url = "jdbc:mysql://localhost/db_quanlysinhvien";
	private static String user = "root";
	private static String pw = "";

	private static Connection getConnection(String url2, String user2, String pw2) {
		Connection conn = null;
		try {
			Class.forName("com.mysql.cj.jdbc.Driver");
			conn = DriverManager.getConnection(url, user, pw);
			System.out.println("Connect successfully");
		} catch (Exception ex) {
			System.out.println("Connect Failure");
			ex.printStackTrace();
		}
		return conn;

	}

	public static void main(String[] args) throws SQLException {
		try {

			Connection conn = getConnection(url, user, pw);

			Statement stmt = conn.createStatement();
			String sql;
			sql = "select* FROM sinhvien";

			ResultSet rs = stmt.executeQuery(sql);

			while (rs.next()) {
				System.out.printf("%-10s %-20s %-10s %-10s\n", rs.getInt(1), rs.getString(2), rs.getInt(3),
						rs.getString(4));
			}
			rs.close();
			stmt.close();
			conn.close();
		} catch (Exception ex) {
			ex.printStackTrace();
		}
	}
}
