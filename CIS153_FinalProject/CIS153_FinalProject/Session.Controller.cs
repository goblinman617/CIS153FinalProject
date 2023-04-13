using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_FinalProject
{
    internal class Session
    {
        Window windowController;

        // Status of the game, defautls to false.
        private bool hasGameStarted = false;

        // Keep track if the game has ended.
        private bool hasGameFinished = false;

        // Keep track of which players turn it is.
        private Player currentPlayer;

        // Weather the player is playing against AI.
        private bool isVersusAI = false;

        // List of players
        private Player[] playerList = new Player[2];

        // Constructor
        public Session(Window _window)
        {
            windowController = _window;
        }

        public Session()
        {
        }

        /* Getters */
        public bool getHasGameStarted()
        {
            return hasGameStarted;
        }

        public bool getHasGameFinished()
        {
            return hasGameFinished;
        }

        public Player getCurrentPlayer()
        {
            return currentPlayer;
        }

        public bool getIsVersusAI()
        {
            return isVersusAI;
        }

        /* Setters */
        public void setHasGameStarted(bool v)
        {
            hasGameStarted = v;
        }

        public void setGameHasFinished(bool v)
        {
            hasGameFinished = v;
        }

        public void setCurrentPlayer(Player v)
        {
            currentPlayer = v;
        }

        public void setIsVersusAI(bool v)
        {
            isVersusAI = v;
        }
    }
}
