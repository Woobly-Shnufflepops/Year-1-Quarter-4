using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassLib
{
    public class Circle:CircularShape
    {
        //Every child must have its own constructor
        //child class does not inherit parent constructor
        public Circle(double radius) : base(radius, 0)
        {
        }

        //Because the Area and Volume methods are
        //declared abstract in the base class,
        //They MUST be overriden in the child class
        public override double Area()
        {

            double a = Math.PI *Radius*Radius;
            return a;
        }

        //Must Override
        public override double Volume()
        {
            return 0;
        }
    }
}
