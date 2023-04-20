using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_FinalProject
{
    class Board {

        private Cell[,] cells = new Cell[7, 6];
        private bool player1Turn = true; //flips when piece is added

        //Constructor
        public Board() {
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 6; y++)
                {
                    cells[x, y] = new Cell() ;
                }
            }

        }
    

        //Primary add piece method
        public void addPiece(int x) //from left starting at zero, 1 or 2 for playerNum
        {
            cellState player; //cellState to be written

            //set player cellstate from parameter p 
            if (player1Turn) { player = cellState.p1; }
            else { player = cellState.p2; }

            // A lot simpler way to do.
            if (cells[x, 0].getState() == cellState.empty)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (cells[x, i + 1].getState() != cellState.empty)
                    {
                        cells[x, i].setState(player);
                        break;
                    }
                }
            }
            

            if (cells[x, 5].getState() == cellState.empty) { cells[x, 5].setState(player); } //if loop finds nothing existing

            ////Gravity
            //for (int i = 5; cells[x, i].getState() == cellState.empty || i > 1; i++) //start at top, do not run for bottom piece or if current cell is filled
            //{
            //    if (cells[x, i-1].getState() != cellState.empty) //if the cell below checked isn't empty
            //    {
            //        cells[x, i].setState(player); //set player piece
            //    }
            //}

            player1Turn = !player1Turn;
        }

        public void consoleDisplay() {
            for (int row = 0; row < 5; row++) {
                for (int col = 0; col < 7; col++) {
                    if (cells[row, col].getState() == cellState.empty) {
                        Console.Write("E");
                    } else if (cells[row, col].getState() == cellState.p1) {
                        Console.Write("p1");
                    } else if (cells[row, col].getState() == cellState.p2) {
                        Console.Write("p2");
                    }
                }
                Console.Write("\n");
            }
        }

        //Getters
        public cellState getCell(int x, int y)
        {
            return cells[x, y].getState();
        }

        //setters
        public void setCell(int x, int y, cellState c)
        { cells[x, y].setState(c); }
    }
}
