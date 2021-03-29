using System;

namespace C_Sharp_class02_homework_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number");
            bool input1 = double.TryParse(Console.ReadLine(), out double number1);

            Console.WriteLine("Please enter second number");
            bool input2 = double.TryParse(Console.ReadLine(), out double number2);

            if (input1 && input2)
            {
                Console.WriteLine("Before swap");
                Console.WriteLine("The first number is: " + number1);
                Console.WriteLine("The second number is: " + number2);
                double temp = number1;
                number1 = number2;
                number2 = temp;
                Console.WriteLine("After swap");
                Console.WriteLine("The first number is: " + number1);
                Console.WriteLine("The second number is: " + number2);
            }
            else
            {
                if (!input1)
                {
                    Console.WriteLine("The first input is not of valid Type");
                }
                if (!input2)
                {
                    Console.WriteLine("The second input is not of valid type");
                }
            }
            

            Console.ReadLine();
        }
    }
}
