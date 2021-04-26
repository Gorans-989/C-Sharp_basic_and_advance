using System;
using System.Collections.Generic;
using System.Text;

namespace Homework02.Domain.Interfaces
{
    public interface IGuest
    {
        int Id { get; set; }
        void ReadComment(string comment);
    }
}
