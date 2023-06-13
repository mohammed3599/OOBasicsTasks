using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOBasicsTasks
{
    internal class Circle
    {
        public double radius;


        public Circle( double radius )
        { 
            this.radius = radius; 
        }

        public double calArea(double radius)
        {
            return (3.14 * radius*radius);
        }
    }
}
