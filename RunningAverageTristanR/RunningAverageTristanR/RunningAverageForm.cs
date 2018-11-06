using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunningAverageTristanR
{
	public partial class RunningAverageForm : Form
	{
		int userMark = 0;
		int totalOfMarks = 0;
		int numberOfMarks = 0;
		int average = 0;
		public RunningAverageForm()
		{
			
			
			InitializeComponent();
			



		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
		
			userMark = int.Parse(txtUserAnswer.Text);
			
			for (numberOfMarks = 0; userMark <= 100;numberOfMarks ++)
			{
				totalOfMarks = totalOfMarks + userMark;
				average = totalOfMarks / numberOfMarks;
				lblAnswer.Text = "The running value is:" + Convert.ToString(average);
				this.Refresh();

			}
		
		}
	}
}
