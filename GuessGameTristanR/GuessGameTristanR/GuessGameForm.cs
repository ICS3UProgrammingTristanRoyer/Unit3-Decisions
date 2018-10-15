/*
     * Created by: Tristan Royer
     * Created on: 11/10/18
     * Created for: ICS3U Programming
     * Daily Assignment – Day #16 - GuessGame
     * This program creates a random number and asks the user to guess it
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

namespace GuessGameTristanR
{
	public partial class frmGuessGame : Form
	{
		public frmGuessGame()
		{
			InitializeComponent();
		}

		
		private void button1_Click(object sender, EventArgs e)
		{
			// declare variables
			const int MIN_NUMBER = 1;
			const int MAX_NUMBER = 20;
			int aRandomNumber;
			int answer;
			Random randomNumberGenerator = new Random();

			//get the random number
			aRandomNumber = randomNumberGenerator.Next(MIN_NUMBER, MAX_NUMBER + 1);
			
		

				//Get the number the user guessed.
			answer = int.Parse(txtAnswer.Text);

			// if the number input by the user matches the Correct answer display correct
			if (answer == aRandomNumber)
			{
				this.lblRealAnswer.Text = "You are correct!";
				this.picShape.Image = Properties.Resources.checkmark;

			}
			else

			{
				this.lblRealAnswer.Text = "You are incorrect... it was " + Convert.ToString(aRandomNumber);
				this.picShape.Image = Properties.Resources.red_x;


			}



		}

		private void GuessGameForm_Load(object sender, EventArgs e)
		{

		}
	}
}
