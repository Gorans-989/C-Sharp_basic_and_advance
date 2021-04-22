using SEDC.CSharpOop.Class10.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpOop.Class10.Domain
{
    public static class InMemoryDatabase
    {
        public static List<Admin> Admins { get; set; }
        public static List<Trainer> Trainers { get; set; }
        public static List<Student> Students { get; set; }
        public static List<Subject> Subjects { get; set; }
        
        

        static InMemoryDatabase()
        {
            GenerateAdmins();
            GenerateTrainers();
            GenerateStudentsAndSubjects();
            
            //asignSubjectsToStudents();
        }
        //private static void asignSubjectsToStudents()
        //{
        //    foreach (Student item in Students)
        //    {
        //        item.Subjects.Add(Subjects[0]);
        //        item.Subjects.Add(Subjects[1]);
        //    }

        // System.NullReferenceException: 'Object reference not set to an instance of an object.'
        //SEDC.CSharpOop.Class10.Domain.Models.Student.Subjects.get returned null.

        //}
        
        private static void GenerateStudentsAndSubjects()
        {
            Subjects = new List<Subject>
            {
                new Subject() { Name = "c# basic",
                    IsOptional = false,
                    NumberOfClasses = 10,
                    EndOn = new DateTime(2021, 04, 20),
                    StartOn =  new DateTime(2021, 04, 01)},
                new Subject() { Name = "c# advanced",
                    IsOptional = false,
                    NumberOfClasses = 10,
                    EndOn = new DateTime(2021, 05, 20),
                    StartOn =  new DateTime(2021, 05, 01)},
                new Subject() { Name = "javascript advanced",
                    IsOptional = false,
                    NumberOfClasses = 10,
                    EndOn = new DateTime(2021, 03, 20),
                    StartOn =  new DateTime(2021, 03, 01)},
                new Subject() { Name = "javascript basic",
                    IsOptional = false,
                    NumberOfClasses = 10,
                    EndOn = new DateTime(2021, 02, 20),
                    StartOn =  new DateTime(2021, 02, 01)},
                new Subject() { Name = "html",
                    IsOptional = false,
                    NumberOfClasses = 10,
                    EndOn = new DateTime(2021, 01, 20),
                    StartOn =  new DateTime(2021, 01, 01)},
                new Subject() { Name = "css",
                    IsOptional = false,
                    NumberOfClasses = 10,
                    EndOn = new DateTime(2020, 12, 20),
                    StartOn =  new DateTime(2020, 12, 01)},
            };


            Students = new List<Student>
            {
                new Student(1, "Andjela", "Mitkova", "andmit@mail.com", "123asd")
                { Subjects = new List<Subject> { Subjects[0], Subjects[1], Subjects[4] } },

                new Student(2, "Angel", "Jordanovski", "andjor@mail.com", "123asd")
                { Subjects = new List<Subject> { Subjects[1], Subjects[0], Subjects[2] } },

                new Student(3, "Biljana", "Radevska", "bilrad@mail.com", "123asd")
                { Subjects = new List<Subject> { Subjects[2], Subjects[3], Subjects[4] } },

                new Student(4, "Filip", "Belevski", "filbel@mail.com", "123asd")
                { Subjects = new List<Subject> { Subjects[3], Subjects[4], Subjects[1] } },

                new Student(5, "Goran", "Stojanovski", "gorsto@mail.com", "123asd")
                { Subjects = new List<Subject> { Subjects[4], Subjects[3], Subjects[2] } },

                new Student(6, "Igor", "Tarchugovski", "igotar@mail.com", "123asd")
                { Subjects = new List<Subject> { Subjects[1], Subjects[3], Subjects[4] } },

                new Student(7, "Kristina", "Lazarovska", "krilar@mail.com", "123asd")
                { Subjects = new List<Subject> { Subjects[2], Subjects[3], Subjects[1] } }
            };


            Random randomNumber = new Random();

            //Students[0].AddGrade(Students[0].Subjects[0].Name, 8);
            foreach (Student item in Students)
            {
                foreach (Subject element in item.Subjects)
                {
                    item.AddGrade(element.Name, randomNumber.Next(6, 11));
                }
            }

        }

        private static void GenerateTrainers()
        {
                Trainers = new List<Trainer>();
                Trainers.Add(new Trainer(1, "Trajan", "Stevkovski", "traste@mail.com", "123asd"));
                Trainers.Add(new Trainer(2, "Damjan", "Stojanovski", "damsto@mail.com", "123asd"));
        }

        private static void GenerateAdmins()
        {
            Admins= new List<Admin>
            {
                new Admin(1, "admin", "admin", "admin@mail.com", "123asd"),
                new Admin(2,"admin2", "admin2", "admin2@mail.com", "123asd")
            };
        }

    }
}
