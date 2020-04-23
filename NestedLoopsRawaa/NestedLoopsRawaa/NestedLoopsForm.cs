/*
 * Created by: Rawaa Al Ghanai
 * Created on: April 16, 2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #26 - Alphabet Nested Loops
 * This program converts 2 individual unicode values, upper case and lower case, 
 * into their appropriate character value, using a nested loop. 
 * It then displays both types of unicode characters 
 * (upper case and lower case) in the listbox.
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

namespace NestedLoopsRawaa
{
    public partial class frmNestedLoops : Form
    {
        public frmNestedLoops()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // declare variables
            int upperCharacterNumber, lowerCharacterNumber;
            string upperCharacter, lowerCharacter;

            // clear listbox
            this.lstFromAtoZ.Items.Clear();

            // for loop for the upper case conversion to unicode 
            for (upperCharacterNumber = 65; upperCharacterNumber <= 90; upperCharacterNumber++)
            {
                // convert from an int to a char, using the hexadecimal notation function. 
                upperCharacter = Char.ConvertFromUtf32(upperCharacterNumber);

                // nested loop for the lower case conversion to unicode 
                for (lowerCharacterNumber = 97; lowerCharacterNumber <= 122; lowerCharacterNumber++)
                {
                    // convert from an int to a char, using the hexadecimal notation function
                    lowerCharacter = Char.ConvertFromUtf32(lowerCharacterNumber);

                    // display both upper case and lower case characters in listbox
                    this.lstFromAtoZ.Items.Add(upperCharacter + "  ->  " + lowerCharacter);
                }
            }
        }
    }
}
