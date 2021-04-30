using Class04_Homework01_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class04_Homework01_Domain.GenericDB
{
    public class PetStore<T>
        where T : Pet
    {
        public List<T> Pets { get; set; }
        public PetStore()
        {
            Pets = new List<T>();
        }
        
        public void PrintPets<T>(List<T> somePet)
            where T : Pet
        {
            if(somePet != null)
            {
                foreach(T item in somePet)
                {
                    Console.WriteLine($"The animal name is: {item.Name} and it is of type {item.AnimalType}");
                }
            }
            else
            {
                Console.WriteLine("something went wrong");
            }

        }
        public string BuyPet(string name)
        {
            T item = Pets.FirstOrDefault(pet => pet.Name.ToLower().Equals(name));
            if(item != null)
            {
                Pets.Remove(item);
                return $"Congratulations you bought Name: {item.Name} " +
                    $"age: {item.Age} AnimalType: {item.AnimalType} ";
            }
            return $"Sorry no such animal in the store by the name {name}";
        }
    }
    //▸Create a PetStoregeneric class with :
    //▹Generic list of pets -Dogs, Cats or Fish depending on what is passed as T
    //▹Generic method printsPets() -Prints Dogs, Cats or Fish depending on what is passed as T
    //▹BuyPet() -Method that takes ‘name’ as parameter, find the first pet by that name,
    //removes it from the list and gives a success message.If there is no pet by that name, inform the customer
}
