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
            if (p == 1)
            {
                cells[x, 5].setState(cellState.p1);
            }
            else if (p == 2)
            {
                cells[x, 5].setState(cellState.p2);
            }
            else
            {
                Console.WriteLine("Board.addPiece: invalid player number");
                return;
            }

            //Gravity
            for (int i = 5; cells[x, i-1].getState() != cellState.empty || i < 0; i++)
            {
                cells[x, i - 1].setState(cells[x, i].getState());
            }
        }

        //Getters
        public cellState getCell(int x, int y) //from bottom left starting at zero
        {
            return cells[x, y].getState();
        }

        //setters
        public void setCell(int x, int y, cellState c) //from bottom left starting at zero
        { cells[x, y].setState(c); }
    }
}
