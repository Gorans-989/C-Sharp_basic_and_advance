using System;
using System.Collections.Generic;
using System.Text;

namespace Class04_Homework02_Domain.Entities
{
    public class Rectangle : Shape
    {//* Create a class Rectangle, with properties sideA and sideB that inherits from Shape.

        public int SideA { get; set; }
        public int SideB { get; set; }

        public Rectangle(int sideA, int sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }
        public override double GetArea()
        {
            return SideA * SideB;
        }

        public override double GetPerimeter()
        {
            return (2 * SideA) + (SideB * 2);
        }

    }
}
