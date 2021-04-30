using Class04_Homework01_Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class04_Homework01_Domain.Entities
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public string Size { get; set; }
        public Fish(string name, int age, string color, string size) : base(name, AnimalType.Fish, age)
        {
            Name = name;
            Age = age;
            Color = color;
            Size = size;
        }
        public override string PrintInfo()
        {
            return $"Name:{Name}, age: {Age}, lives left {Color}, size {Size} AnimalType: {AnimalType}";
        }
    }
}
