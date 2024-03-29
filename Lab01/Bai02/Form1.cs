using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Bai02
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source = DESKTOP-V4CU01B\\SQLEXPRESS; Database = Lab01; Integrated Security = True";
        public Form1()
        {
            InitializeComponent();
        }
         private void Form1_Load(object sender, EventArgs e)
         {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from BacSi", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                int gioiTinh = 0;
                if (radioButtonNu.Checked)
                {
                    gioiTinh = 1;
                }
                string chucDanh = "";
                foreach(var item in listBox1.SelectedItems)
                {
                    chucDanh += item.ToString() + ".";
                }
                if (!string.IsNullOrEmpty(chucDanh))
                {
                    chucDanh = chucDanh.TrimEnd('.');
                }
                SqlCommand cmd = new SqlCommand("insert into BacSi values\r\n('"+textBoxTen.Text+"', "+gioiTinh+", '"+comboBoxQue.Text+"', '"+chucDanh+"', '"+dateTimePicker1.Text+"')", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmd = new SqlCommand("select * from BacSi", connection);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxTen.Text      = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBoxQue.Text     = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            if(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() == "False")
            {
                radioButtonNam.Checked = true;
            }
            else
            {
                radioButtonNu.Checked = true;
            }

            string[] chucDanh = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString().Split('.');

            // Reset lai ListBox
            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox1.SetSelected(i, false);
            }

            // 
            foreach(string chucdanh in chucDanh)
            {
                int index = listBox1.Items.IndexOf(chucdanh);
                if(index >= 0)
                {
                    listBox1.SetSelected(index, true);
                }
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                int gioiTinh = 0;
                if (radioButtonNu.Checked)
                {
                    gioiTinh = 1;
                }
                string chucDanh = "";
                foreach (var item in listBox1.SelectedItems)
                {
                    chucDanh += item.ToString() + ".";
                }
                // Xoa dau . o cuoi chuoi
                if (!string.IsNullOrEmpty(chucDanh))
                {
                    chucDanh = chucDanh.TrimEnd('.');
                }

                // Lay Ten Cu
                string tenCu = dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
                SqlCommand cmd = new SqlCommand("update BacSi set Ten = '" + textBoxTen.Text+"', GioiTinh = "+gioiTinh+", QueQuan = '"+comboBoxQue.Text+"', ChucDanh = '"+chucDanh+"', NgaySinh = Convert(Date,'"+dateTimePicker1.Text+"',106)\r\nwhere Ten = '"+tenCu+"'", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmd = new SqlCommand("select * from BacSi", connection);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string chucDanh = "";
                foreach(var item in listBox1.SelectedItems)
                {
                    chucDanh += item.ToString() + ".";
                }
                if (!string.IsNullOrEmpty(chucDanh))
                {
                    chucDanh = chucDanh.TrimEnd('.');
                }
                SqlCommand cmd = new SqlCommand("delete from BacSi where Ten = '"+textBoxTen.Text+"'", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmd = new SqlCommand("select * from BacSi", connection);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string chucDanh = "";
                foreach (var item in listBox1.SelectedItems)
                {
                    chucDanh += item.ToString() + ".";
                }
                if (!string.IsNullOrEmpty(chucDanh))
                {
                    chucDanh = chucDanh.TrimEnd('.');
                }
                SqlCommand cmd = new SqlCommand("select * from BacSi where ChucDanh = '"+chucDanh+"'", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
