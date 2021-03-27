using System;

namespace C_Sharp_homework_class02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 01
            Console.WriteLine("Please enter the first number: ");
            bool checkNum1 = double.TryParse(Console.ReadLine(), out double parsedNum1);

            Console.WriteLine("Please enter the second number: ");
            bool checkNum2 = double.TryParse(Console.ReadLine(), out double parsedNum2);

            //double parsedNum1 = 0;
            //double parsedNum2 = 0;

                     

            Console.WriteLine("Please write the operator you want to use: + , - , / , * ");
            string operatorInput = Console.ReadLine();

            if(operatorInput == "+")
            {
                if(checkNum1 && checkNum2)
                {
                    double sumResult = parsedNum1 + parsedNum2;
                    Console.WriteLine("The sum of the two numbers is: " + sumResult);
                }
                
            }

            if(operatorInput == "-")
            {
                if(checkNum1 && checkNum2)
                {
                    double substractResult = parsedNum1 - parsedNum2;
                    Console.WriteLine("The substract from the two numbers is: " + substractResult);
                }
            }
            
            if(operatorInput == "*")
            {
                if(checkNum1 && checkNum2)
                {
                    double multiplyResult = parsedNum1 * parsedNum2;
                    Console.WriteLine("The result from multiplying two numbers is: " + multiplyResult);
                }
            }

            if(operatorInput == "/")
            {
                if(checkNum1 && checkNum2)
                {
                    double divideResult = parsedNum1 / parsedNum2;
                    Console.WriteLine("The result from dividing the two numbers is: " + divideResult);
                }
            }
            Console.WriteLine("===========================================================");
            Console.WriteLine("write a day of the week");
            string inputDay = Console.ReadLine();

            switch (inputDay)
            {
                case "monday":
                    Console.WriteLine(inputDay + " is a working day");
                    break;
                case "wednesday":
                    Console.WriteLine(inputDay + " is a working day");
                    break;
                case "saturday":
                    Console.WriteLine("Today is " + inputDay + ". Hooray! The weekend has started!");
                    break;
                default:
                    Console.WriteLine("The input is not of valid type");
                    break;
            }
            
            Console.ReadLine();
        }
    }
}
