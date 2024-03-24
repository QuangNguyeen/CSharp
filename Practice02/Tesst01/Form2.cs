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

namespace Tesst01
{
    public partial class Form2 : Form
    {
        string connectionString = "Data Source = DESKTOP-V4CU01B\\SQLEXPRESS; Database = QLSV01; Integrated Security = True";
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonLoc_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                // update
                string query = "";
                if(textBoxID.Text != null)
                {
                    query = "select * from SinhVien where maSV = '"+textBoxID.Text+"'";
                }
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                dataGridView1.DataSource = datatable;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLoc02_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                // update
                string query = "";
                if (textBoxID.Text != null)
                {
                    query = "select * from SinhVien where noiSinh = '" +comboBox1.Text + "'";
                }
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                dataGridView1.DataSource = datatable;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLoc03_Click(object sender, EventArgs e)
        {
            int gioiTinh = 0;
            if (radioButtonFemale.Checked)
            {
                gioiTinh = 0;
            }
            else
            {
                gioiTinh = 1;
            }
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                // update
                string query = "";
                if (textBoxID.Text != null)
                {
                    query = "select * from SinhVien where gioiTinh = " + gioiTinh + "";
                }
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                dataGridView1.DataSource = datatable;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
