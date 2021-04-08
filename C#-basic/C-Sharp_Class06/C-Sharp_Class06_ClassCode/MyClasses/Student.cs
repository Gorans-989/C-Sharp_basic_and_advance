using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Class06_ClassCode.MyClasses
{
    class Student
    {
        public string Name { get; set; }
        public string Academy { get; set; }
        public int Group { get; set; }

        public Student (string name, string academy, int group)
        {
            Name = name;
            Academy = academy;
            Group = group;
        }

        public void DisplayStats(string userInput)
        {
            if(Name.ToLower() == userInput.ToLower()) { 
            Console.WriteLine($"The student {Name} is studying at the Academy for {Academy} in group number {Group}");
            }
            else
            {
                Console.WriteLine("Error . no such student");
            }

        }

    }
}
