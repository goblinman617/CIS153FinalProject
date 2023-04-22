﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            if (gameMode == "single") {
                playerOne = new Player("Player", Color.Firebrick);
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
            Console.WriteLine(board.setPlayerAsOwnerOfNextToken(0));
            setPlayersTurn(this.board.getCurrentPlayer());
        }

        private void btn_row_1_Click(object sender, EventArgs e)
        {
            board.setPlayerAsOwnerOfNextToken(1);
            setPlayersTurn(this.board.getCurrentPlayer());
        }

        private void btn_row_2_Click(object sender, EventArgs e)
        {
            board.setPlayerAsOwnerOfNextToken(2);
            setPlayersTurn(this.board.getCurrentPlayer());
        }

        private void btn_row_3_Click(object sender, EventArgs e)
        {
            board.setPlayerAsOwnerOfNextToken(3);
            setPlayersTurn(this.board.getCurrentPlayer());
        }

        private void btn_row_4_Click(object sender, EventArgs e)
        {
            board.setPlayerAsOwnerOfNextToken(4);
            setPlayersTurn(this.board.getCurrentPlayer());
        }

        private void btn_row_5_Click(object sender, EventArgs e)
        {
            board.setPlayerAsOwnerOfNextToken(5);
            setPlayersTurn(this.board.getCurrentPlayer());
        }

        private void btn_row_6_Click(object sender, EventArgs e)
        {
            board.setPlayerAsOwnerOfNextToken(6);
            setPlayersTurn(this.board.getCurrentPlayer());
        }
    }
}
