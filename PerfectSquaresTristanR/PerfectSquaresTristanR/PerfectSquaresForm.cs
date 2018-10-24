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
			Double squareRootAsDouble;
			int squareRootAsInteger;

			// set the initial values
			value = 1;

			//clear all the items from the list box
			this.PerfectSquares.Items.Clear();

			// get the user's end value selection from the number up-down box
			endingValue = Convert.ToInt32(this.nudValue.Value);

			// continue stating any perfect squares between the minimum value and the user's selected end value
		}
	}
}
