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
    public partial class frmBuoi2_bai8 : Form
    {
        public frmBuoi2_bai8()
        {
            InitializeComponent();
        }
        Double KQ = 0; //Lưu lại số đầu tiên
        String Pheptinh = ""; //Các phép toán cộng trừ nhân chia
        private void grbNumber_Enter(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtSo.Text = txtSo.Text + btn0.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtSo.Text = txtSo.Text + btn1.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSo.Text = "";
            KQ = 0;
            Pheptinh = "";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtSo.Text = txtSo.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtSo.Text = txtSo.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtSo.Text = txtSo.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtSo.Text = txtSo.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtSo.Text = txtSo.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtSo.Text = txtSo.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtSo.Text = txtSo.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtSo.Text = txtSo.Text + btn9.Text;
        }

        private void btnCham_Click(object sender, EventArgs e)
        {
            if (!txtSo.Text.Contains("."))
                txtSo.Text = txtSo.Text + btnCham.Text;
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            switch (Pheptinh)
            {
                case "+":
                    txtSo.Text = (KQ + Double.Parse(txtSo.Text)).ToString();
                    break;
                case "-":
                    txtSo.Text = (KQ - Double.Parse(txtSo.Text)).ToString();
                    break;
                case "*":
                    txtSo.Text = (KQ * Double.Parse(txtSo.Text)).ToString();
                    break;
                case "/":
                    txtSo.Text = (KQ / Double.Parse(txtSo.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            KQ = Double.Parse(txtSo.Text);
            Pheptinh = btnCong.Text;
            txtSo.Text = "";
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            KQ = Double.Parse(txtSo.Text);
            Pheptinh = btnTru.Text;
            txtSo.Text = "";
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            KQ = Double.Parse(txtSo.Text);
            Pheptinh = btnNhan.Text;
            txtSo.Text = "";
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            KQ = Double.Parse(txtSo.Text);
            Pheptinh = btnChia.Text;
            txtSo.Text = "";
        }

        private void btncongtru_Click(object sender, EventArgs e)
        {
            string _temp = txtSo.Text;

            //Nếu đang là âm thì xóa
            if (_temp[0] == '-')
            {
                _temp = _temp.Remove(0, 1);
            }
            else //Đang ko có dấu thì thêm dấu âm
            {
                _temp = "-" + _temp;
            }

            txtSo.Text = _temp;
        }
    }
}
