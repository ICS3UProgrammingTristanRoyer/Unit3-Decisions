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
			this.txtUserAnswer = new System.Windows.Forms.TextBox();
			this.Factorial = new System.Windows.Forms.ListBox();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.lblFactorialAnswer = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtUserAnswer
			// 
			this.txtUserAnswer.Location = new System.Drawing.Point(88, 37);
			this.txtUserAnswer.Name = "txtUserAnswer";
			this.txtUserAnswer.Size = new System.Drawing.Size(100, 20);
			this.txtUserAnswer.TabIndex = 0;
			// 
			// Factorial
			// 
			this.Factorial.FormattingEnabled = true;
			this.Factorial.Location = new System.Drawing.Point(88, 104);
			this.Factorial.Name = "Factorial";
			this.Factorial.Size = new System.Drawing.Size(120, 95);
			this.Factorial.TabIndex = 1;
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(101, 75);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(75, 23);
			this.btnCalculate.TabIndex = 2;
			this.btnCalculate.Text = "Calculate";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// lblFactorialAnswer
			// 
			this.lblFactorialAnswer.AutoSize = true;
			this.lblFactorialAnswer.Location = new System.Drawing.Point(125, 218);
			this.lblFactorialAnswer.Name = "lblFactorialAnswer";
			this.lblFactorialAnswer.Size = new System.Drawing.Size(13, 13);
			this.lblFactorialAnswer.TabIndex = 3;
			this.lblFactorialAnswer.Text = "--";
			// 
			// FactorialDoWhileForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.lblFactorialAnswer);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.Factorial);
			this.Controls.Add(this.txtUserAnswer);
			this.Name = "FactorialDoWhileForm";
			this.Text = "FactorialDoWhile";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtUserAnswer;
		private System.Windows.Forms.ListBox Factorial;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Label lblFactorialAnswer;
	}
}

