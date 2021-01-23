using System;
using System.Windows.Forms;

namespace LandscapeGenerator
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e) {
            button1.Height = Height - 63;
            button1.Width = Width - 205;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            this.Width = (int)numericUpDown1.Value;
            
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            this.Height = (int)numericUpDown2.Value;
        }
    }
}