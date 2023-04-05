using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_FinalProject
{
    /**
     * Intention behind this concept is to make the placement of the
     * window the same and consistent each time, we can also manage window closing
     * super easily.
    */
    internal class Window
    {
        // This represents the active window for the user.
        private Form _view;

        // Incase we need to access the previous view that was open.
        private Form previousView;

        // When this happens we want close the current view and open the new one
        // while setting the location new veiw and setting it to the new one.
        public void setView(Form view)
        {
            view.StartPosition = FormStartPosition.Manual;
            view.Location = new Point(100, 100);

            // ?? Why can't i do =
            view.FormClosed += closeHandler;

            // Hide the old view.
            if (_view != null)
            {
                _view.Hide();
            }

            // Show the new view.
            view.Show();

            // Set the view being replaced to the previous one.
            this.previousView = this._view;

            // Set the view to the new view.
            this._view = view;

        }

        // Return the current view.
        public Form getView()
        {
            return this._view;
        }

        private void closeHandler(object sender, System.EventArgs e)
        {
            Console.WriteLine("closed");
            Application.Exit();
        }
    }
}
