
using System;
using Class07_Inheritance_class_code_Services;
using Class07_Inheritance_class_code01_domain;





namespace Class07_Inheritance_class_code01
{
    class Program
    {
        static void Main(string[] args)
        {

            SalesPerson salesPerson1 = new SalesPerson("Goran", "Stojanovski");
            SalesPerson salesPerson2 = new SalesPerson("Ana", "Ivanova");

            Manager manager1 = new Manager("Pero", "Petrov");
            Manager manager2 = new Manager("Iva", "Ivkova");

            Console.WriteLine("info for salesPerson 1:");
            salesPerson1.PrintInfo();
            salesPerson1.AddSuccessRevenue(1502);
            Console.WriteLine("we added a Success revenue of 1502");
            double salary1 = salesPerson1.GetSalary();
            Console.WriteLine($"The employee {salesPerson1.FirstName} should have a salary of {salary1} $");
            Console.WriteLine("===============================================================");

            manager1.AddBonus(800);
            manager1.AddBonus(1200);
            double resultManager = manager1.GetSalary();
            Console.WriteLine(resultManager);           
            
          

            Console.ReadLine();
        }
    }
}
