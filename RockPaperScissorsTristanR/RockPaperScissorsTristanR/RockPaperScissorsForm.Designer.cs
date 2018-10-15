namespace RockPaperScissorsTristanR
{
	partial class RockPaperScissorsForm
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
			this.grbUAnswer = new System.Windows.Forms.GroupBox();
			this.grbCAnswer = new System.Windows.Forms.GroupBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radRock = new System.Windows.Forms.RadioButton();
			this.radPaper = new System.Windows.Forms.RadioButton();
			this.radScissors = new System.Windows.Forms.RadioButton();
			this.grbUAnswer.SuspendLayout();
			this.grbCAnswer.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbUAnswer
			// 
			this.grbUAnswer.Controls.Add(this.radScissors);
			this.grbUAnswer.Controls.Add(this.radPaper);
			this.grbUAnswer.Controls.Add(this.radRock);
			this.grbUAnswer.Location = new System.Drawing.Point(12, 12);
			this.grbUAnswer.Name = "grbUAnswer";
			this.grbUAnswer.Size = new System.Drawing.Size(200, 100);
			this.grbUAnswer.TabIndex = 0;
			this.grbUAnswer.TabStop = false;
			this.grbUAnswer.Text = "User Answer";
			this.grbUAnswer.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// grbCAnswer
			// 
			this.grbCAnswer.AutoSize = true;
			this.grbCAnswer.Controls.Add(this.radioButton3);
			this.grbCAnswer.Controls.Add(this.radioButton2);
			this.grbCAnswer.Controls.Add(this.radioButton1);
			this.grbCAnswer.Location = new System.Drawing.Point(12, 118);
			this.grbCAnswer.Name = "grbCAnswer";
			this.grbCAnswer.Size = new System.Drawing.Size(200, 100);
			this.grbCAnswer.TabIndex = 0;
			this.grbCAnswer.TabStop = false;
			this.grbCAnswer.Text = "Computer Answer";
			this.grbCAnswer.Enter += new System.EventHandler(this.groupBox1_Enter_1);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(0, 16);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(51, 17);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Rock";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(0, 39);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(53, 17);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Paper";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(0, 62);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(64, 17);
			this.radioButton3.TabIndex = 2;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Scissors";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// radRock
			// 
			this.radRock.AutoSize = true;
			this.radRock.Location = new System.Drawing.Point(3, 19);
			this.radRock.Name = "radRock";
			this.radRock.Size = new System.Drawing.Size(51, 17);
			this.radRock.TabIndex = 1;
			this.radRock.TabStop = true;
			this.radRock.Text = "Rock";
			this.radRock.UseVisualStyleBackColor = true;
			// 
			// radPaper
			// 
			this.radPaper.AutoSize = true;
			this.radPaper.Location = new System.Drawing.Point(3, 42);
			this.radPaper.Name = "radPaper";
			this.radPaper.Size = new System.Drawing.Size(53, 17);
			this.radPaper.TabIndex = 2;
			this.radPaper.TabStop = true;
			this.radPaper.Text = "Paper";
			this.radPaper.UseVisualStyleBackColor = true;
			// 
			// radScissors
			// 
			this.radScissors.AutoSize = true;
			this.radScissors.Location = new System.Drawing.Point(3, 65);
			this.radScissors.Name = "radScissors";
			this.radScissors.Size = new System.Drawing.Size(64, 17);
			this.radScissors.TabIndex = 3;
			this.radScissors.TabStop = true;
			this.radScissors.Text = "Scissors";
			this.radScissors.UseVisualStyleBackColor = true;
			// 
			// RockPaperScissorsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.grbCAnswer);
			this.Controls.Add(this.grbUAnswer);
			this.Name = "RockPaperScissorsForm";
			this.Text = "RockPaperScissors";
			this.grbUAnswer.ResumeLayout(false);
			this.grbUAnswer.PerformLayout();
			this.grbCAnswer.ResumeLayout(false);
			this.grbCAnswer.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox grbUAnswer;
		private System.Windows.Forms.GroupBox grbCAnswer;
		private System.Windows.Forms.RadioButton radScissors;
		private System.Windows.Forms.RadioButton radPaper;
		private System.Windows.Forms.RadioButton radRock;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
	}
}

