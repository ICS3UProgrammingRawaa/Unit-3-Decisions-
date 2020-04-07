/*
 * Created by: Rawaa Al Ghanai
 * Created on: April 3rd, 2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #19 - Chocolate Boxes
 * This program that rewards the user according to how many chocolates they sell. 
 * If they sell over 20 boxes, they get a "prize". 
 * If a they sells less than 20 boxes but more then 10, they get "honorable mention" . 
 * Otherwise, they get a "small prize" (less then 10 boxes)
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

namespace ChocolateBoxesRawaa
{
    public partial class frmChocolateBoxes : Form
    {
        public frmChocolateBoxes()
        {
            InitializeComponent();

            // hide the reward statement
            lblReward.Hide();
        }

        private void frmChocolateBoxes_Load(object sender, EventArgs e)
        {

        }

        private void btnReward_Click(object sender, EventArgs e)
        {
            // declare variables 
            int soldBoxes;

            // convert the numeric up and down value into an integer 
            soldBoxes = Convert.ToInt32(nudNumberOfBoxes.Value);

            // if statement that presents your reward according to how much the user was able to sell
            if (soldBoxes > 20)
            {
                this.lblReward.Text = "Claim Your Large Prize!";
                lblReward.Show();
            }
            else if (soldBoxes < 20 && soldBoxes > 10)
            {
                this.lblReward.Text = "You've Gotten Honorable Mentions!";
                lblReward.Show();
            }
            else
            {
                this.lblReward.Text = "Claim Your Small Prize!";
                lblReward.Show();
            }
        }
    }
}
