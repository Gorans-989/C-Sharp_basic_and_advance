using SEDC.CSharpOop.Class10.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.CSharpOop.Class10.Domain.Data
{
    public class UserRepo
    {
        public Admin GetAdminByEmail(string email)
        {
            Admin admin = InMemoryDatabase.Admins.FirstOrDefault(admin => admin.Email == email);
            return admin;
        }

        public Student GetStudentByEmail(string email)
        {
            Student student = InMemoryDatabase.Students.FirstOrDefault(student => student.Email == email);
            return student;
        }

        public Trainer GetTrainerByEmail(string email)
        {
            Trainer trainer = InMemoryDatabase.Trainers.FirstOrDefault(trainer => trainer.Email == email);
            return trainer;
        }

        public void AddAdmin (Admin newAdmin)
        {
            InMemoryDatabase.Admins.Add(newAdmin);
        }

        public void AddStudent(Student newStudent)
        {
            InMemoryDatabase.Students.Add(newStudent);
        }

        public int GetLengthOfAdmins()
        {
            int numb = InMemoryDatabase.Admins.Count;
            return numb;
        }
        public int GetLengthOfTrainers()
        {
            int numb = InMemoryDatabase.Trainers.Count;
            return numb;
        }
        public int GetLengthOfStudents()
        {
            int numb = InMemoryDatabase.Students.Count;
            return numb;
        }

        public void ListOFSubjects()
        {
            List<Student> students = InMemoryDatabase.Students;

            foreach(var item in students)
            {
                if(item.Subjects != null)
                {
                    Console.WriteLine($"{item.Subjects.Select(x=> x.Name != null)}");
                }
            }
        }
    }
}
