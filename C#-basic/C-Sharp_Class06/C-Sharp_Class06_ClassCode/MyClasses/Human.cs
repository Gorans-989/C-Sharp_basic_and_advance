using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Class06_ClassCode.MyClasses
{
    public class Human
    {
        public string FirstName { get; set;}
        public string LastName { get; set; }
        public int Age { get; set; }
        public string GetPersonStats()
        {
            string personStats = $"The human name is: {FirstName} {LastName} and is {Age} years old";
            return personStats;
        }

    }
}
