using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(txtnhapA.Text);
            int b = Int32.Parse(txtnhapB.Text);
            int kq= 0;
            if (rbBSCNN.Checked == true)
            {
                kq= BSCNN(a, b);
                txtKetqua.Text = kq.ToString();
            }
            if (rbUSCLN.Checked == true)
            {
                kq = USCLN(a, b);
                txtKetqua.Text = kq.ToString();
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            txtnhapA.Clear();
            txtnhapB.Clear();
            txtKetqua.Clear();
            txtnhapA.Focus();
        }

        public int BSCNN(int a, int b)
        {
            return (a * b) / USCLN(a, b);
        }

        public int USCLN(int a, int b)
        {
            if (b == 0)
                return a;
            return USCLN(b, a % b);
        }
       
    }
}
