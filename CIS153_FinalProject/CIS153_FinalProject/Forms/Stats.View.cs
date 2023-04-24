using CIS153_FinalProject.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_FinalProject
{
    public partial class Stats : Form
    {
        private MatchHistory info = new MatchHistory();
        private Window windowController;
        private StatsController statsController = new StatsController();
        public Stats()
        {
            InitializeComponent();
        }
        public Stats(Window x)
        {
            InitializeComponent();
            windowController = x;
            statsController.readTextFile(info);
            updateDisplay(info);
        }
        private void updateDisplay(MatchHistory info)
        {
            // Fill all the blank spots that need to be filled
            txt_total_games.Text = TotalGamesTextFactory();
            txt_player_win_p.Text = PlayerWinPercentageFactory();
            txt_draw_p.Text = DrawPercentageFactory();
            txt_ai_win_p.Text = ComputerWinPercentageFactory();
        }

        private void btn_to_menu_Click(object sender, EventArgs e)
        {
            windowController.setView(new Main_Menu());
        }

        // TotalGamesTextFactory
        private string TotalGamesTextFactory()
        {
            double numOfGames = info.getTotalGames();

            if (numOfGames > 25)
            {
                return "You have played a total of " + numOfGames.ToString() + " games, you must be good!";
            }

            return "You have only played a total of " + numOfGames.ToString() + " games, gotta keep playing!!";
        }

        // Factory for player win numbers.
        private string PlayerWinPercentageFactory()
        {
            double numOfWinsPercent = Math.Round(info.getPWinPercent(), 2);
            double numOfWins = info.getPlayerWins();

            return "You have won over " + numOfWins.ToString() + " game(s), " + numOfWinsPercent.ToString() + "% of the time.";
        }

        // Factory for computer win numbers.
        private string ComputerWinPercentageFactory()
        {
            double numOfWinsPercent = Math.Round(info.getAIWinPercent(), 2);
            double numOfWins = info.getAIWins();

            return "The Computer has won over " + numOfWins.ToString() + " game(s), " + numOfWinsPercent.ToString() + "% of the time.";
        }

        // Factory for computer draw numbers.
        private string DrawPercentageFactory()
        {
            double numOfDrawsPercent = Math.Round(info.getDrawPercent(), 2);
            double numOfDraws = info.getDraws();

            return "There has been over " + numOfDraws.ToString() + " draw(s), " + numOfDrawsPercent.ToString() + "% of games played";
        }
    }
}
