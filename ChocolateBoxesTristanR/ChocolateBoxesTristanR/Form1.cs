/*
 * Created by: Tristan Royer
 * Created on: 18-10-18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #19 - Chocolate Boxes
 * This program checks how many boxes the user sold and displays the prize they obtained
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

namespace ChocolateBoxesTristanR
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			// hides the label that displays the prize earned.
			lblDisplay.Hide(); 
		}

		private void txtAnswer_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnCheck_Click(object sender, EventArgs e)
		{
			//declare the variables
			double numberOfBoxes;
			// assign the value input by the user to the numberOfBoxes
			numberOfBoxes = (Double)(nudAnswer.Value);
			// displays " you have earned a prize" if the user input a value higher than 20.
			if (numberOfBoxes > 20)
			{
				lblDisplay.Text = "You have earned a prize";
				lblDisplay.Show();
			}

			if (numberOfBoxes < 20)
			{
				// displays "Honourable metion" if the user sold less than 10 boxes.
				if (numberOfBoxes < 10)
				{
					lblDisplay.Text = "Honourable mention";
					lblDisplay.Show();

				}
				// displays "you have earned a small prize" if the user sold less than 20 boxes but more than 10 boxes
				else if (numberOfBoxes > 10)
				{
					lblDisplay.Text = "You have earned a small prize";
					lblDisplay.Show();

				}
			}
			





		}
	}
}
