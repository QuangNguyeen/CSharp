using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void AddNumber() 
        {
            if (textBox1.Text != "")
            {
                string str = textBox1.Text;
                try
                {
                    int number = int.Parse(str);
                    bool checkExist = false;
                    foreach (int i in listBox1.Items)
                    {
                        if (i == number)
                        {
                            checkExist = true;
                            MessageBox.Show($"{number} is exist");
                        }
                    }
                    if (checkExist == false)
                    {
                        listBox1.Items.Add(number);
                        textBox1.Clear();
                        textBox1.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
            }
        }
        private void btn_Enter_Click(object sender, EventArgs e)
        {
            AddNumber();
        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                AddNumber();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach(int i in listBox1.Items)
            {
                sum += i;
            }
            MessageBox.Show($"Sum of number in List: {sum}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach(int i in listBox1.Items) 
            {
                list.Add(i.ToString()); 
            }
            if(list.Count > 0)
            {
                list.RemoveAt(0);
                if(list.Count > 1)
                {
                    list.RemoveAt(list.Count - 1);
                }
                else
                {
                    list.RemoveAt(0);
                }
                MessageBox.Show("List number: \n" + string.Join(", ", list) );
            }
            else
            {
                MessageBox.Show("List is empty");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            listBox1.Items.Remove(index + 1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                int value = Convert.ToInt32(listBox1.Items[i]);
                listBox1.Items[i] = (value + 2).ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<int> listNumber = new List<int>();
            foreach(var i in listBox1.Items)
            {
                int number = Convert.ToInt32(i);
                number = number * number; 
                listNumber.Add(number);
            }
            MessageBox.Show("List Number After Square: \n" + string.Join (", ", listNumber) );
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<int> listEvenNumber = new List<int>();
            try
            {
                foreach(var i in listBox1.Items)
                {
                    int number = Convert.ToInt32(i);
                    if(number %2 == 0)
                    {
                        listEvenNumber.Add(number);
                    }
                    
                }
                MessageBox.Show("List Even Number: \n" + string.Join(",", listEvenNumber));
            }catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<int> listOddNumber = new List<int>();
            try
            {
                foreach (var i in listBox1.Items)
                {
                    int number = Convert.ToInt32(i);
                    if (number % 2 != 0)
                    {
                        listOddNumber.Add(number);
                    }

                }
                MessageBox.Show("List Odd Number: \n" + string.Join(",", listOddNumber));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void button9_Click(object sender, EventArgs e)
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
            if ( r == DialogResult.No )
            {
                e.Cancel = true;
            }
        }
    }
}
