using SEDC.CSharpOop.Class10.Bussines.ServiceModels;
using SEDC.CSharpOop.Class10.Bussines.Services;
using System;

namespace SEDC.CSharpOop.Class10.AcademyManagementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManagmentService userManagmentService = new UserManagmentService();
            AdminManagmentService adminManagmentService = new AdminManagmentService();

            UserResult userResult = userManagmentService.Login();

            Console.WriteLine($"Welcome User");
          
            if(userResult.Admin != null)
            {
                while (userResult.IsLoggedIn)
                {
                    AdminMenu();
                    // parse console inputt
                    bool isValid = int.TryParse(Console.ReadLine(), out int selectiion);
                    if(isValid != false)
                    {
                        adminManagmentService.AddNewUser(selectiion);

                    }

                    
                }
            }
            else if(userResult.Student != null)
            {
                while (userResult.IsLoggedIn)
                {
                    // doSomething
                }
            }
            else if(userResult.Trainer != null)
            {
                while (userResult.IsLoggedIn)
                {
                    // doSomething
                }
            }
            else
            {
                Console.WriteLine("Something bad has happend");
            }
           

            


            Console.ReadLine();
        }

        public static void AdminMenu()
        {
            Console.WriteLine("This is admin menu");
            Console.WriteLine("1. Add new Admin");
            Console.WriteLine("2. Remove Admin");
            Console.WriteLine("3. Add new Student");
            Console.WriteLine("4. Remove existing Student");
            Console.WriteLine("5. Add new Trainer");
            Console.WriteLine("6. Remove new Trainer");
        }
        
    }
}
