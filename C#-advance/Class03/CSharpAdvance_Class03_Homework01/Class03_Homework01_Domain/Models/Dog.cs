using System;
using System.Collections.Generic;
using System.Text;

namespace Class03_Homework01_Domain.Models
{
    public class Dog
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Color { get; set; }

        public Dog()
        {
            
        }
        public Dog(int id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
        }
        public string Bark()
        {
            return "Bark bark bark";
        }
    }
}
