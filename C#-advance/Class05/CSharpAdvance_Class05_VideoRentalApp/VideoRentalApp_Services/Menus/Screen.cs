using System;
using System.Collections.Generic;
using System.Text;

namespace VideoRentalApp_Services.Menus
{
    public static class Screen
    {
        public static void HomeScreen()
        {
            Console.WriteLine("Hello user");
        }

        public static void StartMenu()
        {
            Console.WriteLine("1. Rent a movie with existing acc");
            Console.WriteLine("2. Rent a movie and create acc");
            Console.WriteLine("3. Exit");
        }

    }
}
