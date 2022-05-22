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

namespace Activity_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            Conversions convertToMeters = new Conversions();

            int millimeters;

            if (int.TryParse(numMillimetersBox.Text, out millimeters))
            {
                convertToMeters.showMeters(millimeters);
            }
            else
            {
                MessageBox.Show("Please enter an integer value of Millimeters");
            }
        }
    }

    //Class for methods
    public partial class Conversions
    {
        //initialize variables
        Random randomNumber = new Random();

        public void showMeters(int numMillimeters)
        {
            double meters = numMillimeters/1000.00;
            
            MessageBox.Show(numMillimeters + " millimeters is equal to " + meters + " meters");
        }

        //method 1
        public void addTwoSum(int x, int y)
        {
            //calculate and return sum
            int sum = x + y;
            MessageBox.Show("The sum total is " + sum.ToString());
        }

        //method 2
        public double averageOfFive(double a, double b, double c, double d, double e)
        {
            //calculate and return average
            double average = (a + b + c + d + e) / 5;
            return average;
        }

        //method 3
        public int randomSum()
        {
            int x;
            int y;

            //generate random numbers
            x = randomNumber.Next();
            y = randomNumber.Next();

            //calculate and return sum
            int sum = x + y;
            return sum;
        }

        //method 4
        public bool divisbleByThree(int a, int b, int c)
        {
            //checks if sum is divisible by three 
            if ((a + b + c) % 3 == 0)
            {
                return true;
            }
            //returns false if not
            else
            {
                return false;
            }
        }

        //method 5
        public void shorterString(string a, string b)
        {
            //find length of string A
            int numCharactersInA = 0;
            for (int j = 0; j < a.Length; j++)
            {
                numCharactersInA++;
            }
            //find length of string B
            int numCharactersInB = 0;
            for (int x = 0; x < b.Length; x++)
            {
                numCharactersInB++;
            }

            //display shorter string
            if (numCharactersInA < numCharactersInB)
            {
                MessageBox.Show("The first string was shorter it was: " + a);
            }
            if (numCharactersInB < numCharactersInA)
            {
                MessageBox.Show("The second string was shorter it was: " + b);
            }
            else
            {
                MessageBox.Show("The strings are equal");
            }    
        }

        //method 6
        public double largestInArray(double[] arrayX)
        {
            //find largest in the array 
            double highestValue = 0;

            for (int i = 0; i < arrayX.Length; i++)
            {
                if (arrayX[i] > highestValue)
                    highestValue = arrayX[i];
            }

            //return highest value
            return highestValue;
        }

        //method 7
        public int[] arrayOfIntegers()
        {
            //create new array
            int[] array = new int[50];

            //fill array with random numbers
            for (int i = 0; i < array.Length; i++)
                array[i] = randomNumber.Next();

            return array;
        }

        //method 8
        public bool boolMatch(bool a, bool b)
        {
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //method 9
        public double mixedProduct(int x, double y)
        {
            //perform calculation and return result
            double product = x * y;
            return product;
        }

        //method 10
        public double arrayAverage(int[][] arrayX)
        {
            //initialize variables
            int totalSum = 0;
            int numOfEntries = 0;

            //move across array rows
            for (int row = 0; row < arrayX.Length; row++)
            {
                //move across array columns
                for (int col = 0; col < arrayX[row].Length; col++)
                {
                    //add to total
                    totalSum += arrayX[row][col];

                    //count number of entries
                    numOfEntries++;
                }
            }
            //get average and return result
            double averageTotal = totalSum / numOfEntries;
            return averageTotal;
        }
    }
}
