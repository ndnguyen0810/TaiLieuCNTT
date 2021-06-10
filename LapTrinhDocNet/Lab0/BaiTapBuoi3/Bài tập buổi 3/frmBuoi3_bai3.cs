using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_tập_buổi_3
{
    public partial class frmBuoi3_bai3 : Form
    {
        PhanSo ps = new PhanSo();
        public frmBuoi3_bai3()
        {
            InitializeComponent();
        }

        private void btbIn_Click(object sender, EventArgs e)
        {

        }

        private void btbRutGon_Click(object sender, EventArgs e)
        {

        }

        private void btbCong_Click(object sender, EventArgs e)
        {
            PhanSo PS1 = new PhanSo(Convert.ToSingle(txtTS1.Text), Convert.ToSingle(txtMS1.Text));
            PhanSo PS2 = new PhanSo(Convert.ToSingle(txtTS2.Text), Convert.ToSingle(txtMS2.Text));
            ps = PS1 + PS2;
            ps.InPhanSo();
        }

        private void btbTru_Click(object sender, EventArgs e)
        {
            PhanSo PS1 = new PhanSo(Convert.ToSingle(txtTS1.Text), Convert.ToSingle(txtMS1.Text));
            PhanSo PS2 = new PhanSo(Convert.ToSingle(txtTS2.Text), Convert.ToSingle(txtMS2.Text));
            ps = PS1 - PS2;
            ps.InPhanSo();
        }

        private void btbNhan_Click(object sender, EventArgs e)
        {
            PhanSo PS1 = new PhanSo(Convert.ToSingle(txtTS1.Text), Convert.ToSingle(txtMS1.Text));
            PhanSo PS2 = new PhanSo(Convert.ToSingle(txtTS2.Text), Convert.ToSingle(txtMS2.Text));
            ps = PS1 * PS2;
            ps.InPhanSo();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            PhanSo PS1 = new PhanSo(Convert.ToSingle(txtTS1.Text), Convert.ToSingle(txtMS1.Text));
            PhanSo PS2 = new PhanSo(Convert.ToSingle(txtTS2.Text), Convert.ToSingle(txtMS2.Text));
            ps = PS1 / PS2;
            ps.InPhanSo();
        }

        private void btbSoSanh_Click(object sender, EventArgs e)
        {
            PhanSo PS1 = new PhanSo(Convert.ToSingle(txtTS1.Text), Convert.ToSingle(txtMS1.Text));
            PhanSo PS2 = new PhanSo(Convert.ToSingle(txtTS2.Text), Convert.ToSingle(txtMS2.Text));
            if (PS1 > PS2 == true)
            {
                MessageBox.Show("Phân số 1 lớn hơn Phân số 2");
            }
            else
            {
                MessageBox.Show("Phân số 1 bé hơn Phân số 2");
            }
        }

        private void btnChuyenDoi_Click(object sender, EventArgs e)
        {
            PhanSo PS1 = new PhanSo(Convert.ToSingle(txtTS1.Text), Convert.ToSingle(txtMS1.Text));
            PhanSo PS2 = new PhanSo(Convert.ToSingle(txtTS2.Text), Convert.ToSingle(txtMS2.Text));
            float ps1 = PS1.ChuyenDoi();
            float ps2 = PS2.ChuyenDoi(PS2.Tuso, PS2.Mauso);
            MessageBox.Show("Phân số 1 : " + ps1.ToString() + "\nPhân số 2 : " + ps2.ToString());
        }

        private void btbXoa_Click(object sender, EventArgs e)
        {

        }

        private void frmBuoi3_bai3_Load(object sender, EventArgs e)
        {

        }
    }
}
