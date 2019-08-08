using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicCircularShapesLib
{
   
    public class Cylinder:Circle
    {
        private double _height;
        public Cylinder(double radius, double height)
            : base(radius)
        {
            this._height = height;
        }
        public double Height
        { get { return this._height; } }

        //apply method override for area: new
        public override double Area()
        {
            return Math.PI * Radius * Radius * Height;
        }
        //apply method override to Volume
        public override double  Volume()
        {
            return Math.PI * Radius * Radius * Height;
        }
    }
}
