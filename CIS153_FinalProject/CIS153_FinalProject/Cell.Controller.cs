using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

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

        // The button we dynamically generate for this cell.
        private Button viewButton;

        //Constructor
        public Cell(int x, int y)
        {
            xPos = x;
            yPos = y;
        }

        // Initalize the UI components for cell.
        public void initView(FlowLayoutPanel flow)
        {
            viewButton = new Button();

            // Style Properties
            viewButton.Size = new Size(75, 70);
            viewButton.FlatStyle = FlatStyle.Flat;
            viewButton.FlatAppearance.BorderSize = 0;

            // Setting Cell Color
            if (currentOwner == null)
            {
                viewButton.BackColor = Color.LightGray;
            }
            else
            {
                viewButton.BackColor = currentOwner.getColor();
            }

            viewButton.Text = xPos + ":::" + yPos;

            flow.Controls.Add(viewButton);

        }

        // This function allows us to obtain the cell position, returns
        // an int[] index 0 = X; 1 = Y
        public int[] getPosition()
        {
            int[] posTable = { xPos, yPos };
            return posTable;

        }

        // Set player as the cell owner & update color.
        public void setCellOwner(Player owner)
        {
            this.currentOwner = owner;
            viewButton.BackColor = owner.getColor();

        }

        public Player getOwner()
        {
            return currentOwner;
        }

        public Boolean isTaken()
        {
            return currentOwner == null ? false : true;
        }
    }
}

