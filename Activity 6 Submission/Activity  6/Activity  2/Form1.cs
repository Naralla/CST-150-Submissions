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

namespace Activity__2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            decimal earthWeight = 0;
            decimal marsWeight = 0;
            decimal earthGravity = 9.81m;
            decimal marsGravity = 3.711m;

            try 
                {
                //get user input
                    if (decimal.TryParse(earthWeightBox.Text, out earthWeight))
                    {

                        //process user input
                        marsWeight = (earthWeight / earthGravity) * marsGravity;

                        //return answer
                        marsWeightBox.Text = marsWeight.ToString("N3");
                    }                   
                    //inner exception handler
                    else
                    {
                        MessageBox.Show("Please enter a numeric weight value.");
                    }
                }


            //exception handler
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
