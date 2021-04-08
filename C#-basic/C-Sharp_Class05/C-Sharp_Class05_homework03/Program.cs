using System;

namespace C_Sharp_Class05_homework03
{
    class Program
    {
        static void Main(string[] args)
        {
            /* *Make a method called AgeCalculator
               *The method will have one input parameter, your birthday date
               *The method should return your age
               * Show the age of a user after he inputs a date
            */

            Console.WriteLine("Enter you birth day dd/MM/yyyy");

            DateTime todayDate = DateTime.Now;
            string userInput = Console.ReadLine();

            DateTime userBirthday = new DateTime();
            Console.WriteLine("empty date = " + userBirthday);

            userBirthday = DateTime.Parse(userInput);
            //Console.WriteLine("===== setting boolean =====");
            //bool checkInput = Convert.ToBoolean(userBirthday = DateTime.Parse(userInput));
            //Console.WriteLine("checking boolean value" + checkInput);

            Console.WriteLine("====== after parsing ========");
            Console.WriteLine(userBirthday);
            Console.WriteLine("======================");

            
            int year = userBirthday.Year;
            int month = userBirthday.Month;
            int day = userBirthday.Day;


            int todayYear = todayDate.Year;
            int todayMonth = todayDate.Month;
            int todayDay = todayDate.Day;

           // int resultYear, resultMonth, resultDay;



            //if(todayYear > year)
            //{
            //    resultYear = todayYear - year;
            //    if(todayMonth > month)
            //    {
            //        resultMonth = todayMonth - month;
            //    }
            //    if(todayMonth < month)
            //    {
            //        resultMonth = month - todayMonth;
            //        resultYear -= 1;
            //    }
                
            //}






            Console.ReadLine();
        }

        static void returnAge(DateTime input)
        {
            DateTime todayDate = DateTime.Now;



        }

    }
}
