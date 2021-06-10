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
    public partial class frmBaiTapBuoi3 : Form
    {
        public frmBaiTapBuoi3()
        {
            InitializeComponent();
        }

        private void bàiTập1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuoi3_bai1 frm = new frmBuoi3_bai1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bàiTập2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuoi3_bai2 frm = new frmBuoi3_bai2();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bàiTập3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuoi3_bai3 frm = new frmBuoi3_bai3();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
