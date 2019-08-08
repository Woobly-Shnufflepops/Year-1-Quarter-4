using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicCircularShapesLib
{
    public class Circle
    {
        //private fields
        private double _radius;
        //constructor
        public Circle(double radius)
        {
            this._radius = radius;
        }
        //properties
        public double Radius
        { get { return this._radius; } }
        //methods
        public virtual double Perimeter()
        {
            double p = 2 * Math.PI * _radius;
            return p;
        }
        public virtual double Area()
        {
            double a = Math.PI * _radius * _radius;
            return a;
        }
        public virtual double Volume()
        {
            return 0;
        }
    }
}

