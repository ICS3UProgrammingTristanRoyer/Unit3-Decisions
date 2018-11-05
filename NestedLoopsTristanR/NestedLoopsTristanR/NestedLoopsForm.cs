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

			//clear the list box
			this.Alphabet.Items.Clear();

			// For loop that executes until  the nested if statement has executed fully.
			for (capitalCounter = 65; capitalCounter <= MAX_COUNTER; capitalCounter += 1)
			{
				firstLetter = Char.ConvertFromUtf32(capitalCounter);

				for (smallCounter = 95; smallCounter <= MAX_COUNTER; smallCounter++)
				{ //convert the value of the counter to unicode
					secondLetter = Char.ConvertFromUtf32(smallCounter);
					this.Alphabet.Items.Add(firstLetter + "->" + secondLetter);
				}

			}
		}
	}
}

