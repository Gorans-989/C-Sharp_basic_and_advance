using Homework02.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework02.Business.Services
{
    public class ModeratorManagementService
    {
        public void ModeratorMenu(int selection)
        {
            Console.WriteLine("Welcome Moderator");
            foreach(var item in InMemoryDatabase.Moderators)
            {
                Console.WriteLine(item.Users.Count);
            }
            
            foreach(var item in InMemoryDatabase.ListOfUsers)
            {
                Console.WriteLine($"The user name is: {item.UserName} and his role is: {item.Role}");
            }
        }

    }
}
