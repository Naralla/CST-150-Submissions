using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Dalton Danz
//CST-150
//May 27, 2022
//This is my own work

namespace Activity_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //open streamreader and create list
            StreamReader inputFile;
            List<string> wordsList = new List<string>();

            inputFile = File.OpenText("FileForInput.txt");

            //read input from file to find array size
            while (inputFile.EndOfStream == false)
            {
                wordsList.Add(inputFile.ReadLine());
            }

            //close input file
            inputFile.Close();

            processWords(wordsList);
        }



        static public void processWords(List<string> wordsList)
        {
            //count number of matches
            int numOfMatches = 0;

            //find words ending in t or e
            foreach (string currWord in wordsList)
            {
                //finds index of second to last character in case of non-alphabetical ending.
                int numIndex = 0;
                int lastLetterIndex = 0;
                for (int i = 0; i < currWord.Length; i++)
                {
                    numIndex++;
                }
                lastLetterIndex = (numIndex - 2);

                //convert to lowercase
                string lowerCurrWord = currWord.ToLower();

                //array to target e and t
                char[] targetChar = new char[] { 'e', 't' };

                //checks last letter in word
                if (lowerCurrWord.EndsWith('e') || lowerCurrWord.EndsWith('t'))
                {
                    numOfMatches++;
                }
                //currently not catching words ending in punctuation
                //checks second to last letter
                else if (lowerCurrWord.Contains('!') || lowerCurrWord.Contains(',') || lowerCurrWord.Contains('.')
                    || lowerCurrWord.Contains('?'))
                {
                    if (lowerCurrWord.LastIndexOfAny(targetChar) == lastLetterIndex)
                    {
                        numOfMatches++;
                    }
                }
            }
            //call for results
            outPutResult(numOfMatches);            
        }

        static public void outPutResult(int numOfMatches)
        {
            //output results
            Console.WriteLine("There are " + numOfMatches + " words that end in t or e");
        }
        
    }
}
    


