using System;
using System.Collections.Generic;
using System.Text;

namespace Class04_Homework02_Domain.Entities
{
    public class Circle : Shape
    {//* Create a class Circle, with property radius that inherits from Shape.

        public int Radius { get; set; }
        public Circle(int radius)
        {
            Radius = radius;
        }
        public override double GetArea()
        {   //return Radius * Radius;
            return 3.14 * Math.Pow(Radius, 2);
        }
        public override double GetPerimeter()
        {
            return 2 * 3.14 * Radius;
        }
    }
}
