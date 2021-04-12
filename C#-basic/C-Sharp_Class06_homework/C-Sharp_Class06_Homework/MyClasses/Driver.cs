using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Class06_Homework.MyClasses
{
    // Make a class Driver. Add properties: Name, Skill
    public class Driver
    {
        public string Name { get; set; }
        public int Skill { get; set; }

        public Driver()
        {

        }
        public Driver(string name, int skill)
        {
            Name = name;
            Skill = skill;
        }

    }
}
