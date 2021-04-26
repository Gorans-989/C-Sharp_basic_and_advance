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
        public void AddOrRemoveUser( int selection, string LogedEmail)
        {
            //while (true)
            //{
                try
                {                    
                    Console.WriteLine($"{selection}");

                    if (selection == 1)
                    {   // adding new admin
                        AddnewAdmin();
                        
                    }
                    else if (selection == 3)
                    { // add New Student
                        AddNewStudent();

                    // how to add subject to student.
                    // subject doesnt have constructor
                    // UserRepo.ListOFSubjects();
                    }
                    else if (selection == 5)
                    { // Add new Trainer
                        AddNewTrainer();

                    }
                    // Logic For removing Users
                    else if(selection == 2)
                    { // remove admin
                        Console.WriteLine("Please choose what admin to remove");
                        UserRepo.ListOfAdmins();
                        RemoveAdmin(LogedEmail);
                    }
                    else if (selection == 4)
                    { // remove student
                        Console.WriteLine("Please choose what student to remove");
                        UserRepo.ListOfStudents();
                        RemoveStudent();
                    }
                    else if (selection == 6)
                    { //remove trainer
                        Console.WriteLine("Please choose what Trainer to remove");
                        UserRepo.ListOfTrainers();
                        RemoveTrainer();
                    }
                    
                    else
                    {
                        throw new Exception("Wrong input. Please type 1/2/3/4/5/6 or 7.");
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
                    //Console.WriteLine("Please try again!");
                }

            //return true;
            // }

        }

        public void RemoveAdmin(string LogedUserEmail)
        {
            while (true)
            {
                Console.WriteLine("Please enter the email of the admin you want to remove");
                try
                {
                    string input = Console.ReadLine();
                    Admin admin = UserRepo.GetAdminByEmail(input);
                    if (LogedUserEmail == input)
                    {
                        Console.WriteLine("Error, you cant remove yourself");
                        return;
                    }

                    else if (admin != null)
                    {
                        UserRepo.RemoveAdmin(admin);
                        return;
                    }
                    
                    else
                    {
                        throw new Exception("No such admin email in database");
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
            }
        }
        public void RemoveStudent()
        {
            while (true)
            {
                Console.WriteLine("Please enter the email of the student you want to remove");
                try
                {
                    string input = Console.ReadLine();
                    Student student = UserRepo.GetStudentByEmail(input);
                    if (student != null)
                    {
                        UserRepo.RemoveStudent(student);
                        return;
                    }
                    else
                    {
                        throw new Exception("No such student email in database");
                    }
                }
                catch(Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
            }
        }
        public void RemoveTrainer()
        {
            while (true)
            {
                Console.WriteLine("Please enter the email of the trainer you want to remove");
                try
                {
                    string input = Console.ReadLine();
                    Trainer trainer = UserRepo.GetTrainerByEmail(input);
                    if (trainer != null)
                    {
                        UserRepo.RemoveTrainer(trainer);
                        return;
                    }
                    else
                    {
                        throw new Exception("No such trainer email in database");
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
            }
        }

        public void AddnewAdmin()
        {
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
        }
        public void AddNewStudent()
        {
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
        }
        public void AddNewTrainer()
        {
            Console.WriteLine("Please enter Trainer First name");
            string newTrainerName = Console.ReadLine();
            CheckEmptyInput(newTrainerName);
            Console.WriteLine("Please enter Trainer Last name");
            string newTrainerLastName = Console.ReadLine();
            CheckEmptyInput(newTrainerLastName);
            Console.WriteLine("Please enter Trainer email");
            string newTrainerEmail = Console.ReadLine();
            CheckEmptyInput(newTrainerEmail);
            Console.WriteLine("Please enter Trainer password");
            string newTrainerPassword = Console.ReadLine();
            CheckEmptyInput(newTrainerPassword);

            CheckEmailDomain(newTrainerEmail);
            CheckIfUserEmailExistInOtherModels(newTrainerEmail);

            UserRepo.AddTrainer(new Trainer(UserRepo.GetLengthOfTrainers() + 1,
                 newTrainerName, newTrainerLastName, newTrainerEmail, newTrainerPassword));
        }
        public void CheckEmptyInput(string input)
        {
            if (input.Trim() == string.Empty) //Length < 1 || input == "" input == string.Empty
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
