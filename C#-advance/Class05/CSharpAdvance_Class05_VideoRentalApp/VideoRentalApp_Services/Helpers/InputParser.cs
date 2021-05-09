using System;
using System.Collections.Generic;
using System.Text;

namespace VideoRentalApp_Services.Helpers
{
    public static class InputParser
    {
        public static int ToInteger(string input, int min, int max)
        {
            return ValidateInput(input, min,max);
        }
        public static int ToInteger(int min, int max)
        {
;
            while (true)
            {
                int parsedNumber = ValidateInput(Console.ReadLine(), min, max);
                if(parsedNumber != 0)
                {
                    return parsedNumber;
                }

            }



        }
        private static int ValidateInput(string input, int min, int max)
        {
            int parsedNumber = 0;
            try
            {
                parsedNumber = int.Parse(input);
                if(!(parsedNumber >= min && parsedNumber <= max))
                {
                    throw new Exception($"Please select from the given range {min} to {max} ");
                }
            }
            catch (ArgumentException)
            {

                Console.WriteLine("Please enter argument");
            }
            catch(FormatException)
            {
                Console.WriteLine("Not valid Format");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number is to large or to low");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return parsedNumber;
            
        }

        private static List<string> _validConfirmInputs = new List<string> { "y", "Y", "yes" };
        private static List<string> _validDeclineInput = new List<string> { "n", "N", "no" };
        public static bool ToConfirm()
        {
            
            
            while (true)
            {
                string value = Console.ReadLine();
                if (_validConfirmInputs.Contains(value))
                {
                    return true;
                }
                else if (_validConfirmInputs.Contains(value))
                    {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter valid input");
                    Console.WriteLine($"Valid inputs {string.Join(", ", _validConfirmInputs)}");
                }
            }
        }

    }
}
