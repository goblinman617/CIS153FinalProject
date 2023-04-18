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

        public TwoPlayer(Window value)

        {
            InitializeComponent();
            windowController = value;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            windowController.goBack();
        }
    }
}
