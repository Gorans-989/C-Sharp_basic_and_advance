using Homework02.Domain.Roles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework02.Domain.Interfaces
{
    public interface IUser
    {

        string UserName { get; set; }
        UserRole Role { get; set; }
        List<string> Comments { get; set; }
        void PostComment(string comment);
        void PrintUser();

    }
}
