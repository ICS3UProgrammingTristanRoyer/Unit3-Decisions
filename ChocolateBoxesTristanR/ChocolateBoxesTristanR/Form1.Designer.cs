namespace ChocolateBoxesTristanR
{
	partial class Form1
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
			this.lblQuestion = new System.Windows.Forms.Label();
			this.txtAnswer = new System.Windows.Forms.TextBox();
			this.lblDisplay = new System.Windows.Forms.Label();
			this.btnCheck = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblQuestion
			// 
			this.lblQuestion.AutoSize = true;
			this.lblQuestion.Location = new System.Drawing.Point(2, 32);
			this.lblQuestion.Name = "lblQuestion";
			this.lblQuestion.Size = new System.Drawing.Size(202, 13);
			this.lblQuestion.TabIndex = 0;
			this.lblQuestion.Text = "How many chocolate boxes did you sell?:";
			// 
			// txtAnswer
			// 
			this.txtAnswer.Location = new System.Drawing.Point(200, 29);
			this.txtAnswer.Name = "txtAnswer";
			this.txtAnswer.Size = new System.Drawing.Size(82, 20);
			this.txtAnswer.TabIndex = 1;
			this.txtAnswer.TextChanged += new System.EventHandler(this.txtAnswer_TextChanged);
			// 
			// lblDisplay
			// 
			this.lblDisplay.AutoSize = true;
			this.lblDisplay.Location = new System.Drawing.Point(120, 133);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(13, 13);
			this.lblDisplay.TabIndex = 2;
			this.lblDisplay.Text = "--";
			this.lblDisplay.Click += new System.EventHandler(this.label1_Click);
			// 
			// btnCheck
			// 
			this.btnCheck.Location = new System.Drawing.Point(98, 81);
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.Size = new System.Drawing.Size(75, 23);
			this.btnCheck.TabIndex = 3;
			this.btnCheck.Text = "Check";
			this.btnCheck.UseVisualStyleBackColor = true;
			this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btnCheck);
			this.Controls.Add(this.lblDisplay);
			this.Controls.Add(this.txtAnswer);
			this.Controls.Add(this.lblQuestion);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblQuestion;
		private System.Windows.Forms.TextBox txtAnswer;
		private System.Windows.Forms.Label lblDisplay;
		private System.Windows.Forms.Button btnCheck;
	}
}

