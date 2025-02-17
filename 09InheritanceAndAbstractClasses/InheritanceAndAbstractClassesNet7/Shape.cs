using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAbstractClasses
{
    public abstract class Shape
    {
        public Color Colour { get; set; }
        public Point Position { get; set; }

        //The only way to instantiate a Shape is to specify a colour and position
        //This is still true for derived classes
        public Shape()
        {

        }

        public Shape(Point position, Color colour)
        {
            Position = position; Colour = colour;
        }


        public abstract double Area { get; }  // Value of -1 indicates area cannot be calculated

        public abstract void Draw(Graphics canvas);

    }
}
