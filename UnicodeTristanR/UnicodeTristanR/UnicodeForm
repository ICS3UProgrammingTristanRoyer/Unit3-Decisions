/*
 * Created by: Tristan Royer
 * Created on: 01-11-18
 * Created for: ICS3U Programming
 * Daily Assignment – Day 24 : Unicode
 * This program converts decimal characters to Unicode (Characters)
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

namespace UnicodeTristanR
{
	public partial class frmUnicode : Form
	{
		public frmUnicode()
		{
			InitializeComponent();
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			// declare local variables
			int counter;
			string aLetter;
			const int MAX_COUNTER = 90;

			

			// clear the list box
			this.Unicode.Items.Clear();

			// For loop that repeats the functions until the CAPITAL letters A-Z are displayes
			for (counter = 65; counter <= MAX_COUNTER; counter += 1)
			{
				// convert the value of the counter to unicode
				aLetter = Char.ConvertFromUtf32(counter);

				//adds the letter and current value of the counter to the list box
				this.Unicode.Items.Add(aLetter + "=" + counter);

				// Refreshes the form
				this.Refresh();


			}


				

		}

		private void frmUnicode_Load(object sender, EventArgs e)
		{

		}
	}
}
