using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtMSSV.Text == "" || txtName.Text == "") 
            {
                MessageBox.Show("Vui long nhap thong tin.");
            }
            else
            {
                string mssv = txtMSSV.Text;
                string name = txtName.Text;
                string lop = cb_Class.Text;
                int year = Convert.ToInt32(cb_Nienkhoa.SelectedItem);
                int hocKy;
                if (radioButton1.Checked)
                {
                    hocKy = 1;
                }else if(radioButton2.Checked)
                {
                    hocKy = 2;
                }else if (radioButton3.Checked)
                {
                    hocKy = 3;
                }
                else
                {
                    hocKy = 4;
                }
                StringBuilder listMonhoc = new StringBuilder();
                int i = 1;
                foreach(string s in checkedListBox1.CheckedItems)
                {
                    listMonhoc.Append($" {i}. {s} \n");
                    i++;
                }
                string result = $"Sinh vien: {name} \nLop: {lop} \nNien khoa: {year} \nDa dang ky hoc : Hoc ky {hocKy} Cac mon sau: \n{listMonhoc}";
                MessageBox.Show(result);
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtMSSV.Clear();
            txtName.Clear();
            cb_Class.SelectedIndex = -1;
            cb_Nienkhoa.SelectedIndex = -1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;   
            radioButton4.Checked = false;
           for(int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
