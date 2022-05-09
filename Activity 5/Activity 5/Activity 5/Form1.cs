using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//Dalton Danz
//CST-150
//May 8, 2022
//This is my own work

namespace Activity_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            //open exception handling
            try
            {
                //declare variables
                StreamReader inputFile;
                StreamWriter outputFile;

                string inputWord;
                string lowerWord;
                string fullSentence = "";

                string mostVowels = "";
                int highestNumVowels = 0;

                string mostLetters = "";
                int highestNumLetters = 0;

                string firstAlphabetical = "z";
                string lastAlphabetical = "a";


                //open files
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputFile = File.OpenText(openFileDialog.FileName);

                    outputFile = File.CreateText("Results.txt");

                    outputFile.WriteLine("The words in lowercase are:");

                    //read input from file
                    while (inputFile.EndOfStream == false)
                    {
                        inputWord = inputFile.ReadLine();

                        //convert to lowercase
                        lowerWord = inputWord.ToLower();

                        //create new lowercase version of full file
                        fullSentence = (fullSentence + " " + lowerWord);

                        //send lowercase words to output file
                        outputFile.Write(lowerWord);

                        //find word with the most vowels
                        int numVowels = 0;
                        for (int i = 0; i < lowerWord.Length; i++)
                        {
                            char currLetter = lowerWord[i];

                            if (currLetter == 'a')
                            {
                                numVowels++;

                                if (numVowels > highestNumVowels)
                                {
                                    highestNumVowels = numVowels;
                                    mostVowels = lowerWord;
                                }
                            }
                            if (currLetter == 'e')
                            {
                                numVowels++;

                                if (numVowels > highestNumVowels)
                                {
                                    highestNumVowels = numVowels;
                                    mostVowels = lowerWord;
                                }
                            }
                            if (currLetter == 'i')
                            {
                                numVowels++;

                                if (numVowels > highestNumVowels)
                                {
                                    highestNumVowels = numVowels;
                                    mostVowels = lowerWord;
                                }
                            }
                            if (currLetter == 'o')
                            {
                                numVowels++;

                                if (numVowels > highestNumVowels)
                                {
                                    highestNumVowels = numVowels;
                                    mostVowels = lowerWord;
                                }
                            }
                            if (currLetter == 'u')
                            {
                                numVowels++;

                                if (numVowels > highestNumVowels)
                                {
                                    highestNumVowels = numVowels;
                                    mostVowels = lowerWord;
                                }
                            }
                            if (currLetter == 'y')
                            {
                                numVowels++;

                                if (numVowels > highestNumVowels)
                                {
                                    highestNumVowels = numVowels;
                                    mostVowels = lowerWord;
                                }
                            }
                        }

                        //find the longest word
                        int numLetters = 0;
                        for (int j = 0; j < lowerWord.Length; j++)
                        {
                            numLetters++;

                            if (numLetters > highestNumLetters)
                            {
                                highestNumLetters = numLetters;
                                mostLetters = lowerWord;
                            }
                        }

                        //find first word alphabetically
                        if (String.Compare(lowerWord, firstAlphabetical) < 0)
                        {
                            firstAlphabetical = lowerWord;
                        }

                        //find last word alphabetically
                        if (String.Compare(lowerWord, lastAlphabetical) > 0)
                        {
                            lastAlphabetical = lowerWord;
                        }
                    }
                    //close the input file
                    inputFile.Close();

                    //output remaining results to output file
                    outputFile.WriteLine();
                    outputFile.WriteLine("The first word alphabetically is: " + firstAlphabetical);
                    outputFile.WriteLine("The last word alphabetically is: " + lastAlphabetical);
                    outputFile.WriteLine("The longest word is: " + mostLetters);
                    outputFile.WriteLine("The word with the most vowels is: " + mostVowels);

                    //close the output file
                    outputFile.Close();

                    //output the results to textbox
                    resultsBox.Text = ("The words in lowercase are: " + fullSentence + Environment.NewLine + "The first word alphabetically is: " +
                        firstAlphabetical + Environment.NewLine + " The last word alphabetically is: " + lastAlphabetical +
                         Environment.NewLine + " The longest word is: " + mostLetters + Environment.NewLine +
                        " The word with the most vowels is: " + mostVowels);
                }

                //in case no file selected exception
                else
                {
                    MessageBox.Show("No file was selected");
                }
            }

            //exception handling
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
