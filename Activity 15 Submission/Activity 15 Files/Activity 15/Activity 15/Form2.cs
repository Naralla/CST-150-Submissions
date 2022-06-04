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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            //generate lucky number
            int luckyNumber;
            Random random = new Random();
            luckyNumber = random.Next(101);

            //show result
            luckyNumberLabel.Text = luckyNumber.ToString();
        }
    }
}
