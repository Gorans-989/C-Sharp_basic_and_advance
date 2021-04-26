using Homework01.Domain.Models;
using System;

namespace Homework01.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student(1, "Goran", "GorSto", "123asd", 10);
            Student student2 = new Student(2, "Zoran", "ZorPro", "123asd", 9);

            Teacher teacher1 = new Teacher(1, "Ana", "AnaPro", "123asd", "Web Development");
            Teacher teacher2 = new Teacher(2, "Maja", "MajSto", "123asd", "Testing");

            Console.WriteLine("Printing the students");
            student1.PrintUser();
            student2.PrintUser();
            Console.WriteLine("Printing the teachers");
            teacher1.PrintUser();
            teacher2.PrintUser();

            Console.WriteLine("Press any key to exit.");





            Console.ReadLine();
        }
    }
}
