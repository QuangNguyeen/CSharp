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

namespace TH08_De08
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
            SqlCommand cmd = new SqlCommand("select loai from MatHang group by loai", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            comboBoxTheLoai.DataSource = dt;
            comboBoxTheLoai.DisplayMember = "loai";
        }

        private void comboBoxTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelLoai.Text = comboBoxTheLoai.Text.ToString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select ROW_NUMBER() over (order by tenHang ) as STT, tenHang as 'Ten Hang', donGia as 'Don Gia' from MatHang where loai = '" + comboBoxTheLoai.Text+"'", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void buttonTaoDon_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("delete DonHang", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);


            cmd = new SqlCommand("select ROW_NUMBER() over (order by tenHang) as STT, tenHang as 'Ten Hang', soLuong as 'So Luong', donGia as 'Don Gia', thanhTien as 'Thanh Tien' from DonHang\r\nwhere tenKH = '"+textBoxTenKH.Text+"'", connection);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            if(numericUpDown1.Value > 0)
            {
                string TenHang = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string DonGIa = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                SqlCommand cmd = new SqlCommand("insert into DonHang values\r\n('" + textBoxTenKH.Text + "', '" + TenHang + "', " + numericUpDown1.Text + ", " + DonGIa + ")", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmd = new SqlCommand("select ROW_NUMBER() over (order by tenHang) as STT, tenHang as 'Ten Hang', soLuong as 'So Luong', donGia as 'Don Gia', thanhTien as 'Thanh Tien' from DonHang\r\nwhere tenKH = '" + textBoxTenKH.Text + "'", connection);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);

                dataGridView2.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Vui chon so luong > 0");
            }
            connection.Close();
            
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string TenHang = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            
            SqlCommand cmd = new SqlCommand("delete from DonHang where tenHang = '"+TenHang+"'", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cmd = new SqlCommand("select ROW_NUMBER() over (order by tenHang) as STT, tenHang as 'Ten Hang', soLuong as 'So Luong', donGia as 'Don Gia', thanhTien as 'Thanh Tien' from DonHang\r\nwhere tenKH = '" + textBoxTenKH.Text + "'", connection);
            adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);

            dataGridView2.DataSource = dt;
        }

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            int TongTien = 0;
            foreach(DataGridViewRow row in dataGridView2.Rows)
            {
                TongTien += (int)row.Cells[4].Value;
            }
            textBoxThanhTien.Text = TongTien.ToString();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void doiMauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.SourceControl.BackColor = Color.Green;
        }
    }
}
