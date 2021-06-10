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
    public partial class frSinhVien : Form
    {
        public frSinhVien()
        {
            InitializeComponent();
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sINHVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lab07DataSet);

        }

        private void frSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lab07DataSet.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.lab07DataSet.KHOA);
            // TODO: This line of code loads data into the 'lab07DataSet.KETQUA' table. You can move, or remove it, as needed.
            this.kETQUATableAdapter.Fill(this.lab07DataSet.KETQUA);
            // TODO: This line of code loads data into the 'lab07DataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.lab07DataSet.SINHVIEN);

        }
    }
}
