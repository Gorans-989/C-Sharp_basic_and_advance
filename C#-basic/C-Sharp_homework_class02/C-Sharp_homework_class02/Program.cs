using System;

namespace C_Sharp_homework_class02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 01
            Console.WriteLine("Please enter the first number: ");
            string num1 = Console.ReadLine();
            
            Console.WriteLine("Please enter the second number: ");
            string num2 = Console.ReadLine();

            double parsedNum1 = 0;
            double parsedNum2 = 0;

            bool checkNum1 = double.TryParse(num1, out parsedNum1);
            bool checkNum2 = double.TryParse(num2, out parsedNum2);

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
            
            
            
            
            Console.ReadLine();
        }
    }
}
