using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CIS153_FinalProject {
    internal class MatchHistory {
        private double playerWins;
        private double aiWins;
        private double draws;
        private double totalGames;
        private double pWinPercent;
        private double aiWinPercent;
        private double drawPercent;

        // Getters
        public double getPlayerWins() { return playerWins; }
        public double getAIWins() { return aiWins; }
        public double getDraws() { return draws; }
        public double getTotalGames() { return totalGames;}
        public double getPWinPercent() { return pWinPercent; }
        public double getAIWinPercent() { return aiWinPercent; }
        public double getDrawPercent() { return drawPercent; }

        // Setters
        public void setDrawPercent(double x) { drawPercent = x; }
        public void setAIWinPercent(double x) { aiWinPercent = x; }
        public void setPWinPercent(double x) { pWinPercent = x; }
        public void setTotalGames(double games) { totalGames = games; }
        public void setPlayerWins(double wins) { playerWins = wins; }
        public void setAIWins(double wins) { aiWins = wins; }
        public void setDraws(double x) { draws = x; }
    }
}
