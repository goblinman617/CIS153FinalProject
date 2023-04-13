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

    public partial class Form1 : Form
    {
        private Window windowController;
        private Session sessionController;

        public Form1()
        {
            InitializeComponent();

            // Init window controller.
            windowController = new Window();

            // Init session controller w/ window controller
            sessionController = new Session(windowController);

            // Because this is the inital form we will set the
            // view to this.
            windowController.setView(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            windowController.setView(new TEST_FORM());
        }
    }
}
