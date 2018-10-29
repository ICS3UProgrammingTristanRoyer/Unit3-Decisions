namespace PerfectSquaresTristanR
{
	partial class frmPerfectSquares
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnStart = new System.Windows.Forms.Button();
			this.nudValue = new System.Windows.Forms.NumericUpDown();
			this.PerfectSquares = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(99, 12);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// nudValue
			// 
			this.nudValue.Location = new System.Drawing.Point(77, 56);
			this.nudValue.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
			this.nudValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudValue.Name = "nudValue";
			this.nudValue.Size = new System.Drawing.Size(120, 20);
			this.nudValue.TabIndex = 1;
			this.nudValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// PerfectSquares
			// 
			this.PerfectSquares.FormattingEnabled = true;
			this.PerfectSquares.Location = new System.Drawing.Point(68, 96);
			this.PerfectSquares.Name = "PerfectSquares";
			this.PerfectSquares.Size = new System.Drawing.Size(141, 121);
			this.PerfectSquares.TabIndex = 2;
			this.PerfectSquares.SelectedIndexChanged += new System.EventHandler(this.PerfectSquares_SelectedIndexChanged);
			// 
			// frmPerfectSquares
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.PerfectSquares);
			this.Controls.Add(this.nudValue);
			this.Controls.Add(this.btnStart);
			this.Name = "frmPerfectSquares";
			this.Text = "PerfectSquares";
			((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.NumericUpDown nudValue;
		private System.Windows.Forms.ListBox PerfectSquares;
	}
}

