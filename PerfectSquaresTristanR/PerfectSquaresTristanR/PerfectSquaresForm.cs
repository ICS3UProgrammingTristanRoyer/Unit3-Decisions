/*
 * Created by: Tristan Royer
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day # - Name of Program
 * This program...
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

namespace PerfectSquaresTristanR
{
	public partial class frmPerfectSquares : Form
	{
		public frmPerfectSquares()
		{
			InitializeComponent();
		}

		private void PerfectSquares_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			//declare local variables
			int endingValue = 6;
			int value;
			double squareRootAsDouble;
			int squareRootAsInteger;

			// set the initial values
			value = 1;


			//clear all the items from the list box
			this.PerfectSquares.Items.Clear();

			// get the user's end value selection from the number up-down box
			endingValue = Convert.ToInt32(nudValue.Value);


			// continue stating any perfect squares between the minimum value and the user's selected end value
			while (value <= endingValue)
			{
				// take the square root of the value
				squareRootAsDouble = Math.Sqrt(value);

				//  convert the double to an integer
				squareRootAsInteger = Convert.ToInt32(squareRootAsDouble);

				// the only way for both the decimal and the integer to be equal us if the value was a perfect square
				if (squareRootAsInteger == squareRootAsDouble)
				{
					this.PerfectSquares.Items.Add(value + " is a perfect square");
					//this.lstPerfectSquares.setSelected(numberOfPerfectSquares);

					this.Refresh();
				}
				value = value + 1;

			}

		}
	}
}

