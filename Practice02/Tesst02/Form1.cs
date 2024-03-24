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

namespace Tesst02
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source = DESKTOP-V4CU01B\\SQLEXPRESS; Database = QLTT; Integrated Security = True";
        public Form1()
        {
            InitializeComponent();
        }
        class Truyen
        {
            public string TenTruyen { get; set; }
            public int GiaMuon { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Truyen> listTruyen = new List<Truyen>()
            {
                new Truyen(){TenTruyen = "Dragon Ball", GiaMuon = 5000},
                new Truyen(){TenTruyen = "Demon Slayer", GiaMuon = 2000},
                new Truyen(){TenTruyen = "Conan ", GiaMuon = 2500},
                new Truyen(){TenTruyen = "Doraemon ", GiaMuon = 2300}

            };
            comboBox1.DataSource = listTruyen;
            comboBox1.DisplayMember = "TenTruyen";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("select ROW_NUMBER() over (order by tenKhach) as STT, tenKhach as 'Ten Khach', sdt as 'So Dien Thoai', tenTruyen as 'Ten Truyen', ngayMuon as 'Ngay Muon', ngayTra as 'Ngay Tra', thanhTien as 'Thanh Tien', ghiChu as 'Ghi Chu' from KhachHang", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if(comboBox.SelectedValue != null) {
                Truyen truyen = (Truyen)comboBox.SelectedValue;
                textBoxDonGia.Text = truyen.GiaMuon.ToString();
            }
        }

        private void textBoxSDT_Leave(object sender, EventArgs e)
        {
            string sdt = textBoxSDT.Text;
            for(int i = 0; i < sdt.Length; i++)
            {
                if (int.TryParse(sdt[i].ToString(), out int result) == false)
                {
                    MessageBox.Show("Vui long nhap dung so dien thoai");
                    textBoxSDT.Focus();
                    break;
                }
            }
        }

        private void buttonMuon_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "insert into KhachHang values\r\n('" + textBoxTen.Text + "', '" + textBoxSDT.Text + "','" + comboBox1.Text + "', '" + dateTimePicker1.Text + "', null , null , 'Chua Tra')";
                SqlCommand cmd = new SqlCommand(query, connection);
                

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    query = "select ROW_NUMBER() over (order by tenKhach) as STT, tenKhach as 'Ten Khach',sdt as 'So Dien Thoai', tenTruyen as 'Ten Truyen', ngayMuon as 'Ngay Muon', ngayTra as 'Ngay Tra', thanhTien as 'Thanh Tien', ghiChu as 'Ghi Chu' from KhachHang";
                    cmd = new SqlCommand(query, connection);
                    adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                

                connection.Close();
               
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxTen.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxSDT.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void buttonTra_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "update KhachHang set ngayTra = '"+dateTimePicker2.Text+"', thanhTien = ("+textBoxDonGia.Text+" * DATEDIFF(dayofyear,ngayMuon, ngayTra)), ghiChu = 'Da Tra'\r\nwhere tenKhach = '"+textBoxTen.Text+"'";
                SqlCommand cmd = new SqlCommand(query, connection);


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                query = "select ROW_NUMBER() over (order by tenKhach) as STT, tenKhach as 'Ten Khach',sdt as 'So Dien Thoai', tenTruyen as 'Ten Truyen', ngayMuon as 'Ngay Muon', ngayTra as 'Ngay Tra', thanhTien as 'Thanh Tien', ghiChu as 'Ghi Chu' from KhachHang";
                cmd = new SqlCommand(query, connection);
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
    }
}
