using SEDC.CSharpOop.Class10.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpOop.Class10.Domain.Data
{
    public class SubjectRepo
    {
        // methods for subjcets
        public void listOfStudentSubjects(Student student)
        {
            Console.WriteLine("This are the subject you are listening");
            Dictionary<string, int> gradesDictionary = student.GetGrades();
            foreach (var item in gradesDictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
