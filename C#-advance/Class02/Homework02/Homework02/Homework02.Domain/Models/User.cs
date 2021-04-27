﻿using Homework02.Domain.Interfaces;
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

        public User(string userName)
        {
            UserName = userName;
            Comments = new List<string>();
        }
        public abstract void PostComment(string comment);
        
        public abstract void PrintUser();      
        
    }
}
