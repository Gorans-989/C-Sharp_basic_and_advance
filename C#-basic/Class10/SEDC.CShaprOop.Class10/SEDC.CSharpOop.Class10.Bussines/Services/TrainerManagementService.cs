using SEDC.CSharpOop.Class10.Domain.Data;
using SEDC.CSharpOop.Class10.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpOop.Class10.Bussines.Services
{
    public class TrainerManagementService
    {
        private UserRepo UserRepo { get; set; }
        private SubjectRepo SubjectRepo { get; set; }

        public TrainerManagementService()
        {
            UserRepo = new UserRepo();
            SubjectRepo = new SubjectRepo();
        }

        public void TrainerFunctions(int selection)
        {
            try
            {
                if (selection == 1)
                {
                    DisplaySubjectsOfChosenStudent();


                    //type in name of students to see what subjects is he attending
                }
                if (selection == 2)
                {
                    //see list of subject and how many students attend it
                    SubjectRepo.DisplaySubjectsAndStudentsAttending();
                }
            }
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }

            



        }

        
        public void DisplaySubjectsOfChosenStudent()
        {
            while (true)
            {
                UserRepo.DisplayStudentsNames();
                Console.WriteLine("Write the name of the student to see what subjects is he attending");
                string studentName = Console.ReadLine();
                try
                {

                    Student student = UserRepo.GetStudentByFirstName(studentName);
                    if (student != null)
                    {
                        SubjectRepo.ListOfStudentSubjects(student);
                        return;
                    }
                    else
                    {
                        throw new Exception("This student name doesnt exist in our database. Please Try again");
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
        public void DisplaySubjectAndAttendingStudents()
        {
            //
            
        }

    }
}
