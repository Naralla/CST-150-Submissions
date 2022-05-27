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
//I used source code from the following video to complete this assignment:
//https://www.youtube.com/user/shadsluiter
//This helped me to setup the game button clicking method and game grid array.

namespace Activity_13
{
    public partial class Form1 : Form
    {
        //initialize classes
        GameBoard game = new GameBoard();
        Button[] gameButtons = new Button[9];

        //tracks the turn of players
        int playerTurn = 1;

        public Form1()
        {
            InitializeComponent();

            //assigns GUI buttons to array
            gameButtons[0] = button1;
            gameButtons[1] = button2;
            gameButtons[2] = button3;
            gameButtons[3] = button4;
            gameButtons[4] = button5;
            gameButtons[5] = button6;
            gameButtons[6] = button7;
            gameButtons[7] = button8;
            gameButtons[8] = button9;

            //assigns button with a click handler and locks in player choice
            for (int i = 0; i < 9; i++)
            {
                gameButtons[i].Click += buttonIsClicked;
                gameButtons[i].Tag = i;
            }
        }

        //when a spot is chosen
        private void buttonIsClicked(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            int playerSelection = (int)clickedButton.Tag;

            //player 1 turn
            if (playerTurn % 2 != 0)
            {
                game.gameGrid[playerSelection] = 1;

                refreshTheBoard();
            }
            //player 2 turn
            else
            {
                game.gameGrid[playerSelection] = 2;

                refreshTheBoard();
            }

            //look for if move = win or tie
            if (game.checkForWinner() == 1)
            {
                winnerLabel.Text = "Player 1 wins!";
            }
            if (game.checkForWinner() == 2)
            {
                winnerLabel.Text = "Player 2 wins!";
            }
            else if (game.boardFull() == true && game.checkForWinner() == 0)
            {
                winnerLabel.Text = "The Game is  Tie";
            }

            playerTurn++;
        }


        //shows the choices made on the board & resets for new game
        private void refreshTheBoard()
        {         
            for (int i = 0; i < game.gameGrid.Length; i++)
            {
                if (game.gameGrid[i] == 0)
                {
                    gameButtons[i].Text = "";
                    gameButtons[i].Enabled = true;
                }
                else if (game.gameGrid[i] == 1)
                {
                    gameButtons[i].Text = "X";
                    gameButtons[i].Enabled = false;
                }
                else if (game.gameGrid[i] == 2)
                {
                    gameButtons[i].Text = "O";
                    gameButtons[i].Enabled = false;
                }
            }
        }

        //new game button
        private void newGameButton_Click(object sender, EventArgs e)
        {
            //resets all items and text
            game = new GameBoard();
            winnerLabel.Text = "";
            refreshTheBoard();
            playerTurn = 1;
        }

        //exit button
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    //board class
    class GameBoard
    {

        //initialize the grid
        public int[] gameGrid = new int[9];


        //constructor
        public GameBoard()
        {
            //fills the board with empty choices
            for (int i = 0; i < 9; i++)
            {
                gameGrid[i] = 0;
            }
        }

        //checks for if the board is full
        public bool boardFull()
        {
            bool boardFull = true;
            for (int i = 0; i < gameGrid.Length; i++)
            {
                if (gameGrid[i] == 0)
                {
                    boardFull = false;
                }
            }
            return boardFull;
        }

        //find a winner return 0 for no winner. return player number for winner
        public int checkForWinner()
        {
            //top row
            if (gameGrid[0] == gameGrid[1] && gameGrid[1] == gameGrid[2])
            {
                return gameGrid[0];
            }

            //middle row
            if (gameGrid[3] == gameGrid[4] && gameGrid[4] == gameGrid[5])
            {
                return gameGrid[3];
            }

            //bottom row
            if (gameGrid[6] == gameGrid[7] && gameGrid[7] == gameGrid[8])
            {
                return gameGrid[6];
            }

            //left column
            if (gameGrid[0] == gameGrid[3] && gameGrid[3] == gameGrid[6])
            {
                return gameGrid[0];
            }

            //middle column
            if (gameGrid[1] == gameGrid[4] && gameGrid[4] == gameGrid[7])
            {
                return gameGrid[1];
            }

            //right column
            if (gameGrid[2] == gameGrid[5] && gameGrid[5] == gameGrid[8])
            {
                return gameGrid[2];
            }

            //top left to bottom right diagonal
            if (gameGrid[0] == gameGrid[4] && gameGrid[4] == gameGrid[8])
            {
                return gameGrid[0];
            }

            //bottom left to top right diagonal
            if (gameGrid[6] == gameGrid[4] && gameGrid[4] == gameGrid[2])
            {
                return gameGrid[6];
            }

            return 0;
        }
    }
}
