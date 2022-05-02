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
//4/24/2022
//This is my own work

namespace Hello_World
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void messageButton_Click(object sender, EventArgs e)
        {
            hiddenMessageBox.Text = "Programming in Visual C# is fun!";
            MessageBox.Show("Hello World!");
        }

        private void endProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
