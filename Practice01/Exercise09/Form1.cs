using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if(textName.Text != "")
            {
                if(comboBox1.Text == "Class A")
                {
                    listBoxClassA.Items.Add(textName.Text);
                    textName.Clear();
                    textName.Focus();
                    
                }else if(comboBox1.Text == "Class B")
                {
                    listBoxClassB.Items.Add(textName.Text);
                    textName.Clear();
                    textName.Focus();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listBoxClassA.SelectedItems.Count; i++)
            {
                listBoxClassB.Items.Add(listBoxClassA.SelectedItems[i]);
                listBoxClassA.Items.Remove(listBoxClassA.SelectedItems[i]);
                i--;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(listBoxClassA.Items.Count > 0)
            {
                for (int i = 0; i < listBoxClassA.Items.Count; i++)
                {
                    listBoxClassB.Items.Add(listBoxClassA.Items[i]);
                    listBoxClassA.Items.Remove(listBoxClassA.Items[i]);
                    i--;
                }
            }
            else
            {
                MessageBox.Show("Class A is empty");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxClassB.SelectedItems.Count; i++)
            {
                listBoxClassA.Items.Add(listBoxClassB.SelectedItems[i]);
                listBoxClassB.Items.Remove(listBoxClassB.SelectedItems[i]);
                i--;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBoxClassB.Items.Count > 0)
            {
                for (int i = 0; i < listBoxClassB.Items.Count; i++)
                {
                    listBoxClassA.Items.Add(listBoxClassB.Items[i]);
                    listBoxClassB.Items.Remove(listBoxClassB.Items[i]);
                    i--;
                }
            }
            else
            {
                MessageBox.Show("Class B is empty");
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listBoxClassA.SelectedItems.Count; i++)
            {
                listBoxClassA.Items.Remove(listBoxClassA.SelectedItems[i]);
                i--;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
