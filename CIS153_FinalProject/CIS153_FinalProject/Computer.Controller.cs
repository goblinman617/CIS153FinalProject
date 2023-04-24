using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CIS153_FinalProject
{
    /*internal class Computer : Player
    {
        private Cell previousMove;
        private Cell opponetPreviousMove;
        private Board board;

        public Computer(string name, Color c) : base(name, c)
        {

        }

        public int GetNextMove(Board board, Func<int, Cell> setPlayerAsOwnerOfNextToken)
        {
            int height = 6;
            int width = 7;
            
        }

        private int playForWin() {
            Board temp = board;
            //for check all rows for a win and set move if the move wins
            for (int col = 0; col  < 7; col++)
            {
                temp.setPlayerAsOwnerOfNextToken(col);
                if(temp.getWinner() != null)
                {
                    return col;
                }
                temp = board;
            }

            return -1;
        }

        private int avoidLoss()
        {
            Board temp = board;
            temp.swapTurns(); //swap to check other player

            //for check all rows for a win and set move if the move wins
            for (int col = 0; col < 7; col++)
            {
                temp.setPlayerAsOwnerOfNextToken(col);
                if (temp.getWinner() != null)
                {
                    return col;
                }
                temp = board;
                temp.swapTurns(); //swap 2
            }

            return -1;
        }

        private int placeBetween() //place between computer pieces in middle columns
        {
            Board temp = board;
            Cell last = temp.getLast();
            Cell[,] cells = new Cell[6, 7];
            int lR = last.getPosition()[0];
            int lC = last.getPosition()[1];

            cells = temp.getCells();

            //for check all rows for nighboring cells to make 3 in a row
            for (int col = 1; col < 6; col++)
            {
                temp.setPlayerAsOwnerOfNextToken(col);
                last = temp.getLast();

                for (int i = 1; i > -2; i--)
                {
                    if (cells[lR + i, lC - 1].getOwner().getName() == "Computer" &&
                        cells[lR + i, lC - 1].getOwner().getName() == "Computer") { //if cells at position have computer owner

                        return col;

                    }
                }

                if (temp.getWinner() != null)
                {
                    return col;
                }
                temp = board;

            }

            return -1;
        }

        public void SetOpponetPreviousMove(Cell move)
        {
            opponetPreviousMove = move;
        }
    }*/
}
