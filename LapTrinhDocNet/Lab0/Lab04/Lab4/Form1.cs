using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
	
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnCalc_Click(object sender, EventArgs e)
		{
			GetPay();
			listTien.Items.Add(txtName.Text + "\t" + txtTotal.Text);

		}

		public void GetPay()
		{
			if (txtName.Text == "")
			{
				MessageBox.Show("Vui lòng nhập tên khách hàng!", "Thông báo");
			}
			else
			{
				double Total = 0;
				if (chkClean.Checked == true)
				{
					Total += 100000;
					txtTotal.Text = Total.ToString();
				}
				if (chkWhitening.Checked == true)
				{
					Total += 1200000;
					txtTotal.Text = Total.ToString();
				}
				if (chkXRay.Checked == true)
				{
					Total += 200000;
					txtTotal.Text = Total.ToString();
				}
				if (numfilling.Value >0)
				{
					int count = Convert.ToInt32(numfilling.Value);
					Total += 80000 * count;
					txtTotal.Text = Total.ToString();
				}			
			}

				
		}



		private void listTien_SelectedIndexChanged(object sender, EventArgs e)
		{
			listTien.Items.Add(txtName.Text + "\t" + txtTotal.Text);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			using (System.IO.StreamWriter save = new System.IO.StreamWriter(@".\NguyenDinhNguyen_Lab_BT1\Tien.txt"))
			{
				foreach(var item in listTien.Items)
				{
					save.WriteLine(item.ToString());
				}
			}
		}

		public void btnSelect_Click(object sender, EventArgs e)
		{
			double CV_M = int.Parse(lblCaoVoi.Text);
			double TT_M = int.Parse(lblTayTrang.Text);
			double CH_M = int.Parse(lblChupHinh.Text);
			double TR_M = int.Parse(lblTram.Text);

			frmTuyChon frm = new frmTuyChon();
			this.Hide();
			frm.ShowDialog();
			this.Show();

		}
		private void SetValue(double cv, double tt, double ch, double tr)
		{
			cv = int.Parse(lblCaoVoi.Text);
			tt = int.Parse(lblTayTrang.Text);
			ch = int.Parse(lblChupHinh.Text);
			tr = int.Parse(lblTram.Text);
		
		}
		public void Form1_Load(object sender, EventArgs e)
		{
			string[] lines= File.ReadAllLines(@"D:\update.txt");
			lblCaoVoi.Text = lines[0];
			lblTayTrang.Text = lines[1];
			lblChupHinh.Text = lines[2];
			lblTram.Text = lines[3];
		}
	}
}