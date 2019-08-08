using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable_Interface
{
    public class Cylinder : IComparable<Cylinder>
    {
        private double _radius;
        private double _height;

        public Cylinder(double radius, double height)
        {
            _radius = radius;
            _height = height;
        }

        public double radius { get { return _radius; } }
        public double height { get { return _height; } }
        public double Area()
        {
            return 2 * Math.PI * radius * height;
        }

        public double Volume()
        {
            return Math.PI * radius * radius * height;
        }

        public int CompareTo(Cylinder cylinder)
        {
            // compare this.Volume() against cylinder.Volume()
            // The return value should conform to the .Net definition of the compareTo method
            return this.Volume().CompareTo(cylinder.Volume());
        }
    }
}
