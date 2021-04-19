using System;
using System.Collections.Generic;
using Class09_ClassLibrary_Domain.MyClasses;

namespace Class09_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Error Handling. Exceptions, try-catch block, 
            DemoClass demoObject = new DemoClass();

            #region movie list
            Movie movie1 = new Movie("Scary Movie", Genre.Comedy, 5);
            Movie movie2 = new Movie("American Pie", Genre.Comedy, 4);
            Movie movie3 = new Movie("Saw", Genre.Horror, 4);
            Movie movie4 = new Movie("The Shining", Genre.Horror, 4);
            Movie movie5 = new Movie("Rambo", Genre.Action, 4);
            Movie movie6 = new Movie("The Terminator", Genre.Action, 4);
            Movie movie7 = new Movie("Forrest Gump", Genre.Drama, 4);
            Movie movie8 = new Movie("12 Angru Men", Genre.Drama, 4);
            Movie movie9 = new Movie("Passengers", Genre.SciFi, 4);
            Movie movie10 = new Movie("Interstellar", Genre.SciFi, 4);
            List<Movie> MovieSet1 = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 };
            Movie movie11 = new Movie("Airplane", Genre.Comedy, 4);
            Movie movie12 = new Movie("Johnny English", Genre.Comedy, 4);
            Movie movie13 = new Movie("The Ring", Genre.Horror, 4);
            Movie movie14 = new Movie("Sinister", Genre.Horror, 4);
            Movie movie15 = new Movie("RoboCop", Genre.Action, 4);
            Movie movie16 = new Movie("Judge Dredd", Genre.Action, 4);
            Movie movie17 = new Movie("The Social Network", Genre.Drama, 4);
            Movie movie18 = new Movie("The Shawshank Redemption", Genre.Drama, 4);
            Movie movie19 = new Movie("Inception", Genre.SciFi, 4);
            Movie movie20 = new Movie("Avatar", Genre.SciFi, 4);
            List<Movie> MovieSet2 = new List<Movie>() { movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20 };
            Cinema cinema1 = new Cinema("Cineplexx", new List<int>() { 1, 2, 3, 4 }, MovieSet1);
            Cinema cinema2 = new Cinema("Milenium", new List<int>() { 1, 2 }, MovieSet2);

            #endregion

            Console.WriteLine("Please choose your Cinema");
            Console.WriteLine($"1.{cinema1.Name} \n2.{cinema2.Name}");
            string userChoiceOfCinema = Console.ReadLine();
            int parsedUserChoiceOFCinema = CheckInput(userChoiceOfCinema);

            Console.WriteLine($"Result of parsed choice is:{parsedUserChoiceOFCinema}");
            
            
            





            Console.ReadLine();
        }

        static int CheckInput(string userInput)
        {
            Console.WriteLine("open connection");
            int result = 0;
            try
            {
               result = int.Parse(userInput);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"{ex.Message}"); ;
            }
            finally
            {
                Console.WriteLine("Close connection");
            }
            return result;

        }

    }
}
