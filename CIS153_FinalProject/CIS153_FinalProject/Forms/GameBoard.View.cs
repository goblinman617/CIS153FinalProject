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
        public GameBoard(string playerMode)
        {
            InitializeComponent();

            // Initalize window controller.
            this.windowController = null;

            board = new Board(this);

            // Dynamically build the buttons to the UI.
            buildButtons();
        }

        // Constructor with player mode and window controller.
        public GameBoard(string playerMode, Window windowController)
        {
            InitializeComponent();

            // Initalize window controller.
            this.windowController = windowController;

            board = new Board(this);

            // Dynamically build the buttons to the UI.
            buildButtons();
        }

        private void buildButtons()
        {
            this.gameFlowBox.Controls.Clear();

            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    Button btn = new Button();

                    btn.Size = new Size(75, 70);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;

                    if (true) //cell empty
                    {
                        btn.BackColor = Color.LightGray;
                    }
                    else if (false) //cell p1
                    {
                        btn.BackColor = playerOne.getColor();
                    }
                    else //cell p2
                    {
                        btn.BackColor = playerTwo.getColor();
                    }

                    this.gameFlowBox.Controls.Add(btn);
                }
            }
        }

        // Anything that needs to be initliaze before the board is displayed.
        public void init()
        {
            this.playerOneLabel.Text = playerOne.getName();
            this.playerOneColor.BackColor = playerOne.getColor();

            this.playerTwoLabel.Text = playerTwo.getName();
            this.playerTwoColor.BackColor = playerTwo.getColor();

            // Set player one as the current player.
            this.setPlayersTurn(playerOne);
        }

        // Sets & Updates which player's turn it is.
        private void setPlayersTurn(Player player)
        {

            this.turnLine.Text = player.getName() + ", it's your turn!";
        }

        // Player one & two getters
        public void setPlayerOne(Player value)
        {
            this.playerOne = value;
        }

        public void setPlayerTwo(Player value)
        {
            this.playerTwo = value;
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

        private void columnOneSelect_Click(object sender, EventArgs e)
        {
            board.addPiece(0);
            //getNextSpotInColumn(0, this.currentPlayersTurn);
            buildButtons();
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
            board.addPiece(0);
            buildButtons();
        }

        private void btn_row_1_Click(object sender, EventArgs e)
        {
            board.addPiece(1);
            buildButtons();
        }

        private void btn_row_2_Click(object sender, EventArgs e)
        {
            board.addPiece(2);
            buildButtons();
        }

        private void btn_row_3_Click(object sender, EventArgs e)
        {
            board.addPiece(3);
            buildButtons();
        }

        private void btn_row_4_Click(object sender, EventArgs e)
        {
            board.addPiece(4);
            buildButtons();
        }

        private void btn_row_5_Click(object sender, EventArgs e)
        {
            board.addPiece(5);
            buildButtons();
        }

        private void btn_row_6_Click(object sender, EventArgs e)
        {
            board.addPiece(6);
            buildButtons();
        }
    }
}
