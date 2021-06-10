using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07
{
    public partial class frmXemDiem : Form
    {
        public frmXemDiem()
        {
            InitializeComponent();
        }

        private void kETQUABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kETQUABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lab07DataSet);

        }

        private void frmXemDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lab07DataSet.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.lab07DataSet.KHOA);
            // TODO: This line of code loads data into the 'lab07DataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.lab07DataSet.SINHVIEN);
            // TODO: This line of code loads data into the 'lab07DataSet.KETQUA' table. You can move, or remove it, as needed.
            this.kETQUATableAdapter.Fill(this.lab07DataSet.KETQUA);


         }

       // SqlConnection con;

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=admin\dinhnguyen;Initial Catalog=Lab07;Integrated Security=True");
                 string query = "Select sv.HOTEN,sv.NGAYSINH,k.TENKHOA,mh.TENMH,kq.DIEM from SINHVIEN sv,KHOA k, KETQUA kq ,MON mh where sv.MAKHOA = k.MAKHOA  and sv.MASO = kq.MASO and kq.MAMH = mh.MAMH and sv.MASO = kq.MASO and sv.MAKHOA = k.MAKHOA";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                cmd.Parameters.AddWithValue("MASO", mASOComboBox.Text);
                cmd.Parameters.AddWithValue("HOTEN", hOTENComboBox.Text);
                cmd.Parameters.AddWithValue("MAKHOA", mAKHOAComboBox.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);

                da.Fill(dt);
                int n = cmd.ExecuteNonQuery();
                con.Close();
                DataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}