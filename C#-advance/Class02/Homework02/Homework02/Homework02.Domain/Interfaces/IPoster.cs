using System;
using System.Collections.Generic;
using System.Text;

namespace Homework02.Domain.Interfaces
{
    public interface IPoster
    {
        int Points { get; set; }
        bool IsPosterOfTheWeek { get; set; }
        void CheckStats();

    }
}
