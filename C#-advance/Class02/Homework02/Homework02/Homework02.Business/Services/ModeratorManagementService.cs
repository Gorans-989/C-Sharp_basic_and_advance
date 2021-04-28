using Homework02.Domain;
using Homework02.Domain.Data;
using Homework02.Domain.Helpers;
using Homework02.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework02.Business.Services
{
    public class ModeratorManagementService
    {
        private UserRepo UserRepo { get; set; }
        public ModeratorManagementService()
        {
            UserRepo = new UserRepo();
        }

        public void ModeratorMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Moderator menu.");

            while (true)
            {
                Console.WriteLine("Please choose one Moderator by name or press \"x\" to quit");
                UserRepo.ReturnListOfModerators().ForEach(x => Console.WriteLine(x.UserName));

                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "x")
                {
                    Console.WriteLine("Goodbye");
                    return;
                }

                Moderator loggedModerator = UserRepo.GetModeratorByUserName(userInput);

                if (loggedModerator != null)
                {
                    while (true)
                    {
                        
                        Console.WriteLine("Choose from 3 options");
                        Console.WriteLine("1. BanUser");
                        Console.WriteLine("2. Print info about moderator");
                        Console.WriteLine("3. to exit");

                        int selection = InputValidation.ValidateInput(Console.ReadLine());

                        switch (selection)
                        {
                            case 1:
                                User someUser = BanSelection();
                                Console.WriteLine("Please write the reason for ban");
                                loggedModerator.BanUser(someUser, Console.ReadLine());
                                continue;
                            case 2:
                                loggedModerator.PrintUser();
                                continue;
                            case 3:
                                Console.WriteLine("Goodbye");
                                return;
                            default:
                                Console.WriteLine("Wrong choice. Valid number are from 1 to 3");
                                continue;
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No such name in database");
                    Console.ResetColor();
                }
            }
        }

        public User BanSelection()
        {
            
            while (true)
            {
                  
                Console.WriteLine("Please choose user to ban");
                UserRepo.ReturnListOfUsers().ForEach(x => Console.WriteLine($"User:{x.UserName} - role:{x.Role}"));

                string userInput = Console.ReadLine();
                
                Guest guest = UserRepo.GetGuestByUserName(userInput);
                Poster poster = UserRepo.GetPosterByUserName(userInput);

                if(guest != null)
                {
                    return guest;
                }

                if(poster != null)
                {
                    return poster;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No such name in database");
                    Console.ResetColor();
                }
            }
        }
    }
}
