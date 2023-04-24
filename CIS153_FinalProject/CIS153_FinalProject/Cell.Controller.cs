using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;

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

        //abbreviated cellState
        private cellState state = cellState.empty;

        // The button we dynamically generate for this cell.
        private Button viewButton;

        //Constructor
        public Cell(int x, int y)
        {
            xPos = x;
            yPos = y;
        }

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
            flow.Controls.Add(viewButton);

            //click, enter, and leave event handlers
            //viewButton.Click += new EventHandler(Click);
            //viewButton.mouseEnter += new EventHandler(startHover);
            //viewButton.mouseLeave += new EventHandler(stopHover);
            //need to make these run stuff in gameboard view, painful un wiring

        }

       /* private void Click(object sender, EventArgs e)
        {

        }*/

        //getters and setters

        public cellState getState() { return state; }

        // This function allows us to obtain the cell position, returns
        // an int[] index 0 = X; 1 = Y
        public int[] getPosition()
        {
            int[] posTable = { xPos, yPos };
            return posTable;

        }

        public void setCellOwner(Player owner)
        {
            this.currentOwner = owner;
            if (owner != null) {
                viewButton.BackColor = owner.getColor();
            } else {
                viewButton.BackColor = Color.LightGray;
            }

        }

        public Player getOwner()
        {
            return currentOwner;
        }

        public void startHover(Player player)
        {
            
            Color c = player.getColor();

            // Alpha
            byte a = (byte)(127);

            //byte array ARGB
            byte[] c2 = {   a,
                            c.R,
                            c.G,
                            c.B };

            //update c from c2
            c = Color.FromArgb(c2[0], c2[1], c2[2], c2[3]);

            //make updated color background color
            viewButton.BackColor = c;

        }

        public void stopHover() //also grey but not changing the name
        {
            viewButton.BackColor = Color.LightGray;
        }

        public Boolean isTaken()
        {
            return currentOwner == null ? false : true;
        }

    }
}

