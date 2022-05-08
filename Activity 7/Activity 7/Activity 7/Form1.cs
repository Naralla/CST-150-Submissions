using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Dalton Danz
//CST-150
//May 8, 2022
//This is my own work.

namespace Activity_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //declare variables
            int numberOfTerms;
            double finalResult = 0;

            //exception handling
            if (int.TryParse(numberOfTermsBox.Text, out numberOfTerms))
            {
                //begin loops
                for (int x = 1; x <= numberOfTerms; x++)
                {
                    //checks for even iterations
                    if (x % 2 == 0)
                    {
                        finalResult -=  (4.0 / ((2 * x) - 1));
                    }
                    //for odd iterations
                    else
                    {
                        finalResult += (4.0 / ((2 * x) - 1));
                    }
                }
                //displays answer
                answerLabelBox.Text = ("Approximate value of pi after " + numberOfTermsBox.Text + " terms =" + finalResult.ToString());
            }
            //exception error message
            else
            {
                MessageBox.Show("Please enter an integer number of terms");
            }
        }
    }
}
