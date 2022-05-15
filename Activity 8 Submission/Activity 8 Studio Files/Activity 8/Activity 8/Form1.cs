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
//May 15, 2022
//This is my own work

namespace Activity_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Fat Calories calculation method
        private int FatCalories(int fatGrams)
        {
            return fatGrams * 9;
        }

        //Carbs Calories calculation method
        private int CarbCalories(int carbsGrams)
        {
            return carbsGrams * 4;
        }



        private void calculateButton_Click(object sender, EventArgs e)
        {
            //variable declarations
            int caloriesFromFat;
            int caloriesFromCarbs;
            int gramsFromFat;
            int gramsFromCarbs;

           //clear previous results
            resultsBox.Text = "";

            try
            {
                //for exception handling
                if(int.TryParse(gramsOfFatBox.Text, out gramsFromFat))
                {
                    if(int.TryParse(gramsOfCarbsBox.Text, out gramsFromCarbs))
                    {

                        //method calls for calculations
                        caloriesFromFat = FatCalories(gramsFromFat);
                        caloriesFromCarbs = CarbCalories(gramsFromCarbs);

                        //output results
                        resultsBox.Text = ("The Calories from Fat are " + caloriesFromFat.ToString() + "and the Calories from Carbs are " 
                            + caloriesFromCarbs.ToString());
                    }

                    //exception handling
                    else
                    {
                        MessageBox.Show("Invalid Grams of Carbs. Please enter an integer value of Grams of Carbs");

                    }
                }
                else
                {
                    MessageBox.Show("Invalid Grams of Fat. Please enter an integer value of Grams of Fat");
                }
                    
            }
            //error catching during building
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //exit button
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
