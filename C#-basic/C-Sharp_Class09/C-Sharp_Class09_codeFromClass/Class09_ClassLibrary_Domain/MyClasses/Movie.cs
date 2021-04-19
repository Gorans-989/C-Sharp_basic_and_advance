using System;
using System.Collections.Generic;
using System.Text;

namespace Class09_ClassLibrary_Domain.MyClasses
{
    public class Movie
    {

        public Movie(string title, Genre genre, short rating)
        {
            if (rating >= 1 && rating <= 5)
            {
                Rating = rating;
            }
            else
            {
                throw new Exception("The rating was not valid");
            }

            Title = title;
            Genre = genre;
            
            TicketPrice = rating * 5;
        }



        public string Title { get; set; }
        public Genre Genre { get; set; }
        public short Rating { get; set; }
        public double TicketPrice { get; set; }


    }

}
