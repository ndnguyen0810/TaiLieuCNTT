package buoi7.bai4;

import java.sql.*;

public class NhaSanXuat {
	private Connection con;
	PublicCon MyCon = new PublicCon();

	public NhaSanXuat(String nhaSanXuat, String tenNSX, String diaChi) {
		super();
		this.maNSX = nhaSanXuat;
		this.tenNSX = tenNSX;
		this.diaChi = diaChi;
	}

	public NhaSanXuat() {
		con = MyCon.getConnection();
	}

	private String maNSX;
	private String tenNSX;
	private String diaChi;

	public String getNhaSanXuat() {
		return maNSX;
	}

	public void setNhaSanXuat(String nhaSanXuat) {
		this.maNSX = nhaSanXuat;
	}

	public String getTenNSX() {
		return tenNSX;
	}

	public void setTenNSX(String tenNSX) {
		this.tenNSX = tenNSX;
	}

	public String getDiaChi() {
		return diaChi;
	}

	public void setDiaChi(String diaChi) {
		this.diaChi = diaChi;
	}
//==============================

	public void Show() {
		try {

			ResultSet rs = MyCon.getInfo("select * from NSX");

			while (rs.next()) {
				System.out.printf("%-10s %-20s %-40s \n", rs.getString(1), rs.getString(2), rs.getString(3));
			}
			rs.close();

		} catch (Exception ex) {
			ex.printStackTrace();
		}
	}

	public void Find(String key) {
		try {
			String sql = String.format("select * from nsx where mansx like '%s' or ten like '%s' or diachi like '%s'",
					'%' + key + '%', '%' + key + '%','%' + key + '%');
			ResultSet rs = MyCon.getInfo(sql);

			while (rs.next()) {
				System.out.printf("%-10s %-20s \n", rs.getString(1), rs.getString(2));
			}
			rs.close();

		} catch (Exception ex) {
			ex.printStackTrace();
		}
	}

	public void insert(NhaSanXuat nsx) {
		try {
			Statement stmt = con.createStatement();
			String sql = String.format("insert into nsx(mansx, ten, diachi) values ('%s', '%s', '%s')", nsx.maNSX,
					nsx.tenNSX, nsx.diaChi);
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

	public void update(NhaSanXuat nsx) {
		try {
			Statement stmt = con.createStatement();
			String sql = String.format("update NSX set maNSX='%s', Ten='%s' diachi='s%' where maNSX='%s'",  nsx.maNSX,
					nsx.tenNSX, nsx.diaChi, nsx.maNSX);
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

	public void delete(NhaSanXuat nsx) {
		try {
			Statement stmt = con.createStatement();
			String sql = String.format("delete from nsx where mansx='%s'", nsx.maNSX);
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
