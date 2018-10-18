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
			this.radPlayerScissors = new System.Windows.Forms.RadioButton();
			this.radPlayerPaper = new System.Windows.Forms.RadioButton();
			this.radPlayerRock = new System.Windows.Forms.RadioButton();
			this.grbCAnswer = new System.Windows.Forms.GroupBox();
			this.radComputerScissors = new System.Windows.Forms.RadioButton();
			this.radComputerPaper = new System.Windows.Forms.RadioButton();
			this.radComputerRock = new System.Windows.Forms.RadioButton();
			this.btnPlay = new System.Windows.Forms.Button();
			this.lblWinner = new System.Windows.Forms.Label();
			this.grbUAnswer.SuspendLayout();
			this.grbCAnswer.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbUAnswer
			// 
			this.grbUAnswer.Controls.Add(this.radPlayerScissors);
			this.grbUAnswer.Controls.Add(this.radPlayerPaper);
			this.grbUAnswer.Controls.Add(this.radPlayerRock);
			this.grbUAnswer.Location = new System.Drawing.Point(12, 12);
			this.grbUAnswer.Name = "grbUAnswer";
			this.grbUAnswer.Size = new System.Drawing.Size(200, 100);
			this.grbUAnswer.TabIndex = 0;
			this.grbUAnswer.TabStop = false;
			this.grbUAnswer.Text = "User Answer";
			this.grbUAnswer.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// radPlayerScissors
			// 
			this.radPlayerScissors.AutoSize = true;
			this.radPlayerScissors.Location = new System.Drawing.Point(3, 65);
			this.radPlayerScissors.Name = "radPlayerScissors";
			this.radPlayerScissors.Size = new System.Drawing.Size(64, 17);
			this.radPlayerScissors.TabIndex = 3;
			this.radPlayerScissors.TabStop = true;
			this.radPlayerScissors.Text = "Scissors";
			this.radPlayerScissors.UseVisualStyleBackColor = true;
			// 
			// radPlayerPaper
			// 
			this.radPlayerPaper.AutoSize = true;
			this.radPlayerPaper.Location = new System.Drawing.Point(3, 42);
			this.radPlayerPaper.Name = "radPlayerPaper";
			this.radPlayerPaper.Size = new System.Drawing.Size(53, 17);
			this.radPlayerPaper.TabIndex = 2;
			this.radPlayerPaper.TabStop = true;
			this.radPlayerPaper.Text = "Paper";
			this.radPlayerPaper.UseVisualStyleBackColor = true;
			// 
			// radPlayerRock
			// 
			this.radPlayerRock.AutoSize = true;
			this.radPlayerRock.Location = new System.Drawing.Point(3, 19);
			this.radPlayerRock.Name = "radPlayerRock";
			this.radPlayerRock.Size = new System.Drawing.Size(51, 17);
			this.radPlayerRock.TabIndex = 1;
			this.radPlayerRock.TabStop = true;
			this.radPlayerRock.Text = "Rock";
			this.radPlayerRock.UseVisualStyleBackColor = true;
			this.radPlayerRock.CheckedChanged += new System.EventHandler(this.radRock_CheckedChanged);
			// 
			// grbCAnswer
			// 
			this.grbCAnswer.AutoSize = true;
			this.grbCAnswer.Controls.Add(this.radComputerScissors);
			this.grbCAnswer.Controls.Add(this.radComputerPaper);
			this.grbCAnswer.Controls.Add(this.radComputerRock);
			this.grbCAnswer.Location = new System.Drawing.Point(12, 118);
			this.grbCAnswer.Name = "grbCAnswer";
			this.grbCAnswer.Size = new System.Drawing.Size(200, 100);
			this.grbCAnswer.TabIndex = 0;
			this.grbCAnswer.TabStop = false;
			this.grbCAnswer.Text = "Computer Answer";
			this.grbCAnswer.Enter += new System.EventHandler(this.groupBox1_Enter_1);
			// 
			// radComputerScissors
			// 
			this.radComputerScissors.AutoSize = true;
			this.radComputerScissors.Location = new System.Drawing.Point(0, 62);
			this.radComputerScissors.Name = "radComputerScissors";
			this.radComputerScissors.Size = new System.Drawing.Size(64, 17);
			this.radComputerScissors.TabIndex = 2;
			this.radComputerScissors.TabStop = true;
			this.radComputerScissors.Text = "Scissors";
			this.radComputerScissors.UseVisualStyleBackColor = true;
			// 
			// radComputerPaper
			// 
			this.radComputerPaper.AutoSize = true;
			this.radComputerPaper.Location = new System.Drawing.Point(0, 39);
			this.radComputerPaper.Name = "radComputerPaper";
			this.radComputerPaper.Size = new System.Drawing.Size(53, 17);
			this.radComputerPaper.TabIndex = 1;
			this.radComputerPaper.TabStop = true;
			this.radComputerPaper.Text = "Paper";
			this.radComputerPaper.UseVisualStyleBackColor = true;
			this.radComputerPaper.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radComputerRock
			// 
			this.radComputerRock.AutoSize = true;
			this.radComputerRock.Location = new System.Drawing.Point(0, 16);
			this.radComputerRock.Name = "radComputerRock";
			this.radComputerRock.Size = new System.Drawing.Size(51, 17);
			this.radComputerRock.TabIndex = 0;
			this.radComputerRock.TabStop = true;
			this.radComputerRock.Text = "Rock";
			this.radComputerRock.UseVisualStyleBackColor = true;
			// 
			// btnPlay
			// 
			this.btnPlay.Location = new System.Drawing.Point(197, 226);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(75, 23);
			this.btnPlay.TabIndex = 1;
			this.btnPlay.Text = "Play";
			this.btnPlay.UseVisualStyleBackColor = true;
			this.btnPlay.Click += new System.EventHandler(this.button1_Click);
			// 
			// lblWinner
			// 
			this.lblWinner.AutoSize = true;
			this.lblWinner.Location = new System.Drawing.Point(12, 231);
			this.lblWinner.Name = "lblWinner";
			this.lblWinner.Size = new System.Drawing.Size(13, 13);
			this.lblWinner.TabIndex = 2;
			this.lblWinner.Text = "--";
			this.lblWinner.Click += new System.EventHandler(this.label1_Click);
			// 
			// RockPaperScissorsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.lblWinner);
			this.Controls.Add(this.btnPlay);
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
		private System.Windows.Forms.RadioButton radPlayerScissors;
		private System.Windows.Forms.RadioButton radPlayerPaper;
		private System.Windows.Forms.RadioButton radPlayerRock;
		private System.Windows.Forms.RadioButton radComputerScissors;
		private System.Windows.Forms.RadioButton radComputerPaper;
		private System.Windows.Forms.RadioButton radComputerRock;
		private System.Windows.Forms.Button btnPlay;
		private System.Windows.Forms.Label lblWinner;
	}
}

