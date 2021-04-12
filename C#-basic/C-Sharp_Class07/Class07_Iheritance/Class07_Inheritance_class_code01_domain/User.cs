using System;
using System.Collections.Generic;
using System.Text;

namespace Class07_Inheritance_class_code01_domain
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Role Role { get; set; }

        public string Email { get; set; }

    }
}
