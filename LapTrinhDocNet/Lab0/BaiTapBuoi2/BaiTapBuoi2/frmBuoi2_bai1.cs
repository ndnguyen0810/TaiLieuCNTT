using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapBuoi2
{
    public partial class frmBuoi2_bai1 : Form
    {
        public frmBuoi2_bai1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(txtNhap.Text);
            int tong = 0;
            for (int i = 1; i <= n; i++)
            {
                tong += i;
            }
            txtTong.Text = tong.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
