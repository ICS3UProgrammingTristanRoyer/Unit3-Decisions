/*
 * Created by: Tristan Royer
 * Created on: 23-10-18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #21 - Walking Man
 * This program displays an animated man walking.
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
// add  the following library to use the sleep timer
using System.Threading;

namespace WalkingManTristanR
{
	public partial class frmWalkingMan : Form
	{
		public frmWalkingMan()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			// declare local variables and constants
			const byte MAX_FRAMES = 10;
			int picFrameCounter = 1;

			//continue the loop while the frame counter has not reached the max number of frames we have to display
			while (picFrameCounter < MAX_FRAMES + 1)
			{
			
			if (picFrameCounter == 1)
				{
					this.picWalker.Image = Properties.Resources.walk1;
				}

				else if (picFrameCounter == 2)
				{
					this.picWalker.Image = Properties.Resources.walk2;
				}
				else if (picFrameCounter == 3)
				{
					this.picWalker.Image = Properties.Resources.walk3;
				}
				else if (picFrameCounter == 4)
				{
					this.picWalker.Image = Properties.Resources.walk4;
				}
				else if (picFrameCounter == 5)
				{
					this.picWalker.Image = Properties.Resources.walk5;
				}
				else if (picFrameCounter == 6)
				{
					this.picWalker.Image = Properties.Resources.walk6;
				}
				else if (picFrameCounter == 7)
				{
					this.picWalker.Image = Properties.Resources.walk7;
				}
				else if (picFrameCounter == 8)
				{
					this.picWalker.Image = Properties.Resources.walk8;
				}
				else if (picFrameCounter == 9)
				{
					this.picWalker.Image = Properties.Resources.walk9;
				}
				else if (picFrameCounter == 10)
				{
					this.picWalker.Image = Properties.Resources.walk10;
				}

				picFrameCounter = picFrameCounter + 1;

				//refresh the form.This MUST be done
				this.Refresh();

				Thread.Sleep(100);
			}
		}
	}
}
