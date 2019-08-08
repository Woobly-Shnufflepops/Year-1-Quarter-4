using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable_Interface
{
    public class CylinderAreaComparer : IComparer<Cylinder>
    {
        public int Compare(Cylinder x, Cylinder y)
        {
            if (x.Area() > y.Area()) return 1;
            if (x.Area() < y.Area()) return -1;
            return 0;
        }
    }
}
