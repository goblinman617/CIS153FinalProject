using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace CIS153_FinalProject
{
    class Board
    {

        // Game view so we can manipulate it here.
        private GameBoard view;

        // We want to store the players here.
        private Player playerOne;
        private Player playerTwo;

        // Stores which players turn it is.
        private Player currentPlayer;

        // Gamemode, needed for certain logic at game end.
        private String gamemode = null;

        // Varible for the computer player.
        Computer computer;


        private Cell[,] cells = new Cell[6, 7];

        //Constructor
        public Board()
        {
            this.init(null);
        }

        public Board(GameBoard gameView, FlowLayoutPanel flow)
        {
            this.view = gameView;
            this.init(flow);
        }

        // Build the token ui.
        private void init(FlowLayoutPanel flow)
        {

            // For each row in the array
            for (int row = 0; row < 6; row++)
            {
                // We will loop 7 times and make a new cell.
                for (int column = 0; column < 7; column++)
                {
                    // Create new cell class.
                    cells[row, column] = new Cell(row, column);

                    // Was able to give control over the view comp
                    // via the cell class.
                    cells[row, column].initView(flow);
                }
            }

        }

        // Find the next open token in the column and set the player as the owner.
        public Cell setPlayerAsOwnerOfNextToken(int column)
        {
            if (currentPlayer == null) { currentPlayer = playerOne; }

            // For each row in the array
            for (int row = 5; row >= 0; row--)
            {
                if (!cells[row, column].isTaken())
                {

                    // Set the cell owner to the current player.
                    cells[row, column].setCellOwner(currentPlayer);

                    // Check for win
                    if (currentPlayer != null && checkWin() != null)
                    {
                        Console.WriteLine("Winner!!!!", currentPlayer.getColor());
                    }

                    // Playing in singleplayer mode.
                    if (gamemode == "single")
                    {
                        // Tell the computer what the players last move was.
                        computer.SetOpponetPreviousMove(cells[row, column]);
                    }

                    // Swap players.
                    swapTurns();

                    // Return cell if one is found.
                    return cells[row, column];
                }


            }

            swapTurns();

            return null;
        }

        public Player checkWin()
        {
            // Check Rows
            for (int r = 0; r < cells.GetLength(0); r++)
            {
                // Number of like tokens in a row.
                int tokenInArow = 0;

                for (int c = 0; c < cells.GetLength(1); c++)
                {
                    // Check if current token is owned by the current player.
                    if (cells[r, c].getOwner() == currentPlayer)
                    {
                        tokenInArow++;

                        // If we find 4 Like tokens, return winner.
                        if (tokenInArow == 4)
                        {
                            return currentPlayer;
                        }
                    }
                    // If the tokens don't match, the row is broken.
                    else
                    {
                        tokenInArow = 0;
                    }
                }
            }

            // Check Columns
            for (int c = 0; c < cells.GetLength(1); c++)
            {
                // Number of like tokens in a row.
                int tokenInArow = 0;

                for (int r = 0; r < cells.GetLength(0); r++)
                {
                    // Check if current token is owned by current player.
                    if (cells[r, c].getOwner() == currentPlayer)
                    {
                        tokenInArow++;

                        // Number of tokens in a row is 4, return winner.
                        if (tokenInArow == 4)
                        {
                            return currentPlayer;
                        }
                    }
                    // If the tokens don't match, the row is broken.
                    else
                    {
                        tokenInArow = 0;
                    }
                }
            }

            return null;
        }

        // Swap players turn.
        public void swapTurns()
        {
            if (currentPlayer == playerOne) currentPlayer = playerTwo;
            else currentPlayer = playerOne;
        }


        /* Getters  Setters */

        public void setGamemode(String mode)
        {
            this.gamemode = mode;

            // Singleplayer mode is selected, set up single player.
            if (mode == "single")
            {
                // Create a new computer instance.
                computer = new Computer("Computer", Color.Orange);

                // Set players for the single player game.
                playerTwo = computer;
                playerOne = new Player("You", Color.Firebrick);
            }
        }

        // Set the players for the board.
        public void setPlayerOne(Player value)
        {
            this.playerOne = value;
        }

        public void setPlayerTwo(Player value)
        {
            this.playerTwo = value;
        }

        public Player getPlayerOne()
        {
            return this.playerOne;
        }

        public Player getPlayerTwo()
        {
            return this.playerTwo;
        }

        public Cell[,] getCells()
        {
            return this.cells;
        }

        public Computer GetComputer()
        {
            return computer;
        }

        public string GetGamemode()
        { return gamemode; }
    }
}
