using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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

        //computer object
        //private Computer computer;

        // Stores which players turn it is.
        private Player currentPlayer;

        // Gamemode, needed for certain logic at game end.
        private String gamemode = null;

        // Last placed cell
        private Cell last = null;

        //winner
        private Player winner = null;

        //old board for ai moves, actually just itself
        //private Board old = new Board();

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
            //if (currentPlayer == null) { currentPlayer = playerOne; }

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

                    swapTurns();             // Swap players.
                    return cells[row, column];
                }


            }

            return null;
        }

        public int doAI(Board b)
        {
            int move = -1;
            if (playForWin(b) != -1) //rule 1
            {
                move = playForWin(b);
                Console.WriteLine("move: " + move);
                return move;
            }
            if (avoidLoss(b) != -1) //rule 2
            {
                move = avoidLoss(b);
                Console.WriteLine("move: " + move);
                return move;

            }
            if (placeBetween(b) != -1)
            {
                move = placeBetween(b);
                Console.WriteLine("move: " + move);
                return move;
            }
            if (placeRandom(b) != -1)
            {
                move = placeRandom(b);
                Console.WriteLine("move: " + move);
                return move;
            }

            currentPlayer = playerOne;

            return -1;

            Console.WriteLine("move: " + move);
        }
        /*for (int r = height - 1; r >= 0; r--)
        {
            for (int c = 0; c < 7; c++)
            {
                int numofLikeTokens = 0;
                for (int i = 0; i < 4; i++)
                {
                    if (board.getCells()[r, c].getOwner() != null)
                    {
                        if (board.getCells()[r, c].getOwner() != null && board.getCells()[r, c].getOwner() == board.getCells()[r - i, c].getOwner())
                        {
                            numofLikeTokens++;
                        }
                    }
                    else
                    {
                        numofLikeTokens = 0;
                    }
                }
                Console.WriteLine(numofLikeTokens);
            }
        }*/

    

        private int playForWin(Board b)
        {
            for (int col = 0; col < 7; col++) {

                if (b.setPlayerAsOwnerOfNextToken(col) != null) { //swap to player turn
                    if (b.getWinner() != null) {
                        return col;
                    }
                    removeLastPiece();
                    swapTurns(); //swap back to ai turn
                }
            }
            return -1; //end on AI turn
        }

        private int avoidLoss(Board b)
        {
            b.swapTurns(); //swap to Players turn

            //for check all rows for a win and set move if the move wins
            for (int col = 0; col < 7; col++)
            {
                b.setPlayerAsOwnerOfNextToken(col); //swapped to CPU turn
                if (b.getWinner() != null)
                {
                    return col;
                }

                //reset temp and swap
                b.removeLastPiece(); //need in both
                b.swapTurns(); //swap to players turn
            }
            b.swapTurns(); //swap to 
            return -1;
        }

        private int placeBetween(Board b) //place between computer pieces in middle columns
        {

            //Cell last = b.getLast();
            Cell[,] tempCells = new Cell[6, 7];
            int lR;
            int lC;

            tempCells = b.getCells();


            for (int col = 1; col < 5; col++)
            {

                b.setPlayerAsOwnerOfNextToken(col);

                lR = b.getLast().getPosition()[0];
                lC = b.getLast().getPosition()[1];

                last = b.getLast();
                if (lR < 5)
                {
                    for (int i = 1; i > -2; i--)
                    {
                        if (cells[lR + i, lC - 1].isTaken() && //don't check if both arent fun
                            cells[lR + i, lC + 1].isTaken())
                        {
                            if (cells[lR + i, lC - 1].getOwner().getName() == "Computer" && //if both sides are computer make 3 in checked col
                                cells[lR + i, lC + 1].getOwner().getName() == "Computer")
                            { //if cells at position have computer owner

                                return col;

                            }
                        }
                            
                    }
                }
                    
                b.removeLastPiece();

                //temp = b;

            }

            return -1;
        }

        private int placeRandom(Board b)
        {
            Random r = new Random();
<<<<<<< Updated upstream
            int change = r.Next(-2, 2);

            if (lastCol + change >= 0 && lastCol + change <= 6)
=======
            int change = r.Next(-2,2);
            
            if (2 + change >= 0 && 2 + change <= 6)
>>>>>>> Stashed changes
            {
                if (b.setPlayerAsOwnerOfNextToken(2 + change) != null)
                {
<<<<<<< Updated upstream
                    Console.WriteLine(lastCol);
                    Console.WriteLine(change);

                    return lastCol + change;
=======
                    
                    return 2 + change;
>>>>>>> Stashed changes
                }
            }
            for (int i = 0; i < 7; i++)
            {
                if (b.setPlayerAsOwnerOfNextToken(i) != null)
                {
                    return i;
                }
            }
            return 1;
        }

        // Swap players turn.
        public void swapTurns()
        {
            if (currentPlayer == playerOne)
            {
                currentPlayer = playerTwo;
            }
            else
            {
                currentPlayer = playerOne;
            }
        }

        //start hover
        public void startHover(int col)
        {
            for (int row = 5; row >= 0; row--)
            {
                if (!cells[row, col].isTaken())
                {
                    cells[row, col].startHover(currentPlayer);
                    row = -1; //stop looping
                }
            }
        }

        //stop hover
        public void stopHover(int col)
        {
            for (int row = 5; row >= 0; row--)
            {
                if (!cells[row, col].isTaken())
                {
                    cells[row, col].stopHover();
                    row = -1; //stop looping
                }
            }
        }

        /* Getters  Setters */

        public void setGamemode(String mode)
        {
            this.gamemode = mode;
        }
        public string getGamemode()
        {
            return gamemode;
        }
        public Player getWinner()
        {
            return winner;
        }
        // Set the players for the board.
        public void setPlayerOne(Player value)
        {
            this.playerOne = value;
            currentPlayer = playerOne;
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

        public Cell[,] getCells()
        {
            return this.cells;
        }

        public int[,] getSimpleCells() //1 is player 1, 2 is player 2, 0 is empty
        {
            int[,] sCells = new int[6, 7];

            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 6; y++)
                {
                    if (cells[y, x].getOwner() == playerOne)
                    {
                        sCells[y, x] = 1;
                    }
                    else if (cells[y, x].getOwner() == playerTwo)
                    {
                        sCells[y, x] = 2;
                    }
                    else
                    {
                        sCells[y, x] = 0;
                    }
                }
            }

            return sCells;
        }

        public Cell getLast()
        {
            return this.last;
        }


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
            if (counter == 7)
            {
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

        private void removeLastPiece()
        {
            getLast().setCellOwner(null);
        }

    }
}


//for check all rows for a win and set move if the move wins
/*for (int col = 0; col < 7; col++)
{
    b.setPlayerAsOwnerOfNextToken(col); //swap to player turn
    if (b.getWinner() != null)
    {
        return col;
    }
    removeLastPiece();
    swapTurns(); //swap back to ai turn
}

return -1;*/












































































































































































































































































































































































































































































































//no u