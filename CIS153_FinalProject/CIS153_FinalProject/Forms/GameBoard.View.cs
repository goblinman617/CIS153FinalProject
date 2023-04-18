using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_FinalProject
{
    public partial class GameBoard : Form
    {
        Game gameSession = new Game();

        public GameBoard(string playerMode)
        {
            InitializeComponent();
            Console.WriteLine(playerMode);
        }
    }
}
