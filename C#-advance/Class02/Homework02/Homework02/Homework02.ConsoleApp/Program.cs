using Homework02.Business.Services;
using Homework02.Domain.Models;
using System;
using System.Collections.Generic;

namespace Homework02.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GuestManagementService guestManagementService = new GuestManagementService();
            ModeratorManagementService moderatorManagementService = new ModeratorManagementService();
            PosterManagementService posterManagementService = new PosterManagementService();

            Console.WriteLine("Welcome to oup app. Please choose a role");
            
            while (true)
            {
                Console.WriteLine("1. Guest \n2. Poster \n3.Moderator");
                bool isValid = int.TryParse(Console.ReadLine(), out int selection);
                //int selection = int.Parse(Console.ReadLine());

                if (isValid)
                {

                    if (selection == 1)
                    {//guest menu
                        guestManagementService.GuestMenu();
                        break;
                    }
                    else if (selection == 2)
                    {//poster menu
                        posterManagementService.PosterMenu();
                        break;
                    }
                    else if (selection == 3)
                    {//moderator menu
                        moderatorManagementService.ModeratorMenu();
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("invalid Choice");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("invalid Input. Please type in only numbers");
                    Console.ResetColor();
                }

            }

            Console.ReadLine();
        }
    }
}
