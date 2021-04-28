using System;
using System.Collections.Generic;
using System.Text;

namespace Homework02.Domain.Helpers
{
    public static class InputValidation
    {
        public static int ValidateInput(string input)
        {
            if(int.TryParse(input, out int selection))
            {
                return selection;
            }
            else
            {
                return -1;
            }

        }
    }
}
