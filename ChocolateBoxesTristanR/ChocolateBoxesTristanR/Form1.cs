/*
 * Created by: First Last
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #19 - Chocolate Boxes
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

namespace ChocolateBoxesTristanR
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
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
			numberOfBoxes = (Double)(nudAnswer.Value);
			if (numberOfBoxes > 20)
			{
				lblDisplay.Text = "You have earned a prize";
				lblDisplay.Show();
			}

			if (numberOfBoxes < 20)
			{
				if (numberOfBoxes < 10)
				{
					lblDisplay.Text = "Honourable mention";
					lblDisplay.Show();

				}
				else if (numberOfBoxes > 10)
				{
					lblDisplay.Text = "You have earned a small prize";
					lblDisplay.Show();

				}
			}
			





		}
	}
}
