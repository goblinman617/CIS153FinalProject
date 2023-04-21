using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_FinalProject
{
    class Board
    {

        // Game view so we can manipulate it here.
        private GameBoard view;

        // We want to store the players here.
        private Player playerOne;
        private Player playerTwo;

        // Stores which players turn it is.
        private Player currentPlayer;

        // Gamemode, needed for certain logic at game end.
        private String gamemode = null;


        private Cell[,] cells = new Cell[7, 6];
        private bool player1Turn = true; //flips when piece is added

        //Constructor
        public Board()
        {
            this.init();
        }

        public Board(GameBoard gameView)
        {
            this.view = gameView;
            this.init();


        }

        private void init()
        {
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 6; y++)
                {
                    cells[x, y] = new Cell(x, y);
                    Console.Write("X");
                }
                Console.WriteLine("");
            }
        }


        //Primary add piece method
        public void addPiece(int x) //from left starting at zero, 1 or 2 for playerNum
        {

        }

        public void consoleDisplay()
        {

        }

        //Getters
        public void getCell(int x, int y)
        {

        }

        //setters
        public void setCell(int x, int y, cellState c)
        { }
    }
}
