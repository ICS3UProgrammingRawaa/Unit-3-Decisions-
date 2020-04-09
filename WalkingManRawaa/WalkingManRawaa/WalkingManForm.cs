/*
 * Created by: Rawaa Al GHanai
 * Created on: April 7th, 2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #21 - Walking Man
 * This program displays a man walking using images and a while loop.
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
// add sleep timer to library
using System.Threading;

namespace WalkingManRawaa
{
    public partial class frmWalkingMan : Form
    {
        public frmWalkingMan()
        {
            InitializeComponent();
        }

        private void btnWalk_Click(object sender, EventArgs e)
        {
            // declare variables 
            int pictureFrameCounter = 1;

            // declare constants
            const byte MAX_FRAMES = 10;

            // while the frame counter doesn't reach the max frame, continue this loop
            while (pictureFrameCounter < MAX_FRAMES + 1)
            {
                if (pictureFrameCounter == 1)
                {
                    this.picMan.Image = Properties.Resources.walk1;
                }
                else if (pictureFrameCounter == 2)
                {
                    this.picMan.Image = Properties.Resources.walk2;
                }
                else if (pictureFrameCounter == 3)
                {
                    this.picMan.Image = Properties.Resources.walk3;
                }
                else if (pictureFrameCounter == 4)
                {
                    this.picMan.Image = Properties.Resources.walk4;
                }
                else if (pictureFrameCounter == 5)
                {
                    this.picMan.Image = Properties.Resources.walk5;
                }
                else if (pictureFrameCounter == 6)
                {
                    this.picMan.Image = Properties.Resources.walk6;
                }
                else if (pictureFrameCounter == 7)
                {
                    this.picMan.Image = Properties.Resources.walk7;
                }
                else if (pictureFrameCounter == 8)
                {
                    this.picMan.Image = Properties.Resources.walk8;
                }
                else if (pictureFrameCounter == 9)
                {
                    this.picMan.Image = Properties.Resources.walk9;
                }
                else
                {
                    this.picMan.Image = Properties.Resources.walk10;
                }
            }

            // refresh the form 
            this.Refresh();

            // add a pause of 100 miliseconds
            Thread.Sleep(100);
        }
    }
}
