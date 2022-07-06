package buoi6.bai2;

import java.sql.*;

public class Nganh {
	private Connection con;
	public Nganh() {
		con = Myconnect.getConnection();
	}
	
	public ResultSet getInfo() {
		ResultSet rs = null;
		try {
			Statement stmt = con.createStatement();
			String sql = "select * from nganh";
			stmt.executeQuery(sql);
			rs = stmt.getResultSet();			
		}catch(SQLException ex) {
			ex.printStackTrace();
		}
		
		
		return rs;
		
	}
	
	public ResultSet getInfo_Ma(String ma) {
		ResultSet rs = null;
		try {
			Statement stmt = con.createStatement();
			String sql = "select * from nganh where MANGANH = '"+ma+"' ";
			stmt.executeQuery(sql);
			rs = stmt.getResultSet();
		}catch(SQLException ex) {
			ex.printStackTrace();

		}
		
		return rs;
	}
	
	public void insert(String ma , String ten) {
		try {
			Statement stmt = con.createStatement();
			String sql = "insert into nganh value('"+ma+"','"+ten+"')";
			PreparedStatement s = con.prepareStatement(sql);
			
			if(s.executeUpdate() > 0 ) {
				System.out.println("Thêm thành công");
			}else {
				System.out.println("Thêm thất bại");

			}
		}catch(SQLException ex) {
			ex.printStackTrace();

		}
		
	}
	
	public void update (String ma,String ten) {
		try {
			Statement stmt = con.createStatement();
			String sql = "update  nganh set TENNGANH='"+ten+"' where MANGANH = '"+ma+"'";
			PreparedStatement s = con.prepareStatement(sql);
			
			if(s.executeUpdate() > 0 ) {
				System.out.println("Sửa thành công");
			}else {
				System.out.println("Sửa thất bại");

			}
		}catch(SQLException ex) {
			ex.printStackTrace();

		}
	}
	
	public void delete (String ma) {
		try {
			Statement stmt = con.createStatement();
			String sql = "delete from nganh where MANGANH = '"+ma+"'";
			PreparedStatement s = con.prepareStatement(sql);
			
			if(s.executeUpdate() > 0 ) {
				System.out.println("Xóa thành công");
			}else {
				System.out.println("Xóa thất bại");

			}
		}catch(SQLException ex) {
			ex.printStackTrace();

		}
	}
	
	
	public static void main(String[] args) throws SQLException {

//		Select dữ liệu 
//		Nganh ng = new Nganh();
//		ResultSet rs = ng.getInfo();
//		while(rs.next()) {
//			System.out.printf("%-10s %-10s \n",rs.getString(1),rs.getString(2));
//		}
		
//		Tìm kiếm theo mã ngành
//		Nganh ng = new Nganh();
//		ResultSet rs = ng.getInfo_Ma("CNTT");
//		while(rs.next()) {
//			System.out.printf("%-10s %-10s \n",rs.getString(1),rs.getString(2));
//		}
		
//		Thêm dữ liệu
		
//		Nganh ng = new Nganh();
//		ng.insert("DDT","Điện - Điện tử");
//		ResultSet rs = ng.getInfo();
//		while(rs.next()) {
//			System.out.printf("%-10s %-10s \n",rs.getString(1),rs.getString(2));
//		}
		
//		Sửa dữ liệu
		
//		Nganh ng = new Nganh();
//		ng.update("QTKD","Quản Trị Kinh Doanh - Du Lịch - Nhà Hàng Khách Sạn");
//		ResultSet rs = ng.getInfo();
//		while(rs.next()) {
//			System.out.printf("%-10s %-10s \n",rs.getString(1),rs.getString(2));
//		}
		
//		Xóa dữ liệu
		
		Nganh ng = new Nganh();
		
		String manganh = "DDT";
		ng.delete("QTKD");
		ResultSet rs = ng.getInfo_Ma(manganh);
		while(rs.next()) {
			System.out.printf("%-10s %-10s \n",rs.getString(1),rs.getString(2));
		}
	}
}
