using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularShapesLib
{
    public class Circle
    {
        // private fields
        private double _radius;

        // Constructor
        public Circle(double radius)
        {
            _radius = radius;
        }
        // Properties
        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }
        // Methods
        public double Perimeter()
        {
            double p = 2 * Math.PI * _radius;
            return p;
        }
        public double Volume()
        {
            return 0;
        }
        public double Area()
        {
            double a = Math.PI * _radius * _radius;
            return a;
        }
    }
}
