
namespace LandscapeGenerator
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.DisplayBox = new System.Windows.Forms.PictureBox();
			this.SizeApplyButton = new System.Windows.Forms.Button();
			this.WidthCounter = new System.Windows.Forms.NumericUpDown();
			this.HeightCounter = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.TimerTick = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.DisplayBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WidthCounter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HeightCounter)).BeginInit();
			this.SuspendLayout();
			// 
			// DisplayBox
			// 
			this.DisplayBox.Location = new System.Drawing.Point(177, 12);
			this.DisplayBox.Name = "DisplayBox";
			this.DisplayBox.Size = new System.Drawing.Size(595, 437);
			this.DisplayBox.TabIndex = 0;
			this.DisplayBox.TabStop = false;
			// 
			// SizeApplyButton
			// 
			this.SizeApplyButton.Location = new System.Drawing.Point(12, 12);
			this.SizeApplyButton.Name = "SizeApplyButton";
			this.SizeApplyButton.Size = new System.Drawing.Size(159, 46);
			this.SizeApplyButton.TabIndex = 1;
			this.SizeApplyButton.Text = "Изменить размер";
			this.SizeApplyButton.UseVisualStyleBackColor = true;
			this.SizeApplyButton.Click += new System.EventHandler(this.SizeApplyButton_Click);
			// 
			// WidthCounter
			// 
			this.WidthCounter.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.WidthCounter.Location = new System.Drawing.Point(70, 93);
			this.WidthCounter.Maximum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
			this.WidthCounter.Minimum = new decimal(new int[] {
            800,
            0,
            0,
            0});
			this.WidthCounter.Name = "WidthCounter";
			this.WidthCounter.Size = new System.Drawing.Size(45, 23);
			this.WidthCounter.TabIndex = 3;
			this.WidthCounter.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
			// 
			// HeightCounter
			// 
			this.HeightCounter.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.HeightCounter.Location = new System.Drawing.Point(70, 64);
			this.HeightCounter.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
			this.HeightCounter.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.HeightCounter.Name = "HeightCounter";
			this.HeightCounter.Size = new System.Drawing.Size(45, 23);
			this.HeightCounter.TabIndex = 3;
			this.HeightCounter.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 95);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 15);
			this.label1.TabIndex = 4;
			this.label1.Text = "Ширина";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "Высота";
			// 
			// TimerTick
			// 
			this.TimerTick.Enabled = true;
			this.TimerTick.Interval = 15;
			this.TimerTick.Tick += new System.EventHandler(this.TimerTick_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 461);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.HeightCounter);
			this.Controls.Add(this.WidthCounter);
			this.Controls.Add(this.SizeApplyButton);
			this.Controls.Add(this.DisplayBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MinimumSize = new System.Drawing.Size(800, 500);
			this.Name = "Form1";
			this.Text = "Демонстрационная форма";
			this.Resize += new System.EventHandler(this.Form1_Resize);
			((System.ComponentModel.ISupportInitialize)(this.DisplayBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WidthCounter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HeightCounter)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox DisplayBox;
        private System.Windows.Forms.Button SizeApplyButton;
        private System.Windows.Forms.NumericUpDown WidthCounter;
        private System.Windows.Forms.NumericUpDown HeightCounter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Timer TimerTick;
	}
}

