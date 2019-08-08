using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicCircularShapesLib
{
    public class Cone:Cylinder
    {
        public Cone(double radius, double height)
            : base(radius, height)
        {
            //the cone constructor calls its base
            //or parent constructor (cylinder)
            //its parent constructor, the Cylinder also
            //calls its parent, the Circle constructor
        }
        //Both Radius and Height properties are inherited
        //but needs to override Area and Volume methods
        public override double Area()
        {
            return Math.PI * Radius * 
  (Radius + Math.Sqrt(Height * Height + Radius * Radius));
        }
        public override double Volume()
        {
            return Math.PI * Math.Pow(Radius, 2)*Height / 3;
        }
    }
}
