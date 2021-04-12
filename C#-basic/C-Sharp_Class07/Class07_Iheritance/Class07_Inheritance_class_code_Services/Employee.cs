using System;

namespace Class07_Inheritance_class_code_Services
{
    public class Employee
    {
        public Employee(string fname, string lname, EmployeeRole role, double salary)
        {
            FirstName = fname;
            LastName = lname;
            Role = role;
            Salary = salary;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EmployeeRole Role { get; set; }
        protected double Salary { get; set; }

        public virtual double GetSalary()
        {
            //Console.WriteLine($"Write salary for worker name:{FirstName} ");
            //Console.WriteLine($"{Salary}");
            return Salary;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"The employee full name is: {FirstName} {LastName} and has {Salary} $");
        }

    }
}
