using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        

        public void txtNhapN_TextChanged(object sender, EventArgs e)
        {
           // int n = Int32.Parse(txtNhapN.Text);
         //   int m = Int32.Parse(txtNhapM.Text);
        }

        public void btnCong_Click(object sender, EventArgs e)
        {
            float n = float.Parse(txtNhapN.Text);
            float m = float.Parse(txtNhapM.Text);
            float kq= n+m;
            txtKetQua.Text = kq.ToString();
            
        }

        public void Form1_Load(object sender, EventArgs e)
        {
          
          
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            float n = float.Parse(txtNhapN.Text);
            float m = float.Parse(txtNhapM.Text);
            float kq = n - m;
            txtKetQua.Text = kq.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            float n = float.Parse(txtNhapN.Text);
            float m = float.Parse(txtNhapM.Text);
            float kq = n* m;
            txtKetQua.Text = kq.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            float n = float.Parse(txtNhapN.Text);
            float m = float.Parse(txtNhapM.Text);
            float kq = n/m;
            txtKetQua.Text = kq.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtKetQua.Clear();
            txtNhapM.Clear();
            txtNhapN.Clear();
            txtNhapM.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
