using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectC_2
{
    public class Rectangle : Shape
    {
        public double Length{get;set;}
        public double Width{get;set;}
        public Rectangle(double length, double width)
        {
            if(length <= 0 || width <= 0)
            throw new ArgumentException("Length and Width must be psoitive numbers.");
            Length = length;
            Width = width;

        }
        public double GetArea()
        {
          return Length * Width;
        }

        public double GetPerimeter()
        {
            return 2 * (Length + Width);
        }
    }
}