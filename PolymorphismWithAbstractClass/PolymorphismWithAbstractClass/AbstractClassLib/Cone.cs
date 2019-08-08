using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassLib
{
    public class Cone:Cylinder
    {
        public Cone(double radius,double height):
            base(radius, height)
        { }

        ///Same logic (of inheritance) as the 
        ///Sphere class.
        ///It Does not have to override the methods
        ///but it should override Area and Volume
        public override double Area()
        {
            return Math.PI * Radius *
            (Radius + 
    Math.Sqrt(Height * Height + Radius * Radius));
        }
        public override double Volume()
        {
            return Math.PI * 
                Math.Pow(Radius, 2) * Height / 3;
        }

    }
}
