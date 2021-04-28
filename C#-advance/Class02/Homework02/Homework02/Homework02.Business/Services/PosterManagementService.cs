using Homework02.Domain.Data;
using Homework02.Domain.Helpers;
using Homework02.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework02.Business.Services
{
    public class PosterManagementService
    {
        private UserRepo UserRepo { get; set; }
        public PosterManagementService()
        {
            UserRepo = new UserRepo();
        }

        public void PosterMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to poster menu.");

            while (true)
            {
                Console.WriteLine("Please choose one poster by name or press \"x\" to quit");
                UserRepo.ReturnListOfPosters().ForEach(x => Console.WriteLine(x.UserName));

                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "x")
                {
                    Console.WriteLine("Goodbye");
                    return;
                }

                Poster loggedPoster = UserRepo.GetPosterByUserName(userInput);

                if (loggedPoster != null)
                {
                    while (true)
                    {
                        Console.WriteLine("Choose from 3 options");
                        Console.WriteLine("1. check stats");
                        Console.WriteLine("2. post Comment");
                        Console.WriteLine("3. Print info about poster");
                        Console.WriteLine("4. to exit");

                        int selection = InputValidation.ValidateInput(Console.ReadLine());

                        switch (selection)
                        {
                            case 1:
                                loggedPoster.CheckStats();
                                continue;
                            case 2:
                                Console.WriteLine("Please write the comment to post it");
                                loggedPoster.PostComment(Console.ReadLine()); //dali e vo red da se koristi vaka?
                                continue;
                            case 3:
                                loggedPoster.PrintUser();
                                continue;
                            case 4:
                                Console.WriteLine("Goodbye");
                                return;
                            default:
                                Console.WriteLine("Wrong choice. Valid number are from 1 to 4");
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
    }
}
