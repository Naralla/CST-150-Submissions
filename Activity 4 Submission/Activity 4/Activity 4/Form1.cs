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
//May 1, 2022
//This is my own work

namespace Activity_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int numSeconds;
            int numMinutes;
            int numHours;
            int numDays;
            if (int.TryParse(secondsBox.Text, out numSeconds))
            {
                if (numSeconds >= 60 && numSeconds < 3600)
                {
                    numMinutes = numSeconds / 60;
                    MessageBox.Show("There are " + numMinutes + " minute(s) in " + numSeconds + " seconds.");
                }
                else if (numSeconds >= 3600 && numSeconds < 86400)
                {
                    numMinutes = numSeconds / 60;
                    numHours = numSeconds / 3600;
                    MessageBox.Show("There are " + numHours + " hour(s) or " + numMinutes + " minute(s) in " + numSeconds + " seconds.");
                }
                else if (numSeconds >= 86400 && !(numSeconds < 86400))
                {
                    numMinutes = (numSeconds / 60);
                    numHours = (numSeconds / 3600);
                    numDays = (numSeconds / 86400);
                    MessageBox.Show("There are " + numDays + " day(s) or " + numHours + " hour(s) or " + numMinutes + " minute(s) in " +
                        numSeconds + " seconds.");
                }
                else
                {
                    MessageBox.Show("Please enter more than 60 seconds");
                }    
            }
            else
            {
                MessageBox.Show("Please enter an integer number of seconds");
            }
        }
    }
}
