using SEDC.CSharpOop.Class10.Domain.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpOop.Class10.Bussines.Services
{
    public class TrainerManagementService
    {
        private UserRepo UserRepo { get; set; }
        private SubjectRepo SubjectRepo { get; set; }

        public TrainerManagementService()
        {
            UserRepo = new UserRepo();
            SubjectRepo = new SubjectRepo();
        }
    }
}
