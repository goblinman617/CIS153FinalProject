using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_FinalProject
{
    internal class AI
    {
        // Think it's fair to assume the next best move is either our last move or the players,
        // so we don't have to check the entire board.
        //
        private int[] playersLastMove = { };
        private int[] myLastMove = { };

        // Set the players last move.
        public void setPlayersLastMove(int[] playersLastMove)
        {
            this.playersLastMove = playersLastMove;
        }

        public void getNextMove(Board[,] board) { }
    }
}
