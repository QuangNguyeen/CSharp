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
namespace TH08_De06
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source = DESKTOP-V4CU01B\\SQLEXPRESS; Database = Lab01; Integrated Security = True";
        public Form1()
        {
            InitializeComponent();
        }
        Button selected = null;
        private void button37_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(selected != null && selected.BackColor != Color.Red)
            {
                selected.BackColor = Color.White;
            }
            if(button.BackColor != Color.Orange)
            {
                button.BackColor = Color.Orange;
                selected = button;
            }
        }

        private void numericUpDown1_Leave(object sender, EventArgs e)
        {
            int tuoi = int.Parse(numericUpDown1.Value.ToString());
            if(tuoi > 0 && tuoi < 18)
            {
                textBoxGiaVe.Text = (50000 * 8 / 10).ToString();
            }else if ( tuoi >= 50)
            {
                textBoxGiaVe.Text = (50000 / 2).ToString();
            }
        }

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            foreach (Control control in panel1.Controls)
            {
                Button button = control as Button;
                if(button.BackColor == Color.Orange)
                {
                    button.BackColor = Color.Red;
                    button.Enabled = false;
                    SqlCommand cmd = new SqlCommand("insert into VeXe values\r\n("+button.Text+", '"+textBoxTen.Text+"', "+numericUpDown1.Text+", "+textBoxGiaVe.Text+")\r\n", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmd = new SqlCommand("Select * from VeXe", connection);
                    adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            
            connection.Close();

        }
    }
}
