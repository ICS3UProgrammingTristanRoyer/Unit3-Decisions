namespace WalkingManTristanR
{
	partial class frmWalkingMan
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
			this.picWalker = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picWalker)).BeginInit();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(96, 43);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "START";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// picWalker
			// 
			this.picWalker.Image = global::WalkingManTristanR.Properties.Resources.walk10;
			this.picWalker.Location = new System.Drawing.Point(45, 72);
			this.picWalker.Name = "picWalker";
			this.picWalker.Size = new System.Drawing.Size(186, 177);
			this.picWalker.TabIndex = 1;
			this.picWalker.TabStop = false;
			this.picWalker.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// frmWalkingMan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.picWalker);
			this.Controls.Add(this.btnStart);
			this.Name = "frmWalkingMan";
			this.Text = "WalkingMan";
			((System.ComponentModel.ISupportInitialize)(this.picWalker)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.PictureBox picWalker;
	}
}

