using SEDC.CSharpOop.Class10.Domain.Data;
using SEDC.CSharpOop.Class10.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpOop.Class10.Bussines.Services
{
    public class StudentManagementService
    {
        private UserRepo UserRepo { get; set; }
        private SubjectRepo SubjectRepo { get; set; }

        public StudentManagementService()
        {
            UserRepo = new UserRepo();
            SubjectRepo = new SubjectRepo();
        }

        public void DisplaySubjectAndGrades(Student student)
        {
            SubjectRepo.listOfStudentSubjectsAndGrades(student);
        }
        public bool StudentExit()
        {
            Console.WriteLine("Press Enter to exit");
            return false;
        }


    }
}
