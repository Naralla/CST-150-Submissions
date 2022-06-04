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
//June 4, 2022
//This is my own work

namespace Activity_15
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            InitializeYearComboBox();

            InitializeMonthComboBox();
        }

        //programmatically initializes and populates month box
        public void InitializeMonthComboBox()
        {
            //generate and place combo box
            ComboBox monthComboBox = new ComboBox();
            monthComboBox.Location = new Point(165, 118);
            monthComboBox.Name = "birthMonthComboBox";
            monthComboBox.Size = new Size(121, 21);

            //fill combo box
            monthComboBox.Items.Add("January");
            monthComboBox.Items.Add("February");
            monthComboBox.Items.Add("March");
            monthComboBox.Items.Add("April");
            monthComboBox.Items.Add("May");
            monthComboBox.Items.Add("June");
            monthComboBox.Items.Add("July");
            monthComboBox.Items.Add("August");
            monthComboBox.Items.Add("September");
            monthComboBox.Items.Add("October");
            monthComboBox.Items.Add("November");
            monthComboBox.Items.Add("December");

            //add to control list
            this.Controls.Add(monthComboBox);

            //adds event handler for birth month change
            monthComboBox.SelectedIndexChanged += birthMonthComboBox_SelectedIndexChanged;  
           
        }

        //programmatically populate the birth year combo box
        private void InitializeYearComboBox()
        {
            string[] years = new string[21]
            {
                "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997",
                "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", 
                "2006", "2007", "2008", "2009", "2010"
            };

            birthYearComboBox.DataSource = years;
        }


        //Programmatically fill day combo box with 28 days
        private void Initialize28DayComboBox()
        {
            birthDayComboBox.Items.Clear();

            string[] days = new string[28]
            {
                "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14",
                "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26",
                "27", "28"
            };

            //update combo box
            birthDayComboBox.Items.AddRange(days);
        }

        //Programmatically fill day combo box with 29 days if leap year conditions are met
        //from other boxes
        private void Initialize29DayComboBox()
        {
            birthDayComboBox.Items.Clear();

            string[] days = new string[29]
            {
                "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", 
                "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", 
                "27", "28", "29"
            };

            //update combo box
            birthDayComboBox.Items.AddRange(days);
        }

        //Programmatically fill day combo box with 30 days
        private void Initialize30DayComboBox()
        {
            birthDayComboBox.Items.Clear();

            string[] days = new string[30]
            {
                "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", 
                "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", 
                "27", "28", "29", "30"
            };

            //update combo box
            birthDayComboBox.Items.AddRange(days);
        }

        //Programmatically fill day combo box with 31 days
        private void Initialize31DayComboBox()
        {
            birthDayComboBox.Items.Clear();

            string[] days = new string[31]
            {
                "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", 
                "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", 
                "27", "28", "29", "30", "31"
            };

            //update combo box
            birthDayComboBox.Items.AddRange(days);
        }

        //Change days combo box off of month selection.
        private void birthMonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get month from combo box
            ComboBox monthComboBox = (ComboBox)sender;
            int selectedMonth = 0;
            if (monthComboBox.SelectedItem != null)
            {
                selectedMonth = int.Parse(monthComboBox.SelectedIndex.ToString());
            }
            else
            {
                selectedMonth = 0;
            }

            // get year from combo box
            int selectedYear;
            if (birthYearComboBox.SelectedItem != null)
            {
                selectedYear = int.Parse(birthYearComboBox.SelectedItem.ToString());
            }
            else
            {
                selectedYear = 0;
            }

            //31 day month initialization
            if (selectedMonth == 0 || selectedMonth == 2 || selectedMonth == 4 || selectedMonth == 6 ||
                selectedMonth == 7 || selectedMonth == 9 || selectedMonth == 11)
            {
                Initialize31DayComboBox();
            }

            //30 day month initialization
            else if(selectedMonth == 3 || selectedMonth == 5 || selectedMonth == 8 || selectedMonth == 10)
            {
                Initialize30DayComboBox();
            }

            //29 day month initialization
            else if(selectedMonth == 1 && selectedYear % 4 ==0 )
            {
                Initialize29DayComboBox();
            }
            else
            {
                Initialize28DayComboBox();
            }    
        }

        //Change days combo box off year number. searching for leap years
        private void birthYearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //get month from combo box
            ComboBox monthComboBox = (ComboBox)sender;
            int selectedMonth = 0;
            if (monthComboBox.SelectedItem != null)
            {
                selectedMonth = int.Parse(monthComboBox.SelectedIndex.ToString());
            }
            else
            {
                selectedMonth = 0;
            }

            // get year from combo box
            int selectedYear;
            if (birthYearComboBox.SelectedItem != null)
            {
                selectedYear = int.Parse(birthYearComboBox.SelectedItem.ToString());
            }
            else
            {
                selectedYear = 0;
            }


            if (selectedMonth == 1)
            {
                if (selectedYear % 4 == 0)
                {
                    Initialize29DayComboBox();
                }
                else
                {
                    Initialize28DayComboBox();
                }
            }
        }

        private void getLuckyNumbersButton_Click(object sender, EventArgs e)
        {
            //hide form 1
            this.Hide();

            // create an instance of form 2
            Form2 resultsForm = new Form2();
            resultsForm.ShowDialog();

            //when form closed
            resultsForm = null;

            //re-show main form
            this.Show();
        }

        private void secretMessageButton_Click(object sender, EventArgs e)
        {
            //hide form 1
            this.Hide();

            //create an instance of form 3
            Form3 secretForm = new Form3();
            secretForm.ShowDialog();

            //when form closed
            secretForm = null;

            //re-show main form
            this.Show();
        }
    }
}
