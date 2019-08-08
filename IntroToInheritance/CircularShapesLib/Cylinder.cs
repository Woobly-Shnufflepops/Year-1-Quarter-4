using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularShapesLib
{
    public class Cylinder:Circle
    {
        // Cylinder has height and radius. It inherits the radius from circle, but must define height

        // add contructor

        // add any property

        // Do any method hiding if necessary. Formula for area: 2*math>pi*radius*height
        // Formula for volume: Math.Pi*Radius*Radius*height

        private double _height;
        

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public Cylinder(double radius, double height) : base(radius)
        {
            _height = height;
        }
        new public double Area()
        {
            return 2 * Math.PI * Radius * Height;
        }

        new public double Volume()
        {
            return Math.PI * Radius * Radius * Height;
        }
    }
}
