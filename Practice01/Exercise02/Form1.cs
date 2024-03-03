using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise02
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Do you want to close?", "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1
                );
            if ( r == DialogResult.No )
            {
                e.Cancel = true;    
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            btn_Solution.Enabled = false;
            btn_Erase.Enabled = false;
        }
        private void btn_Solution_Click(object sender, EventArgs e)
        {
            string first = textFirstNumber.Text;
            string second = textSecondNumber.Text;
            try
            {
                float a = float.Parse(first);  
                float b = float.Parse(second);
                if(a == 0)
                {
                    if(b == 0)
                    {
                        textSolution.Text = "Vo so nghiem.";
                    }
                    else
                    {
                        textSolution.Text = "Vo nghiem";
                    }
                }
                else
                {
                    textSolution.Text = $"x = {-b / a}";
                    textSolution.ReadOnly = true ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void textFirstNumber_TextChanged(object sender, EventArgs e)
        {
            string number1 = textFirstNumber.Text;
            string number2 = textSecondNumber.Text;
            if (float.TryParse(number1, out float numberFirst) && float.TryParse(number2, out float numberSecond))
            {
                btn_Solution.Enabled = true;
                btn_Erase.Enabled = true;
            }
            else
            {
                btn_Solution.Enabled = false;
                btn_Erase.Enabled = false;
            }
        }

        private void textSecondNumber_TextChanged(object sender, EventArgs e)
        {
            string number1 = textFirstNumber.Text;
            string number2 = textSecondNumber.Text;
            if (float.TryParse(number1, out float numberFirst) && float.TryParse(number2, out float numberSecond))
            {
                btn_Solution.Enabled = true;
                btn_Erase.Enabled = true;
            }
            else
            {
                btn_Solution.Enabled = false;
                btn_Erase.Enabled = false;
            }
        }

        private void btn_Erase_Click(object sender, EventArgs e)
        {
            textFirstNumber.Clear();
            textSecondNumber.Clear(); 
            textSolution.Clear();
            textFirstNumber.Focus();
        }
    }
}
