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

namespace QuangLyBanHang
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source = DESKTOP-V4CU01B\\SQLEXPRESS; Database = QLBH; Integrated Security = True";
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                SqlCommand commnand = new SqlCommand("delete from Bill", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(commnand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                commnand = new SqlCommand("select ROW_NUMBER() over (order by (id)) as 'STT', nameProduct as 'Ten San Pham', quantity as 'So Luong', totalMoney as 'Thanh Tien' from Bill", connection);
                adapter = new SqlDataAdapter(commnand);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "select price from HangHoa where name = '"+comboBoxProduct.Text+"'";
                SqlCommand commnand = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(commnand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                textBoxPrice.Text = dt.Rows[0][0].ToString();
                connection.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "select name from HangHoa";
                SqlCommand commnand = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(commnand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                comboBoxProduct.DataSource = dt;
                comboBoxProduct.DisplayMember = "name";
                
                commnand = new SqlCommand("select ROW_NUMBER() over (order by (id)) as 'STT', nameProduct as 'Ten San Pham', quantity as 'So Luong', price as 'Don Gia',totalMoney as 'Thanh Tien' from Bill", connection);
                adapter = new SqlDataAdapter(commnand);
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                if(numericUpDown1.Value > 0)
                {
                    SqlCommand commnand = new SqlCommand("insert into Bill values\r\n('" + comboBoxProduct.Text + "', " + textBoxPrice.Text + ", " + numericUpDown1.Text + ")", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(commnand);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    commnand = new SqlCommand("select ROW_NUMBER() over (order by (id)) as 'STT', nameProduct as 'Ten San Pham', quantity as 'So Luong', price as 'Don Gia',totalMoney as 'Thanh Tien' from Bill", connection);
                    adapter = new SqlDataAdapter(commnand);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Enter quantity > 0");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            
                SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                SqlCommand commnand = new SqlCommand("delete from Bill where nameProduct = '"+comboBoxProduct.Text+"'", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(commnand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                commnand = new SqlCommand("select ROW_NUMBER() over (order by (id)) as 'STT', nameProduct as 'Ten San Pham', quantity as 'So Luong', price as 'Don Gia',totalMoney as 'Thanh Tien' from Bill", connection);
                adapter = new SqlDataAdapter(commnand);
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
            comboBoxProduct.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            numericUpDown1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand commnand = new SqlCommand("select ROW_NUMBER() over (order by (id)) as 'STT', nameProduct as 'Ten San Pham', quantity as 'So Luong', price as 'Don Gia',totalMoney as 'Thanh Tien' from Bill", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(commnand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            int totalMoney = 0;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                int money = Convert.ToInt32(row.Cells["Thanh Tien"].Value);
                totalMoney += money;
            }
            textBoxMoney.Text = totalMoney.ToString();
        }

        private void doiMauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(contextMenuStrip1.SourceControl is Button)
            {
                Button btn = (Button)contextMenuStrip1.SourceControl;
                btn.BackColor = Color.Green;
            }
            if(contextMenuStrip1.SourceControl is TextBox)
            {
                TextBox texBox = (TextBox)contextMenuStrip1.SourceControl;
                texBox.BackColor = Color.Green;
            }
            if(contextMenuStrip1.SourceControl is ComboBox)
            {
                ComboBox comboBox = (ComboBox)contextMenuStrip1.SourceControl;
                comboBox.BackColor = Color.Green;
            }
        }
    }
}
