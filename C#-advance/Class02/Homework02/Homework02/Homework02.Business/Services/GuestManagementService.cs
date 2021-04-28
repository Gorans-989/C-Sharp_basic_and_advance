using Homework02.Domain;
using Homework02.Domain.Data;
using Homework02.Domain.Helpers;
using Homework02.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework02.Business.Services
{
    public class GuestManagementService
    {
        private UserRepo UserRepo { get; set; }
        public GuestManagementService()
        {
            UserRepo = new UserRepo();
        }

        public void GuestMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to guest menu.");

            while (true)
            {
                Console.WriteLine("Please choose one guest by name or press \"x\" to quit");
                UserRepo.ReturnListOfGuest().ForEach(x => Console.WriteLine(x.UserName));

                string userInput = Console.ReadLine();
                if(userInput.ToLower() == "x")
                {
                    Console.WriteLine("Goodbye");
                    return;
                }

                //Guest loggedGuest = UserRepo.GetGuestByUserName(Console.ReadLine());

                Guest loggedGuest = UserRepo.GetGuestByUserName(userInput);

                if (loggedGuest != null)
                {
                    while (true)
                    {
                        Console.WriteLine("Choose from 3 options");
                        Console.WriteLine("1. read Comment");
                        Console.WriteLine("2. post Comment");
                        Console.WriteLine("3. Print info about guest");
                        Console.WriteLine("4. to exit");

                        int selection = InputValidation.ValidateInput(Console.ReadLine());

                        switch (selection)
                        {
                            case 1:
                                Console.WriteLine("Please write the comment to read it");
                                loggedGuest.ReadComment(Console.ReadLine());
                                continue;
                            case 2:
                                Console.WriteLine("Sorry Guests cant Post Comment. Only Poster do.");
                                continue;
                            case 3:
                                loggedGuest.PrintUser();
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
                    Console.WriteLine("No such name in database");
                }
                
                
                // post comment(add)
                // read comment
                //print info

            }
        }
    }
}
