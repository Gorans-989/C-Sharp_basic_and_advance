using Class04_Homework01_Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;


namespace Class04_Homework01_Domain.Entities
{
    public class Dog : Pet
    { /*▹Dog(from Pet) with GoodBoiand FavoriteFood*/

        public string FavoriteFood { get; set; }

        public Dog(string name, int age, string favoriteFood):base(name, AnimalType.Dog, age)
        {
            Name = name;
            Age = age;
            FavoriteFood = favoriteFood;
        }


        public string GoodBoy()
        {
            return $"{Name} is a good dog. ";
        }

        
        public override string PrintInfo()
        {//some info about dog
            return $"Name:{Name}, age: {Age}, favorite food{FavoriteFood} AnimalType: {AnimalType}";
        }
    }
}
