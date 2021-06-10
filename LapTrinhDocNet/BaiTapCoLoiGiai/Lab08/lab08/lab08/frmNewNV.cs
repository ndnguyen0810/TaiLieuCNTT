using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab08
{
    public partial class frmNewNV : Form
    {
        public frmNewNV()
        {
            InitializeComponent();

        }

        public bool themmoi = false;
        NhanVien nv = new NhanVien();
       
        void HienthiNhanvien()
        {
            lviewNV.FullRowSelect = true;
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";

            lviewNV.GridLines = true;
            lviewNV.Columns.Add("Ma Nhan Vien", 100);//1022
            lviewNV.Columns.Add("Ho ten Nhan Vien", 195);
            lviewNV.Columns.Add("Ngay sinh", 170);
            lviewNV.Columns.Add("Dia chi", 300);
            lviewNV.Columns.Add("Dien thoai", 130);
            lviewNV.Columns.Add("Ma bang", 120);

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
           // lviewNV.Columns[0].Width = 0;
        }

        private void lviewNV_Click(object sender, EventArgs e)
        {
            if (lviewNV.SelectedItems.Count > 0)
            {
                txtHoTen.Text = lviewNV.SelectedItems[0].SubItems[1].Text;
                txtDienThoai.Text = lviewNV.SelectedItems[0].SubItems[4].Text;
                txtDiaChi.Text = lviewNV.SelectedItems[0].SubItems[3].Text;
                string dte = lviewNV.SelectedItems[0].SubItems[2].Text;
                cbbBangCap.Text = lviewNV.SelectedItems[0].SubItems[5].Text;
                dtpNgaySinh.Value = DateTime.Parse(dte);
            }
        }


        void LoadNameNV()
        {
            lviewNV.FullRowSelect = true;
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";

            lviewNV.GridLines = true;
            lviewNV.Columns.Add("Ma Nhan Vien", 100);//1022
            lviewNV.Columns.Add("Ho ten Nhan Vien", 195);
            lviewNV.Columns.Add("Ngay sinh", 170);
            lviewNV.Columns.Add("Dia chi", 300);
            lviewNV.Columns.Add("Dien thoai", 130);
            lviewNV.Columns.Add("Ma bang", 120);
            //HienthiNhanvien();

        }

       
        void SetNull()
        {
            txtHoTen.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
        }

        void SetButon(bool val)
        {
            btnThem.Enabled = val;
            btnXoa.Enabled = val;
            btnSua.Enabled = val;
            btnThoat.Enabled = val;
            btnLuu.Enabled = !val;
            btnHuy.Enabled = !val;
        }

        void HienBangCap()
        {
            DataTable dt = nv.LayBangcap();
            cbbBangCap.DataSource = dt;
            cbbBangCap.DisplayMember = "TenBangCap";
            cbbBangCap.ValueMember = "maBangCap";
        }

        private void frmNewNV_Load(object sender, EventArgs e)
        {            
            SetNull();
            SetButon(true);
            HienBangCap();
           HienthiNhanvien();
           //LoadNameNV();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            SetButon(false);
            txtHoTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            if (lviewNV.SelectedIndices.Count > 0)
            {
               DialogResult dr = MessageBox.Show("Bạn có chắc xóa  không?", "Xóa bằng cấp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    nv.XoaNhanVien(Int32.Parse(lviewNV.SelectedItems[0].SubItems[0].Text));
                    //lviewNV.Items.RemoveAt( lviewNV.SelectedIndices[0]);
                    SetNull();
                  //  LoadNV();
                    
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lviewNV.SelectedIndices.Count > 0)
            {
                themmoi = false;
                SetButon(false);
                //LoadNV();
            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cập nhật", "Sửa mẫu tin");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
       
        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetButon(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ten = txtHoTen.Text;
            string dt = txtDienThoai.Text;
            string dc = txtDiaChi.Text;
            int bc = Int32.Parse(cbbBangCap.SelectedValue.ToString());
            string ngay = dtpNgaySinh.Text;
            if (themmoi)
            {
                nv.ThemNhanVien(ten, ngay, dt, dc, bc);
                MessageBox.Show("tc");

                //LoadNV();
            }
        }

       
    }
}
