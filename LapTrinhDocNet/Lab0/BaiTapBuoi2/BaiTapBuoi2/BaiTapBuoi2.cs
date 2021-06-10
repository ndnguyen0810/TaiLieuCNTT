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
    public partial class BaiTapBuoi2 : Form
    {
        public BaiTapBuoi2()
        {
            InitializeComponent();
        }

        private void bài1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuoi2_bai1 frm = new frmBuoi2_bai1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bài2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuoi2_bai2 frm = new frmBuoi2_bai2();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bài3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuoi2_bai3 frm = new frmBuoi2_bai3();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bài4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuoi2_bai4 frm = new frmBuoi2_bai4();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bài5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuoi2_bai5 frm = new frmBuoi2_bai5();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bài6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuoi2_bai6 frm = new frmBuoi2_bai6();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bài7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuoi2_bai7 frm = new frmBuoi2_bai7();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bài8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuoi2_bai8 frm = new frmBuoi2_bai8();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bài9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuoi2_bai9 frm = new frmBuoi2_bai9();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
