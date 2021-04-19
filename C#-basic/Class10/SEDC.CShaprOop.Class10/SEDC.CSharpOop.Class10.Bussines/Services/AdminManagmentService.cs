using SEDC.CSharpOop.Class10.Domain.Data;
using SEDC.CSharpOop.Class10.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpOop.Class10.Bussines.Services
{
    public class AdminManagmentService
    {
        private UserRepo UserRepo { get; set; }
        private SubjectRepo SubjectRepo { get; set; }

        public AdminManagmentService()
        {
            UserRepo = new UserRepo();
            SubjectRepo = new SubjectRepo();
        }

        // admin managment stuff
        public void AddNewUser( int selection)
        {
            //while (true)
            //{
                
                try
                {
                    //CheckSelection(selection);
                    Console.WriteLine($"{selection}");


                    if (selection == 1)
                    {   // adding new admin

                        Console.WriteLine("Please enter Admin First name");
                        string newAdminName = Console.ReadLine();
                        CheckEmptyInput(newAdminName);
                        Console.WriteLine("Please enter Admin Last name");
                        string newAdminLastName = Console.ReadLine();
                        CheckEmptyInput(newAdminLastName);
                        Console.WriteLine("Please enter Admin email");
                        string newAdminEmail = Console.ReadLine();
                        CheckEmptyInput(newAdminEmail);
                        Console.WriteLine("Please enter Admin password");
                        string newAdminPassword = Console.ReadLine();
                        CheckEmptyInput(newAdminPassword);

                        CheckEmailDomain(newAdminEmail);
                        CheckIfUserEmailExistInOtherModels(newAdminEmail);
                       
                        UserRepo.AddAdmin(new Admin(UserRepo.GetLengthOfAdmins() + 1,
                                newAdminName, newAdminLastName, newAdminEmail, newAdminPassword));
                            Console.WriteLine("Admin Created.");
                         
                    }
                    else if (selection == 3)
                    { // add New Student
                        Console.WriteLine("Please enter Student First name");
                        string newStudentName = Console.ReadLine();
                        CheckEmptyInput(newStudentName);
                        Console.WriteLine("Please enter Student Last name");
                        string newStudentLastName = Console.ReadLine();
                        CheckEmptyInput(newStudentLastName);
                        Console.WriteLine("Please enter Student email");
                        string newStudentEmail = Console.ReadLine();
                        CheckEmptyInput(newStudentEmail);
                        Console.WriteLine("Please enter Student password");
                        string newStudentPassword = Console.ReadLine();
                        CheckEmptyInput(newStudentPassword);

                        CheckEmailDomain(newStudentEmail);
                        CheckIfUserEmailExistInOtherModels(newStudentEmail);

                        
                        UserRepo.AddStudent(new Student(UserRepo.GetLengthOfStudents() + 1,
                            newStudentName, newStudentLastName, newStudentEmail, newStudentPassword));
                            Console.WriteLine("Student Created.");

                    // how to add subject to student.
                    // subject doesnt have constructor
                    // UserRepo.ListOFSubjects();

                    }
                    else if (selection == 5)
                    { // Add new Trainer

                    }
                    else
                    {
                        throw new Exception("Wrong input. Please type 1/2/3/4/5 or 6.");
                    }

                    // whole logic for adding new user
                    //Admins    id, fname, lname, email, password, Role.Admin)
                    //Student   id, fname, lname, email, password, Role.Student)
                    //Trainer   id, fname, lname, email, password, Role.Trainer)

                    
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                    Console.WriteLine("Please try again!");
                }

            // }

        }

        public void RemoveUser()
        {
            // whole logic for remove new user
        }

        public void CheckEmptyInput(string input)
        {
            if (input.Length < 1 || input == "")
            {
                throw new Exception("The input is not valid");
            }
        }

        public void CheckEmailDomain(string inputEmail)
        {
            if (inputEmail.EndsWith("@mail.com") == false)
            {
                throw new Exception("Email must be @mail.com domain");
            }
        }
        public void CheckIfUserEmailExistInOtherModels(string input)
        {
            Admin admin = UserRepo.GetAdminByEmail(input);
            Student student = UserRepo.GetStudentByEmail(input);
            Trainer trainer = UserRepo.GetTrainerByEmail(input);
            if (admin != null)
            {
                throw new Exception($"The email {input} already exist in admin Database ");
            }
            if(student != null)
            {
                throw new Exception($"The email {input} already exist in student Database ");
            }
            if(trainer != null)
            {
                throw new Exception($"The email {input} already exist in trainer Database ");
            }
        }
    }
}
