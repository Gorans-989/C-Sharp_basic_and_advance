using Class03_Homework01_Domain.Helpers;
using Class03_Homework01_Domain.Models;
using Class03_Homework01_Domain.StaticClassesDB;
using System;
using System.Collections.Generic;

namespace Class03_Homework01_ConsoleApp
{
    class Program
    {
        static List<Dog> _DummyListOfDogs;
        //static List<Dog> _DogsList; just to check
        static void Main(string[] args)
        {

            _DummyListOfDogs = new List<Dog>
            {
                new Dog(),
                new Dog() { Color = "red" },
                new Dog() { Name = "Grof" },
                new Dog(1, "Reks", "Brown"),
                new Dog(2, "Yeller", "Golden"),
                new Dog(0, "Dzinac", "Crno"),
                new Dog(-1, "Dutches", "White")
            };

            foreach (Dog item in _DummyListOfDogs)
            {
                if (ValidateObject.Validate(item))
                {
                    DogShelter.AddDogs(item);
                }
                else
                {
                    Console.WriteLine("Your object has no properties");
                }
            }
            Console.WriteLine($"The count of dummy list is {_DummyListOfDogs.Count}");
            Console.WriteLine($"The count of DB List of dogs is {DogShelter.Dogs.Count}");
            Console.WriteLine("========================================================");


            //_DogsList = DogShelter.Dogs; if i need the list to use without calling
            //_DogsList.ForEach(x => Console.WriteLine(x.Name));
            DogShelter.PrintAll();

            Console.ReadLine();
        }
        //d, Name, Color, Bark() -Prints “Bark Bark”▹
        //A static method Validate() -Checks if dog has all 3 properties,
        //if Id is not less than 0 and Name is 2 characters or longer
        //
        //●Create a static class called DogShelter
        //that has:▹List of Dogs▹PrintAll() -prints all dogs from List of Dogs
        //●Create 3 Dog objects, call validate on them to see if they are okay,
        //add them in the List of Dogs and call PrintAll()


    }
}
