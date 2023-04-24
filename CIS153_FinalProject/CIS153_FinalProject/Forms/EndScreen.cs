using System;
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
    public partial class EndScreen : Form
    {
        GameBoard boardView;

        StatsController statsController = new StatsController();
        Window windowController;
        public EndScreen()
        {
            InitializeComponent();
        }
        // Currently we are passing a lot of stuff. I'm not sure exactly how it will work so we can
        public EndScreen(Window controller, int winner, string winnerName, GameBoard boardView)
        { // Pass an int for whoever has won the game, 0 = p1 win, 1 = p2 win, 2 = draw, 3 = NO WINNER TO BE ASSIGNED AKA 2 PLAYER GAME
            InitializeComponent();

            this.boardView = boardView;

            windowController = controller;

            switch (winner)
            {
                case 0:
                    statsController.writeTextFile(winner);
                    txt_display_winner.Text = "Awesome! " + winnerName + " has won the game!";
                    break;
                case 1:
                    statsController.writeTextFile(winner);
                    txt_display_winner.Text = "Booooo! The Computer won the game.";
                    break;
                case 2:
                    statsController.writeTextFile(winner);
                    txt_display_winner.Text = "The game ended in a draw, try again?";
                    break;
                default:
                    txt_display_winner.Text = "Unknown Game Result.";
                    break;
            }

            if (winnerName == "")
            {
                txt_display_winner.Text = "The game ended in a draw, try again?!";
            }
        }

        public EndScreen(Window controller, int winner, string winnerName)
        { // Pass an int for whoever has won the game, 0 = p1 win, 1 = p2 win, 2 = draw, 3 = NO WINNER TO BE ASSIGNED AKA 2 PLAYER GAME
            InitializeComponent();

            windowController = controller;

            switch (winner)
            {
                case 0:
                    statsController.writeTextFile(winner);
                    txt_display_winner.Text = "Awesome! " + winnerName + " has won the game!";
                    break;
                case 1:
                    statsController.writeTextFile(winner);
                    txt_display_winner.Text = "Booooo! The Computer won the game.";
                    break;
                case 2:
                    statsController.writeTextFile(winner);
                    txt_display_winner.Text = "The game ended in a draw, try again?";
                    break;
                default:
                    txt_display_winner.Text = "Unknown Game Result.";
                    break;
            }

            if (winnerName == "")
            {
                txt_display_winner.Text = "The game ended in a draw, try again?!";
            }
        }

        private void btn_main_menu_Click(object sender, EventArgs e)
        {
            windowController.setView(new Main_Menu());
        }

        private void btn_stats_Click(object sender, EventArgs e)
        {
            windowController.setView(new Stats(windowController));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.boardView != null)
            {
                this.boardView.playAgain();
            }
        }

        private void btn_review_game_Click(object sender, EventArgs e)
        {
            if (this.boardView != null)
            {
                this.boardView.reviewBoard();
                windowController.goBack();
            }
        }
    }
}
