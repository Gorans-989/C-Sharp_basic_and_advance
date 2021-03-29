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

            Console.WriteLine("Please write the operator you want to use: + , - , / , * ");
            string operatorInput = Console.ReadLine();
            
            if(checkNum1 && checkNum2)
            {
                switch (operatorInput)
                {
                    case "+":
                        double sumResult = parsedNum1 + parsedNum2;
                        Console.WriteLine("The sum of the two numbers is: " + sumResult);
                        break;
                    case "-":
                        double substractResult = parsedNum1 - parsedNum2;
                        Console.WriteLine("The substract from the two numbers is: " + substractResult);
                        break;
                    case "/":
                        double divideResult = parsedNum1 / parsedNum2;
                        Console.WriteLine("The result from dividing the two numbers is: " + divideResult);
                        break;
                    case "*":
                        double multiplyResult = parsedNum1 * parsedNum2;
                        Console.WriteLine("The result from multiplying two numbers is: " + multiplyResult);
                        break;
                    default:
                        Console.WriteLine("Wrong input. Please enter only operators + , - , / , * ");
                        break;
                }
            }
            else if (!checkNum1 || !checkNum2)
            {
                if (!checkNum1) {
                    Console.WriteLine("The first number in not valid");
                }
                if (!checkNum2)
                {
                    Console.WriteLine("The second number is not valid");
                }
            }
            
            Console.ReadLine();
        }
    }
}
