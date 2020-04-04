/*
     * Created by: Rawaa Al Ghanai
     * Created on: March 13 2020
     * Created for: ICS3U Programming
     * Daily Assignment – Day #16 - Number Guessing Game
     * This program asks the user to guess my number. If they get it right it tells them so, makes a 
     * check mark and displays a ding sound. Else it tells them they are wrong, displays an x and a wrong sound.
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

namespace NumberGuessingGameRawaa
{
    public partial class frmNumberGuessingGame : Form
    {
        private SoundPlayer correctSound;
        private SoundPlayer incorrectSound; 

        public frmNumberGuessingGame()
        {
            // hide the guess label and image
            this.lblGuess.Hide(); 
            this.picAnswer.Hide();

            // create the sounds (correct and incorrect)
            correctSound = new SoundPlayer(@"Downloads: Correct Answer Sound Effect.mp3");


            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // declare local variables 
            int guessedNumber;

            // declare constants
            const int THENUMBER = 5;

            // assign the user's guess to the variable guessedNumber;
            guessedNumber = int.Parse(txtNumber.Text);

            // if the user's number is my number 
            if (guessedNumber == THENUMBER)
            {
                // display the text
                this.lblGuess.Text = "That's right!";
                this.lblGuess.Show();

                // display the correct image
                this.picAnswer.Image = Properties.Resources.checkmark;
                this.picAnswer.Show();

                // play the sound for correct answer 
                
            }
        }
    }
}
