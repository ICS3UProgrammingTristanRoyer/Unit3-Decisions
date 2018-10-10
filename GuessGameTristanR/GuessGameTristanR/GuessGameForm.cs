using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessGameTristanR
{
	public partial class GuessGameForm : Form
	{
		public GuessGameForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// declare variables
			const int REAL_ANSWER = 19;
			int answer;

				//Get the number the user guessed.
			answer = int.Parse(txtAnswer.Text);

			// if the number input by the user matches the Correct answer display correct
			if (answer == REAL_ANSWER)
			{
				this.lblRealAnswer.Text = "You are correct!";
				this.picShape.Image = Properties.Resources.checkmark;

			}
			else

			{
				this.lblRealAnswer.Text = "You are incorrect...";
				this.picShape.Image = Properties.Resources.red_x;


			}



		}
	}
}
