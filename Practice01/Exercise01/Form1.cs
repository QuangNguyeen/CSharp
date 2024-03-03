using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            int age = DateTime.Now.Year - Convert.ToInt32(textYear.Text);
            string s = "My name is: " + textYourName.Text + "\n" + "Age: " + age.
                ToString();
            MessageBox.Show(s);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textYear_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if(ctr.Text.Trim().Length > 0 && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
            {
                this.errorProvider1.SetError(textYear, "This is not valid number");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textYourName.Clear();
            textYear.Clear();
            textYourName.Focus();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Do you want to close?", "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1
                );
            if( r == DialogResult.No) 
            {
                e.Cancel = true;
            }
        }

        private void textYourName_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(textYourName, "You must enter your name.");
            }
            else
            {
                this.errorProvider1.Clear();
            }
        }
    }
}
