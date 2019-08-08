using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassLib
{
    public class Sphere : Circle
    {
        public Sphere(double radius) : base(radius) { }
        //because the Sphere inherits from Circle and
        //not directly from CircularShape
        //it Does not have to override abstract methods
        //Area and Volume, since they have been overriden
        //already in Circle
        //So as far as the Sphere is concerned, this
        //becomes a "May Override"
        //Nonetheless it should override them, because
        //the Sphere has different implementation for
        //Area and Volume

        public override double Area()
        {
            return 4 * Math.PI * Radius * Radius;
        }
        public override double Volume()
        {
            return 4 * Math.PI * Math.Pow(Radius, 3) / 3;
        }
    }
}
