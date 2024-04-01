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

namespace TH08_De07
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source = DESKTOP-V4CU01B\\SQLEXPRESS; Database = Lab01; Integrated Security = True";
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonThemSach_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("insert into Sach values\r\n('"+textBoxMaSach.Text+"', '"+textBoxTenSach.Text+"')", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cmd = new SqlCommand("Select * from Sach", connection);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            comboBoxSach.DataSource = dt;
            comboBoxSach.DisplayMember = "tenSach";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("Select * from Sach", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            comboBoxSach.DataSource = dt;
            comboBoxSach.DisplayMember = "tenSach";
            dataGridView1.DataSource = dt;

            cmd = new SqlCommand("select ROW_NUMBER() over (order by tenSV) as STT, * from BillSach", connection);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;

            cmd = new SqlCommand("select ROW_NUMBER() over (order by tenSV) as STT, * from BillSach", connection);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView3.DataSource = dt;
        }

        private void dateTimePickerMuon_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePickerMuon.Value;
            DateTime newDate = selectedDate.AddDays(40);
            dateTimePickerTra.Value = newDate;
        }

        private void buttonMuon_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("insert into BillSach values\r\n('"+comboBoxSinhVien.Text+"', '"+comboBoxSach.Text+"', '"+dateTimePickerMuon.Text+"', '"+dateTimePickerTra.Text+"', 0)", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cmd = new SqlCommand("select ROW_NUMBER() over (order by tenSV) as STT, * from BillSach", connection);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxSinhVien.Text   = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxSach.Text       = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePickerMuon.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTimePickerTra.Text  = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();

            DateTime date1 = dateTimePickerMuon.Value;
            DateTime date2 = dateTimePickerTra.Value;
            TimeSpan khoangCach = date2 - date1;
            labelSoNgayMuon.Text = khoangCach.Days.ToString();
        }

        private void dateTimePickerTra_ValueChanged(object sender, EventArgs e)
        {
            DateTime date1 = dateTimePickerMuon.Value;
            DateTime date2 = dateTimePickerTra.Value;
            TimeSpan khoangCach = date2 - date1;
            labelSoNgayMuon.Text = khoangCach.Days.ToString();
            
        }

        private void buttonTra_Click(object sender, EventArgs e)
        {
            DateTime date1 = dateTimePickerMuon.Value;
            DateTime date2 = dateTimePickerTra.Value;
            TimeSpan khoangCach = date2 - date1;
            if (khoangCach.Days > 40)
            {
                int tien = (khoangCach.Days - 40) * 2000;
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("update BillSach\r\nset ngayTra = '" + dateTimePickerTra.Text + "', thanhTien = " + tien + "\r\nwhere tenSV = '" + comboBoxSinhVien.Text + "'", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmd = new SqlCommand("select ROW_NUMBER() over (order by tenSV) as STT, * from BillSach", connection);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;
                dataGridView3.DataSource = dt;
            }
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            if (tabControl1.SelectedIndex == 2)
            {
                SqlCommand cmd = new SqlCommand("select ROW_NUMBER() over (order by tenSV) as STT, * from BillSach", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView3.DataSource = dt;
            }
        }
    }
}
