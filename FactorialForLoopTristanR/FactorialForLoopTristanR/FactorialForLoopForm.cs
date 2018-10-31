/*
 * Created by: Tristan Royer
 * Created on: 31 - 10 - 18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #23 - Factorial For Loop
 * This program calculates the sum of all the numbers leading up to the value input by the user.
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

namespace FactorialForLoopTristanR
{
	public partial class FactorialForLoopForm : Form
	{
		public FactorialForLoopForm()
		{
			InitializeComponent();
			lblAnswer.Hide();
		}

		private void txtUserAnswer_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			// declare the variables
			int counter;
			int sumNumber;
			int sumAnswer;

			// clear the list box
			this.lstFactorial.Items.Clear();

			// initialize the final sum to 1
			sumAnswer = 0;

			//get the value from the user
			sumNumber = int.Parse(this.txtUserAnswer.Text);

			// initizlize the counter , check to see if the counter is less than the user's number and also increments the counter.
			for (counter = 0; counter <= sumNumber; counter += 1 )
			{
				// updates the sum answer
				sumAnswer = sumAnswer + counter;
				
				// adds the counter's current value to the list
				this.lstFactorial.Items.Add(counter);
				
				// reveals the answer label
				lblAnswer.Show();

				// Refreshes the program
				this.Refresh();

			}
			// Updates the text to display the Sum answer.
			this.lblAnswer.Text = (Convert.ToString(sumAnswer) + "!");



		}
	}
}
