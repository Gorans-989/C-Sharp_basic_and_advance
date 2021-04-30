using Class04_Homework01_Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class04_Homework01_Domain.Entities
{
    public abstract class Pet
    { //Pet( abstract ) with Name, Type, Age and abstract PrintInfo()
        public string Name { get; set; }
        public AnimalType AnimalType { get; set; }
        public int Age { get; set; }

        public Pet(string name, AnimalType animalType, int age)
        {
            Name = name;
            AnimalType = animalType;
            Age = age;
        }
        
        public abstract string PrintInfo();
        
    }
}
