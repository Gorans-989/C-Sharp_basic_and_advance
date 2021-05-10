using System;
using System.Collections.Generic;
using System.Text;

namespace QuizMillionaire_Domain.Helpers
{
    public static class InputParser
    {
        public static int CheckInput(int min, int max)
        {
            Console.WriteLine("Please type in the number of the answer you choose");
            while (true)
            {
                int parsedNumber = ValidateInput(Console.ReadLine(), min, max);
                if(parsedNumber >= min && parsedNumber <= max)
                {
                    return parsedNumber;
                } 
            }
        }

        private static int ValidateInput(string input,int min, int max)
        {
            int parsedNumber = 0;
            try
            {
                parsedNumber = int.Parse(input);
                if (!(parsedNumber >= min && parsedNumber <= max))
                {
                    throw new Exception($"Please select from the given range {min} to {max} ");
                }
            }
            catch (ArgumentException)
            {

                Console.WriteLine("Please enter argument");
            }
            catch (FormatException)
            {
                Console.WriteLine("Not valid Format");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number is to large or to low");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return parsedNumber;
        }
    }
}
