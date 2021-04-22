using SEDC.CSharpOop.Class10.Domain.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpOop.Class10.Domain.Data
{
    public class SubjectRepo
    {
        // methods for subjcets

        public void listOfStudentSubjectsAndGrades(Student student)
        {
            Console.WriteLine("This are the Subjects the student is attending");
            Dictionary<string, int> gradesDictionary = student.GetGrades();
            foreach (KeyValuePair<string, int> item in gradesDictionary)
            {
                Console.WriteLine($"Subject: {item.Key.ToUpper()} - Grade:{item.Value}");
            }
        }

        public void ListOfStudentSubjects(Student student)
        {
            Console.WriteLine("This are the Subjects the student is attending");
            Dictionary<string, int> gradesDictionary = student.GetGrades();
            foreach (KeyValuePair<string, int> item in gradesDictionary)
            {
                Console.WriteLine($"Subject: {item.Key.ToUpper()}");
            }

        }

        public void DisplaySubjectsAndStudentsAttending()
        {
            List<Student> studentsList = InMemoryDatabase.Students;
            List<Subject> subjectsList = InMemoryDatabase.Subjects;
            
            //Dictionary<string, List<string>> subjectsWithStudentsDictionary = new Dictionary<string, List<string>>();

            foreach(Subject subject in subjectsList)
            {
                foreach(Student student in studentsList)
                {
                    foreach(Subject item in student.Subjects)
                    {
                        if(subject.Name == item.Name)
                        {
                            //add student name to that subject
                            subject.StudentsAttending.Add( student.FirstName);
                        }
                    }
                }
            }
            foreach(var item in subjectsList)
            {
                foreach (var element in item.StudentsAttending) 
                {
                    Console.WriteLine($"{item.Name} Attending students :{element}");
                }
            }
        }
    }
}
