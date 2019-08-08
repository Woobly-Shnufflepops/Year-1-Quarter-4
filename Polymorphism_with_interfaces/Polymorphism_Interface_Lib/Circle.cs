using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Interface_Lib
{
    public class Circle : IShape
    {
        private double _radius;
        public Circle(double radius)
        {
            _radius = radius;
        }
        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
        public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public double Volume()
        {
            return 0;
        }
        public double Height
        {
            get
            {
                return 0;
            }
        }
        public double Radius
        {
            get { return _radius; }
        }
        public override string ToString()
        {
            return "Radius: " + Radius.ToString("n") + " perimeter: " + Perimeter().ToString("n") + "area: " + Area().ToString("n") + " volume: " + Volume().ToString("n");
        }
    }
}
