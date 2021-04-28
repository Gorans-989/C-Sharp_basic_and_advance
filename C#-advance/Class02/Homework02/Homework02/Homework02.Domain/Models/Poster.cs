using Homework02.Domain.Interfaces;
using Homework02.Domain.Roles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework02.Domain.Models
{
    public class Poster : User, IPoster
    {
        public int Points { get; set; }
        public bool IsPosterOfTheWeek { get; set; }

        public Poster(string userName, int points) : base(userName)
        {
            UserName = userName;
            Points = points;
            Role = UserRole.Poster;
            //Comments = new List<string>();
        }

        
        public void CheckStats()
        {
            Console.WriteLine($"This user {UserName}has {Points} points and number of comments : {Comments.Count}");
        }

        public override void PrintUser()
        {
            Console.WriteLine($"User name is {UserName} and he has the role of {Role}");
        }

        public override void PostComment(string comment)
        {
            base.PostComment(comment);
            Console.WriteLine($"You added \"{comment} \" to your list of comments");
        }
        
    }
}
