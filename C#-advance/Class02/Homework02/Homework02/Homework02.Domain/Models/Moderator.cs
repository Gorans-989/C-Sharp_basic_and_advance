using Homework02.Domain.Interfaces;
using Homework02.Domain.Roles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework02.Domain.Models
{
    public class Moderator : User, IModerator
    {       
        public List<User> Users { get; set; }

        public Moderator (string userName) : base(userName)
        {
            UserName = userName;
            Role = UserRole.Moderator; // default for role moderator is this ok?
            //Comments = new List<string>();
            /*Users = new List<User>(); */// instanced in database
        }


        public void BanUser(User user, string reason)
        {
            Console.WriteLine($"The user {user.UserName} is banned for \"{reason.ToUpper()}\"");
        }

        public override void PostComment(string comment)
        {
            Comments.Add(comment);
            Console.WriteLine($"You added \"{comment} \" to your list of comments");
        }

        public override void PrintUser()
        {
            Console.WriteLine($"User name is {UserName} and he has the role of {Role}");
        }
    }
}
