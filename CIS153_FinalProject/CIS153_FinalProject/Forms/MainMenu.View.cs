using CIS153_FinalProject.Forms;
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
    // Brad Hanson
    // Ben Macleod

    public partial class Main_Menu : Form
    {
        private Window windowController = new Window();
        public Main_Menu()
        {
            InitializeComponent();

            // Because this is the inital form we will set the
            // view to this.
            windowController.setView(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btn_open_stats_Click(object sender, EventArgs e)
        {
            windowController.setView(new Stats(windowController));
        }

        // Call when the user wants to player two players, and redirect to collect
        // player information.
        private void btn_two_player_Click(object sender, EventArgs e)
        {
            windowController.setView(new TwoPlayer(windowController));
        }

        // Called when the user wants to play a single player game.
        private void btn_single_player_Click(object sender, EventArgs e)
        {
            windowController.setView(new GameBoard("single", windowController));
        }
    }
}
