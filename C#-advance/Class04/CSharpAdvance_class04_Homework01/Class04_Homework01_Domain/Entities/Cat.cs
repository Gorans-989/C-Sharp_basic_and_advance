using Class04_Homework01_Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class04_Homework01_Domain.Entities
{
    public class Cat : Pet
    {   /*▹Cat(from Pet) with Lazy and LivesLeft▹*/

        public int LivesLeft { get; set; }

        public Cat(string name, int age, int livesLeft) : base (name, AnimalType.Cat, age)
        {
            Name = name;
            Age = age;
            LivesLeft = livesLeft;
        }
        public string Lazy()
        {
            return $"The {AnimalType} {Name} is very lazy.";
        }

        public override string PrintInfo()
        {
            return $"Name:{Name}, age: {Age}, lives left {LivesLeft} AnimalType: {AnimalType}";
        }
    }
}
