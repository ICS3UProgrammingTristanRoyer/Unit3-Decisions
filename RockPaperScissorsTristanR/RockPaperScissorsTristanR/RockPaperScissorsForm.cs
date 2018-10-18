using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorsTristanR
{
	public partial class RockPaperScissorsForm : Form
	{
		const int MIN_VALUE = 1;
		const int MAX_VALUE = 3;
		Random randomNumberGenerator;
	
		public RockPaperScissorsForm()
		{
			this.lblWinner.Hide();



			InitializeComponent();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{


		}

		private void groupBox1_Enter_1(object sender, EventArgs e)
		{

		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void radRock_CheckedChanged(object sender, EventArgs e)
		{
			int uAnswer = 1;

			

		
			

		}

		private void button1_Click(object sender, EventArgs e)
		{
			

			int cAnswer, uAnswer;
			const int ROCK = 1;
			const int PAPER = 2;
			const int SCISSORS = 3;
			//get the random number
			Random randomNumberGenerator = new Random();
			int cAnswer = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
			this.lblWinner.Show();
			if (radPlayerRock.Checked == true)
			{
				uAnswer = 1;
				if ( cAnswer == 1)
				{
					lblWinner.Text = "Draw!";
				}
				else if (cAnswer == 2)
				{
					lblWinner.Text = "Computer wins!";
				}
				else if (cAnswer == 3)
				{
					lblWinner.Text = "User Wins!";
				}
			}
			else if (radPlayerPaper.Checked == true)
			{ uAnswer = 2;
				if (cAnswer == 1)
				{
					lblWinner.Text = "User Wins wins!";
				}
				else if (cAnswer == 2)
				{
					lblWinner.Text = "Draw!";
				}
				else if (cAnswer == 3)
				{ lblWinner.Text = "Computer wins!";
				}
			}
			else if (radPlayerScissors.Checked == true)
			{ uAnswer = 3;
				if (cAnswer == 1)
				{
					lblWinner.Text = "Computer wins!";
			    }
				else if (cAnswer == 2)
				{
					lblWinner.Text = "User wins!";
				}
				else if (cAnswer == 3)
				{
					lblWinner.Text = "Draw!";
				}
				

			}
			else
			{ uAnswer = 0;
			}
			if (cAnswer == ROCK)
			{ this.radComputerRock.Checked = true;

			}
			else if (cAnswer == PAPER)
			{ this.radComputerPaper.Checked = true;
			}
			else 
			{
				this.radComputerScissors.Checked = true;
			}



		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
	}
}
