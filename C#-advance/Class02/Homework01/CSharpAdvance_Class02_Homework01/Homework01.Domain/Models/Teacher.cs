using Homework01.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework01.Domain.Models
{
    public class Teacher : User, ITeacher
    {
        public string Subject { get; set; }

        public Teacher(int id, string name, string userName, string password, string subject)
            : base(id, name, userName, password)
        {
            Subject = subject;
        }

        public override void PrintUser()
        {
            Console.WriteLine($"Student info: id:{Id} Name:{Name} UserName:{UserName} Subject:{Subject}");
        }
    }
}
