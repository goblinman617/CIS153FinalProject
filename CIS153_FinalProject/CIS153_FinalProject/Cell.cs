using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CIS153_FinalProject
{
    enum cellState
    {
        p1,
        p2,
        empty
    }

    class Cell
    {
        // Store cell position on the board.
        private int xPos;
        private int yPos;

        // Store a player, if selected.
        private Player currentOwner = null;

        //Constructor
        public Cell(int x, int y)
        {
            xPos = x;
            yPos = y;
        }

        // This function allows us to obtain the cell position, returns
        // an int[] index 0 = X; 1 = Y
        public int[] getPosition()
        {
            int[] posTable = { xPos, yPos };
            return posTable;

        }
    }
}

