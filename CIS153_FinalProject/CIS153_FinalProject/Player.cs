using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_FinalProject
{
    public class Player
    {
        private string name;

        // Custom color for the checkers would be cool.
        private Color color = Color.Red;

        public Player(string name, Color c)
        {
            this.name = name;
            this.color = c;
        }

        /* Getters */
        public string getName()
        { return name; }

        public Color getColor()
        { return color; }

        /* Setters */
        public void setName(string _name)
        { name = _name; }

        public void setColor(Color c)
        { color = c; }
    }
}
