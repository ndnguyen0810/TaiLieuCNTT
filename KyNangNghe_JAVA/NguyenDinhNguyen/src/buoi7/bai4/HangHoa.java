package buoi7.bai4;

import java.sql.*;


public class HangHoa {

	private Connection con;
	PublicCon MyCon = new PublicCon();



	public HangHoa() {
		con = MyCon.getConnection();
	}

	public HangHoa(String maHH, String tenHH, String loaiHH, String MaNSX) {
		super();
		this.MaHH = maHH;
		this.tenHH = tenHH;
		this.LoaiHH = loaiHH;
		this.MaNSX = MaNSX;
	}

	public String getMaHH() {
		return MaHH;
	}

	public void setMaHH(String maHH) {
		MaHH = maHH;
	}

	public String getTenHH() {
		return tenHH;
	}

	public void setTenHH(String tenHH) {
		this.tenHH = tenHH;
	}

	public String getLoaiHH() {
		return LoaiHH;
	}

	public void setLoaiHH(String loaiHH) {
		LoaiHH = loaiHH;
	}

	public String getMaNSX() {
		return MaNSX;
	}

	public void setMaNSX(String MaNSX) {
		this.MaNSX = MaNSX;
	}

	private String MaHH;
	private String tenHH;
	private String LoaiHH;
	private String MaNSX;


//==============================

	public void Show() {
		try {

			ResultSet rs = MyCon.getInfo("select * from hanghoa");

			while (rs.next()) {
				System.out.printf("%-10s %-20s %-40s %-40s \n", rs.getString(1), rs.getString(2), rs.getString(3),rs.getString(4) );
			}
			rs.close();

		} catch (Exception ex) {
			ex.printStackTrace();
		}
	}

	public void Find(String key) {
		try {
			String sql = String.format("select * from hanghoa where mahh like '%s' or ten like '%s' or loaihang like '%s', mahh like '%s'",
					'%' + key + '%', '%' + key + '%','%' + key + '%','%' + key + '%');
			ResultSet rs = MyCon.getInfo(sql);

			while (rs.next()) {
				System.out.printf("%-10s %-20s \n", rs.getString(1), rs.getString(2));
			}
			rs.close();

		} catch (Exception ex) {
			ex.printStackTrace();
		}
	}

	public void insert(HangHoa hh) {
		try {
			Statement stmt = con.createStatement();
			String sql = String.format("insert into hanghoa(mahh, ten, maloai, mansx) values ('%s', '%s', '%s','%s')", hh.MaHH,
					hh.tenHH, hh.LoaiHH, hh.MaNSX);
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

	public void update(HangHoa hh) {
		try {
			Statement stmt = con.createStatement();
			String sql = String.format("update hh set mahh='%s', Ten='%s' maloai='s%' mansx='%s' where mahh='%s'",   hh.MaHH,
					hh.tenHH, hh.LoaiHH, hh.MaNSX, hh.MaHH);
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

	public void delete(HangHoa hh) {
		try {
			Statement stmt = con.createStatement();
			String sql = String.format("delete from hh where mahh='%s'", hh.MaHH);
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
