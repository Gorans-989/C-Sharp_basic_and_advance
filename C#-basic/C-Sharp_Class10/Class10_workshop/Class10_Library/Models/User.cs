using Class10_Library.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class10_Library.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public User(int id, string fName, string lName, string email, string password, Role role)
        {
            Id = id;
            FirstName = fName;
            LastName = lName;
            Email = email;
            Password = password;
            Role = role;
        }

        public void ValidatePassword(string password)
        {
            if (password != Password)
            {
                throw new Exception("Not valid password");
            }
        }

        public bool IsValidPassword(string password)
        {
            return password == Password;
        }
    }
}
