﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_FinalProject.Forms
{
    public partial class TwoPlayer : Form
    {
        private Window windowController;

        ColorDialog player1Color = new ColorDialog();
        ColorDialog player2Color = new ColorDialog();

        public TwoPlayer(Window value)

        {
            InitializeComponent();
            windowController = value;

            player1Color.Color = Color.Firebrick;
            player2Color.Color = Color.Orange; //default color, add .backcolor to change, currently in design
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            windowController.goBack();
        }

        private void readyButton_Click(object sender, EventArgs e)
        {
            string _playerOneName = this.playerOneName.Text;
            string _playerTwoName = this.playerTwoName.Text;

            Color playerOneColor = this.player1Color.Color;
            Color playerTwoColor = this.player2Color.Color;

            // Make sure all names are there.
            if (string.IsNullOrEmpty(_playerOneName) || string.IsNullOrEmpty(_playerTwoName))
            {
                this.errorLabel.Visible = true;
                this.errorLabel.Text = "Whoa! We are missing a players name.";
                return;
            }

            // Generate new game session.
            GameBoard gameBoard = new GameBoard("multi", windowController);

            // Set player one and two for the game.
            gameBoard.setPlayerOne(new Player(_playerOneName, playerOneColor));
            gameBoard.setPlayerTwo(new Player(_playerTwoName, playerTwoColor));


            // Prep game board before displaying to the user.

            gameBoard.init();
            // Set players here.

            windowController.setView(gameBoard);
        }

        private void btn_color_p2_Click(object sender, EventArgs e)
        {
            
            player2Color.ShowDialog();
            btn_color_p2.BackColor = player2Color.Color;
        }

        private void btn_color_p1_Click(object sender, EventArgs e)
        {
            
            player1Color.ShowDialog();
            btn_color_p1.BackColor = player1Color.Color;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
