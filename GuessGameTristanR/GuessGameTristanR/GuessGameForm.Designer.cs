namespace GuessGameTristanR
{
	partial class frmGuessGame
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
			this.txtAnswer = new System.Windows.Forms.TextBox();
			this.lblQuestion = new System.Windows.Forms.Label();
			this.btnCheck = new System.Windows.Forms.Button();
			this.lblRealAnswer = new System.Windows.Forms.Label();
			this.picShape = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picShape)).BeginInit();
			this.SuspendLayout();
			// 
			// txtAnswer
			// 
			this.txtAnswer.Location = new System.Drawing.Point(172, 21);
			this.txtAnswer.Name = "txtAnswer";
			this.txtAnswer.Size = new System.Drawing.Size(100, 20);
			this.txtAnswer.TabIndex = 0;
			// 
			// lblQuestion
			// 
			this.lblQuestion.AutoSize = true;
			this.lblQuestion.Location = new System.Drawing.Point(12, 24);
			this.lblQuestion.Name = "lblQuestion";
			this.lblQuestion.Size = new System.Drawing.Size(155, 13);
			this.lblQuestion.TabIndex = 1;
			this.lblQuestion.Text = "Guess a number between 1-20:";
			// 
			// btnCheck
			// 
			this.btnCheck.Location = new System.Drawing.Point(15, 86);
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.Size = new System.Drawing.Size(75, 23);
			this.btnCheck.TabIndex = 2;
			this.btnCheck.Text = "Check";
			this.btnCheck.UseVisualStyleBackColor = true;
			this.btnCheck.Click += new System.EventHandler(this.button1_Click);
			// 
			// lblRealAnswer
			// 
			this.lblRealAnswer.AutoSize = true;
			this.lblRealAnswer.Location = new System.Drawing.Point(121, 96);
			this.lblRealAnswer.Name = "lblRealAnswer";
			this.lblRealAnswer.Size = new System.Drawing.Size(13, 13);
			this.lblRealAnswer.TabIndex = 3;
			this.lblRealAnswer.Text = "--";
			// 
			// picShape
			// 
			this.picShape.Location = new System.Drawing.Point(104, 120);
			this.picShape.Name = "picShape";
			this.picShape.Size = new System.Drawing.Size(168, 129);
			this.picShape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picShape.TabIndex = 4;
			this.picShape.TabStop = false;
			// 
			// frmGuessGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.picShape);
			this.Controls.Add(this.lblRealAnswer);
			this.Controls.Add(this.btnCheck);
			this.Controls.Add(this.lblQuestion);
			this.Controls.Add(this.txtAnswer);
			this.Name = "frmGuessGame";
			this.Text = "GuessGame";
			this.Load += new System.EventHandler(this.GuessGameForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.picShape)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtAnswer;
		private System.Windows.Forms.Label lblQuestion;
		private System.Windows.Forms.Button btnCheck;
		private System.Windows.Forms.Label lblRealAnswer;
		private System.Windows.Forms.PictureBox picShape;
	}
}

