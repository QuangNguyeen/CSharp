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
namespace Bai01
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source = DESKTOP-V4CU01B\\SQLEXPRESS; Database = Lab01; Integrated Security = True";
        public Form1()
        {
            InitializeComponent();
        }
        class DoUong
        {
            public string Ten { get; set; }
            public int Gia { get; set; }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            List<DoUong> listDoUong = new List<DoUong>()
            {
                new DoUong(){Ten = "Sting", Gia = 10000},
                new DoUong(){Ten = "Coca", Gia = 10000},
                new DoUong(){Ten = "Coffee", Gia = 15000},
                new DoUong(){Ten = "Orange", Gia = 17000} 
            };
            comboBox1.DataSource = listDoUong;
            comboBox1.DisplayMember = "Ten";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("select Ban, TenDoUong, GhiChu, SoLuong, ThanhTien from Bill", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex !=  -1) {
                DoUong doUong = (DoUong)comboBox1.SelectedItem;
                textBoxGia.Text = doUong.Gia.ToString();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxBan.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxGhiChu.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            numericUpDown1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void comboBoxBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select Ban, TenDoUong, GhiChu, SoLuong, ThanhTien from Bill where Ban = '"+comboBoxBan.Text+"'", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                // Tinh Tong Tien
                int TongTien = 0;
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    TongTien += (int)row.Cells[4].Value;
                }
                textBoxThanhTien.Text = TongTien.ToString();
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                if(numericUpDown1.Value > 0)
                {
                    int gia = int.Parse(textBoxGia.Text);
                    int soLUong = int.Parse(numericUpDown1.Text);
                    int thanhTien = gia * soLUong;
                    SqlCommand cmd = new SqlCommand("insert into Bill values\r\n('" + comboBoxBan.Text + "', '" + comboBox1.Text + "','" + textBoxGhiChu.Text + "'," + numericUpDown1.Text + ", "+thanhTien+")", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmd = new SqlCommand("select Ban, TenDoUong, GhiChu, SoLuong, ThanhTien from Bill where Ban = '" + comboBoxBan.Text + "'", connection);
                    adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    // Tinh Tong Tien
                    int TongTien = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        TongTien += (int)row.Cells[4].Value;
                    }
                    textBoxThanhTien.Text = TongTien.ToString();
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Vui long cho so luong > 0");
                }
                
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
                SqlCommand cmd = new SqlCommand("delete from Bill where TenDoUong = '"+comboBox1.Text+"' and Ban = '"+comboBoxBan.Text+"'", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmd = new SqlCommand("select Ban, TenDoUong, GhiChu, SoLuong, ThanhTien from Bill where Ban = '" + comboBoxBan.Text + "'", connection);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                // Tinh Tong Tien
                int TongTien = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    TongTien += (int)row.Cells[4].Value;
                }
                textBoxThanhTien.Text = TongTien.ToString();
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
