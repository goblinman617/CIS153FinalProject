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

namespace CIS153_FinalProject {
    public partial class Stats : Form {
        private MatchHistory info = new MatchHistory();
        private Window windowController = new Window();
        public Stats() {
            InitializeComponent();
            windowController.setView(this);
            // We read text file everytime this window is created.
            // If we start passing the same windowController THIS WILL NEED TO BE CHANGED SO THAT INFORMATION IS UPDATED SOME OTHER WAY
            readTextFile(info);
            updateDisplay(info);
        }
        private void readTextFile(MatchHistory info) {
            // Simple read the text file and set values
            // It sets all values even the ones we dont store
            StreamReader file = new StreamReader("../../MatchHistory.txt");
            string s = file.ReadLine();
            info.setPlayerWins(Int32.Parse(s));

            s = file.ReadLine();
            info.setAIWins(Int32.Parse(s));

            s = file.ReadLine();
            info.setDraws(Int32.Parse(s));

            file.Close();

            info.setTotalGames((info.getAIWins() + info.getPlayerWins() + info.getDraws()));
            if (info.getTotalGames() != 0) {
                info.setPWinPercent(info.getPlayerWins() / info.getTotalGames() * 100);
                info.setAIWinPercent(info.getAIWins() / info.getTotalGames() * 100);
                info.setDrawPercent(info.getDraws() / info.getTotalGames() * 100);
            } else {
                Console.WriteLine(info.getTotalGames());
                info.setPWinPercent(0);
                info.setAIWinPercent(0);
                info.setDrawPercent(0);
            }
        }
        private void updateDisplay(MatchHistory info) {
            // Fill all the blank spots that need to be filled
            txt_total_games.Text = info.getTotalGames().ToString();
            txt_player_win_p.Text = Math.Round(info.getPWinPercent(), 2).ToString() + "%";
            txt_player_wins.Text = info.getPlayerWins().ToString();
            txt_draw_p.Text = Math.Round(info.getDrawPercent(), 2).ToString() + "%";
            txt_draws.Text = info.getDraws().ToString();
            txt_ai_win_p.Text = Math.Round(info.getPWinPercent(), 2).ToString() + "%";
            txt_ai_wins.Text = info.getAIWins().ToString();
        }

        private void btn_to_menu_Click(object sender, EventArgs e) {
            windowController.setView(new Main_Menu());
        }
    }
}
