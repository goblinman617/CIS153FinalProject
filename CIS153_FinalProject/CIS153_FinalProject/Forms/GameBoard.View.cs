using CIS153_FinalProject.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_FinalProject
{
    public partial class GameBoard : Form
    {
        // Window Controller initalized by the constructor.
        //
        private Window windowController;

        // Create a new board controller.
        private Board board;

        // Keep track of active players.
        private Player playerOne;
        private Player playerTwo;

        // Constructor with player mode and window controller.
        public GameBoard(string gameMode)
        {
            InitializeComponent();

            // Initalize window controller.
            this.windowController = null;

            board = new Board(this, this.gameFlowBox);

            board.setGamemode(gameMode);

        }

        // Constructor with player mode and window controller.
        public GameBoard(string gameMode, Window windowController)
        {
            InitializeComponent();

            // Initalize window controller.
            this.windowController = windowController;

            board = new Board(this, this.gameFlowBox);

            board.setGamemode(gameMode);

            if (gameMode == "single")
            {
                playerOne = new Player("Player #1", Color.Firebrick);
                playerTwo = new Player("Computer", Color.Orange);
                board.setPlayerOne(playerOne);
                board.setPlayerTwo(playerTwo);
                init();
            }
        }

        // Anything that needs to be initliaze before the board is displayed.
        public void init()
        {
            this.playerOneLabel.Text = this.board.getPlayerOne().getName();
            this.playerOneColor.BackColor = this.board.getPlayerOne().getColor();

            this.playerTwoLabel.Text = this.board.getPlayerTwo().getName();
            this.playerTwoColor.BackColor = this.board.getPlayerTwo().getColor();

            // Set player one as the current player.
            this.setPlayersTurn(this.board.getPlayerOne());


        }

        public void playAgain()
        {
            GameBoard newBoard = new GameBoard(board.getGamemode(), windowController);

            // Set players as the same people.
            newBoard.setPlayerOne(board.getPlayerOne());
            newBoard.setPlayerTwo(board.getPlayerTwo());

            // Initalize the board.
            newBoard.init();

            // Set view.
            windowController.setView(newBoard);
        }

        public void reviewBoard() 
        {
            btn_row_0.Hide();
            btn_row_1.Hide();
            btn_row_2.Hide();
            btn_row_3.Hide();
            btn_row_4.Hide();
            btn_row_5.Hide();
            btn_row_6.Hide();
            linkLabel1.Text = "<-- Go back";
        }


        // Sets & Updates which player's turn it is.
        public void setPlayersTurn(Player player)
        {

            this.turnLine.Text = player.getName() + ", it's your turn!";
        }

        // Player one & two getters
        public void setPlayerOne(Player value)
        {

            this.board.setPlayerOne(value);
        }

        public void setPlayerTwo(Player value)
        {
            this.board.setPlayerTwo(value);
        }

        // Back button
        private void backButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            windowController.goBack();
        }

        // Find the next open spot in a column.
        /*private void getNextSpotInColumn(int column, Player p)
        {
            for (int r = 6; r > 0; r--)
            {
                if (board.getCell(column, r-1) != cellState.empty)
                {
                    //board[r - 1, column] = p;
                    return;
                }

            }
        }*/

        private void columnOneSelect_Click(object sender, EventArgs e) // Does this exist?
        {
            //board.addPiece(0);
            //getNextSpotInColumn(0, this.currentPlayersTurn);
        }

        private void playerTwoLabel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void playerOneLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_row_0_Click(object sender, EventArgs e)
        {
            board.setPlayerAsOwnerOfNextToken(0);
            endCheck();
            setPlayersTurn(this.board.getCurrentPlayer());
            board.getSimpleCells();
        }

        private void btn_row_1_Click(object sender, EventArgs e)
        {
            board.setPlayerAsOwnerOfNextToken(1);
            endCheck();
            setPlayersTurn(this.board.getCurrentPlayer());
        }

        private void btn_row_2_Click(object sender, EventArgs e)
        {
            board.setPlayerAsOwnerOfNextToken(2);
            endCheck();
            setPlayersTurn(this.board.getCurrentPlayer());
        }

        private void btn_row_3_Click(object sender, EventArgs e)
        {
            board.setPlayerAsOwnerOfNextToken(3);
            endCheck();
            setPlayersTurn(this.board.getCurrentPlayer());
        }

        private void btn_row_4_Click(object sender, EventArgs e)
        {
            board.setPlayerAsOwnerOfNextToken(4);
            endCheck();
            setPlayersTurn(this.board.getCurrentPlayer());
        }

        private void btn_row_5_Click(object sender, EventArgs e)
        {
            board.setPlayerAsOwnerOfNextToken(5);
            endCheck();
            setPlayersTurn(this.board.getCurrentPlayer());
        }

        private void btn_row_6_Click(object sender, EventArgs e)
        {
            board.setPlayerAsOwnerOfNextToken(6);
            endCheck();
            setPlayersTurn(this.board.getCurrentPlayer());
        }

        private void endCheck()
        {
            Player winner = board.getWinner();
            int statsHelper = 3;
            if (board.getWinner() != null)
            {
                if (board.getGamemode() == "single")
                {
                    if (winner.getName() == "Computer")
                    {
                        statsHelper = 1;
                    }
                    else
                    {
                        statsHelper = 0;
                    }
                    windowController.setView(new EndScreen(windowController, statsHelper, winner.getName(), this));
                }
                else
                {
                    windowController.setView(new EndScreen(windowController, statsHelper, winner.getName(), this));
                }
            }
            if (board.checkDraw())
            {
                if (board.getGamemode() == "single")
                {
                    statsHelper = 2;
                }
                windowController.setView(new EndScreen(windowController, statsHelper, "", this));
            }
        }

        //start hover
        private void btn_row_0_MouseEnter(object sender, EventArgs e) { board.startHover(0); }
        private void btn_row_1_MouseEnter(object sender, EventArgs e) { board.startHover(1); }
        private void btn_row_2_MouseEnter(object sender, EventArgs e) { board.startHover(2); }
        private void btn_row_3_MouseEnter(object sender, EventArgs e) { board.startHover(3); }
        private void btn_row_4_MouseEnter(object sender, EventArgs e) { board.startHover(4); }
        private void btn_row_5_MouseEnter(object sender, EventArgs e) { board.startHover(5); }
        private void btn_row_6_MouseEnter(object sender, EventArgs e) { board.startHover(6); }

        //stop hover

        private void btn_row_0_MouseLeave(object sender, EventArgs e) { board.stopHover(0); }
        private void btn_row_1_MouseLeave(object sender, EventArgs e) { board.stopHover(1); }
        private void btn_row_2_MouseLeave(object sender, EventArgs e) { board.stopHover(2); }
        private void btn_row_3_MouseLeave(object sender, EventArgs e) { board.stopHover(3); }
        private void btn_row_4_MouseLeave(object sender, EventArgs e) { board.stopHover(4); }
        private void btn_row_5_MouseLeave(object sender, EventArgs e) { board.stopHover(5); }
        private void btn_row_6_MouseLeave(object sender, EventArgs e) { board.stopHover(6); }

    }
}
