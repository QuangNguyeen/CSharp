using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise04
{
    public partial class frmFormater : Form
    {
        public frmFormater()
        {
            InitializeComponent();
        }

        private void rBtn_Red_CheckedChanged(object sender, EventArgs e)
        {
            lbresult.ForeColor = Color.Red;
        }

        private void cB_Bold_CheckedChanged(object sender, EventArgs e)
        {
            lbresult.Font = new Font(
                lbresult.Name,
                lbresult.Font.Size,
                lbresult.Font.Style ^ FontStyle.Bold
                );
        }

        private void lb_Result_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            lb_Result.Text = name;
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {
            lbresult.Text = textName.Text.Trim();
        }

        private void cB_Italic_CheckedChanged(object sender, EventArgs e)
        {
            lbresult.Font = new Font(
                lbresult.Name,
                lbresult.Font.Size,
                lbresult.Font.Style ^ FontStyle.Italic
                );
        }

        private void cB_Underline_CheckedChanged(object sender, EventArgs e)
        {
            lbresult.Font = new Font(
                lbresult.Name,
                lbresult.Font.Size,
                lbresult.Font.Style ^ FontStyle.Underline
                );
        }

        private void rBtn_Green_CheckedChanged(object sender, EventArgs e)
        {
            lbresult.ForeColor = Color.Green;
        }

        private void rBtn_Blue_CheckedChanged(object sender, EventArgs e)
        {
            lbresult.ForeColor= Color.Blue;
        }

        private void rBtn_Black_CheckedChanged(object sender, EventArgs e)
        {
            lbresult.ForeColor = Color.Black;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFormater_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Do you want to close?", "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1
                );
            if( r == DialogResult.No )
            {
                e.Cancel = true;
            }
        }
    }
}
