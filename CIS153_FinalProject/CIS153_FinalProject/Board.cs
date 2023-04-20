using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_FinalProject
{
    class Board {

        private Cell[,] cells = new Cell[6, 7];
        private bool player1Turn = true; //flips when piece is added

        //Constructor
        public Board() {
            for (int x = 0; x < 6; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    cells[x, y] = new Cell() ;
                }
            }

        }
    

        //Primary add piece method
        public void addPiece(int x) // starting at 0 going to 6
        {
            cellState player; //cellState to be written

            //set player cellstate from parameter p 
            if (player1Turn) { player = cellState.p1; }
            else { player = cellState.p2; }


            for (int row = 5; row >= 0; row--) {
                if (cells[row, x].getState() == cellState.empty) {
                    cells[row, x].setState(player);
                    break;
                }
            }

            player1Turn = !player1Turn;
        }

        public void consoleDisplay() {
            for (int row = 0; row < 6; row++) {
                for (int col = 0; col < 7; col++) {
                    if (cells[row, col].getState() == cellState.empty) {
                        Console.Write("_");
                    } else if (cells[row, col].getState() == cellState.p1) { //p1 = X
                        Console.Write("X");
                    } else if (cells[row, col].getState() == cellState.p2) { //p2 = O
                        Console.Write("O");
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
