using Homework02.Domain.Interfaces;
using Homework02.Domain.Roles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework02.Domain.Models
{
    public class Moderator : User, IModerator
    {       
        public override string UserName { get; set; }
        public override UserRole Role { get; set; }
        public override List<string> Comments { get; set; }
        public List<User> Users { get; set; }

        public Moderator (string userName) : base(userName)
        {
            UserName = userName;
            Role = UserRole.Moderator; // default for role moderator
            Comments = new List<string>();
            /*Users = new List<User>(); */// instanced by default
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
