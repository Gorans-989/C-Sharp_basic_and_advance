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
        public Student GetStudentByFirstName(string firstName)
        {
            Student student = InMemoryDatabase.Students.FirstOrDefault(student => student.FirstName.ToLower() == firstName.ToLower());
            return student;
        }
        
        public void AddAdmin (Admin newAdmin)
        {
            InMemoryDatabase.Admins.Add(newAdmin);
            Console.WriteLine("Admin Created.");
        }
        public void AddStudent(Student newStudent)
        {
            InMemoryDatabase.Students.Add(newStudent);
            Console.WriteLine("Student Created.");
        }
        public void AddTrainer(Trainer newTrainer)
        {
            InMemoryDatabase.Trainers.Add(newTrainer);
            Console.WriteLine("Trainer Created.");
        }

        public void RemoveAdmin(Admin admin)
        {
            if (InMemoryDatabase.Admins.Remove(admin))
            {

                Console.WriteLine($"Admin {admin.FirstName} was removed from Database");
            }
            else
            {
                throw new Exception("Something went wrong. Please try again");
            }

        }
        public void RemoveStudent(Student student)
        {
            if (InMemoryDatabase.Students.Remove(student))
            {

                Console.WriteLine($"Student {student.FirstName} was removed from Database");
            }
            else
            {
                throw new Exception("Something went wrong. Please try again");
            }
            
        }
        public void RemoveTrainer(Trainer trainer)
        {
            if (InMemoryDatabase.Trainers.Remove(trainer))
            {

                Console.WriteLine($"Trainer {trainer.FirstName} was removed from Database");
            }
            else
            {
                throw new Exception("Something went wrong. Please try again");
            }

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

        public void ListOfAdmins()
        {
            foreach(var item in InMemoryDatabase.Admins)
            {
                Console.WriteLine(item.Email);
            } 
        }
        public void ListOfTrainers()
        {
            foreach (var item in InMemoryDatabase.Trainers)
            {
                Console.WriteLine(item.Email);
            }
        }
        public void ListOfStudents()
        {
            foreach (var item in InMemoryDatabase.Students)
            {
                Console.WriteLine(item.Email);
            }
        }
        public void DisplayStudentsNames()
        {
            foreach(Student student in InMemoryDatabase.Students)
            {
                Console.WriteLine(student.FirstName);
            }
        }

    }
}
