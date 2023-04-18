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
        Window windowController;

        public GameBoard(string playerMode)
        {
            InitializeComponent();
            Console.WriteLine(playerMode);
        }

        public GameBoard(string playerMode, Window windowController)
        {
            InitializeComponent();
            Console.WriteLine(playerMode);
            this.windowController = windowController;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void backButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
