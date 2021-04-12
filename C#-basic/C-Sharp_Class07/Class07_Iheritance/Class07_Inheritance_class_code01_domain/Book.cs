using System;

namespace Class07_Inheritance_class_code01_domain
{
    public class Book
    {
        public Book()
        {

        }

        public Book(string title, string author, BookGenre genre, double price, DateTime publishedDate, int numOfPages)
        {
            this.BookId = SetId();
            Title = title;
            Author = author;
            this.Genre = genre;
            this.Price = price;
            this.PublishedDate = publishedDate;
            this.NumberOfPages = numOfPages;
        }

        private int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public BookGenre Genre { get; set; }
        public double Price { get; set; }
        public DateTime PublishedDate { get; set; }
        public int NumberOfPages { get; set; }


        public int SetId()
        {
        return new Random().Next(1, 100);
        }

        public void PrintBookInfo()
        {
            Console.WriteLine($"The book details are title:{Title}, id: {BookId}, author:{Author}, " +
                $"price:{Price}, published on:{this.PublishedDate}, numOfPages:{NumberOfPages}," +
                $" genre:{this.Genre}");
        }
    }
}
