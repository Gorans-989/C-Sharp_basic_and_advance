using Homework02.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework02.Domain.Interfaces
{
    public interface IModerator
    {
        List<User> Users { get; set; }
        void BanUser(User user, string reason);
    }
}
