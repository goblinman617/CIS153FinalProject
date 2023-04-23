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

        // Last placed cell
        private Cell last = null;

        //winner
        private Player winner = null;


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
                    cells[row, column].setCellOwner(currentPlayer);
                    last = cells[row, column];

                    winner = hasWin();
                    //winner = hasWin();

                    if (winner != null)
                    {
                        Console.WriteLine(winner.getName());
                    }

                    swapTurns();
                    return cells[row, column];
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
        }
        public string getGamemode() {
            return gamemode;
        }
        public Player getWinner() {
            return winner;
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

        public Player getCurrentPlayer()
        {
            return this.currentPlayer;
        }
        /*
        public Player hasWin_v3()
        {
            // Check Rows
            for (int r = 0; i < cells.Length(0); r++)
            {
                // Number of like tokens in a row.
                int tokenInArow = 0;

                for (int c = 0; i < cells.Length(1); c++)
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
            for (int c = 0; c < cells.Length(1); c++)
            {
                // Number of like tokens in a row.
                int tokenInArow = 0;

                for (int r = 0; r < cells.Length(0); r++)
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

            // Check Diagnals
            for (int row = 0; row <= cells.GetLength(0) - 4; row++)
            {
                for (int col = 0; col <= cells.GetLength(1) - 4; col++)
                {
                    // Number of like tokens in a row.
                    int tokenInArow = 0;

                    for (int i = 0; i < 4; i++)
                    {
                        if (cells[row + i, col + i].getOwner() == currentPlayer)
                        {
                            tokenInArow++;

                            // Number of tokens in a row is 4, return winner.
                            if (tokenInArow == 4)
                            {
                                return currentPlayer;
                            }
                        }
                        else
                        {
                            count = 0;
                        }
                    }
                }
            }
        }

        */

        /*
        //returns winning player or null
        public Player hasWin()
        {
            Console.WriteLine("Game is not a draw");
            int lX = last.getPosition()[0];
            int lY = last.getPosition()[1];
            Player lastP = last.getOwner();

            int tokenInArow = 0;
            //
            Cell[,] cellcheck = { { cells[lX, lY-1], cells[lX, lY - 2], cells[lX, lY - 3] }, //down 0 -
                        { cells[lX, lY-1], cells[lX, lY - 2], cells[lX, lY - 3] }, //left           - 0
                        { cells[lX, lY-1], cells[lX, lY - 2], cells[lX, lY - 3] }, //right          + 0
                        { cells[lX, lY-1], cells[lX, lY - 2], cells[lX, lY - 3] }, //up left        - +
                        { cells[lX, lY-1], cells[lX, lY - 2], cells[lX, lY - 3] }, //up right       + +
                        { cells[lX, lY-1], cells[lX, lY - 2], cells[lX, lY - 3] }, //down left      - -
                        { cells[lX, lY-1], cells[lX, lY - 2], cells[lX, lY - 3] } };//down right    + -
            */
        /*
        for (int i = 0; i < 4; i++)
        {
            // Check if current token is owned by current player.
            if (cells[x, y - i].getOwner() == currentPlayer)
            {
                tokenInArow++;

                // Number of tokens in a row is 4, return winner.
                if (tokenInArow == 4) { return currentPlayer; }
            }
            // If the tokens don't match, the row is broken.
            else { tokenInArow = 0; }
        }
        //
        //=========================================================================================================
        for (int x = 0; x <= 6; x++) //loop x
        {
            for (int y = 0; y <= 5; y++) //loop y
            {
                Console.WriteLine("X: " + x + " Y: " + y);
                if (y >= 3) //space for checks down
                {
                    //---------------------------------------------------check down
                    for (int i = 0; i < 4; i++)
                    {
                        tokenInArow = 0;
                        // Check if current token is owned by current player.
                        if (cells[y - 1, x].getOwner() == currentPlayer)
                        {
                            tokenInArow++;

                            // Number of tokens in a row is 4, return winner.
                            if (tokenInArow == 4) { Console.WriteLine("WIN FOUND XY: " + x + y + " " + currentPlayer.getName()); return currentPlayer; }
                        }
                        // If the tokens don't match, the row is broken.
                        //else { tokenInArow = 0; }
                    }

                    if (x <= 3) //space for checks right
                    {
                        //-----------------------------------------------check +- diags
                        for (int i = 0; i < 4; i++)
                        {
                            tokenInArow = 0;
                            // Check if current token is owned by current player.
                            if (cells[y - i, x + i].getOwner() == currentPlayer)
                            {
                                tokenInArow++;

                                // Number of tokens in a row is 4, return winner.
                                if (tokenInArow == 4) { Console.WriteLine("WIN FOUND XY: " + x + y + " " + currentPlayer.getName()); return currentPlayer; }
                            }
                            // If the tokens don't match, the row is broken.
                            //else { tokenInArow = 0; }
                        }
                    }
                    if (x >= 3) //space for checks left
                    {
                        //-----------------------------------------------check -- diags
                        for (int i = 0; i < 4; i++)
                        {
                            tokenInArow = 0;
                            // Check if current token is owned by current player.
                            if (cells[y - i, x - i].getOwner() == currentPlayer)
                            {
                                tokenInArow++;

                                // Number of tokens in a row is 4, return winner.
                                if (tokenInArow == 4) { Console.WriteLine("WIN FOUND XY: " + x + y + " " + currentPlayer.getName()); return currentPlayer; }
                            }
                            // If the tokens don't match, the row is broken.
                            //else { tokenInArow = 0; }
                        }
                    }
                }
                if (x <= 3) //space for checks right
                {
                    //---------------------------------------------------check right
                    for (int i = 0; i < 4; i++)
                    {
                        tokenInArow = 0;
                        // Check if current token is owned by current player.
                        if (cells[y, x + i].getOwner() == currentPlayer)
                        {
                            tokenInArow++;

                            // Number of tokens in a row is 4, return winner.
                            if (tokenInArow == 4) { Console.WriteLine("WIN FOUND XY: " + x + y + " " + currentPlayer.getName()); return currentPlayer; }
                        }
                        // If the tokens don't match, the row is broken.
                        //else { tokenInArow = 0; }
                    }
                }

            }
        }
        //=========================================================================================================
        //
        // Do this 3 times.
        for (int i = 0; i < 3; i++)
        {
            //if last y 3+
            //check down
            //copy sides for diag

            //if last x 3-
            //check right
            //if last y 4-
            //up right diag

            //if last x 4+
            //check left
            //if last y 4-

            // Check if in index.
            if (lX - i >= 0 && lX - i <= 6)
            {
                // Check if they don't match.
                if (cells[lX - i, ].getOwner() != last.getOwner())
                {
                    // Return if they don't
                    return null;
                }
            }

        }
    */
        // Check Down, break if we do not find 3 or more like tokens.
        // Check Diagonals, break if we do not find 3 or more like tokens
        // Check Sides, break if we do not find 3 or more like tokens

        // Return Player on win.
        //
        // Returns true if the game is a draw
        public bool checkDraw()
        {
            int row = 0;
            int counter = 0;
            for (int col = 0; col < 7; col++)
            {
                if (cells[row, col].isTaken())
                {
                    counter++;
                }
            }
            if (counter == 7) {
                return true;
            }
            return false;
        }

        public Player hasWin()
        {
            int baseRow = last.getPosition()[0];
            int baseCol = last.getPosition()[1];
            Player winPlayer = last.getOwner();
            int count = 0;
            //We set these and check the whole line for a win. in case a win appears by slotting a piece in the middle 
            int topLeftRow = baseRow;
            int topLeftCol = baseCol;

            int topRightRow = baseRow;
            int topRightCol = baseCol;
            //[5,3]
            //[4,2]
            //[3,1]
            //[2,0]
            //END LOOP
            while (topLeftRow > 0 && topLeftCol > 0)
            {
                topLeftRow--;
                topLeftCol--;
            }
            //[5,3]
            //[4,4]
            //[3,5]
            //[2,6]
            //END LOOP
            while (topRightRow > 0 && topRightCol < 6)
            {
                topRightRow--;
                topRightCol++;
            }

            // Checking down
            for (int i = 0; i < 6; i++)
            {
                if (cells[i, baseCol].getOwner() == currentPlayer)
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                if (count == 4)
                {
                    Console.WriteLine("WIN FOUND");
                    return currentPlayer;
                }
            }
            count = 0;
            for (int i = 0; i < 7; i++)
            {
                if (cells[baseRow, i].getOwner() == currentPlayer)
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                if (count == 4)
                {
                    Console.WriteLine("WIN FOUND");
                    return currentPlayer;
                }
            }
            count = 0;
            while (topLeftRow < 6 && topLeftCol < 7)
            {
                if (cells[topLeftRow, topLeftCol].getOwner() == currentPlayer)
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                if (count == 4)
                {
                    Console.WriteLine("WIN FOUND");
                    return currentPlayer;
                }
                topLeftRow++;
                topLeftCol++;
            }
            count = 0;
            while (topRightRow < 6 && topRightCol >= 0)
            {
                if (cells[topRightRow, topRightCol].getOwner() == currentPlayer)
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                if (count == 4)
                {
                    Console.WriteLine("WIN FOUND");
                    return currentPlayer;
                }
                topRightRow++;
                topRightCol--;
            }
            return null;
        }

    }
}




































































































//GetHashCode









































































































































































































































































































































































































//no u