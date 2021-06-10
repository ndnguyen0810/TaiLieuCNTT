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
    public partial class frmBuoi2_bai2 : Form
    {
        public frmBuoi2_bai2()
        {
            InitializeComponent();
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {

            int a = Int32.Parse(txtA.Text);
            int b = Int32.Parse(txtB.Text);
            int c = Int32.Parse(txtC.Text);
            int max = a;
            int min = a;
            if (max < b)
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
            }
            if (min > b)
            {
                min = b;
            }
            if (min > c)
            {
                min = c;
            }
            txtMax.Text = max.ToString();
            txtMin.Text = min.ToString();
        }

        private void txtMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
