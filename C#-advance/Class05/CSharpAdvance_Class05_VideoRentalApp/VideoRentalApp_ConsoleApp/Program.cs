using System;
using VideoRentalApp_Data.Models;
using VideoRentalApp_Services.Helpers;
using VideoRentalApp_Services.Interfaces;
using VideoRentalApp_Services.Menus;
using VideoRentalApp_Services.Services;

namespace VideoRentalApp_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = null;

            IUserService userService = new UserService();
            Screen.HomeScreen();

            bool isLoggedIn = false;
            while (!isLoggedIn)
            {
                Screen.StartMenu();
                int startMenuInput = InputParser.ToInteger(1, 3);

                switch (startMenuInput)
                {
                    case 1:

                        user = userService.LogIn();
                        break;
                    case 2:
                        user = userService.SignUp();
                        break;
                    case 3:
                        Environment.Exit(0);
                        //somelogic;
                        break;
                }





            }


            Console.ReadLine();
        }


        
    }
}
