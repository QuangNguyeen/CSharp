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

namespace NetManagementSystem
{

    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
           
        }
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        

        private void buttonComputer1_Click(object sender, EventArgs e)
        {
            if(buttonComputer1.BackColor == Color.Transparent)
            {
                try 
                {
                    int timeIN = int.Parse(textIN1.Text);
                    int timeOUT = int.Parse(textOUT1.Text);
                    int money = 0;
                    if (timeIN < timeOUT)
                    {
                        money = (timeOUT - timeIN) * 5000;
                        labelMoney1.Text = money.ToString();
                        buttonComputer1.BackColor = Color.IndianRed;
                    }
                    else
                    {
                        MessageBox.Show("Time invalid.");
                    }
                }
                catch(Exception) 
                {
                    MessageBox.Show("Please enter integer number");
                }
                

            }
            else
            {
                MessageBox.Show("Please choose other computer");
            }
        }

        private void buttonComputer2_Click(object sender, EventArgs e)
        {
            if (buttonComputer2.BackColor == Color.Transparent)
            {
                try
                {
                    int timeIN = int.Parse(textIN2.Text);
                    int timeOUT = int.Parse(textOUT2.Text);
                    int money = 0;
                    if (timeIN < timeOUT)
                    {
                        money = (timeOUT - timeIN) * 5000;
                        labelMoney2.Text = money.ToString();
                        buttonComputer2.BackColor = Color.IndianRed;
                    }
                    else
                    {
                        MessageBox.Show("Time invalid.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter integer number");
                }


            }
            else
            {
                MessageBox.Show("Please choose other computer");
            }
        }

        private void buttonComputer3_Click(object sender, EventArgs e)
        {
            if (buttonComputer3.BackColor == Color.Transparent)
            {
                try
                {
                    int timeIN = int.Parse(textIN3.Text);
                    int timeOUT = int.Parse(textOUT3.Text);
                    int money = 0;
                    if (timeIN < timeOUT)
                    {
                        money = (timeOUT - timeIN) * 5000;
                        labelMoney3.Text = money.ToString();
                        buttonComputer3.BackColor = Color.IndianRed;
                    }
                    else
                    {
                        MessageBox.Show("Time invalid.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter integer number");
                }


            }
            else
            {
                MessageBox.Show("Please choose other computer");
            }
        }

        private void buttonComputer4_Click(object sender, EventArgs e)
        {
            if (buttonComputer4.BackColor == Color.Transparent)
            {
                try
                {
                    int timeIN = int.Parse(textIN4.Text);
                    int timeOUT = int.Parse(textOUT4.Text);
                    int money = 0;
                    if (timeIN < timeOUT)
                    {
                        money = (timeOUT - timeIN) * 5000;
                        labelMoney4.Text = money.ToString();
                        buttonComputer4.BackColor = Color.IndianRed;
                    }
                    else
                    {
                        MessageBox.Show("Time invalid.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter integer number");
                }


            }
            else
            {
                MessageBox.Show("Please choose other computer");
            }
        }

        private void buttonComputer5_Click(object sender, EventArgs e)
        {
            if (buttonComputer5.BackColor == Color.Transparent)
            {
                try
                {
                    int timeIN = int.Parse(textIN5.Text);
                    int timeOUT = int.Parse(textOUT5.Text);
                    int money = 0;
                    if (timeIN < timeOUT)
                    {
                        money = (timeOUT - timeIN) * 5000;
                        labelMoney5.Text = money.ToString();
                        buttonComputer5.BackColor = Color.IndianRed;
                    }
                    else
                    {
                        MessageBox.Show("Time invalid.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter integer number");
                }


            }
            else
            {
                MessageBox.Show("Please choose other computer");
            }
        }

        private void buttonPay1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            if(buttonComputer1.BackColor == Color.IndianRed)
            {
                try 
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("insert into ManagementComputer values('"+buttonComputer1.Text+"', "+textIN1.Text+", "+textOUT1.Text+", '5000/h', "+labelMoney1.Text+")", connection);
                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("Successfully.");
                        buttonComputer1.BackColor = Color.Transparent;
                        textIN1.Clear();
                        textOUT1.Clear();
                        labelMoney1.Text = "0";
                    }
                    connection.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void buttonPay2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            if (buttonComputer2.BackColor == Color.IndianRed)
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("insert into ManagementComputer values('" + buttonComputer2.Text + "', " + textIN2.Text + ", " + textOUT2.Text + ", '5000/h', " + labelMoney2.Text + ")", connection);
                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("Successfully.");

                        buttonComputer2.BackColor = Color.Transparent;
                        textIN2.Clear();
                        textOUT2.Clear();
                        labelMoney2.Text = "0";
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void buttonPay3_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            if (buttonComputer3.BackColor == Color.IndianRed)
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("insert into ManagementComputer values('" + buttonComputer3.Text + "', " + textIN3.Text + ", " + textOUT3.Text + ", '5000/h', " + labelMoney3.Text + ")", connection);
                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("Successfully.");
                        buttonComputer3.BackColor = Color.Transparent;
                        textIN3.Clear();
                        textOUT3.Clear();
                        labelMoney3.Text = "0";
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void buttonPay4_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            if (buttonComputer4.BackColor == Color.IndianRed)
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("insert into ManagementComputer values('" + buttonComputer4.Text + "', " + textIN4.Text + ", " + textOUT4.Text + ", '5000/h', " + labelMoney4.Text + ")", connection);
                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("Successfully.");
                        buttonComputer4.BackColor = Color.Transparent;
                        textIN4.Clear();
                        textOUT4.Clear();
                        labelMoney4.Text = "0";
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonPay5_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            if (buttonComputer5.BackColor == Color.IndianRed)
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("insert into ManagementComputer values('" + buttonComputer5.Text + "', " + textIN5.Text + ", " + textOUT5.Text + ", '5000/h', " + labelMoney5.Text + ")", connection);
                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("Successfully.");
                        buttonComputer5.BackColor = Color.Transparent;
                        textIN5.Clear();
                        textOUT5.Clear();
                        labelMoney5.Text = "0";
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            if (tabControl1.SelectedIndex == 1)
            {
                
                try
                {
                    SqlCommand cmd = new SqlCommand("select ROW_NUMBER() over (order by Name) as STT, * from ManagementComputer", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            
        }
    }
}
