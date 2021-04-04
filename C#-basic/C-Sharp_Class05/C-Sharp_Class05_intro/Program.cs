using System;

namespace C_Sharp_Class05_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            #region String format
            /*
            string firstName = "Goran";
            string lastName = "Stojanovski";

            string fullName = string.Format("My fullname is {0} {1}", firstName, lastName);
            Console.WriteLine(fullName);


            //format for currency
            int dollars = 1000;
            string moneyUSD = string.Format("I won the lottery. {0:C} {1}", dollars, "My name is goran");
            Console.WriteLine(moneyUSD);

            //Custom Format
            string percentages = string.Format("Your chance of winning the lottery are: {0:P}", 0.0007);
            Console.WriteLine(percentages);
            */
            #endregion

            #region string methods
            // String methods

            //To lower case 
            /*
            string sentence = " Hello it's Saturday ";
            string sentenceToLower = sentence.ToLower();
            Console.WriteLine(sentenceToLower);
            Console.WriteLine(sentence);
            // Using trim to delete the space before string and after the end
            Console.WriteLine("This is the lenght of the sentance" + sentence.Length);
            Console.WriteLine("===================================");

            string cleanString = sentence.Trim();
            Console.WriteLine(cleanString);
            Console.WriteLine("Length after trim is: " + cleanString.Length);
            //TO upper case
            string exampleSmallCase = "this was a string with all small case letters. Not annymore :)";
            string upperCase = exampleSmallCase.ToUpper();

            Console.WriteLine(upperCase);

            */
            //

            #endregion

            #region indexOF length ToCharArray
            /*
            // .Length gives the length of the string. it return a number (int), which we can use vo math operations
            string demo = "Hello there g3";
            int numberOfCharachters = demo.Length;
            Console.WriteLine($"{demo}" + " " + $"The length is {demo.Length}");
            Console.WriteLine("The number of characters in string " + numberOfCharachters);

            bool startWithCheck = demo.StartsWith("Hello");
            Console.WriteLine(startWithCheck);

            //Index Of (search the char and bring back his index , position)
            string exampleString = "Hye there kids.Kiss It is me Supermen. Kiss - kiss";
            int checkPosition = exampleString.IndexOf("ss");
            Console.WriteLine(exampleString);
            Console.WriteLine(checkPosition);

            //ToCharArray 

            string demo2 = "Today is Saturday. First day of weekend.";
            char[] charArray = demo2.ToCharArray();
            foreach(char character in charArray)
            {
                if(character.ToString() == "f")
                {
                    Console.WriteLine("there is the letter f in the array");
                }
                Console.WriteLine(character + " ");
            }

            */
            #endregion

            #region Exercise01
            /*
            string example = "Hello from SEDC CodeAcademy 2021";
            Console.WriteLine("Write a number ");
            bool checkInput = int.TryParse(Console.ReadLine(), out int inputNumber);
            if(checkInput)
            {
                
                if(inputNumber < example.Length) { 
                    string newString = PrintCharacters(example, inputNumber);
                    Console.WriteLine("The new string is " + newString);
                    Console.WriteLine("The length of the new string is " + newString.Length);
                }
                else
                {
                    Console.WriteLine($"The number {inputNumber} is to big. Please write smaller number");
                }
            }
            else
            {
                Console.WriteLine("the input is invalid. Write only numbers");
            }
            */
            #endregion

            #region DateTime exercise
            /*
            DateTime todayDate = DateTime.Now;
            Console.WriteLine("Today is the :" + todayDate);
            DateTime day3InFuture = todayDate.AddDays(3);
            Console.WriteLine($"3 days in the future {day3InFuture}");
            DateTime monthInFuture = todayDate.AddMonths(1);
            Console.WriteLine($"1 month in the future {monthInFuture}");

            DateTime monthsAndDaysInFuture = todayDate.AddMonths(1).AddDays(3);
            Console.WriteLine($"1 month and 3 day in the future {monthsAndDaysInFuture}");

            DateTime yearAndMonthsPast = todayDate.AddYears(-1).AddMonths(-2);
            Console.WriteLine(yearAndMonthsPast);

            int currentMonth = todayDate.Month;
            Console.WriteLine(currentMonth);

            int currentYear = todayDate.Year;
            Console.WriteLine(currentYear);


            
            string onlyYear = string.Format("{0: yyyy} ", todayDate);
            string onlyMonth = string.Format("{0: MM}", todayDate);
            Console.WriteLine($"get the year only : {onlyYear}");
            Console.WriteLine($"get the month only : {onlyMonth}");
            */
            #endregion

            Console.ReadLine();
        }
        static string PrintCharacters(string someString, int number)
        {
                string cuttString = someString.Substring(0, number);
                return cuttString;   
        }

    }
}
