using Homework02.Domain.Models;
using Homework02.Domain.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework02.Domain.Data
{
    public class UserRepo
    {
        public Guest GetGuestByUserName(string userName)
        {
           Guest Guest = InMemoryDatabase.Guests.FirstOrDefault(guest => guest.UserName.ToLower().Equals(userName));
            return Guest;
        }
        public Poster GetPosterByUserName(string userName)
        {
            Poster poster = InMemoryDatabase.Posters.FirstOrDefault(guest => guest.UserName.ToLower().Equals(userName));
            return poster;
        }
        public Moderator GetModeratorByUserName(string userName)
        {
            Moderator moderator = InMemoryDatabase.Moderators.FirstOrDefault(guest => guest.UserName.ToLower().Equals(userName));
            return moderator;
        }
        public List<Guest> ReturnListOfGuest()
        {
            return InMemoryDatabase.Guests;
        }
        public List<Poster> ReturnListOfPosters()
        {
            return InMemoryDatabase.Posters;
        }
        public List<Moderator> ReturnListOfModerators()
        {
            return InMemoryDatabase.Moderators;
        }
        public List<User> ReturnListOfUsers()
        {
            List<User> listOfUsers = InMemoryDatabase.ListOfUsers;
            return listOfUsers;
        }
    }
}
