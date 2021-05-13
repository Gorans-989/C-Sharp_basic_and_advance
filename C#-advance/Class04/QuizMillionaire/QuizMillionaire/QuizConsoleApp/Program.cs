using QuizServices;
using System;
using System.Collections.Generic;

namespace QuizConsoleApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            QuizManagement quiz = new QuizManagement();
            Console.WriteLine("Welcome to Who wants to be a Millionaire");
            quiz.StartGame();

            Console.ReadLine();
        }
    }
}
