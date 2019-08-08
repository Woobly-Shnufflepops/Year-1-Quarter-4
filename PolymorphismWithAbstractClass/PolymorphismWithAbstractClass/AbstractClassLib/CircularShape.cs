using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassLib
{
    public abstract class CircularShape
    {
        //private fields
        private double _radius;
        private double _height;

        public CircularShape(double radius, double height)
        {
            _radius = radius;
            _height = height;
        }
        //properties
        public double Height
        { get { return this._height; } }
        public double Radius
        { get { return this._radius; } }

        //methods
        public virtual double Perimeter()
        {
            return 2 * Math.PI * _radius;
        }

        //an abstract method is defined using the
        //abstract keyword.
        //abstract method cannot have a body.
        //that is you cannot add code to it
        //must be terminated by a semi colon

        //abstract method cannot be defined in a
        //non-abstract class.
        //so this class MUST be abstract
        public abstract double Area();

        public abstract double Volume();
       

    }
}
