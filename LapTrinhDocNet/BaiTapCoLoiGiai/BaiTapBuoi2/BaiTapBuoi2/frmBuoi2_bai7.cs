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
    public partial class frmBuoi2_bai7 : Form
    {
        public frmBuoi2_bai7()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(txtS1.Text);
            int b = Int32.Parse(txtS2.Text);
            float tong = 0;
            if (rdoCong.Checked)
            {
                tong = a + b;
            }
            if (rdoTru.Checked)
            {
                tong = a - b;
            }
            if (rdoNhan.Checked)
            {
                tong = a * b;
            }
            if (rdoChia.Checked)
            {
                tong = (float)a / (float)b;
            }
            txtTong.Text = tong.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
