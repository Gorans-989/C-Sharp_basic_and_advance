using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using VideoRentalApp_Data.Database;
using VideoRentalApp_Data.Models;
using VideoRentalApp_Services.Helpers;
using VideoRentalApp_Services.Interfaces;

namespace VideoRentalApp_Services.Services
{
    public class UserService :IUserService
    {
        private UserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public User LogIn()
        {
            while (true)
            {
                Console.WriteLine("Enter card number:");
                int idCard = InputParser.ToInteger(100, 999);

                User user = _userRepository.GetUserByIdCard(idCard);
                if (user != null)
                {
                    //renew subscription( user);
                    Console.WriteLine($"welcome {user.FullName}");
                    return user;
                }
                Console.WriteLine("User card id doen not exists");
                Console.WriteLine("Try again y/n");
                if (!InputParser.ToConfirm())
                {
                    Console.WriteLine("Thank you using rent a video app");
                    Thread.Sleep(3000);
                }

            }

        }

        public User SignUp()
        {
            throw new NotImplementedException();
        }
    }
}
