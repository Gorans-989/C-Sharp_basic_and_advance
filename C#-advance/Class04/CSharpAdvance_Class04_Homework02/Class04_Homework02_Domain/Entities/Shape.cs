using System;
using System.Collections.Generic;
using System.Text;

namespace Class04_Homework02_Domain.Entities
{
    public abstract class Shape
    {
        public int Id { get; set; }
        public abstract double GetArea();       
        public abstract double GetPerimeter();
        

    }


}
