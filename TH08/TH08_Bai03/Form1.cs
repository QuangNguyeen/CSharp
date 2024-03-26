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

namespace TH08_Bai03
{
    
    public partial class Form1 : Form
    {
        string connectionString = "Data Source = DESKTOP-V4CU01B\\SQLEXPRESS; Database = TH08; Integrated Security = True";
        public Form1()
        {
            InitializeComponent();
        }
        class Hang
        {
            public string Ten { get; set; }
            public int Gia { get; set; }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Hang> listHang = new List<Hang> {
                new Hang(){Ten = "Chocopie", Gia = 55000},
                new Hang(){Ten = "Egg", Gia = 5000},
                new Hang(){Ten = "Milk", Gia = 8000},
                new Hang(){Ten = "Vegetable", Gia = 7000},
                new Hang(){Ten = "Coffee", Gia = 15000},
                new Hang(){Ten = "Orange", Gia = 20000},
                new Hang(){Ten = "Apple", Gia = 23000},
            };
            comboBoxHang.DataSource = listHang;
            comboBoxHang.DisplayMember = "Ten";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("select ROW_NUMBER() over (order by tenHang) as STT, tenHang, soLuong, donGia, thanhTien from DonHang", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void buttonTaoDonHang_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("delete from DonHang", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmd = new SqlCommand("select ROW_NUMBER() over (order by tenHang) as STT, tenHang, soLuong, donGia, thanhTien from DonHang", connection);
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
            textBoxTenKhach.Clear();
            textBoxTongTien.Clear();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
           
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                if(numericUpDown1.Value > 0)
                {
                    string query = "insert into DonHang values\r\n('" + textBoxTenKhach.Text + "', '" + comboBoxHang.Text + "', " + numericUpDown1.Text + ", " + textBoxDonGia.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmd = new SqlCommand("select ROW_NUMBER() over (order by tenHang) as STT, tenHang, soLuong, donGia, thanhTien from DonHang", connection);
                    adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    connection.Close();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void comboBoxHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if(comboBox.SelectedValue != null)
            {
                Hang hang = (Hang) comboBox.SelectedValue;
                textBoxDonGia.Text = hang.Gia.ToString();
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "delete from DonHang where tenHang = '"+comboBoxHang.Text+"'";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmd = new SqlCommand("select ROW_NUMBER() over (order by tenHang) as STT, tenHang, soLuong, donGia, thanhTien from DonHang", connection);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxHang.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            numericUpDown1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxDonGia.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            int totalMoney = 0;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                totalMoney += Convert.ToInt32(row.Cells[4].Value);
            }
            textBoxTongTien.Text = totalMoney.ToString();
        }
    }
}
