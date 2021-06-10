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
    public partial class frmBuoi2_bai6 : Form
    {
        public frmBuoi2_bai6()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(txtN.Text);
            int x = Int32.Parse(txtX.Text);
            double nhan = 0;
            for (int i = 1; i <= n; i++)
            {
                nhan = nhan + Math.Pow(x, i);
                if (i == 1)
                {
                    txtKQ1.Text = "X +";
                    txtKQ2.Text = x + " + ";
                    txtKQ3.Text = x * i + " + ";
                }
                else
                {
                    if (i == n)
                    {
                        txtKQ1.Text += "X ^ " + i;
                        txtKQ2.Text += x + " ^ " + i;
                        txtKQ3.Text += (Math.Pow(x, i)).ToString();
                    }
                    else
                    {
                        txtKQ1.Text += "X ^ " + i + " + ";
                        txtKQ2.Text += x + " ^ " + i + " + ";
                        txtKQ3.Text += (Math.Pow(x, i)).ToString() + " + ";
                    }

                }
            }
            txtKetqua.Text = nhan.ToString();
        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length > 0 && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            {
                this.errorProvider1.SetError(txtN, "This is not invalid number");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txtX_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length > 0 && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            {
                this.errorProvider1.SetError(txtX, "This is not invalid number");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void txtKQ1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKQ2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKQ3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKetqua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
