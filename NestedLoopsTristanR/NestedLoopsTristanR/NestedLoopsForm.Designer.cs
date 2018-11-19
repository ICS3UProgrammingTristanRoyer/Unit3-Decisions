namespace NestedLoopsTristanR
{
	partial class NestedLoopsForm
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
			this.Alphabet = new System.Windows.Forms.ListBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Alphabet
			// 
			this.Alphabet.FormattingEnabled = true;
			this.Alphabet.Location = new System.Drawing.Point(73, 104);
			this.Alphabet.Name = "Alphabet";
			this.Alphabet.Size = new System.Drawing.Size(120, 95);
			this.Alphabet.TabIndex = 0;
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(94, 64);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 1;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// NestedLoopsForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.Alphabet);
			this.Name = "NestedLoopsForm";
			this.Text = "NestedLoops";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox Alphabet;
		private System.Windows.Forms.Button btnStart;
	}
}

