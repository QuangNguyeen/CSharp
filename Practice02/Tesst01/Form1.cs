using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tesst01
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source = DESKTOP-V4CU01B\\SQLEXPRESS; Database = QLSV01; Integrated Security = True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "select * from SinhVien";
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

        private void buttonThem_Click(object sender, EventArgs e)
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
                // insert
                string query = "insert into SinhVien values ('" + textBoxID.Text + "', '" + textBoxName.Text + "','" + dateTimePicker1.Text + "' ,'" + comboBox1.Text + "', " + gioiTinh + ")";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);

                // Show data
                query = "select * from SinhVien";
                cmd = new SqlCommand(query, connection);
                adapter = new SqlDataAdapter(cmd);
                datatable = new DataTable();
                adapter.Fill(datatable);
                dataGridView1.DataSource = datatable;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString().Equals("True"))
            {
                radioButtonMale.Checked = true;

            }
            else
            {

                radioButtonFemale.Checked = true;
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
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
            // Lay Id cu
            string Id = dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString();

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                // update
                string query = "update SinhVien set maSV = '" + textBoxID.Text + "', hoTen = '" + textBoxName.Text + "', ngaySinh = '" + dateTimePicker1.Text + "', noiSinh = '" + comboBox1.Text + "', gioiTinh = " + gioiTinh + "\r\nwhere maSV = '" + Id + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);

                query = "select * from SinhVien";
                cmd = new SqlCommand(query, connection);
                adapter = new SqlDataAdapter(cmd);
                datatable = new DataTable();
                adapter.Fill(datatable);
                dataGridView1.DataSource = datatable;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
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
            // Lay Id cu
            string Id = textBoxID.Text;

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                // update
                string query = "delete SinhVien\r\nwhere maSV = '"+textBoxID.Text+"'";
                SqlCommand cmd = new SqlCommand(query, connection);
                int row = cmd.ExecuteNonQuery();
                if(row > 0)
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable datatable = new DataTable();
                    adapter.Fill(datatable);

                    query = "select * from SinhVien";
                    cmd = new SqlCommand(query, connection);
                    adapter = new SqlDataAdapter(cmd);
                    datatable = new DataTable();
                    adapter.Fill(datatable);
                    dataGridView1.DataSource = datatable;
                }
                else
                {
                    MessageBox.Show("Khong tim thay sinh vien");
                }
                
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLoc_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}