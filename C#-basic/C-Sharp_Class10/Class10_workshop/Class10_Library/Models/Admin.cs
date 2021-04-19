using Class10_Library.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class10_Library.Models
{
    public class Admin : User
    {
        public Admin(int id, string fname, string lname, string email,string password)
            : base(id, fname, lname, email, password, Role.Admin)
        {

        }




    }
}
