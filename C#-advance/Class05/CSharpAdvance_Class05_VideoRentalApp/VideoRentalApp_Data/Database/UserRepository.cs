using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoRentalApp_Data.Models;

namespace VideoRentalApp_Data.Database
{
    public class UserRepository
    {
        public User GetUserByIdCard(int idCard)
        {
            return InMemoryDatabase.Users.FirstOrDefault(user => user.CardNumber == idCard);
        }

        public bool Insert(User user)
        {
            int beforeInsert = InMemoryDatabase.Users.Count;
            
            user.Id = ++InMemoryDatabase.userId;
            InMemoryDatabase.Users.Add(user);

            return InMemoryDatabase.Users.Count != beforeInsert;
        }

        public List<int> GetAllCardNumbers()
        {
            return InMemoryDatabase.Users.Select(user => user.CardNumber).ToList();
        }




    }
}
