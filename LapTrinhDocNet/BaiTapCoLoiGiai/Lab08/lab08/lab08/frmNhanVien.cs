using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab08
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        #region
        SqlConnection sqlConn; //khai báo biến connection
        SqlDataAdapter da; //khai báo biến dataAdapter
        DataSet ds = new DataSet(); //khai báo 1 dataset

        void KetnoiCSDL() //thực hiện kết nối bằng chuỗi kết nối
        {
            string connStr = @"Data Source=VT47_M28;Initial Catalog=QLThuVien;Integrated Security=True";
            sqlConn = new SqlConnection(connStr);
        }

        DataTable layDanhSachNhanVien()
        {
             
            string sql = "Select * from NhanVien ";
            KetnoiCSDL();
            sqlConn.Open();
            da = new SqlDataAdapter(sql, sqlConn);
            da.Fill(ds);
            return ds.Tables[0];
        }

        void LoadListview()
        {
            lviewNV.FullRowSelect = true;
            DataTable dt = layDanhSachNhanVien();
            lviewNV.Items.Clear();

            lviewNV.View = View.Details; 
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lviewNV.Items.Add(dt.Rows[i]["MaNhanVien"].ToString());
                //dòng thứ i, tên cột là nhân viên
                lvi.SubItems.Add(dt.Rows[i][1].ToString()); //dùng chỉ số cột : dòng thứ i,cột thứ 1               
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
            }

        }
       
        #endregion

        private void btnThem_Click(object sender, EventArgs e)
        {
            KetnoiCSDL();
            sqlConn.Open();

            string ht= txtHoTen.Text;
            string ngay = dtpNgaySinh.Value.ToShortDateString();
            string diachi= txtDiaChi.Text;
            string dt= txtDienThoai.Text;           
          
            string sql = string.Format("insert into NhanVien([hotennhanvien], [NgaySinh], [DiaChi], [DienThoai]) values ( N'{0}','{1}',N'{2}','{3}')", ht, ngay, diachi, dt);
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            cmd.ExecuteNonQuery();
            sqlConn.Close();
            ds.Clear();
            LoadListview();

        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            KetnoiCSDL();
            sqlConn.Open();
            string productName = lviewNV.SelectedItems[0].SubItems[0].Text,
                sql = "delete from NhanVien where MANHANVIEN = " + productName;
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            cmd.ExecuteNonQuery();
            LoadListview();
            ds.Clear();
            sqlConn.Close();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KetnoiCSDL();
            sqlConn.Open();
            string productName = lviewNV.SelectedItems[0].SubItems[0].Text,
                sql = "update NhanVien set hotennhanvien = '" + txtHoTen.Text + "' , NgaySinh = '" +
                dtpNgaySinh.Value.ToShortDateString() +
                    "' , DiaChi = '" + txtDiaChi.Text + "' , DienThoai = '" + txtDienThoai.Text + "'   where MANHANVIEN = " + productName;
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            // MessageBox.Show(sql);
            cmd.ExecuteNonQuery();
            ds.Clear();
            LoadListview();
            sqlConn.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dtpNgaySinh.Value;
        }

        private void frmNhavVien_Load(object sender, EventArgs e)
        {
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";

            lviewNV.GridLines = true;
          //  lviewNV.Columns.Add("Ma Nhan Vien", 100);//1022
            lviewNV.Columns.Add("Ho ten Nhan Vien", 195);
            lviewNV.Columns.Add("Ngay sinh", 170);
            lviewNV.Columns.Add("Dia chi", 300);
            lviewNV.Columns.Add("Dien thoai", 130);
            lviewNV.Columns.Add("Ma bang", 120);
            //HienthiNhanvien();
            LoadListview();

        }
        #region 3 lớp
        NhanVien nv = new NhanVien();
        void HienthiNhanvien()
        {
            lviewNV.View = View.Details;
            DataTable dt = nv.LayDSNhanvien();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lviewNV.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
               
            }
            //lviewNV.Columns[1].Width = 0;
        }

        void setNull()
        {
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
        }
        void setButton(bool val)
        {
            btnThem.Enabled = val;
            btnXoa.Enabled = val;
            btnSua.Enabled = val;
            btnThoat.Enabled = val;
            //  btnLuu.Enabled = !val;b
            //  btnHuy.Enabled = !val;
        }


        #endregion

        private void frmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void lviewNV_Click(object sender, EventArgs e)
        {
            if (lviewNV.SelectedItems.Count > 0)
            {
                txtHoTen.Text = lviewNV.SelectedItems[0].SubItems[1].Text;
                txtDienThoai.Text = lviewNV.SelectedItems[0].SubItems[4].Text;
                txtDiaChi.Text = lviewNV.SelectedItems[0].SubItems[3].Text;
                string dte = lviewNV.SelectedItems[0].SubItems[2].Text;
                dtpNgaySinh.Value = DateTime.Parse(dte);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
