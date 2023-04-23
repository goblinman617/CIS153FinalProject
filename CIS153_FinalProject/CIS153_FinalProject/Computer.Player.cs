using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_FinalProject
{
    internal class Computer : Player
    {
        private Cell previousMove;
        private Cell opponetPreviousMove;

        public Computer(string name, Color c) : base(name, c)
        {
        }

        public Cell GetNextMove(Board board, Func<int, Cell> setPlayerAsOwnerOfNextToken)
        {
            int height = board.getCells().GetLength(0);
            int width = board.getCells().GetLength(1);

            for (int r = height - 1; r >= 0; r--)
            {
                for (int c = 0; c < 7; c++)
                {
                    int numofLikeTokens = 0;

                    for (int i = 0; i < 4; i++)
                    {
                        if (board.getCells()[r, c].getOwner() != null)
                        {
                            if (board.getCells()[r, c].getOwner() != null && board.getCells()[r, c].getOwner() == board.getCells()[r - i, c].getOwner())
                            {
                                numofLikeTokens++;
                            }
                        }
                        else
                        {
                            numofLikeTokens = 0;
                        }

                    }

                    Console.WriteLine(numofLikeTokens);
                }

            }

            return null;
        }

        public void SetOpponetPreviousMove(Cell move)
        {
            opponetPreviousMove = move;
        }
    }
}
