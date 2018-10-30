/*
 * Created by: Tristan Royer
 * Created on: 19 - 10 - 18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #18 - Rock, Paper, Scissors
 * This program allows the user to play Rock , Paper , Scissors with the cpu that generates random answers
*/
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

		public RockPaperScissorsForm()
		{

			Random randomNumberGenerator;



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







		}

		private void button1_Click(object sender, EventArgs e)
		{
			// declare local variables

			int uAnswer;
			const int ROCK = 1;
			const int PAPER = 2;
			const int SCISSORS = 3;
			//get the random number
			Random randomNumberGenerator = new Random();
			int cAnswer = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);

			// check what option the user chose and assign that to their answer.
			if (radPlayerRock.Checked == true)
			{
				uAnswer = ROCK;

			}
			else if (radPlayerPaper.Checked == true)
			{
				uAnswer = PAPER;
			}
			else if (radPlayerScissors.Checked == true)
			{
				uAnswer = SCISSORS;
			}
			else
			{
				uAnswer = 0;
			}
			if (cAnswer == ROCK)
			{
				this.radComputerRock.Checked = true;
			}
			else if (cAnswer == PAPER)
			{
				this.radComputerPaper.Checked = true;
			}
			else if (cAnswer == SCISSORS)
			{
				this.radComputerScissors.Checked = true;
			}

			if (uAnswer == 1)
			{
				if (cAnswer == 1)
				{
					lblWinner.Text = "Draw!";
				}
				else if (cAnswer == 2)
				{
					lblWinner.Text = "Computer Wins!";
				}
				else if (cAnswer == 3)
				{
					lblWinner.Text = "User wins!";
				}
			}
			if (uAnswer == 2)
			{
				if (cAnswer == 1)
				{
					lblWinner.Text = "User Wins!";
				}
				else if (cAnswer == 2)
				{
					lblWinner.Text = "Draw!";
				}
				else if (cAnswer == 3)
				{
					lblWinner.Text = "Computer Wins!";
				}
			}
			if (uAnswer == 3)
			{
				if (cAnswer == 1)
				{
					lblWinner.Text = "Computer Wins!";
				}
				else if (cAnswer == 2)
				{
					lblWinner.Text = "User Wins!";
				}
				else if (cAnswer == 3)
				{
					lblWinner.Text = "Draw!";
				}
			}
		}
	}
}



