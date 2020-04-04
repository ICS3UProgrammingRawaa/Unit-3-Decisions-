/*
 * Created by: Rawaa Al GHanai
 * Created on: March 13, 2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #17 - Random Number
 * This program that creates a random number that can be guessed by the user. I 
 * added this code to yesterdays assignment, so that always being the same number,
 * it's now random. I added the following.
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
using System.Media;

namespace RandomNumberRawaa
{
    public partial class frmRandomNumber : Form
    {
        private SoundPlayer correctSound;
        private SoundPlayer incorrectSound;

        public frmRandomNumber()
        {
            InitializeComponent();
        }

        private void frmRandomNumber_Load(object sender, EventArgs e)
        {
            // hide the answer label and picture box
            this.lblAnswer.Hide();
            this.picAnswer.Hide();

            // create the sounds (correct and incorrect)
            correctSound = new SoundPlayer(@"C: \Users\Rawaa\Documents\ICS3U Programming\Unit - 3 - Decisions -\NumberGuessingGameRawaa\Sound\Correct Answer Sound Effect(1)");
            incorrectSound = new SoundPlayer(@"C: \Users\Rawaa\Documents\ICS3U Programming\Unit - 3 - Decisions -\NumberGuessingGameRawaa\Sound\Wrong Buzzer Sound Effect");
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // declare local constants 
            const int MIN_NUM = 1;
            const int MAX_NUM = 10;

            // declare variables 
            int guessedNumber;
            int aRandomNumber;
            Random randomNumberGenerator = new Random();

            // get a random number 
            aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);

            // assign the user's guess to the variable guessedNumber
            guessedNumber = int.Parse(txtNumber.Text);

            // assign random number to the label 
            lblAnswer.Text = Convert.ToString(aRandomNumber);

            if (guessedNumber == aRandomNumber)
            {
                // display text 
                this.lblAnswer.Text = "That's right!";
                this.lblAnswer.Show();

                // display the correct image
                this.picAnswer.Image = Properties.Resources.checkmark;
                this.picAnswer.Show();

            }
            else
            {
                // display text
                this.lblAnswer.Text = "That's not it. Try again.";
                this.lblAnswer.Show();

                //display the correct image
                this.picAnswer.Image = Properties.Resources.red_x;
                this.picAnswer.Show();
            }
        }
    }
}
