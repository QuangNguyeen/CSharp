using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelRed.Text = "R = " + trackBar1.Value.ToString();
            UpdateColor();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            labelGreen.Text = "G = " + trackBar2.Value.ToString();
            UpdateColor();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            labelBlue.Text = "B = " + trackBar3.Value.ToString();
            UpdateColor();
        }
        private void UpdateColor()
        {
            int red = (int)(trackBar1.Value);
            int green = (int)(trackBar2.Value);
            int blue = (int)(trackBar3.Value);
            panel1.BackColor = Color.FromArgb(red, green, blue);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
