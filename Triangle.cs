using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectC_2
{
    public class Triangle : Shape
    {
        public double Side1{get;set;}
        public double Side2{get;set;}
        public double Side3{get;set;}

        public Triangle(double side1, double side2, double side3)
        {
            if(side1 <= 0 || side2 <= 0 || side3 <= 0)
              throw new ArgumentException("Sides must be positive numbers.");

            if(side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
               throw new ArgumentException("The sum of any two side must be greater than the third side.");  
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;

        }
        public double GetArea()
        {
            double s = (Side1 + Side2 + Side3)/2;
            return Math.Sqrt(s * (s- Side1) * (s-Side2) * (s - Side3));
        }

        public double GetPerimeter()
        {
            return Side1 + Side2 + Side3;
        }
    }
}