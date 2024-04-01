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

namespace TH08_De05
{
    public partial class Form1 : Form
    {

        string connectionString = "Data Source = DESKTOP-V4CU01B\\SQLEXPRESS; Database = Lab01; Integrated Security = True";
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = buttonThem;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("select maHD as 'Ma HD', tenKH as 'Ten Khach Hang', ngayBan as 'Ngay Ban', loai as 'Loai May', tenMay as 'Ten May', donGia as 'Don Gia', soLuong as 'So Luong', thanhTien as 'Thanh Tien' from MayTinh", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void textBoxDonGia_Leave(object sender, EventArgs e)
        {
            try
            {
                int donGia = int.Parse(textBoxDonGia.Text);
                if(donGia <= 0)
                {
                    MessageBox.Show("Vui long nhap so nguyen duong.");
                    textBoxDonGia.Focus();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Vui long nhap so nguyen duong.");
                textBoxDonGia.Focus();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaHD.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxTenKH.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxTenMay.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxDonGia.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            numericUpDown1.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

            if(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() == "False")
            {
                radioButtonXachTay.Checked = true;
            }
        }

        private void buttonThem_Enter(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                if(numericUpDown1.Value > 0)
                {
                    connection.Open();
                    int loaiMayTinh = 0;
                    if (radioButtonDeban.Checked)
                    {
                        loaiMayTinh = 1;
                    }
                    SqlCommand cmd = new SqlCommand("insert into MayTinh values\r\n('" + textBoxMaHD.Text + "', '" + textBoxTenKH.Text + "', '" + dateTimePicker1.Text + "', " + loaiMayTinh + ", '" + textBoxTenMay.Text + "', " + textBoxDonGia.Text + ", " + numericUpDown1.Text + ")", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);


                    cmd = new SqlCommand("select maHD as 'Ma HD', tenKH as 'Ten Khach Hang', ngayBan as 'Ngay Ban', loai as 'Loai May', tenMay as 'Ten May', donGia as 'Don Gia', soLuong as 'So Luong', thanhTien as 'Thanh Tien' from MayTinh", connection);
                    adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Vui long chon so luong > 0");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                if(numericUpDown1.Value > 0)
                {
                    connection.Open();
                    int loaiMayTinh = 0;
                    if (radioButtonDeban.Checked)
                    {
                        loaiMayTinh = 1;
                    }
                    string oldID = dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
                    SqlCommand cmd = new SqlCommand("update MayTinh\r\nset maHD = '" + textBoxMaHD.Text + "', tenKH = '" + textBoxTenKH.Text + "', ngayBan = '" + dateTimePicker1.Text + "', loai = " + loaiMayTinh + ", tenMay = '" + textBoxTenMay.Text + "', donGia = " + textBoxDonGia.Text + ", soLuong = " + numericUpDown1.Text + "\r\nwhere maHD = '" + oldID + "'", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);


                    cmd = new SqlCommand("select maHD as 'Ma HD', tenKH as 'Ten Khach Hang', ngayBan as 'Ngay Ban', loai as 'Loai May', tenMay as 'Ten May', donGia as 'Don Gia', soLuong as 'So Luong', thanhTien as 'Thanh Tien' from MayTinh", connection);
                    adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Vui long chon so luong > 0");
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
                SqlCommand cmd = new SqlCommand("delete from MayTinh\r\nwhere maHD = '"+textBoxMaHD.Text+"'", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);


                cmd = new SqlCommand("select maHD as 'Ma HD', tenKH as 'Ten Khach Hang', ngayBan as 'Ngay Ban', loai as 'Loai May', tenMay as 'Ten May', donGia as 'Don Gia', soLuong as 'So Luong', thanhTien as 'Thanh Tien' from MayTinh", connection);
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

        private void buttonDong_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Ban muon dong chuong trinh?", "Dong", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(r == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
