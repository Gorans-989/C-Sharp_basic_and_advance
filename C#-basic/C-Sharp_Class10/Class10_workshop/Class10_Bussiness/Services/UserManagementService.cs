using Class10_Library.Data;
using Class10_Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class10_Bussiness.Services
{
    public class UserManagementService
    {
        private UserRepo UserRepo { get; set; }

        public UserManagementService()
        {
            UserRepo = new UserRepo();
        }

        public bool Login()
        {

            while (true)
            {
                Console.WriteLine("Please enter email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Please enter password: ");
                string password = Console.ReadLine();

                try
                {
                    Student student = UserRepo.GetStudentByEmail(email);
                    if (student != null)
                    {
                        student.ValidatePassword(password);
                    }
                    Admin admin = UserRepo.GetAdminByEmail(email);
                    if(admin != null)
                    {
                        admin.ValidatePassword(password);
                    }
                    Trainer trainer = UserRepo.GetTrainerByEmail(email);
                    if(trainer != null)
                    {
                        trainer.ValidatePassword(password);
                    }

                    
                    throw new Exception("Not valid email");
                }
                catch(Exception ex)
                {

                }


            }

            return true;
        }



    }
}
