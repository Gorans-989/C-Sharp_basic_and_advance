using System;
using System.Collections.Generic;
using System.Text;

namespace Class07_Inheritance_class_code_Services
{
    public class SalesPerson : Employee
    {
        public SalesPerson(string fname, string lname)
            : base(fname, lname, EmployeeRole.Sales, 500)
        {
            
        }
        private double SuccessSaleRevenue { get; set; }
        public void AddSuccessRevenue(int number)
        {
            SuccessSaleRevenue = number;
        }
        
        public override double GetSalary()
        {
            double result = 0;
            if(SuccessSaleRevenue <= 2000)
            {
                result = 500;
            }
            
            else if(SuccessSaleRevenue > 2000 && SuccessSaleRevenue <= 5000)
            {
                result = 1000;
            }

            else if(SuccessSaleRevenue > 5000)
            {
                // result = Salary + 1500 
               result = 1500;
            }
            //return result
            return base.GetSalary() + result;
        }

        

        //EXERCISE2●Create a SalesPerson class that inherits from Employee and has the following properties:
        //▹SuccessSaleRevenue double, private
        //▹The salary is by default 500 and role is default Sales
        //●Create constructor that sets all the properties
        //●Create a method called AddSuccessRevenue that will get a number and set the SuccessSaleRevenue
        //to that value
        //●Override the GetSalary method to return the value of the salary plus bonus that is calculated
        //by the SuccessSaleRevenue.
        //▹If less or equal to 2000 then add 500 bonus
        //▹If larger than 2000 but less or equal than 5000 then add 1000 bonus
        //▹If larger than 5000 add 1500 bonus


    }
}
