using System;

namespace C_Sharp_Class05_homework01
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Task 08
            /*## Task 8:
            Create a function to take one parameter n and calculate what day of the week is n days from this moment.
            */

            /*
            Console.WriteLine("Please enter a number");
            bool checkInput = int.TryParse(Console.ReadLine(), out int inputNumber);
            if (checkInput)
            {
                dayOftheWeek(inputNumber);
            }
            else
            {
                Console.WriteLine("Wrong input. please write only numbers");
            }

            */
            #endregion

            #region Task 09
            /*## Task 9:
            Create a function to take one parameter n to display the date of past n years from current date
            and to tell what day it was. The parameter should not be larger that 20.
            */
            Console.WriteLine("Please type a number from 0-20 and go back in time");
            bool checkInput2 = int.TryParse(Console.ReadLine(), out int inputNumber2);
            if( checkInput2 )
            {
                if(inputNumber2 > 0 && inputNumber2 <= 20)
                {
                    displayPastYear(inputNumber2);
                }
                else
                {
                    Console.WriteLine($"The input {inputNumber2} is not a valid number");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Type only only numbers from 0 - 20");
            }


            #endregion

            Console.ReadLine();
        }   
        
        static void dayOftheWeek(int number)
        {
            DateTime todayDate = DateTime.Now;
            Console.WriteLine($"Today is: {todayDate}");
            Console.WriteLine(todayDate.AddDays(number)); 
        }


        static void displayPastYear(int number)
        {
            DateTime todayDate = DateTime.Now;
            Console.WriteLine($"Today is: {todayDate}");
            DateTime result = todayDate.AddYears(-number);
            string formatedResult = result.ToLongDateString();
            string directFormat = string.Format("The new date is {0: dd-MM-yyyy}. You travelled " + number + " years in the past"
                , result);
            Console.WriteLine(directFormat);
            Console.WriteLine($"Using .dayOfWeek - {result.DayOfWeek}");
            Console.WriteLine($"Using .ToLongDateString() - {formatedResult}");            
        }
    }
}
