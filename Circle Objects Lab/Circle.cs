using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Objects_Lab
{
    public class Circle
    {
        public double radius { get; set; }

        public Circle(double _radius)
        {
            radius = _radius;
        }

        public double CalculateDiameter(double r)
        {
            return r + r;
        }
        public double CalculateCircumference(double r)
        {
            return 2 * Math.PI * r;
        }
        public double CalculateArea(double r)
        {
            return Math.PI * r * r;
        }
        public void Grow()
        {
            radius = radius + radius;
        }
    }
}
