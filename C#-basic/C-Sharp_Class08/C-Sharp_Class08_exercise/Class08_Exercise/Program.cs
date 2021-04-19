using Class08_Exercise2_Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Class08_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //Dictionary<string, long> example = new Dictionary<string, long>()
            //{
            //    {"goran", 070123456 },
            //    {"ana", 072123654 },
            //    {"iva", 075654321 },
            //    {"eva", 074123987 },
            //    {"petar", 075122954 }
            //};

            ////Console.WriteLine("Please enter name");
            //string inputSearch = Console.ReadLine();

            // Select Jerry and add all songs that start with B
            Person jerry = Database.FansArray.FirstOrDefault(x => x.FirstName.ToLower() == "jerry");
            jerry.FavoriteSongs.AddRange(Database.Songs.Where(x => x.Title.ToLower().StartsWith("b")).ToList());
            Console.WriteLine($"This is {jerry.FullName()}. His favorite songs are:");
            jerry.GetFavoriteSongs();

            Console.WriteLine("Maria favorite songs");
            //Select  the person Maria and add all the songs with length  longer than 6 mins
            Person maria = Database.FansArray.First(x => x.FirstName.ToLower() == "maria");
            maria.FavoriteSongs.AddRange(Database.Songs.Where(x => x.Length > 6 * 60).ToList());
            Console.WriteLine($"This is {maria.FullName()}. Her favorite songs are:");
            maria.GetFavoriteSongs();


            //Select  the person Jane and add all the songs that are of genre Rock
            Person jane = Database.FansArray.First(x => x.FirstName.ToLower() == "jane");
            jane.FavoriteSongs.AddRange(Database.Songs.Where(x => x.Genre.ToString().ToLower() == "rock").ToList());
            Console.WriteLine($"This is {jane.FullName()}. Her favorite songs are:");
            jane.GetFavoriteSongs();


            //Select  the person Stefan and add all songs shorter than 3 mins and of genre Hip-Hop
            Person stefan = Database.FansArray.First(x => x.FirstName.ToLower() == "stefan");
            stefan.FavoriteSongs.AddRange(Database.Songs.Where(x => x.Genre.ToString().ToLower() == "hip_hop" &&
            x.Length < 3 * 60 ).ToList());
            Console.WriteLine($"This is {stefan.FullName()}. His favorite songs are:");
            stefan.GetFavoriteSongs();

            //Select  all persons from the persons array that have 4 or more songs
            List<Person> allPersonsWithMoreThen4favoriteSongs = Database.FansArray.Where(x => x.FavoriteSongs.Count >= 4).ToList();
            Console.WriteLine(allPersonsWithMoreThen4favoriteSongs.Count);

            

            



            Console.ReadLine();
        }

        static void GoThroughCollection(IEnumerable collection, string name)
        {
            Console.WriteLine($"Collection {name} items: ");
            foreach (var item in collection)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }
        
       static void AddSongs(List<Song> inputsong, Person fan1)
        {
            foreach (Song item in inputsong)
            {
                fan1.FavoriteSongs.Add(item);
                Console.WriteLine(item.Title);
            }
        }
    }
}
