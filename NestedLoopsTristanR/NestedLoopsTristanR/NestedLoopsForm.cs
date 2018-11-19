/*
 * Created by: Tristan Royer
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #28 - Numbers Nested Loops
 * This program uses nested loops to display all the letters of the alphabet in small and large case.
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

namespace NestedLoopsTristanR
{
	public partial class NestedLoopsForm : Form
	{
		public NestedLoopsForm()
		{
			InitializeComponent();
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			//declare local variables
			int smallCounter;
			int capitalCounter;
			string firstLetter;
			string secondLetter;
			const int MAX_COUNTER = 90;
			const int MAX_COUNTERv2 = 122;

			//clear the list box
			this.Alphabet.Items.Clear();

			// For loop that executes until  the nested if statement has executed fully.
			for (capitalCounter = 65; capitalCounter <= MAX_COUNTER; capitalCounter += 1)
			{
				firstLetter = Char.ConvertFromUtf32(capitalCounter);

				for (smallCounter = 97; smallCounter <= MAX_COUNTERv2; smallCounter++)
				{ //convert the value of the counter to unicode
					secondLetter = Char.ConvertFromUtf32(smallCounter);
					this.Alphabet.Items.Add(firstLetter + "->" + secondLetter);
				}

			}
		}
	}
}

