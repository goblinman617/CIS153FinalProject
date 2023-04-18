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
        private Game gameSession = new Game();
        private Window windowController;
        private Player[,] board = new Player[6, 7];
        private Player currentPlayersTurn = null;

        // Assign Player Varibles
        Player playerOne;
        Player playerTwo;

        // Constructor without window controller.
        public GameBoard(string playerMode)
        {
            InitializeComponent();
            Console.WriteLine(playerMode);
            buildButtons();
        }

        // Constructor with player mode and window controller.
        public GameBoard(string playerMode, Window windowController)
        {
            InitializeComponent();
            Console.WriteLine(playerMode);
            this.windowController = windowController;
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

                    if (board[row, col] == null)
                    {
                        btn.BackColor = Color.LightGray;
                    }

                    if (board[row, col] != null)
                    {
                        btn.BackColor = Color.Firebrick;
                    }

                    this.gameFlowBox.Controls.Add(btn);
                }
            }
        }

        // Anything that needs to be initliaze before the board is displayed.
        public void init()
        {
            this.playerOneLabel.Text = playerOne.getName();
            this.playerTwoLabel.Text = playerTwo.getName();

            // Set player one as the current player.
            this.setPlayersTurn(playerOne);
        }

        // Sets & Updates which player's turn it is.
        private void setPlayersTurn(Player player)
        {
            this.currentPlayersTurn = player;

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
        private void getNextSpotInColumn(int column, Player p)
        {
            for (int r = 6; r > 0; r--)
            {
                if (board[r - 1, column] == null)
                {
                    board[r - 1, column] = p;
                    return;
                }

            }
        }

        private void columnOneSelect_Click(object sender, EventArgs e)
        {
            getNextSpotInColumn(0, this.currentPlayersTurn);
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
    }
}
