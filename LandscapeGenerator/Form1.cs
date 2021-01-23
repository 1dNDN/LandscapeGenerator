using System;
using System.Windows.Forms;

namespace LandscapeGenerator
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
            numericUpDown1.Value = this.Width;
            numericUpDown2.Value = this.Height;
        }

        private void Form1_Resize(object sender, EventArgs e) {
            button1.Height = Height - 63;
            button1.Width = Width - 205;
        }

		private void button2_Click(object sender, EventArgs e)
		{
            this.Width = (int)numericUpDown1.Value;
            this.Height = (int)numericUpDown2.Value;
        }
	}
}