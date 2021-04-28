using Class03_Homework01_Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class03_Homework01_Domain.Helpers
{
    public static class ValidateObject
    {
        public static bool Validate(Dog someDog)
        {
            if (someDog.Name != string.Empty && someDog.Color != string.Empty && someDog.Id != 0)
            {
                if ((someDog.Id > 0) && (someDog.Name.Length > 2))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
