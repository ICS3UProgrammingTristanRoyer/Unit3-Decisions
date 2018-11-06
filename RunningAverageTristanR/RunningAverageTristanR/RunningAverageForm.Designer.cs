namespace RunningAverageTristanR
{
	partial class RunningAverageForm
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
			this.btnCalculate = new System.Windows.Forms.Button();
			this.txtUserAnswer = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblAnswer = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(12, 108);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(85, 38);
			this.btnCalculate.TabIndex = 0;
			this.btnCalculate.Text = "Calculate Average";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// txtUserAnswer
			// 
			this.txtUserAnswer.Location = new System.Drawing.Point(160, 15);
			this.txtUserAnswer.Name = "txtUserAnswer";
			this.txtUserAnswer.Size = new System.Drawing.Size(100, 20);
			this.txtUserAnswer.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Enter a number from 1 - 100:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "(Enter -1 to exit)";
			// 
			// lblAnswer
			// 
			this.lblAnswer.AutoSize = true;
			this.lblAnswer.Location = new System.Drawing.Point(9, 194);
			this.lblAnswer.Name = "lblAnswer";
			this.lblAnswer.Size = new System.Drawing.Size(119, 13);
			this.lblAnswer.TabIndex = 4;
			this.lblAnswer.Text = "The running average is:";
			// 
			// RunningAverageForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.lblAnswer);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtUserAnswer);
			this.Controls.Add(this.btnCalculate);
			this.Name = "RunningAverageForm";
			this.Text = "RunningAverage";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.TextBox txtUserAnswer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblAnswer;
	}
}

