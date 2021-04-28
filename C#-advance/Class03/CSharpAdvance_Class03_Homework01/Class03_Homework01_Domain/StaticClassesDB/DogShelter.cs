using Class03_Homework01_Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class03_Homework01_Domain.StaticClassesDB
{
    public static class DogShelter
    {

        public static List<Dog> Dogs;

        static DogShelter()
        {
            Dogs = new List<Dog>();
        }
        public static void PrintAll()
        {
            Dogs.ForEach(x => Console.WriteLine($"{x.Id}.{x.Name} - {x.Color}"));
        }

        public static void AddDogs(Dog someDog)
        {
            if(someDog != null)
            {
                Dogs.Add(someDog);
                Console.WriteLine($"Your dog {someDog.Name} is admited in the shelter");
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Eror , the input is empty");
                Console.ResetColor();
            }
            
        }



        //●Create a static class called DogShelter
        //that has:▹List of Dogs▹PrintAll() -prints all dogs from List of Dogs
        //●Create 3 Dog objects, call validate on them to see if they are okay,
        //add them in the List of Dogs and call PrintAll()


    }
}
