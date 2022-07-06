package buoi6.bai2;

import java.sql.*;

public class Myconnect {
	public static Connection getConnection() {
		Connection con = null;

		String url ="jdbc:mysql://localhost/db_quanlysinhvien?characterEncoding=UTF-8";
		String user = "admin";
		String pw = "";
		if(con!=null) {
			return con;
		}else {
			try {
				Class.forName("com.mysql.cj.jdbc.Driver");
				con= DriverManager.getConnection(url,user,pw);
				System.out.println("Connect successfully");
			}catch (Exception ex) {
				System.out.println("Connect Failure");
				ex.printStackTrace();
			}
			return con;
		}
		
		
	}
}
