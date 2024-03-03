using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise05
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private bool rBtnTimesNewRoman_Checked = false;
        private bool rBtnArial_Checked = false;
        private bool rBtnTahoma_Checked = false;
        private bool rBtnCourierNew_Checked = false;
        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rBtn_TimesNewRoman_CheckedChanged(object sender, EventArgs e)
        {
            textWord.Font = new Font("Times New Roman", 12, FontStyle.Regular);
        }

        private void rBtn_Arial_CheckedChanged(object sender, EventArgs e)
        {
            textWord.Font = new Font("Arial", 12, FontStyle.Regular);
        }

        private void rBtn_Tahoma_CheckedChanged(object sender, EventArgs e)
        {
            textWord.Font = new Font("Tahoma", 12, FontStyle.Regular);
        }

        private void rBtn_CourierNew_CheckedChanged(object sender, EventArgs e)
        {
            textWord.Font = new Font("Courier New", 12, FontStyle.Regular);
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
    }
}
