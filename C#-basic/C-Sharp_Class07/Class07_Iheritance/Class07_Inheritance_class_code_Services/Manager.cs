using System;
using System.Collections.Generic;
using System.Text;

namespace Class07_Inheritance_class_code_Services
{
    public class Manager : Employee
    {
        public Manager(string fname, string lname): base(fname,lname,EmployeeRole.Manager, 500)
        {

        }

        private double Bonus { get; set; }

        public double AddBonus(double input)
        {
            return Bonus += input;
        }

        public override double GetSalary()
        {
            return base.GetSalary() + Bonus;
        }
        //Add class Manager that inherits from Employee and has a new property called Bonus -double, private
        //●Create a constructor that sets all properties except Bonus●
        //Create a method called AddBonus that adds bonus to the Bonus property●
        //Override the method GetSalary to return the Salary + Bonus
    }
}
