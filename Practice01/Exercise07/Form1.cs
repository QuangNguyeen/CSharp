using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if(textNumber.Text != "")
            {
                string str = textNumber.Text;
                try
                {
                    bool checkExist = false;
                    int number = int.Parse(str);
                    foreach(int i in cB_Number.Items) {
                        if(i == number)
                        {
                            checkExist = true;
                            MessageBox.Show("Number is exist");
                        }
                    }
                    if(checkExist == false) {
                        cB_Number.Items.Add(number);
                        textNumber.Clear();
                        textNumber.Focus();
                    }
                   
                }catch(Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please enter number");
            }
        }

        private void btn_SumDivisors_Click(object sender, EventArgs e)
        {
            listBoxDivisors.Items.Clear();
            string str = cB_Number.SelectedItem.ToString();
            try
            {
                int sum = 0;
                int number = int.Parse(str);
                for(int i = 1; i <= number; i++)
                {
                    if(number % i == 0)
                    {
                        listBoxDivisors.Items.Add(i);
                        sum += i;
                    }
                }
                MessageBox.Show($"Sum of divisors: {sum}");
            }catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBoxDivisors.Items.Clear();
            string str = cB_Number.SelectedItem.ToString();
            try
            {
                int count = 0;
                int number = int.Parse(str);
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0 & i % 2 == 0)
                    {
                        listBoxDivisors.Items.Add(i);
                        count++;
                    }
                }
                MessageBox.Show($"The number of Even divisors: {count}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
        private bool checkPrimeNumber(int number)
        {
            int k = (int)Math.Sqrt(number);
            if (number <= 1) return false;
            for(int i = 2; i <= k;i++)
            {
                if(number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listBoxDivisors.Items.Clear();
            string str = cB_Number.SelectedItem.ToString();
            try
            {
                int count = 0;
                int number = int.Parse(str);
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0 & checkPrimeNumber(i) == true)
                    {
                        listBoxDivisors.Items.Add(i);
                        count++;
                    }
                }
                MessageBox.Show($"The number of Prime divisors: {count}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Dou you want to close?", "Exit",
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
