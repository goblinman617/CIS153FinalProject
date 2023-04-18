using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_FinalProject.Forms
{
    public partial class TwoPlayer : Form
    {
        private Window windowController;

        ColorDialog player1Color = new ColorDialog();
        ColorDialog player2Color = new ColorDialog();

        public TwoPlayer(Window value)

        {
            InitializeComponent();
            windowController = value;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            windowController.goBack();
        }

        private void readyButton_Click(object sender, EventArgs e)
        {
            string _playerOneName = this.playerOneName.Text;
            string _playerTwoName = this.playerTwoName.Text;

            Color playerOneColor = player1Color.Color;
            Color playerTwoColor = player2Color.Color;

            if (string.IsNullOrEmpty(_playerOneName) || string.IsNullOrEmpty(_playerTwoName))
            {
                this.errorLabel.Visible = true;
                this.errorLabel.Text = "Whoa! We are missing a players name.";
                return;
            }

            GameBoard gameBoard = new GameBoard("multi");

            // Set players here.

            windowController.setView(gameBoard);
        }

        private void btn_color_p2_Click(object sender, EventArgs e)
        {
            
            player1Color.ShowDialog();
            btn_color_p2.BackColor = player1Color.Color;
        }

        private void btn_color_p1_Click(object sender, EventArgs e)
        {
            player2Color.ShowDialog();
            btn_color_p2.BackColor = player1Color.Color;
        }
    }
}
