using System;

namespace C_Sharp_class02_homework_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write first number: ");
            bool input1 = double.TryParse(Console.ReadLine(), out double number1);

            Console.WriteLine("Please write second number");
            bool input2 = double.TryParse(Console.ReadLine(), out double number2);

            Console.WriteLine("Please write third number");
            bool input3 = double.TryParse(Console.ReadLine(), out double number3);

            Console.WriteLine("Please write fourth number");
            bool input4 = double.TryParse(Console.ReadLine(), out double number4);
            
            if (input1 && input2 && input3 && input4)
            {
                double result = (number1 + number2 + number3 + number4) / 4;
                Console.WriteLine("The average number is: " + result);
            }
            else
            {
                if (!input1)
                {
                    Console.WriteLine("The First input is not of valid type. Please enter only numbers");
                }
                if (!input2)
                {
                    Console.WriteLine("The second input is not of valid type. Please enter only numbers");
                }
                if (!input3)
                {
                    Console.WriteLine("The third input is not of valid type. Please enter only numbers");
                }
                if (!input4)
                {
                    Console.WriteLine("The fourt input is not of valid type. Please enter only numbers");
                }
            }


            Console.ReadLine();
        }
    }
}
