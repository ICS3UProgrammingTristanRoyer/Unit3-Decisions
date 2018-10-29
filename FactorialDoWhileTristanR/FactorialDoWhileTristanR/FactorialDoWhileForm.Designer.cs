namespace FactorialDoWhileTristanR
{
	partial class FactorialDoWhileForm
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
			this.prbProgressBar = new System.Windows.Forms.ProgressBar();
			this.btnStart = new System.Windows.Forms.Button();
			this.lblPercentage = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// prbProgressBar
			// 
			this.prbProgressBar.Location = new System.Drawing.Point(329, 176);
			this.prbProgressBar.Name = "prbProgressBar";
			this.prbProgressBar.Size = new System.Drawing.Size(100, 23);
			this.prbProgressBar.TabIndex = 0;
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(343, 113);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 1;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// lblPercentage
			// 
			this.lblPercentage.AutoSize = true;
			this.lblPercentage.Location = new System.Drawing.Point(356, 229);
			this.lblPercentage.Name = "lblPercentage";
			this.lblPercentage.Size = new System.Drawing.Size(21, 13);
			this.lblPercentage.TabIndex = 2;
			this.lblPercentage.Text = "0%";
			// 
			// FactorialDoWhileForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblPercentage);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.prbProgressBar);
			this.Name = "FactorialDoWhileForm";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ProgressBar prbProgressBar;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label lblPercentage;
	}
}

