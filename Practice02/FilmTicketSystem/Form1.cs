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

namespace FilmTicketSystem
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source = DESKTOP-V4CU01B\\SQLEXPRESS; Database = Film; Integrated Security = True";
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string nameFilm = comboBox1.Text;
            label2.Text = "Please choose seat in the cenima room:    " + nameFilm;
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                
                // Truy van nhung ghe da duoc dat mua trong CSDL
                string query = "Select * from Ticket where nameFilm = '" + nameFilm + "' and seatStatus = 1";
                SqlCommand commend = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(commend);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Kiem tra, neu ghe da duoc dat mua thi change Color
                foreach (Control control in tableLayoutPanel1.Controls)
                {
                    if (control is Button)
                    {
                        Button button = (Button)control;
                        Color origanalColor = button.BackColor;
                        button.BackColor = origanalColor;
                        string buttonId = button.Text;
                        foreach (DataRow row in dataTable.Rows)
                        {
                            if (buttonId == row["seatId"].ToString())
                            {
                                button.BackColor = Color.Gray;
                                button.Text = "///////";
                            }
                              
                        }
                      
                    }

                }
                
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
