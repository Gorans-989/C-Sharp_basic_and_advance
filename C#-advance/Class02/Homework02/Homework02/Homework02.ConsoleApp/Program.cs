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
            Console.WriteLine("1. Guest \n2. Poster \n3.Moderator");
            bool isValid = int.TryParse(Console.ReadLine(), out int selection);
            if(selection == 1)
            {//guest menu
                guestManagementService.GuestMenu(selection);
            }
            if(selection == 2)
            {//poster menu
                
            }
            if(selection == 3)
            {//moderator menu

                moderatorManagementService.ModeratorMenu(selection);
            }








            Console.ReadLine();
        }
    }
}
