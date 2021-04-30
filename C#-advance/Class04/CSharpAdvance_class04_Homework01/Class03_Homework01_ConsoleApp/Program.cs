using Class04_Homework01_Domain.Entities;
using Class04_Homework01_Domain.GenericDB;
using System;

namespace Class03_Homework01_ConsoleApp
{
    class Program
    {
        public static PetStore<Dog> DogStore = new PetStore<Dog>();
        public static PetStore<Cat> CatStore = new PetStore<Cat>();
        public static PetStore<Fish> FishStore = new PetStore<Fish>();
        public static PetStore<Pet> genericPetStore = new PetStore<Pet>();

        static void Main(string[] args)
        {
            DogStore.Pets.Add(new Dog("Reks", 7, "bacon"));
            DogStore.Pets.Add(new Dog("Grof", 5, "steak"));
            DogStore.Pets.Add(new Dog("Dutches", 2, "bacon"));
            ////////////////////////////////////////////////////
            CatStore.Pets.Add(new Cat("Milka", 4, 9));
            CatStore.Pets.Add(new Cat("Spark", 6, 2));
            CatStore.Pets.Add(new Cat("Bob", 8, 6));
            ////////////////////////////////////////////////////
            FishStore.Pets.Add(new Fish("jill", 5, "yellow-green", "small"));
            FishStore.Pets.Add(new Fish("jane", 2, "lime", "medium"));
            FishStore.Pets.Add(new Fish("tarzan", 6, "pink", "large"));
            ////////////////////////////////////////////////////

            Console.WriteLine("Printing all pets from all stores");

            //genericPetStore.PrintPets(DogStore.Pets);
            //genericPetStore.PrintPets(CatStore.Pets);
            //genericPetStore.PrintPets(FishStore.Pets);
            DogStore.PrintPets(CatStore.Pets);
            CatStore.PrintPets(FishStore.Pets);
            FishStore.PrintPets(DogStore.Pets);
            Console.WriteLine("==================================");

            Console.WriteLine("please type in the name of the dog you want to buy");
            Console.WriteLine(DogStore.BuyPet(Console.ReadLine()));
            Console.WriteLine("please type in the name of the cat you want to buy");
            Console.WriteLine(CatStore.BuyPet(Console.ReadLine()));
            Console.WriteLine("please type in the name of the fish you want to buy");
            Console.WriteLine(FishStore.BuyPet(Console.ReadLine()));
            Console.WriteLine("pets in store after bying");
            DogStore.PrintPets(CatStore.Pets);
            CatStore.PrintPets(FishStore.Pets);
            FishStore.PrintPets(DogStore.Pets);



            Console.ReadLine();
        }

        //Create 4 classes:
        //▹Pet( abstract ) with Name, Type, Age and abstract PrintInfo()
        //▹Dog(from Pet) with GoodBoiand FavoriteFood
        //▹Cat(from Pet) with Lazy and LivesLeft▹
        //Fish(from Pet) with color, size
        //▸Create a PetStoregeneric class with :
        //▹Generic list of pets -Dogs, Cats or Fish depending on what is passed as T
        //▹Generic method printsPets() -Prints Dogs, Cats or Fish depending on what is passed as T
        //▹BuyPet() -Method that takes ‘name’ as parameter, find the first pet by that name,
        //removes it from the list and gives a success message.If there is no pet by that name, inform the customer
        //▸Create a Dog, Cat and fish store with 2 pets each
        //▹Buy a dog and a cat from the Dog and Cat store
        //▹Call PrintPets() method on all stores

    }
}
