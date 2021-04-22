using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpOop.Class10.Domain.Models
{
    public class Subject
    {
        public string Name { get; set; }
        public int NumberOfClasses { get; set; }
        public bool IsOptional { get; set; }
        public DateTime StartOn { get; set; }
        public DateTime EndOn { get; set; }
        public List<string> StudentsAttending { get; set; } = new List<string>();
    }
}
