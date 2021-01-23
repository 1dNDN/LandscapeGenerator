using System;
using System.Windows.Forms;

namespace LandscapeGenerator
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
            WidthCounter.Value = this.Width;
            HeightCounter.Value = this.Height;
        }

        private void Form1_Resize(object sender, EventArgs e) {
            PictureBox.Height = Height - 63;
            PictureBox.Width = Width - 205;
        }

		private void SizeApplyButton_Click(object sender, EventArgs e)
		{
            this.Width = (int)WidthCounter.Value;
            this.Height = (int)HeightCounter.Value;
        }
	}
}