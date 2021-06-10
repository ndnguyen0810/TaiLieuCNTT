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
    public partial class frmBuoi2_bai3 : Form
    {
        public frmBuoi2_bai3()
        {
            InitializeComponent();
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length > 0 && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            {
                this.errorProvider1.SetError(txtNhap, "This is not invalid number");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(txtNhap.Text);
            int HT = n / 100;
            int HC = (n / 10) % 10;
            int HDV = (n % 10);
            if (n < 10)
                switch (Int32.Parse(txtNhap.Text))
                {
                    case 0:
                        txtKetQua.Text = "Không";
                        break;
                    case 1:
                        txtKetQua.Text = "Một";
                        break;
                    case 2:
                        txtKetQua.Text = "Hai";
                        break;
                    case 3:
                        txtKetQua.Text = "Ba";
                        break;
                    case 4:
                        txtKetQua.Text = "Bốn";
                        break;
                    case 5:
                        txtKetQua.Text = "Năm";
                        break;
                    case 6:
                        txtKetQua.Text = "Sáu";
                        break;
                    case 7:
                        txtKetQua.Text = "Bảy";
                        break;
                    case 8:
                        txtKetQua.Text = "Tám";
                        break;
                    case 9:
                        txtKetQua.Text = "Chín";
                        break;
                    default:
                        break;
                }
            else if (n < 100)
            {
                switch (HC)
                {
                    case 1:
                        txtKetQua.Text = "Mười";
                        break;
                    case 2:
                        txtKetQua.Text = "Hai";
                        break;
                    case 3:
                        txtKetQua.Text = "Ba";
                        break;
                    case 4:
                        txtKetQua.Text = "Bốn";
                        break;
                    case 5:
                        txtKetQua.Text = "Năm";
                        break;
                    case 6:
                        txtKetQua.Text = "Sáu";
                        break;
                    case 7:
                        txtKetQua.Text = "Bảy";
                        break;
                    case 8:
                        txtKetQua.Text = "Tám";
                        break;
                    case 9:
                        txtKetQua.Text = "Chín";
                        break;
                    default:
                        break;
                }
                switch (HDV)
                {
                    case 0:
                        if (HC != 1)
                        {
                            txtKetQua.Text += " Mươi";
                        }
                        break;
                    case 1:
                        txtKetQua.Text += " Một";
                        break;
                    case 2:
                        txtKetQua.Text += " Hai";
                        break;
                    case 3:
                        txtKetQua.Text += " Ba";
                        break;
                    case 4:
                        txtKetQua.Text += " Bốn";
                        break;
                    case 5:
                        txtKetQua.Text += " Năm";
                        break;
                    case 6:
                        txtKetQua.Text += " Sáu";
                        break;
                    case 7:
                        txtKetQua.Text += " Bảy";
                        break;
                    case 8:
                        txtKetQua.Text += " Tám";
                        break;
                    case 9:
                        txtKetQua.Text += " Chín";
                        break;
                    default:
                        break;
                }
            }
            else if (n < 1000)
            {
                switch (HT)
                {
                    case 1:
                        txtKetQua.Text = "Một Trăm";
                        break;
                    case 2:
                        txtKetQua.Text = "Hai Trăm";
                        break;
                    case 3:
                        txtKetQua.Text = "Ba Trăm";
                        break;
                    case 4:
                        txtKetQua.Text = "Bốn Trăm";
                        break;
                    case 5:
                        txtKetQua.Text = "Năm Trăm";
                        break;
                    case 6:
                        txtKetQua.Text = "Sáu Trăm";
                        break;
                    case 7:
                        txtKetQua.Text = "Bảy Trăm";
                        break;
                    case 8:
                        txtKetQua.Text = "Tám Trăm";
                        break;
                    case 9:
                        txtKetQua.Text = "Chín trăm";
                        break;
                    default:
                        break;
                }
                switch (HC)
                {
                    case 0:
                        if (HDV == 0)
                        {
                            txtKetQua.Text += "";
                        }
                        break;
                    case 1:
                        txtKetQua.Text += " Mười";
                        break;
                    case 2:
                        txtKetQua.Text += " Hai Mươi";
                        break;
                    case 3:
                        txtKetQua.Text += " Ba Mươi";
                        break;
                    case 4:
                        txtKetQua.Text += " Bốn Mươi";
                        break;
                    case 5:
                        txtKetQua.Text += " Năm Mươi";
                        break;
                    case 6:
                        txtKetQua.Text += " Sáu Mươi";
                        break;
                    case 7:
                        txtKetQua.Text += " Bảy Mươi";
                        break;
                    case 8:
                        txtKetQua.Text += " Tám Mươi";
                        break;
                    case 9:
                        txtKetQua.Text += " Chín Mươi";
                        break;
                    default:
                        break;
                }
                switch (HDV)
                {
                    case 0:
                        if (HC == 0)
                        {
                            txtKetQua.Text += " Chẳn";
                        }
                        break;
                    case 1:
                        if (HC == 0)
                        {
                            txtKetQua.Text += " Lẻ";
                        }
                        txtKetQua.Text += " Một";
                        break;
                    case 2:
                        if (HC == 0)
                        {
                            txtKetQua.Text += " Lẻ";
                        }
                        txtKetQua.Text += " Hai";
                        break;
                    case 3:
                        if (HC == 0)
                        {
                            txtKetQua.Text += " Lẻ";
                        }
                        txtKetQua.Text += " Ba";
                        break;
                    case 4:
                        if (HC == 0)
                        {
                            txtKetQua.Text += " Lẻ";
                        }
                        txtKetQua.Text += " Bốn";
                        break;
                    case 5:
                        if (HC == 0)
                        {
                            txtKetQua.Text += " Lẻ";
                        }
                        txtKetQua.Text += " Năm";
                        break;
                    case 6:
                        if (HC == 0)
                        {
                            txtKetQua.Text += " Lẻ";
                        }
                        txtKetQua.Text += " Sáu";
                        break;
                    case 7:
                        if (HC == 0)
                        {
                            txtKetQua.Text += " Lẻ";
                        }
                        txtKetQua.Text += " Bảy";
                        break;
                    case 8:
                        if (HC == 0)
                        {
                            txtKetQua.Text += " Lẻ";
                        }
                        txtKetQua.Text += " Tám";
                        break;
                    case 9:
                        if (HC == 0)
                        {
                            txtKetQua.Text += " Lẻ";
                        }
                        txtKetQua.Text += " Chín";
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNhap.Clear();
            txtKetQua.Clear();
            txtNhap.Focus();
        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
