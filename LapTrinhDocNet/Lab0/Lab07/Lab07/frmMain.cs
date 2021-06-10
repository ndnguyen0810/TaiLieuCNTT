using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
     

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frSinhVien")
                {
                    f.Activate();
                    return;
                }
            }
            frSinhVien frm = new frSinhVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmKhoa")
                {
                    f.Activate();
                    return;
                }
            }
            frmKhoa frm = new frmKhoa();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmMonHoc")
                {
                    f.Activate();
                    return;
                }
            }
            frmMonHoc frm = new frmMonHoc();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmXemDiem")
                {
                    f.Activate();
                    return;
                }
            }
            frmXemDiem frm = new frmXemDiem();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripLabel6_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frSinhVien")
                {
                    f.Activate();
                    return;
                }
            }
            frSinhVien frm = new frSinhVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "frmKetQua")
                {
                    f.Activate();
                    return;
                }
            }
            frmKetQua frm = new frmKetQua();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
