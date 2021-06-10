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
    public partial class frmBuoi2_bai9 : Form
    {
        Double fMemory = 0; //Biến lưu memory
        Double KQ = 0; //Lưu lại số đầu tiên
        String Pheptinh = ""; //Các phép toán cộng trừ nhân chia
        public frmBuoi2_bai9()
        {
            InitializeComponent();
        }

        private void btnMC_Click(object sender, EventArgs e)
        {

            Button gedruktebutton = (Button)sender;
            string ButtonText = gedruktebutton.Text;

            if (ButtonText == "MC")
            {
                //Memory Clear
                fMemory = 0;
                lblMemory.Visible = false;
                return;
            }

            if (ButtonText == "MR")
            {
                //Gọi lại M
                txtSo.Text = fMemory.ToString();
                return;
            }
            if (ButtonText == "MS")
            {
                fMemory = Double.Parse(txtSo.Text);
                return;
            }

            if (ButtonText == "M-")
            {
                // Memory subtract
                if (txtSo.Text != "0")
                {
                    fMemory -= float.Parse(txtSo.Text);
                    //Nếu M bị trừ hết thì tắt biểu tượng M
                    if (fMemory == 0)
                    {
                        lblMemory.Visible = false;
                    }
                }
                return;
            }

            if (ButtonText == "M+")
            {
                // Memory add 
                if (txtSo.Text != "0")
                {
                    //Lưu trữ
                    fMemory += Double.Parse(txtSo.Text);
                    //Bật M+
                    lblMemory.Visible = true;

                }
                return;

            }
        }

        private void btnMR_Click(object sender, EventArgs e)
        {

            Button gedruktebutton = (Button)sender;
            string ButtonText = gedruktebutton.Text;


            if (ButtonText == "MC")
            {
                //Memory Clear
                fMemory = 0;
                lblMemory.Visible = false;
                return;
            }

            if (ButtonText == "MR")
            {
                //Gọi lại M
                txtSo.Text = fMemory.ToString();
                return;
            }
            if (ButtonText == "MS")
            {
                fMemory = Double.Parse(txtSo.Text);
                return;
            }

            if (ButtonText == "M-")
            {
                // Memory subtract
                if (txtSo.Text != "0")
                {
                    fMemory -= float.Parse(txtSo.Text);
                    //Nếu M bị trừ hết thì tắt biểu tượng M
                    if (fMemory == 0)
                    {
                        lblMemory.Visible = false;
                    }
                }
                return;
            }

            if (ButtonText == "M+")
            {
                // Memory add 
                if (txtSo.Text != "0")
                {
                    //Lưu trữ
                    fMemory += Double.Parse(txtSo.Text);
                    //Bật M+
                    lblMemory.Visible = true;

                }
                return;

            }
        }

        private void btnMS_Click(object sender, EventArgs e)
        {

            Button gedruktebutton = (Button)sender;
            string ButtonText = gedruktebutton.Text;


            if (ButtonText == "MC")
            {
                //Memory Clear
                fMemory = 0;
                lblMemory.Visible = false;
                return;
            }

            if (ButtonText == "MR")
            {
                //Gọi lại M
                txtSo.Text = fMemory.ToString();
                return;
            }
            if (ButtonText == "MS")
            {
                fMemory = Double.Parse(txtSo.Text);
                return;
            }

            if (ButtonText == "M-")
            {
                // Memory subtract
                if (txtSo.Text != "0")
                {
                    fMemory -= float.Parse(txtSo.Text);
                    //Nếu M bị trừ hết thì tắt biểu tượng M
                    if (fMemory == 0)
                    {
                        lblMemory.Visible = false;
                    }
                }
                return;
            }

            if (ButtonText == "M+")
            {
                // Memory add 
                if (txtSo.Text != "0")
                {
                    //Lưu trữ
                    fMemory += Double.Parse(txtSo.Text);
                    //Bật M+
                    lblMemory.Visible = true;

                }
                return;

            }
        }

        private void btnMCong_Click(object sender, EventArgs e)
        {
            Button gedruktebutton = (Button)sender;
            string ButtonText = gedruktebutton.Text;


            if (ButtonText == "MC")
            {
                //Memory Clear
                fMemory = 0;
                lblMemory.Visible = false;
                return;
            }

            if (ButtonText == "MR")
            {
                //Gọi lại M
                txtSo.Text = fMemory.ToString();
                return;
            }
            if (ButtonText == "MS")
            {
                fMemory = Double.Parse(txtSo.Text);
                return;
            }

            if (ButtonText == "M-")
            {
                // Memory subtract
                if (txtSo.Text != "0")
                {
                    fMemory -= float.Parse(txtSo.Text);
                    //Nếu M bị trừ hết thì tắt biểu tượng M
                    if (fMemory == 0)
                    {
                        lblMemory.Visible = false;
                    }
                }
                return;
            }

            if (ButtonText == "M+")
            {
                // Memory add 
                if (txtSo.Text != "0")
                {
                    //Lưu trữ
                    fMemory += Double.Parse(txtSo.Text);
                    //Bật M+
                    lblMemory.Visible = true;

                }
                return;

            }
        }

        private void btnMTru_Click(object sender, EventArgs e)
        {
            Button gedruktebutton = (Button)sender;
            string ButtonText = gedruktebutton.Text;


            if (ButtonText == "MC")
            {
                //Memory Clear
                fMemory = 0;
                lblMemory.Visible = false;
                return;
            }

            if (ButtonText == "MR")
            {
                //Gọi lại M
                txtSo.Text = fMemory.ToString();
                return;
            }
            if (ButtonText == "MS")
            {
                fMemory = Double.Parse(txtSo.Text);
                return;
            }

            if (ButtonText == "M-")
            {
                // Memory subtract
                if (txtSo.Text != "0")
                {
                    fMemory -= float.Parse(txtSo.Text);
                    //Nếu M bị trừ hết thì tắt biểu tượng M
                    if (fMemory == 0)
                    {
                        lblMemory.Visible = false;
                    }
                }
                return;
            }

            if (ButtonText == "M+")
            {
                // Memory add 
                if (txtSo.Text != "0")
                {
                    //Lưu trữ
                    fMemory += Double.Parse(txtSo.Text);
                    //Bật M+
                    lblMemory.Visible = true;

                }
                return;

            }
        }

        private void btnLui_Click(object sender, EventArgs e)
        {
            string _temp = txtSo.Text;
            _temp = _temp.Remove(_temp.Length - 1);
            //Gán lại cho khung KQ
            if (_temp == "")
            {
                txtSo.Text = "0";
            }
            else
            {
                txtSo.Text = _temp;
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtSo.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtSo.Text = "";
            KQ = 0;
            Pheptinh = "";
        }

        private void btnCongTru_Click(object sender, EventArgs e)
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

        private void btnCan_Click(object sender, EventArgs e)
        {

           
            double _temp = double.Parse(txtSo.Text);
            //Nếu căn bậc 2 số âm thì lỗi NaN
            _temp = Math.Sqrt(_temp);
            txtSo.Text = _temp.ToString();
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

        private void btnChia_Click(object sender, EventArgs e)
        {
            KQ = Double.Parse(txtSo.Text);
            Pheptinh = btnChia.Text;
            txtSo.Text = "";
        }

        private void btnPhanTram_Click(object sender, EventArgs e)
        {
            double _temp = double.Parse(txtSo.Text);
            _temp = _temp / 100;
            txtSo.Text = _temp.ToString();
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

        private void btnNhan_Click(object sender, EventArgs e)
        {
            KQ = Double.Parse(txtSo.Text);
            Pheptinh = btnNhan.Text;
            txtSo.Text = "";
        }

        private void btn1chiaX_Click(object sender, EventArgs e)
        {
            KQ = Double.Parse(txtSo.Text);
            Pheptinh = btnChia.Text;
            txtSo.Text = "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtSo.Text = txtSo.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtSo.Text = txtSo.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtSo.Text = txtSo.Text + btn3.Text;
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            KQ = Double.Parse(txtSo.Text);
            Pheptinh = btnTru.Text;
            txtSo.Text = "";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtSo.Text = txtSo.Text + btn0.Text;
        }

        private void btnCham_Click(object sender, EventArgs e)
        {
            if (!txtSo.Text.Contains("."))
                txtSo.Text = txtSo.Text + btnCham.Text;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            KQ = Double.Parse(txtSo.Text);
            Pheptinh = btnCong.Text;
            txtSo.Text = "";
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
    }
}
