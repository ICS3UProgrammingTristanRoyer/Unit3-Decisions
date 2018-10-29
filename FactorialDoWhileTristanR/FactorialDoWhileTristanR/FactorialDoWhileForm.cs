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

namespace FactorialDoWhileTristanR
{
	public partial class FactorialDoWhileForm : Form
	{
		public FactorialDoWhileForm()
		{
			InitializeComponent();
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			//declare variables and constants
			const int MAX_PROGRESS_BAR_VALUE = 100;
			int valueOfProgressBar = 0;

			//increment the value of the progress bar by 5 each time untill it has reached its max value
			do
			{
				this.prbProgressBar.Value = valueOfProgressBar;
				valueOfProgressBar = valueOfProgressBar + 5;
				lblPercentage.Text = (valueOfProgressBar - 5) + " % ";
				Thread.Sleep(200);
				this.Refresh();
				
			} while (valueOfProgressBar <= MAX_PROGRESS_BAR_VALUE );
		}
	}
}
