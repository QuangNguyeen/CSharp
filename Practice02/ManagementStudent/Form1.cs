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

namespace ManagementStudent
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source = DESKTOP-V4CU01B\\SQLEXPRESS; Database = StudentManagement; Integrated Security = True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select * from Student",connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                connection.Close();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTimePicker.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString().Equals("False")){
                radioButtonFemale.Checked = true;
            }
            else
            {
                radioButtonMale.Checked = true;
            }
            comboBoxCountry.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string id = textBoxID.Text;
                int sex = 0;
                if(radioButtonMale.Checked == true)
                {
                    sex = 1;
                }
                string query = "update Student\r\nset Id = '" + textBoxID.Text + "', Name = '" + textBoxName.Text + "', DayOfBirth = CONVERT(datetime, '" + dateTimePicker.Text + "',101), Sex = " + sex + ", Country = '" + comboBoxCountry.Text + "'\r\nwhere Id = '" + id + "'";
                
                SqlCommand command = new SqlCommand(query, connection);
                int row = command.ExecuteNonQuery();
                if (row > 0)
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("select * from Student", connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Error in Update Information of Student");
                }
                connection.Close ();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection (connectionString);
            try
            {
                connection.Open();
                string id = textBoxID.Text;
                string query = "Delete from Student where Id = '"+id+"'";
                SqlCommand command = new SqlCommand (query, connection);
                int row = command.ExecuteNonQuery();
                if(row > 0)
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("Select * from Student", connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource= dataTable;
                }
                connection.Close();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection .Open();
                string query = "insert into Student values\r\n('" + textBoxID.Text + "', '" + textBoxName.Text + "', CONVERT(datetime, '" + dateTimePicker.Text + "',101), 1,'" + comboBoxCountry.Text + "')";
                SqlCommand command = new SqlCommand(query, connection);

                int row = command.ExecuteNonQuery();
                if(row > 0)
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("Select * from Student", connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource= dataTable;
                }
                else
                {
                    MessageBox.Show("Failed in insert data");
                }
                connection.Close();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxName.Clear();
            dateTimePicker.Value = new DateTime(2000, 1, 1);
            comboBoxCountry.SelectedIndex = -1;
            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FormSearch formSearch = new FormSearch();
            formSearch.Show();
        }
    }
}
