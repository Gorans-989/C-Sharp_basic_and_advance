using System;
using System.Collections.Generic;

namespace Class01.Task01.App
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = EnterNamesFromScreen();

            Console.WriteLine("enter Text to search how many times");
            string someText = Console.ReadLine();
            





            Console.ReadLine();
        }

        static List<string> EnterNamesFromScreen()
        {
            List<string> names = new List<string>();
            Console.WriteLine("Please enter names to fill the list");
            Console.WriteLine("Enter \"x\" to finish the list");
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "x")
                {
                    break;
                }
                names.Add(input);
            }
            return names;
        }
    }
}
