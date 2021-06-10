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
    public partial class frmKetQua : Form
    {
        public frmKetQua()
        {
            InitializeComponent();
        }

        private void kETQUABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kETQUABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lab07DataSet);

        }

        private void frmKetQua_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lab07DataSet.MON' table. You can move, or remove it, as needed.
            this.mONTableAdapter.Fill(this.lab07DataSet.MON);
            // TODO: This line of code loads data into the 'lab07DataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.lab07DataSet.SINHVIEN);
            // TODO: This line of code loads data into the 'lab07DataSet.KETQUA' table. You can move, or remove it, as needed.
            this.kETQUATableAdapter.Fill(this.lab07DataSet.KETQUA);

        }

        private void kETQUADataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.kETQUATableAdapter.FillBy1(this.lab07DataSet.KETQUA);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
