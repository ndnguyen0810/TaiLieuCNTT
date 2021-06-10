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
    public partial class frmBuoi3_bai2 : Form
    {
        SoPhuc sp = new SoPhuc();
        public frmBuoi3_bai2()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            SoPhuc SP1 = new SoPhuc(Int32.Parse(txtThuc1.Text), Int32.Parse(txtAo1.Text));
            SoPhuc SP2 = new SoPhuc(Int32.Parse(txtThuc2.Text), Int32.Parse(txtAo2.Text));
            sp = SP1 + SP2;
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            SoPhuc SP1 = new SoPhuc(Int32.Parse(txtThuc1.Text), Int32.Parse(txtAo1.Text));
            SoPhuc SP2 = new SoPhuc(Int32.Parse(txtThuc2.Text), Int32.Parse(txtAo2.Text));
            sp = SP1 - SP2;
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            SoPhuc SP1 = new SoPhuc(Int32.Parse(txtThuc1.Text), Int32.Parse(txtAo1.Text));
            SoPhuc SP2 = new SoPhuc(Int32.Parse(txtThuc2.Text), Int32.Parse(txtAo2.Text));
            sp = SP1 * SP2;
        }

        private void btbChia_Click(object sender, EventArgs e)
        {
            SoPhuc SP1 = new SoPhuc(Int32.Parse(txtThuc1.Text), Int32.Parse(txtAo1.Text));
            SoPhuc SP2 = new SoPhuc(Int32.Parse(txtThuc2.Text), Int32.Parse(txtAo2.Text));
            sp = SP1 / SP2;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sp.XuatSP());
        }

        private void btbXoa_Click(object sender, EventArgs e)
        {
            txtAo1.Clear();
            txtAo2.Clear();
            txtThuc1.Clear();
            txtThuc2.Clear();
            txtThuc1.Focus();
        }
    }
}
