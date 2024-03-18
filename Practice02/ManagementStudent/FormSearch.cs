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
    public partial class FormSearch : Form
    {
        string connectionString = "Data Source = DESKTOP-V4CU01B\\SQLEXPRESS; Database = StudentManagement; Integrated Security = True";
        public FormSearch()
        {
            InitializeComponent();
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                SqlCommand command = new SqlCommand("Select * from Student", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            textBoxID.Enabled = false;
            textBoxID.BackColor = Color.Gray;
            comboBoxCountry.BackColor = Color.Gray;
            comboBoxCountry.Enabled = false;
        }

        private void checkBoxID_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxID.Checked)
            {
                textBoxID.Enabled = false;
                textBoxID.BackColor = Color.Gray;
            }
            else
            {
                textBoxID.Enabled = true;
                textBoxID.BackColor = Color.White;
            }
        }

        private void checkBoxCity_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxCity.Checked)
            {
                comboBoxCountry.BackColor = Color.Gray;
                comboBoxCountry.Enabled = false;
            }
            else
            {
                comboBoxCountry.BackColor = Color.White;
                comboBoxCountry.Enabled = true;
            }
        }

        private void checkBoxSex_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxSex.Checked)
            {
                radioButtonMale.Enabled = false;
                radioButtonFemale.Enabled = false;
            }
        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "Select * from Student where Country = '" + comboBoxCountry.Text + "'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "Select * from Student where Sex = '" + 1 + "'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxID_Leave(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
               
                connection.Open();
                string query = "Select * from Student where Id = '" + textBoxID.Text + "'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "Select * from Student where Sex = '" + 0 + "'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
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
