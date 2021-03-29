using System;

namespace C_Sharp_Class02_homework_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to check if it can be divided by 3 or 5");
            bool input1 = int.TryParse(Console.ReadLine(), out int number1);


            if (input1) {
                if (number1 % 3 == 0 && number1 % 5 == 0)
                {
                    Console.WriteLine("Tik - Tak");
                }
                else if (number1 % 3 == 0 && number1 % 5 != 0)
                {
                    Console.WriteLine("Tik");
                }
                else if (number1 % 3 != 0 && number1 % 5 == 0)
                {
                    Console.WriteLine("Tak");
                }
                else if (number1 % 3 != 0 && number1 % 5 != 0)
                {
                    Console.WriteLine("Bad number");
                }
            }
            else
            {
                Console.WriteLine("The input is not of valid type. Please enter only numbers");
            }

            Console.ReadLine();
        }
    }
}
