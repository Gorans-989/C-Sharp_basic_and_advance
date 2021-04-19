using Class10_Library.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;


namespace Class10_Library.Models
{
    public class Trainer : User
    {
       public List<Subject> Subject { get; set; }

        public Trainer(int id, string fname, string lname, string email, string password)
        : base(id, fname, lname, email, password, Role.Trainer)
        {

        }

    }
}
