using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToManyStudentsRawaa
{
    public partial class frmTooManyStudents : Form
    {
        public frmTooManyStudents()
        {
            InitializeComponent();
        }

        private void FrmTooManyStudents_Load(object sender, EventArgs e)
        {
            // Hide the answer label 
            this.lblTooManyStudents.Hide();
        }

        private void BtnCheckSize_Click(object sender, EventArgs e)
        {
            // declare constants and varaibles 
            const int MAX_STUDENTS = 24;
            int numStudents;

            // get the number of students from the textbox
            numStudents = int.Parse(txtNumStudents.Text);

            // if the number of students is greater than the maximum capacity, display "Too Many Students"
            if ()
        }

        private void LblAnswer_Click(object sender, EventArgs e)
        {

        }
    }
}
