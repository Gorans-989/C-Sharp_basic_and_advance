using Homework02.Domain.Interfaces;
using Homework02.Domain.Roles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework02.Domain.Models
{
    public class Guest : User, IGuest
    {
        public int Id { get; set; }

        public Guest(string userName, int id) : base(userName)
        {
            UserName = userName;
            Id = id;
            Role = UserRole.Guest;
            //Comments = new List<string>();
        }

        public override void PostComment(string comment)
        {
            Console.WriteLine("Sorry, Guest users cant post comments");
        }

        public override void PrintUser()
        {
            Console.WriteLine($"User name is {UserName} and he has the role of {Role}");
        }

        public void ReadComment(string comment)
        {
            //ReadComment(method) - accepts string and writes in the console: The Guest with Id: Id read this comment: Comment
            Console.WriteLine($"The Guest with ID : {Id} read this comment: {comment}");
        }
    }
}
