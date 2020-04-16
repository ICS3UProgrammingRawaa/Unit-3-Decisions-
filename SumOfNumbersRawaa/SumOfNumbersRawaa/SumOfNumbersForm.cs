/*
 * Created by: Rawaa Al Ghanai
 * Created on: April 10th, 2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day 23 - Factorial with For Loop
 * This program asks the user for a positive number. 
 * Then it calculates the sum of all numbers, until 
 * it reaches that given number, from the user.
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

namespace SumOfNumbersRawaa
{
    public partial class frmSumOfNumbers : Form
    {
        public frmSumOfNumbers()
        {
            InitializeComponent();
            this.lblAnswer.Hide();
        }

        private void frmSumOfNumbers_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // declare variables and constants
            double answer, number, calculations;
            int counter;

            // clear the listbox
            this.lstAddingNumber.Items.Clear();

            // initialize the final answer to one
            answer = 1;

            // get the from the user and assign it to the appropriate variable 
            number = Convert.ToDouble(this.txtMaxNumber.Text);

            // the for loop
            for (counter = 1; counter <= number; counter++)
            {
                // calculate the sum using the Gauss formula 
                calculations = (number * (number + 1)) / 2;

                // display the counter in list box 
                this.lstAddingNumber.Items.Add(counter);

                // add up all the numbers before the user's entered number 
                answer = calculations;

                // display the answer the answer as a label 
                this.lblAnswer.Text = Convert.ToString(answer);

                // show the label that displays the answer
                this.lblAnswer.Show();
            }
        }
    }
}
