using System;
using System.Collections.Generic;
using System.Text;
using Class10_Library.Enumerations;

namespace Class10_Library.Models
{
    public class Student : User
    {
        private Dictionary<string, int> Grades { get; set; }       
        public List<Subject> Subjects { get; set; }

        public Student(int id, string fname, string lname, string email, string password)
        : base(id, fname, lname, email, password, Role.Student)
        {

        }

        public Dictionary<string, int> GetGRades()
        {
            return Grades;
        }

        public void AddGrade (string subject, int grade)
        {
            
        }

    }
}
