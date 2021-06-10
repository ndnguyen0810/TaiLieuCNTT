using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Button
        private void button0_Click(object sender, EventArgs e)
        {
            txtNhap.Text += button0.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtNhap.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNhap.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNhap.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtNhap.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtNhap.Text += button5.Text;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            txtNhap.Text += button6.Text;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            txtNhap.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtNhap.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtNhap.Text += button9.Text;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            txtNhap.Clear();
            txtNhap.Focus();
        }
#endregion
       // public ListBox listbox = new ListBox();

        private void button11_Click(object sender, EventArgs e)
        {

            int code = int.Parse(txtNhap.Text);
            switch (code)
            {
                case 1645:
                    listbox.Items.Add(DateTime.Now + "\t Technicians");
                    txtNhap.Clear();  
                    break;   
              
                case 1689:
                    listbox.Items.Add(DateTime.Now + "\t Technicians");        txtNhap.Clear();         
                    break;

                case 8345:
                    listbox.Items.Add(DateTime.Now + "\t Custodians");         txtNhap.Clear();        
                    break;

                case 9998:
                    listbox.Items.Add(DateTime.Now + "\t Scientist");        txtNhap.Clear();         
                    break;

                case 1006:
                    listbox.Items.Add(DateTime.Now + "\t Scientist");           txtNhap.Clear();      
                    break;

                case 1008:
                    listbox.Items.Add(DateTime.Now + "\t Scientist");           txtNhap.Clear();      
                    break;

                default:
                    listbox.Items.Add(DateTime.Now + "\t Restricted Access!");  
                    break;
            }
            using (System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(@"D:\NguyenDinhNguyen_Lab03\list.txt"))
            {
                foreach (var item in listbox.Items)
                {
                    SaveFile.WriteLine(item.ToString());
                }
            }
           

        }

        private void txtNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)&&(e.KeyChar!='.'))
            {
                e.Handled= true;
            }
          
        }
        
        private void listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
       // public ListBox mylist = new ListBox();
     //   public DateTime datetime = new DateTime(day,month,)
        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        
        
       
    }
}
