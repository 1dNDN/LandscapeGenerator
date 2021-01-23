using System;
using System.Windows.Forms;

namespace LandscapeGenerator
{
    public partial class Form1 : Form
    {
        public DirectBitmap ImageBitmap;
        public bool ImageWasChanged = true;
        private bool TickProceed = false;

        public Form1() {
            InitializeComponent();
            WidthCounter.Value = this.Width;
            HeightCounter.Value = this.Height;
            ImageBitmap = new DirectBitmap(DisplayBox.Width, DisplayBox.Height);
        }

        private void Form1_Resize(object sender, EventArgs e) {
            DisplayBox.Height = Height - 63;
            DisplayBox.Width = Width - 205;
            ImageBitmap = new DirectBitmap(DisplayBox.Width, DisplayBox.Height);
            ImageWasChanged = true;
        }

		private void SizeApplyButton_Click(object sender, EventArgs e)
		{
            this.Width = (int)WidthCounter.Value;
            this.Height = (int)HeightCounter.Value;
        }

		private void TimerTick_Tick(object sender, EventArgs e) {
            TickProceed = true;
            if(ImageWasChanged)
                if (!TickProceed) {
                    DisplayBox.Image = ImageBitmap.Bitmap;
                    ImageWasChanged = false;
                }
            TickProceed = false;
        }
	}
}