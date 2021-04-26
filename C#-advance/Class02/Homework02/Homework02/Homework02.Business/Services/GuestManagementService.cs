using Homework02.Domain;
using Homework02.Domain.Data;
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
        public void GuestMenu(int selection)
        {
            Console.WriteLine("Welcome to guest menu.");
            // post comment(add)
            // read comment
            //print info

            while (true)
            {
                Console.WriteLine("Press 1 to test methods for guest 1");
                int inputSelection = int.Parse(Console.ReadLine());
                switch (inputSelection)
                {
                    case 1:
                        //
                        InMemoryDatabase.Guests[0].ReadComment("pero");
                        InMemoryDatabase.Guests[0].PrintUser();
                        InMemoryDatabase.Guests[0].PostComment("corona19");
                        continue;
                    case 2:
                        //
                        continue;
                    default:
                        continue;
                }
            }
        }
        
    }
}
