using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassLib
{
    public class Cylinder:CircularShape
    {
        //since user except to provide both radius
        //and height, the constructor of this 
        //class must have both fields
        public Cylinder(double radius,double height)
            : base(radius, height) { }

        //override methods if necessary
        //May override virtual Perimeter method
        //Must override abstract Area and Volume methods

        public override double Area()
        {
            return Math.PI * Radius * Radius * Height;
        }
        //apply method override to Volume
        public override double Volume()
        {
            return Math.PI * Radius * Radius * Height;
        }

    }
}
