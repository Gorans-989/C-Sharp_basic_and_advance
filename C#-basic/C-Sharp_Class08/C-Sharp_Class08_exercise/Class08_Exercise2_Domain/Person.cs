using System;
using System.Collections.Generic;
using System.Text;

namespace Class08_Exercise2_Domain
{
    public class Person
    {
        public Person(string fname, string lname, int age, Genre genre)
        {
            FirstName = fname;
            LastName = lname;
            Age = age;
            FavoriteMusicType = genre;
        }

        protected int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        Genre FavoriteMusicType { get; set; }

        public List<Song> FavoriteSongs { get; set; } = new List<Song>();

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }
        public void GetFavoriteSongs()
        {


            if (FavoriteSongs.Count > 0)
            {
                foreach (var item in FavoriteSongs)
                {
                    Console.WriteLine($"{item.Title}");
                }
            }
            else
            {
                Console.WriteLine($"This person {FullName()} hates music." +
                    $" There are no favourite songs in their list");
            }
        }
    }
}
