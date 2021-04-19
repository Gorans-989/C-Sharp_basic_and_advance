using System;
using System.Collections.Generic;
using System.Text;

namespace Class08_Exercise2_Domain
{
    public class Song
    {
        public string Title { get; set; }
        public int Length { get; set; }
        public Genre Genre { get; set; }

        public Song( string title, int length, Genre genre)
        {
            Title = title;
            Length = length;
            Genre = genre;
        }

    }
}
