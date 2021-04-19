using System;
using System.Collections.Generic;
using System.Text;

namespace Class10_Library.Models
{
    public class Subject
    {


        public string Name { get; set; }
        public bool IsOptional { get; set; }
        public int NumberOfClasses { get; set; }
        public DateTime StartOn { get; set; }
        public DateTime EndOn { get; set; }

        

        //public Subject(string name, bool isOptional, int numOfClasses, DateTime startOn, DateTime endOn)
        //{
        //    Name = name;
        //    IsOptional = isOptional;
        //    NumberOfClasses = numOfClasses;
        //    StartOn = startOn;
        //    EndOn = endOn;
        //}


    }
}
