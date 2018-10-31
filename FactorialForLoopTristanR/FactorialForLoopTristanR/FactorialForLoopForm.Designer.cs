namespace FactorialForLoopTristanR
{
	partial class FactorialForLoopForm
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
			this.txtUserAnswer = new System.Windows.Forms.TextBox();
			this.lstFactorial = new System.Windows.Forms.ListBox();
			this.lblAnswer = new System.Windows.Forms.Label();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtUserAnswer
			// 
			this.txtUserAnswer.Location = new System.Drawing.Point(92, 27);
			this.txtUserAnswer.Name = "txtUserAnswer";
			this.txtUserAnswer.Size = new System.Drawing.Size(100, 20);
			this.txtUserAnswer.TabIndex = 0;
			this.txtUserAnswer.TextChanged += new System.EventHandler(this.txtUserAnswer_TextChanged);
			// 
			// lstFactorial
			// 
			this.lstFactorial.FormattingEnabled = true;
			this.lstFactorial.Location = new System.Drawing.Point(81, 104);
			this.lstFactorial.Name = "lstFactorial";
			this.lstFactorial.Size = new System.Drawing.Size(120, 95);
			this.lstFactorial.TabIndex = 1;
			// 
			// lblAnswer
			// 
			this.lblAnswer.AutoSize = true;
			this.lblAnswer.Location = new System.Drawing.Point(131, 224);
			this.lblAnswer.Name = "lblAnswer";
			this.lblAnswer.Size = new System.Drawing.Size(13, 13);
			this.lblAnswer.TabIndex = 2;
			this.lblAnswer.Text = "--";
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(106, 66);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(75, 23);
			this.btnCalculate.TabIndex = 3;
			this.btnCalculate.Text = "Calculate";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// FactorialForLoopForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.lblAnswer);
			this.Controls.Add(this.lstFactorial);
			this.Controls.Add(this.txtUserAnswer);
			this.Name = "FactorialForLoopForm";
			this.Text = "FactorialForLoop";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtUserAnswer;
		private System.Windows.Forms.ListBox lstFactorial;
		private System.Windows.Forms.Label lblAnswer;
		private System.Windows.Forms.Button btnCalculate;
	}
}

