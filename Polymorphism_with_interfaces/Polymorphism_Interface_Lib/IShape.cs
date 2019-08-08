using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Interface_Lib
{
    /*
     * You can think of an interface as a pure abstract class where every method and every property is abstract
     * 
     * the keyword interface replaces the keywords abstract and class.
     * Any method defined in an interface is by default public and abstract, so you don't add those keywords when defining a method in an interface
     * Same holds true for a property
     */
    public interface IShape
    {
        double Perimeter();
        double Area();
        double Volume();
        double Height
        {
            get;
        }
    }
}
