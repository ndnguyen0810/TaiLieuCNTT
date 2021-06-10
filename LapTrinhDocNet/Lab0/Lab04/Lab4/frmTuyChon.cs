using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
	public partial class frmTuyChon : Form
	{
		public frmTuyChon()
		{
			InitializeComponent();
		}
		public SendMessage send;
		public frmTuyChon(SendMessage sender)
		{
			InitializeComponent();
			this.send = sender;
		}

		public frmTuyChon(Action<double, double, double, double> setValue)
		{
		}

		private void frmTuyChon_Load(object sender, EventArgs e)
		{

			txtcaovoi.Focus();
			
		}

		public void txtcaovoi_TextChanged(object sender, EventArgs e)
		{
			double CaoVoi = int.Parse(txtcaovoi.Text);
			txtcaovoi.Focus();
		}

		private void txttaytrang_TextChanged(object sender, EventArgs e)
		{
			double TayTrang = int.Parse(txttaytrang.Text);
		}

		private void txtchuphinh_TextChanged(object sender, EventArgs e)
		{
			double ChupHinh = int.Parse(txtchuphinh.Text);
		}

		private void txttramrang_TextChanged(object sender, EventArgs e)
		{
			double TramRang = int.Parse(txttramrang.Text);
		}

		public void btnUpdate_Click(object sender, EventArgs e)
		{
			using (System.IO.StreamWriter save = new System.IO.StreamWriter(@"D:\update.txt"))
			{
				save.WriteLine(txtcaovoi.Text);
				save.WriteLine(txttaytrang.Text);
				save.WriteLine(txtchuphinh.Text);
				save.WriteLine(txttramrang.Text);
			}
			MessageBox.Show("Cập nhật thành công!", "Thông báo");
		}

	}
}
