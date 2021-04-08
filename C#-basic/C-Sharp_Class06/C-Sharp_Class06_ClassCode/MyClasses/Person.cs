using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Class06_ClassCode.MyClasses
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private long SSN { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            SSN = GenerateSSN();
        }
        public Person()
        {
            SSN = GenerateSSN();
        }

        private long GenerateSSN()
        {
            return new Random().Next(10000, 99999); 
        }

        public void Talk(string text)
        {
            Console.WriteLine($"The Human named {Name} (SSN:{SSN}) is saying this: {text}");
        }




        /*
            dokolku ne deklariram dali e public DEFAULT e slednoto :

        internal class Person
        {
            private string Name { get; set; }
            private int Age { get; set; }
            private long SSN { get; set; }

        }
        na ovoj nacin ne mozam da ja koristam nadvor od ovoj projekt t.e. class.
        */
    }
}
