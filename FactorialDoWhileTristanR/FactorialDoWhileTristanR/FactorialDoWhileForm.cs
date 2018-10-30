/*
 * Created by: Tristan Royer
 * Created on: 30-10-18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #20 - Factorial Do While
 * This program displays the factorials of a given numbers
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

namespace FactorialDoWhileTristanR
{
	public partial class FactorialDoWhileForm : Form
	{
		public FactorialDoWhileForm()
		{
			InitializeComponent();
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			// declare local variables
			double factorialAnswer;
			double factorialNumber;
			int factorialCounter;

			// clear the items from the listbox
			this.Factorial.Items.Clear();

			//initialize the final answer by 1
			factorialAnswer = 1;

			// get the number (factorialNumber) from the user
			factorialNumber = Convert.ToDouble(this.txtUserAnswer.Text);

			//set the counter to 0
			factorialCounter = 0;

			//multiply the counter by the next incremented number until it reaches the user's number
			do
			{
				//increment the counter by 1
				factorialCounter += 1;

				// list the counter number in the listbox for the user to see
				this.Factorial.Items.Add(factorialCounter);
				// multiply the counter by the answer
				factorialAnswer = factorialAnswer * factorialCounter;

				this.Refresh();

			} while (factorialCounter < factorialNumber);
			this.lblFactorialAnswer.Text = this.txtUserAnswer.Text + "! = " + Convert.ToString(factorialAnswer);
		}
	}
}
