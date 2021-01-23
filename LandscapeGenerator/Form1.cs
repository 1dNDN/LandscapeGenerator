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
    }
}