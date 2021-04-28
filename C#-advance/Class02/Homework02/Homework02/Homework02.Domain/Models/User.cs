using Homework02.Domain.Interfaces;
using Homework02.Domain.Roles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework02.Domain.Models
{
    public abstract class User : IUser
    {
       
        public string UserName { get ; set ; }
        public UserRole Role { get; set ; }
        public List<string> Comments { get; set; }

        public User()
        {

        }
        public User(string userName)
        {
            UserName = userName;
            Comments = new List<string>();
        }
        public virtual void PostComment(string comment)
        {
            Comments.Add(comment);
        }
        //public abstract void PostComment(); prvo ja napraviv abstract pa smeniv
       
        
        public abstract void PrintUser();      
        
    }
}
