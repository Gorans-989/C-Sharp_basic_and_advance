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
            StudentManagementService studentManagementService = new StudentManagementService();
            TrainerManagementService trainerManagementService = new TrainerManagementService();

            UserResult userResult = userManagmentService.Login();

            
          
            if(userResult.Admin != null)
            {
                Console.WriteLine($"Welcome Admin : {userResult.Admin.FirstName}");
                while (userResult.IsLoggedIn)
                {
                    
                    AdminMenu();
                    // parse console inputt
                    bool isValid = int.TryParse(Console.ReadLine(), out int selectiion);
                    if(isValid != false)
                    {
                        if(selectiion == 7)
                        {
                            userResult.IsLoggedIn = false;
                            Console.WriteLine("GoodBye Admin");
                        }
                        else
                        {
                            adminManagmentService.AddOrRemoveUser(selectiion, userResult.Admin.Email);
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong input. Please Try again");
                        Console.ResetColor();
                    }
                }
            }
            else if(userResult.Student != null)
            {
                while (userResult.IsLoggedIn)
                {
                    Console.WriteLine($"Welcome Student: {userResult.Student.FirstName}");
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    studentManagementService.DisplaySubjectAndGrades(userResult.Student);
                    userResult.IsLoggedIn = studentManagementService.StudentExit();
                    // doSomething
                }
            }
            else if(userResult.Trainer != null)
            {
                Console.WriteLine($"Welcome Trainer : {userResult.Trainer.FirstName}");
                while (userResult.IsLoggedIn)
                {
                    TrainerMenu();

                    bool isValid = int.TryParse(Console.ReadLine(), out int selection);
                    if(isValid != false)
                    {   
                        if(selection == 3)
                        {
                            Console.WriteLine($"Goodbye Trainer {userResult.Trainer.FirstName}");
                            userResult.IsLoggedIn = false;
                            //return;
                        }
                        else if(selection != 1 && selection != 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Wrong input. Please Try again");
                            Console.ResetColor();
                        }
                        
                        else
                        {
                            trainerManagementService.TrainerFunctions(selection);
                            // trainer management service
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Wrong input. Please Try again");
                        Console.ResetColor();
                    }
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
            Console.WriteLine("2. Remove existing Admin");
            Console.WriteLine("3. Add new Student");
            Console.WriteLine("4. Remove existing Student");
            Console.WriteLine("5. Add new Trainer");
            Console.WriteLine("6. Remove existing Trainer");
            Console.WriteLine("7. To Exit press \"7\"");
        }
        public static void TrainerMenu()
        {
            Console.WriteLine("This is trainer menu");
            Console.WriteLine("1. Press 1 to see all Students");
            Console.WriteLine("2. Press 2 to see all Subjects");
            Console.WriteLine("3. Press 3 to exit");
        }
        
    }
}
