/*
 * Created by: Tristan Royer
 * Created on: 10-10-18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #17 - Random Number
 * This program generates a random number between 1 and 10.
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

namespace RandomNumberTristanR
{
	public partial class frmRandomNumber : Form
	{
		public frmRandomNumber()
		{
			InitializeComponent();
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			// declare the constants and variables
			const int MIN_NUM = 1;
			const int MAX_NUM = 10;
			int aRandomNumber;
			Random randomNumberGenerator = new Random();


			// get the random number
			aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);


			// assign the random number to a label
			lblAnswer.Text = "The Random Number is:" + Convert.ToString(aRandomNumber);
		}
	}
}

