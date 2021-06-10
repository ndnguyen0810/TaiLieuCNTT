using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab08
{
    class NhanVien
    {
        Database db;
        public NhanVien()
        {
            db = new Database();
        }

        public DataTable LayDSNhanvien()
        {
            string strSQL = "Select Manhanvien, HoTenNhanVien,  Ngaysinh,Diachi,Dienthoai, B.TenBangcap From Nhanvien N, BANGCAP B Where N.MaBangCap=B.MaBangCap";
            DataTable dt = db.Execute(strSQL);
            //Goi phuong thuc truy xuat du lieu
            return dt;
        }

        public DataTable LayBangcap()
        {
            string strSQL = "Select * from bangcap";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }

        public void XoaNhanVien(int id)
        {
            string query = string.Format("delete nhanvien where manhanvien={0}", id);
            db.ExecuteNonQuery(query);
        }

        public void ThemNhanVien(string ten, string ngay, string dia, string dt, int bc)
        {
            string query=string.Format("insert into nhanvien values(N'{0}','{1}',N'{2}','{3}',{4})",ten,ngay,dia,dt,bc);
            db.ExecuteNonQuery(query);
        }

        public void SuaNhanVien(string ten, string ngay, string dia, string dt, int bc,int manv)
        {
            string query = string.Format("update nhanvien set hotennhanvien= N'{0}', Ngaysinh='{1}',diachi=N'{2}',dienthoai='{3}',mabangcap={4} where manhanvien={5})", ten, ngay, dia, dt, bc,manv);
            db.ExecuteNonQuery(query);
        }
    }
}
