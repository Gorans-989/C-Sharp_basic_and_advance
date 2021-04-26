using System;
using System.Collections.Generic;
using System.Linq;

namespace Class01.Task01.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> names = EnterNamesFromScreen();

            //Console.WriteLine("enter Text to search how many times");
            //string someText = Console.ReadLine();

            SelectManyEx3();





            Console.ReadLine();
        }

        class PetOwner
        {
            public string Name { get; set; }
            public List<string> Pets { get; set; }
        }

        public static void SelectManyEx3()
        {
            PetOwner[] petOwners =
                { new PetOwner { Name="Higa",
              Pets = new List<string>{ "Scruffy", "Sam" } },
          new PetOwner { Name="Ashkenazi",
              Pets = new List<string>{ "Walker", "Sugar" } },
          new PetOwner { Name="Price",
              Pets = new List<string>{ "Scratches", "Diesel" } },
          new PetOwner { Name="Hines",
              Pets = new List<string>{ "Dusty" } } };

            // Project the pet owner's name and the pet's name.
            var query =
                petOwners
                .SelectMany(petOwner => petOwner.Pets, (petOwnerList, thePetListFromInside) => new
                {
                    Owner = petOwnerList.Pets,
                    NameOFPet = thePetListFromInside,
                    NameOFPersons = petOwnerList.Name

                })
                .Select(obj => new
                {
                    Owner = obj.NameOFPersons,
                    Pets = obj.NameOFPet
                });
                
                
                
                
                
                //, (petOwner, petName) => new { petOwner, petName })
               // .Where(ownerAndPet => ownerAndPet.petName.StartsWith("S"))
               // .Select(ownerAndPet =>
                //        new
                //        {
                //            Owner = ownerAndPet.petOwner.Name,
                //            Pet = ownerAndPet.petName
                //        }
                //);

            foreach (var item in query)
            {
                Console.WriteLine($"Person: {item.Owner} animal: {item.Pets}  ");
            }
            //static List<string> EnterNamesFromScreen()
            //{
            //    List<string> names = new List<string>();
            //    Console.WriteLine("Please enter names to fill the list");
            //    Console.WriteLine("Enter \"x\" to finish the list");
            //    while (true)
            //    {
            //        string input = Console.ReadLine();
            //        if (input.ToLower() == "x")
            //        {
            //            break;
            //        }
            //        names.Add(input);
            //    }
            //    return names;
            //}
        }
    }
}
