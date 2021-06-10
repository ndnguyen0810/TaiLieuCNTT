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
    public partial class frmBuoi3_bai1 : Form
    {
        public frmBuoi3_bai1()
        {
            InitializeComponent();
        }

        private void btnKT_Click(object sender, EventArgs e)
        {
            TamGiac tamGiac = new TamGiac(Int32.Parse(txtCanh1.Text), Int32.Parse(txtCanh2.Text), Int32.Parse(txtCanh3.Text));
            if (tamGiac.Kiemtra() == 0)
            {
                MessageBox.Show("Ba cạnh thứ 1, thứ 2, thứ 3 không phải là ba cạnh của một tam giác!!");
            }
            else
            {
                MessageBox.Show("Ba cạnh thứ 1, thứ 2, thứ 3 là ba cạnh của một tam giác!!");
            }       
        }

        private void btbLoai_Click(object sender, EventArgs e)
        {
            TamGiac tamGiac = new TamGiac(Int32.Parse(txtCanh1.Text), Int32.Parse(txtCanh2.Text), Int32.Parse(txtCanh3.Text));
            if (tamGiac.Kiemtra() == 3)
            {
                MessageBox.Show("Đây là tam giác cân!!");
            }
            else if (tamGiac.Kiemtra() == 2)
            {
                MessageBox.Show("Đây là tam giác đều!!");
            }
            else if (tamGiac.Kiemtra() == 1)
            {
                MessageBox.Show("Đây là tam giác vuông!!");
            }
            else
            {
                MessageBox.Show("Đây không phải là tam giác!!");
            }
        }

        private void btnCV_Click(object sender, EventArgs e)
        {
            TamGiac tamGiac = new TamGiac(Int32.Parse(txtCanh1.Text), Int32.Parse(txtCanh2.Text), Int32.Parse(txtCanh3.Text));
            if (tamGiac.Kiemtra() == 3)
            {
                MessageBox.Show("Chu vi của Tam giác là " + tamGiac.TinhChuVi().ToString());
            }
            else if (tamGiac.Kiemtra() == 2)
            {
                MessageBox.Show("Chu vi của Tam giác là " + tamGiac.TinhChuVi().ToString());
            }
            else if (tamGiac.Kiemtra() == 1)
            {
                MessageBox.Show("Chu vi của Tam giác là " + tamGiac.TinhChuVi().ToString());
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai !! Đây không phải là tam giác");
            }
        }

        private void btbDT_Click(object sender, EventArgs e)
        {
            TamGiac tamGiac = new TamGiac(Int32.Parse(txtCanh1.Text), Int32.Parse(txtCanh2.Text), Int32.Parse(txtCanh3.Text));
            if (tamGiac.Kiemtra() == 3)
            {
                MessageBox.Show("Diện tích của Tam giác là " + tamGiac.TinhDienTich().ToString());
            }
            else if (tamGiac.Kiemtra() == 2)
            {
                MessageBox.Show("Diện tích của Tam giác là " + tamGiac.TinhDienTich().ToString());
            }
            else if (tamGiac.Kiemtra() == 1)
            {
                MessageBox.Show("Diện tích của Tam giác là " + tamGiac.TinhDienTich().ToString());
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai !! Đây không phải là tam giác");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtCanh1.Clear();
            txtCanh2.Clear();
            txtCanh3.Clear();
            txtCanh1.Focus();
        }
    }
}
