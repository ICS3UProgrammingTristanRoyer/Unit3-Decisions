﻿namespace UnicodeTristanR
{
	partial class frmUnicode
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
			this.Unicode = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(100, 12);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// Unicode
			// 
			this.Unicode.FormattingEnabled = true;
			this.Unicode.Location = new System.Drawing.Point(78, 86);
			this.Unicode.Name = "Unicode";
			this.Unicode.Size = new System.Drawing.Size(120, 95);
			this.Unicode.TabIndex = 1;
			// 
			// frmUnicode
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.Unicode);
			this.Controls.Add(this.btnStart);
			this.DoubleBuffered = true;
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Name = "frmUnicode";
			this.Text = "Unicode from A-Z";
			this.Load += new System.EventHandler(this.frmUnicode_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.ListBox Unicode;
	}
}

