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

namespace MangaManagementSystem
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source = DESKTOP-V4CU01B\\SQLEXPRESS; Database = Manga; Integrated Security = True";
        public Form1()
        {
            InitializeComponent();
        }
        public class Book
        {
            public string Name { get; set; }
            public int Fee {  get; set; }
        }
        
        private void textBoxPhone_Leave(object sender, EventArgs e)
        {
            string phoneNumber = textBoxPhone.Text;
            for(int i = 0; i < phoneNumber.Length; i++)
            {
                if (int.TryParse(phoneNumber[i].ToString(), out int result) == false)
                {
                    MessageBox.Show("Phone Number invalid.");
                    textBoxPhone.Focus();
                    break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Book> listBook = new List<Book>()
            {
                new Book() {Name = "Dragon Ball", Fee = 1000},
                new Book() {Name = "One Piece", Fee = 1500},
                new Book() {Name = "Demon Slayer", Fee = 2000},
                new Book() {Name = "Doraemon", Fee = 1800}
            };
            comboBoxManga.DataSource = listBook;
            comboBoxManga.DisplayMember = "Name";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("select ROW_NUMBER() over(order by name) as STT,   name as Name, phone as Phone, nameManga as Manga, checkIn as CheckIn, checkOut as CheckOut, money as Money, note as Note from Reader", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
            
        }

        private void comboBoxManga_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combox = (ComboBox)sender;
            if(combox.SelectedValue != null)
            {
                Book book = (Book) combox.SelectedValue;
                textBox1.Text = book.Fee.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "insert into Reader values\r\n('" + textBoxName.Text + "','" + textBoxPhone.Text + "','" + comboBoxManga.Text + "', convert(datetime, '" + dateTimePicker1.Text + "',101), convert(datetime, '" + dateTimePicker2.Text + "',101), null, 'Not returned yet')";
                SqlCommand cmd = new SqlCommand(query, connection);
                
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    cmd = new SqlCommand("select ROW_NUMBER() over(order by name) as STT,   name as Name, phone as Phone, nameManga as Manga, checkIn as CheckIn, checkOut as CheckOut, money as Money, note as Note from Reader", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
               
                connection.Close();

            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonGiveBack_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "update Reader\r\nset money = " + textBox1.Text + " * DATEDIFF(DAYOFYEAR, checkIn, checkOut), note = 'returned' \r\nwhere name = '" + textBoxName.Text + "' and nameManga = '" + comboBoxManga.Text + "'";
                SqlCommand command = new SqlCommand(query, connection);
                int row = command.ExecuteNonQuery();
                if (row > 0)
                {
                    command = new SqlCommand("select ROW_NUMBER() over(order by name) as STT,   name as Name, phone as Phone, nameManga as Manga, checkIn as CheckIn, checkOut as CheckOut, money as Money, note as Note from Reader", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                connection.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxManga.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}
