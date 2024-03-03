using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise03
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void textFirstNumber_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (ctrl.Text.Trim().Length > 0)
            {
                string first = ctrl.Text.Trim();
                if (!float.TryParse(first, out float value))
                {
                    this.errorProvider1.SetError(textFirstNumber, "Please enter number");
                }
                else
                {
                    this.errorProvider1.Clear();
                }
            }
        }

        private void textSecondNumber_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (ctrl.Text.Trim().Length > 0)
            {
                string first = ctrl.Text.Trim();
                if (!float.TryParse(first, out float value))
                {
                    this.errorProvider2.SetError(textFirstNumber, "Please enter number");
                }
                else
                {
                    this.errorProvider2.Clear();
                }
            }
        }

        private void radioAdd_CheckedChanged(object sender, EventArgs e)
        {
            string first = textFirstNumber.Text.Trim();
            string second = textSecondNumber.Text.Trim();
            try
            {
                float firstNumber = float.Parse(first);
                float secondNumber = float.Parse(second);
                textResult.Text = $"{firstNumber + secondNumber}";
                textResult.ReadOnly = true ;
            }catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void radioSub_CheckedChanged(object sender, EventArgs e)
        {
            string first = textFirstNumber.Text.Trim();
            string second = textSecondNumber.Text.Trim();
            try
            {
                float firstNumber = float.Parse(first);
                float secondNumber = float.Parse(second);
                textResult.Text = $"{firstNumber - secondNumber}";
                textResult.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void radioMul_CheckedChanged(object sender, EventArgs e)
        {
            string first = textFirstNumber.Text.Trim();
            string second = textSecondNumber.Text.Trim();
            try
            {
                float firstNumber = float.Parse(first);
                float secondNumber = float.Parse(second);
                textResult.Text = $"{firstNumber * secondNumber}";
                textResult.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void radioDiv_CheckedChanged(object sender, EventArgs e)
        {
            string first = textFirstNumber.Text.Trim();
            string second = textSecondNumber.Text.Trim();
            try
            {
                float firstNumber = float.Parse(first);
                float secondNumber = float.Parse(second);
                float result = firstNumber / secondNumber;
                textResult.Text = $"{result}";
                textResult.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Do you want to close?", "Exit", 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if(r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
