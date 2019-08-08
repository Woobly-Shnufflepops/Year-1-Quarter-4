using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularShapesLib
{
    public class Sphere:Circle
    {
        //the field _radius defined in circle is inherited by the sphere class
        // but because the _radius field is dfined as private in the circle class, the sphere cannot
        // access it directly.
        
        // Child class inherits the filds, properties, and methods of its parent class. But, it doesn't
        // inherit the constructor(s) of its parent class.

        // A child constructor always calls its parent constructor before running its own code.
        // The child constructor passes any parameter values to the parent constructor to allow it to
        // initalize its private fields
        public Sphere(double radius):base(radius)
        {
            // since there are no fields defined in this class, this constructor has no additional code
            // its purpose is to call its parent constructor
        }
        // Property radius in inherited
        // Methods:
        //  Perimeter() is inherited
        //  Area() is inherited, but since the compuation for a sphere's area is different, you need to redfeine
        // the method area in the sphere. Make sure to use the same syntax
        new public double Area()
        {
            return Math.PI * 4 * Math.Pow(Radius, 2);
        }

        //  Volume() is inherited
        // Sphere has a different volume formula than a circle, so it also needs to be redefined
        new public double Volume()
        {
            return Math.PI * 4 * Math.Pow(Radius, 3) / 3;
        }
    }
}
