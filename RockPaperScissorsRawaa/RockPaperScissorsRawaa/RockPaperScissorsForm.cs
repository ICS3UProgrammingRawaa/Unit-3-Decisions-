/*
 * Created by: Rawaa Al GHanai
 * Created on: April 1st, 2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #18 - Rock, Paper, Scissors
 * This program will generate a random number between 1-3 ( rock, paper or scissors. 
 * The user will being play against the random generator.
 * The game could either end in a win, lose or a tie. 
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

namespace RockPaperScissorsRawaa
{
    public partial class frmRockPaperScissors : Form
    {
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 3;
        Random randomNumberGenerator; 
        public frmRockPaperScissors()
        {
            InitializeComponent();

            // hide the label that tells the user's result 
            lblResult.Hide();

            // create a random number generator object 
            randomNumberGenerator = new Random();
        }

        private void frmRockPaperScissors_Load(object sender, EventArgs e)
        {
    
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            // declare local variables 
            int usersChoice, computersChoice;

            // declare variables 
            const int ROCK = 1;
            const int PAPER = 2;
            const int SCISSORS = 3;

            // get the user's selection if there's no selection set it to zero
            if (radPlayerRock.Checked == true)
            {
                usersChoice = ROCK;
            }

            else if (radPlayerPaper.Checked == true)
            {
                usersChoice = PAPER;
            }
            else if (radPlayerScissors.Checked == true)
            {
                usersChoice = SCISSORS;
            }

            else
            {
                usersChoice = 0;
            }

            // generate the random rock, paper, scissors 
            computersChoice = randomNumberGenerator.Next(MIN_VALUE, MIN_VALUE + 1);

            // set the computer's choice 
            if (computersChoice == ROCK)
            {
                this.radComputerRock.Checked = true;
            }
            else if (computersChoice == PAPER)
            {
                this.radComputerPaper.Checked = true;
            }

            // compare the user's choice with the random generator's 
            if (usersChoice == computersChoice)
            {
                this.lblResult.Text = "You tied!";
                lblResult.Show();
            }
            else if (usersChoice == ROCK && computersChoice == SCISSORS)
            {
                this.lblResult.Text = "You Won!:)";
                lblResult.Show();
            }
            else if (usersChoice == PAPER && computersChoice == ROCK)
            {
                this.lblResult.Text = "You Won!:)";
                lblResult.Show();
            }
            else if (usersChoice == PAPER && computersChoice == SCISSORS)
            {
                this.lblResult.Text = "You Lost!:(";
                lblResult.Show();
            }
            else if (usersChoice == SCISSORS && computersChoice == PAPER)
            {
                this.lblResult.Text = "You Won!:)";
                lblResult.Show();
            }
            else if (usersChoice == SCISSORS && computersChoice == ROCK)
            {
                this.lblResult.Text = "You Lost!:(";
                lblResult.Show();
            }
        }
    }
}
