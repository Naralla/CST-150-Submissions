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
//May 27, 2022
//This is my own work

namespace Activity_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //call methods once button is clicked
        private void writeButton_Click(object sender, EventArgs e)
        {
            //variable to hold checkbox results
            string results;

            //call methods
            listBoxChoice();
            radioButtonChoice();
            
            //to hold return from method call
            results = checkBoxChoice(); 

            //output result
            resultsBox.Text = results;
        }

        //clear selections and results for a new set of choices
        private void clearButton_Click(object sender, EventArgs e)
        {
            fontListBox.ClearSelected();
            nameCheckBox.Checked = false;
            specialMessageBox.Checked = false;
            dateCheckBox.Checked = false;
            resultsBox.Text = " ";
        }

        //get radio button choice. radio button used since text should be one
        //or the other.
        public void radioButtonChoice()
        {
            if (yesBoldButton.Checked)
            {
                resultsBox.Font = new Font(resultsBox.Font, FontStyle.Bold);
            }
            else
            {
                resultsBox.Font = new Font(resultsBox.Font, FontStyle.Regular);
            }
        }

        //get listbox choice. List box used since there are many 
        //colors that could be added or chosen.
        public void listBoxChoice()
        {
            int listChoice = fontListBox.SelectedIndex;

            //change color based on choice
            if (listChoice == 0)
            {
                resultsBox.ForeColor = Color.Blue;
            }
            if (listChoice == 1)
            {
                resultsBox.ForeColor = Color.Red;
            }
            if (listChoice == 2)
            {
                resultsBox.ForeColor = Color.Purple;
            }
        }

        //get checkbox choices. Check box used so that message can
        //be tailored as desired.
        public string checkBoxChoice()
        {
            string checkBoxChoices = null;

            //concatenate string based on choices
            if(nameCheckBox.Checked)
            {
                checkBoxChoices = (checkBoxChoices + "Dalton Danz");
            }
            if(specialMessageBox.Checked)
            {
                checkBoxChoices = (checkBoxChoices + Environment.NewLine + "Thank you for your time");
            }
            if(dateCheckBox.Checked)
            {
                DateTime currentDateTime = DateTime.Now;
                checkBoxChoices = (checkBoxChoices + Environment.NewLine + currentDateTime);
            }

            return checkBoxChoices;
        }
    }
}
