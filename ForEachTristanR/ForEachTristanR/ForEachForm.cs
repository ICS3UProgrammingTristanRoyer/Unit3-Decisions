/*
 * Created by: Tristan Royer
 * Created on: 02 - 11 - 18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #27 - Control Objects
 * This program cycles between random colours using new random and the colour function.
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
using System.Threading;

namespace ForEachTristanR
{
	public partial class ForEachForm : Form
	{
		// allows the random function to be used
		private Random random = new Random();
		public ForEachForm()
		{
			InitializeComponent();
		}

		private void btnColour_Click(object sender, EventArgs e)
		{
			// declare variables 
			int counter;

			// loop through each object on the form and make it a random colour(Soruce:https://stackoverflow.com/questions/29198073/get-random-color)
			for (counter = 0; counter <= 20; counter += 1)
			{
				foreach (Control aControlObject in this.Controls)
				{
					Color randomColor = Color.FromArgb(random.Next(0,256), random.Next(0,256), random.Next(0,256));

					aControlObject.BackColor = randomColor;
					if (aControlObject.GetType() == typeof(Label))
					{
						aControlObject.BackColor = randomColor;
					}
					this.Refresh();
					Thread.Sleep(500);
				}
			}
		}
	}
}
