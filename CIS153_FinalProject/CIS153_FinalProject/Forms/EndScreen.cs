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
        Action _playAgain;

        StatsController statsController = new StatsController();
        Window windowController;
        public EndScreen()
        {
            InitializeComponent();
        }
        // Currently we are passing a lot of stuff. I'm not sure exactly how it will work so we can
        public EndScreen(Window controller, int winner, string winnerName, Action playAgain)
        { // Pass an int for whoever has won the game, 0 = p1 win, 1 = p2 win, 2 = draw, 3 = NO WINNER TO BE ASSIGNED AKA 2 PLAYER GAME
            InitializeComponent();

            _playAgain = playAgain;

            windowController = controller;
            if (winner == 0)
            { // probably find a better way 
                statsController.writeTextFile(winner);
                txt_display_winner.Text = winnerName + " has won the game!";
            }
            else if (winner == 1)
            {
                statsController.writeTextFile(winner);
                txt_display_winner.Text = "The AI has won the game!";
            }
            else if (winner == 2)
            {
                statsController.writeTextFile(winner);
                txt_display_winner.Text = "The game is a draw!";
            }
            else if (winnerName == "")
            {
                txt_display_winner.Text = "The game is a draw!";
            }
            else
            {
                txt_display_winner.Text = winnerName + " has won the game!";
            }
        }

        public EndScreen(Window controller, int winner, string winnerName)
        { // Pass an int for whoever has won the game, 0 = p1 win, 1 = p2 win, 2 = draw, 3 = NO WINNER TO BE ASSIGNED AKA 2 PLAYER GAME
            InitializeComponent();

            windowController = controller;
            if (winner == 0)
            { // probably find a better way 
                statsController.writeTextFile(winner);
                txt_display_winner.Text = winnerName + " has won the game!";
            }
            else if (winner == 1)
            {
                statsController.writeTextFile(winner);
                txt_display_winner.Text = "The AI has won the game!";
            }
            else if (winner == 2)
            {
                statsController.writeTextFile(winner);
                txt_display_winner.Text = "The game is a draw!";
            }
            else if (winnerName == "")
            {
                txt_display_winner.Text = "The game is a draw!";
            }
            else
            {
                txt_display_winner.Text = winnerName + " has won the game!";
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
            if (this._playAgain != null)
            {
                this._playAgain();
            }
        }
    }
}
