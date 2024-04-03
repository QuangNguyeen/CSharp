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
namespace TH08_De08_1
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source = DESKTOP-V4CU01B\\SQLEXPRESS; Database = QLCAFE; Integrated Security = True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("select SOBAN, DOUONG, SOLUONG, GIA, NGAY from DATHANG", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            cmd = new SqlCommand("select DOUONG from DATHANG group by DOUONG", connection);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            comboBoxDoUong.DataSource = dt;
            comboBoxDoUong.DisplayMember = "DOUONG";
            connection.Close();
        }

        private void buttonThongKe_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("select SOBAN, DOUONG, SOLUONG, GIA, NGAY from DATHANG where NGAY between '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "' and DOUONG = '" + comboBoxDoUong.Text + "'", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            int TongTien = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                TongTien += (int)row.Cells[3].Value * (int)row.Cells[2].Value;
            }
            textBoxThanhTien.Text = TongTien.ToString();
        }
    }
}
