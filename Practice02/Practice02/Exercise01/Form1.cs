using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise01
{
    public partial class Form1 : Form
    {
        List<Country> countryList;
        public Form1()
        {
            InitializeComponent();
            countryList = new List<Country>();
            countryList.Add(new Country()
            {
                CountryName = "Vietnam",
                ListCity = new List<string>() { "HaNoi", "DaNang", "HoChiMinh"}
            }) ;
            countryList.Add(new Country()
            {
                CountryName = "Japan",
                ListCity = new List<string>() { "Tokyo", "Osaka", "Hokkaido" }
            });
            comboBoxCountry.DataSource = countryList;
            comboBoxCountry.DisplayMember = "CountryName";
            comboBoxCountry.SelectedIndexChanged += comboBoxCountry_SelectedIndexChanged;
            AddBinding();
            
        }
        void AddBinding()
        {
          
            listBoxCity.DataBindings.Add("DataSource", comboBoxCountry.SelectedValue, "ListCity");
            
        }
        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxCity.DataSource = (comboBoxCountry.SelectedValue as Country)?.ListCity;
        }
        public class Country
        {
            public string CountryName { get; set; }
            public List<string> ListCity { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result;
            result = $"Name: {textName.Text} \nDay Of Birth: {maskTextDayOfBirth.Text} \n" +
                     $"Address: {textAddress.Text} \nCity: {listBoxCity.SelectedValue} \n" + 
                     $"Country: {comboBoxCountry.Text} \nQualification: {listBoxQualification.SelectedItem} \n" + 
                     $"Phone: {textEmail.Text} \nDate of Joinning: {dateTimePicker1.Text}";
            MessageBox.Show(result, "Information");
            textName.Clear();
            textAddress.Clear();
            textEmail.Clear();
            comboBoxCountry.SelectedIndex = -1;
            maskTextDayOfBirth.Clear();
            maskedTextBoxPhone.Clear();
            listBoxCity.SelectedItem = null;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Do you want close?", "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1
                );
            if ( r == DialogResult.No )
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
