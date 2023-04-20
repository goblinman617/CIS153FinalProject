using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_FinalProject.Forms {
    public partial class EndScreen : Form {
        private StatsController statsController = new StatsController();
        private Window windowController;
        public EndScreen() {
            InitializeComponent();
        }

        public EndScreen(Window x, Player player1, Player player2 ,int winner) {// 0 = p1 win | 1 = p2 win | 2 = draw
            statsController.writeTextFile(winner);
            windowController = x;
            string p1Name = player1.getName();
            string p2Name = player2.getName();
            statsController.writeTextFile(winner);
            switch (winner) {
                case 0:
                    txt_display_winner.Text = "Congrats " + p1Name + ", You've won the game!\nReturn to main menu to play again or\nView your stats vs the AI";
                    break;
                case 1:
                    txt_display_winner.Text = "Congrats " + p2Name + ", You've won the game!\nReturn to main menu to play again or\nView your stats vs the AI";
                    break;
                case 3:
                    txt_display_winner.Text = "The Game is a draw!\nReturn to main menu to play again or\nview your stats vs the AI";
                    break;
                default:
                    Console.WriteLine("Something went wrong in the EndScreen");
                    break;
            }
            InitializeComponent();
        }
    }
}
