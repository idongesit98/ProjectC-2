using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectC_2
{
    public class Circle : Shape
    {
        public double Radius {get; set;}

        public Circle(double radius)
        {
            if(radius <= 0)
            throw new ArgumentException("Radius must be a positive number.");
            Radius = radius;

        }
        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double GetPerimeter()
        {
           return 2 * Math.PI * Radius;
        }
    }
}