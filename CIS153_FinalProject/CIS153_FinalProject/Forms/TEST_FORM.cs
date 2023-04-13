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
    public partial class TEST_FORM : Form
    {
        // Is this what you wanted or is there a way to use the same windowController in every form?
        private Window windowController = new Window();
        public TEST_FORM()
        {
            InitializeComponent();
            // It needs this line right now to correctly hide this test form after its created
            windowController.setView(this);
        }
        private void bnt_goback_Click(object sender, EventArgs e) {
            // only downside to this that I see is that it creates a brand new form every single time instead of showing/hiding forms
            // I'm not really sure if you want to worry about that but 
            windowController.setView(new Main_Menu());
        }
    }
}