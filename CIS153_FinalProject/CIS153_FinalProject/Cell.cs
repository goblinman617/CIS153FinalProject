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
        
        private cellState state = cellState.empty;

        //Constructor
        public Cell()
        {
            this.state = cellState.empty;
        }

        //Getters
        public cellState getState()
        { return state; }

        //Setters 
        public void setState(cellState s)
        { state = s; }

    }
}

