using System;
using System.Collections.Generic;
using System.Text;

namespace Class09_ClassLibrary_Domain.MyClasses
{
    public class Cinema
    {
        public Cinema(string name, List<int> someNumbers ,List<Movie> movies)
        {
            Name = name;
            Movies = movies;
            Halls = someNumbers;
        }



        public string Name { get; set; }
        public List<Movie> Movies { get; set; }
        public List<int> Halls { get; set; }


        public void MoviePlaying (Movie movie)
        {
            Console.WriteLine($"Currently watching {movie.Title}.");
        }

    }
}
