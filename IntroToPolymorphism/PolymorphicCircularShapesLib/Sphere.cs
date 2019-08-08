using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicCircularShapesLib
{
    public class Sphere:Circle
    {
        public Sphere(double radius) : base(radius)
        {
        }
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
