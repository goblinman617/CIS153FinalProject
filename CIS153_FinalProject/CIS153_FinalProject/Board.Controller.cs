using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            currentPlayer = playerOne;
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
                    swapTurns();
                    cells[row, column].setCellOwner(currentPlayer);
                    return cells[row, column];
                }


            }

            swapTurns();

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
    }
}
