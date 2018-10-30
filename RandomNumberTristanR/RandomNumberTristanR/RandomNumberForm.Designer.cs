namespace RandomNumberTristanR
{
	partial class frmRandomNumber
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
			this.btnGenerate = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblAnswer = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(291, 173);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(168, 23);
			this.btnGenerate.TabIndex = 0;
			this.btnGenerate.Text = "Generate Random Number";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(254, 113);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(261, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Click to generate a random number between 1 and 10";
			// 
			// lblAnswer
			// 
			this.lblAnswer.AutoSize = true;
			this.lblAnswer.Location = new System.Drawing.Point(332, 232);
			this.lblAnswer.Name = "lblAnswer";
			this.lblAnswer.Size = new System.Drawing.Size(13, 13);
			this.lblAnswer.TabIndex = 2;
			this.lblAnswer.Text = "--";
			// 
			// frmRandomNumber
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblAnswer);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnGenerate);
			this.Name = "frmRandomNumber";
			this.Text = "RandomNumber";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblAnswer;
	}
}

