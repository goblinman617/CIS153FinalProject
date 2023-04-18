using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_FinalProject
{
    class Board
    {
        private Cell[,] cells = new Cell[7, 6];
            

        //Constructor
        public Board()
        {
            
        }

        //Primary add piece method
        public void addPiece(int x, int p) //from left starting at zero, 1 or 2 for playerNum
        {
            cellState player; //cellState to be written

            //set player cellstate from parameter p 
            if (p == 1)
            {
                player = cellState.p1;
            }
            else if (p == 2)
            {
                player = cellState.p2;
            }
            else
            {
                Console.WriteLine("Board.addPiece: invalid player number");
                return;
            }
            // A lot simpler way to do.
            for (int i = 5; i >= 0; i--) {
                if (cells[i, x].getState() == cellState.empty) {
                    cells[i, x].setState(player);
                    break;
                }
            }

            ////Gravity
            //for (int i = 5; cells[x, i].getState() == cellState.empty || i > 1; i++) //start at top, do not run for bottom piece or if current cell is filled
            //{
            //    if (cells[x, i-1].getState() != cellState.empty) //if the cell below checked isn't empty
            //    {
            //        cells[x, i].setState(player); //set player piece
            //    }
            //}
        }

        //Getters
        public cellState getCell(int x, int y) //from top left starting at zero
        {
            return cells[x, y].getState();
        }

        //setters
        public void setCell(int x, int y, cellState c) //from top left starting at zero
        { cells[x, y].setState(c); }
    }
}
