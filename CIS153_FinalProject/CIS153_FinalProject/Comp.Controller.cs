using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_FinalProject {
    internal class Comp {




        // Constructor
        public Comp() {

        }

        public void doAI(Board b) {
            int move = -1;

            if (playForWin(b) != -1) //rule 1
            {
                move = playForWin(b);
            } else if (avoidLoss(b) != -1) //rule 2
              {
                move = avoidLoss(b);
            } else if (placeBetween(b) != -1) {
                move = placeBetween(b);
            }

            //setPlayerAsOwnerOfNextToken(move);

            Console.WriteLine("move: " + move);
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

        }

        private int playForWin(Board b) {
            Board temp = b;
            //for check all rows for a win and set move if the move wins
            for (int col = 0; col < 7; col++) {
                temp.setPlayerAsOwnerOfNextToken(col);
                if (temp.getWinner() != null) {
                    return col;
                }
                temp = b;
            }

            return -1;
        }

        private int avoidLoss(Board b) {
            Board temp = b;
            temp.swapTurns(); //swap to check other player

            //for check all rows for a win and set move if the move wins
            for (int col = 0; col < 7; col++) {
                temp.setPlayerAsOwnerOfNextToken(col);
                if (temp.getWinner() != null) {
                    return col;
                }

                //reset temp and swap
                temp = b;
                temp.swapTurns(); //swap 2
            }

            return -1;
        }

        private int placeBetween(Board b) //place between computer pieces in middle columns
        {
            Board temp = b;
            Cell last = temp.getLast();
            Cell[,] cells = new Cell[6, 7];
            int lR = last.getPosition()[0];
            int lC = last.getPosition()[1];

            cells = temp.getCells();

            //for check all rows for nighboring cells to make 3 in a row
            for (int col = 1; col < 6; col++) {
                temp = b;
                temp.setPlayerAsOwnerOfNextToken(col);
                last = temp.getLast();

                for (int i = 1; i > -2; i--) {
                    if (cells[lR + i, lC - 1].getOwner().getName() == "Computer" &&
                        cells[lR + i, lC - 1].getOwner().getName() == "Computer") { //if cells at position have computer owner

                        return col;

                    }
                }

                if (temp.getWinner() != null) {
                    return col;
                }
                //temp = b;

            }

            return -1;
        }
    }
}
