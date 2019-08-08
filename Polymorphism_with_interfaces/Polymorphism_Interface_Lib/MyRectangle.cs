using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Interface_Lib
{
    public class MyRectangle : IShape
    {
        private double _width;
        private double _length;
        public MyRectangle(double length, double width)
        {
            _width = width;
            _length = length;
        }
        public double Width { get { return _width; } }
        public double Length { get { return _length; } }
        public double Area()
        {
            return Length * Width;
        }
        public double Perimeter()
        {
            return 2 * (Length * Width);
        }
        public double Volume()
        {
            return 0;
        }
        public double Height
        {
            get
            {
                return 0;
            }
        }
        //override the ToString
        public override string ToString()
        {
            return "Length: " + Length + " width: " + Width + "\n" + " perimeter: " + Perimeter().ToString("n") + "area: " + Area().ToString("n") + " volume: " + Volume().ToString("n");
        }
    }
}
