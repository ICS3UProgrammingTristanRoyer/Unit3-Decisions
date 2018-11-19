/*
 * Created by: Tristan Royer
 * Created on: 06 - 11 - 18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #29 - Running Average
 * This program calculates the average of the numbers entered by the user.
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

namespace RunningAverageTristanR
{
	public partial class RunningAverageForm : Form
	{
		// declare variables
		int userMark = 0;
		int totalOfMarks = 0;
		int numberOfMarks = 0;
		int average = 0;
		int counter;
		public RunningAverageForm()
		{


			InitializeComponent();




		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{

			// Tracks the number of values the user has entered and the toal sum of  them.
			for (counter = 0; counter <= 100; counter++)
			{
				numberOfMarks = numberOfMarks + 1;
				userMark = int.Parse(txtUserAnswer.Text);
				totalOfMarks = totalOfMarks + userMark;
				average = totalOfMarks / numberOfMarks;
				// displays the running average
				lblAnswer.Text = "The running value is:" + Convert.ToString(average);
				// refreshes the program
				this.Refresh();

			}
		
		
				
				// if the user enters -1,  display a Goodbye message and disable the buttons.
				if (userMark == -1)
			{
				// calls a message box to display the program ended.
				MessageBox.Show("Running average ended.", "Running Average");
				this.btnCalculate.Enabled = false;
				this.txtUserAnswer.Visible = false;
			}

			
		}
	}
}

		
		

	




