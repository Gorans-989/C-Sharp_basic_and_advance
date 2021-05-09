using System;
using System.Collections.Generic;
using System.Text;
using VideoRentalApp_Data.Models;

namespace VideoRentalApp_Services.Interfaces
{
    public interface IUserService
    {
        User LogIn();
        User SignUp();
    }
}
