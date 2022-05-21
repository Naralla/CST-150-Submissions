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
//May 21, 2022
//This is my own work

namespace Activity_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rollDiceButton_Click(object sender, EventArgs e)
        {
            //generate random number of sides for dice. number of sides restricted to 
            //meet constructor criteria
            Random randNumOfSides = new Random();
            int numOfSides = randNumOfSides.Next(4, 20);

            //create dice objects
            Dice die1 = new Dice(numOfSides, 0);
            Dice die2 = new Dice(numOfSides, 0);

            //initialize count number of rolls until snake eyes
            int numOfRolls = 0;

            do
            {
                //roll both dice
                die1.RollDie();
                die2.RollDie();

                //increment number of rolls
                numOfRolls++;

                //keep rolling until snake eyes
            } while (die1.isSnakeEyes(die2));
                    
                //display results
                MessageBox.Show("It took " + numOfRolls + " rolls to get snake eyes!");
        }
    }
}


//Dice class
public class Dice
{

    //initialize variables
    public int valueOfSide;
    private int numberOfSides;
    Random rollNumber = new Random();

    //constructors
    public Dice(int numberOfSides, int valueOfSide)
    {
        //to restrict constructor to intended values only
        if(numberOfSides <= 20 && numberOfSides >= 4)
        {
            this.numberOfSides = numberOfSides;
            this.valueOfSide = valueOfSide;
        }
        else
        {
            MessageBox.Show("Invalid number of sides entered. Please enter an integer value " +
                "between 4 and 20");
        }
    }

    //Dice Class
    public Dice()
    {
        this.numberOfSides = 0;
        this.valueOfSide = 0;
    }

    //rolls the dice
    public int RollDie()
    {
        this.valueOfSide = (int)(rollNumber.Next(1, this.numberOfSides));
        return this.valueOfSide;
    }

    //checks for snake eyes
    public bool isSnakeEyes(Dice rcvDice)
    {
        if (this.valueOfSide != 1 && rcvDice.valueOfSide != 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}