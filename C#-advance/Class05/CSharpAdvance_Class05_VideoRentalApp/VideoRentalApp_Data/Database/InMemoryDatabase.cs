using System;
using System.Collections.Generic;
using System.Text;
using VideoRentalApp_Data.Models;

namespace VideoRentalApp_Data.Database
{
    public static class InMemoryDatabase
    {
        public static List<User> Users { get; set; }
        public static int userId = 1;
        static InMemoryDatabase()
        {
            InitDatabase();
        }

        private static void InitDatabase()
        {
            Users = new List<User>
            {
                new User(){Id = 1, CardNumber = 123, FullName = "Smiley Face"}
            };
        }
    }
}
