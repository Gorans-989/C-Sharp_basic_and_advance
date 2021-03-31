using System;

namespace C_Sharp_Class03_Homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task01 SumOfSeven
            //Task 01 - Sum of Seven
            bool inputLength = false;

            while (!inputLength)
            {
                Console.WriteLine("How many numbers you want in the array? type number: ");
                inputLength = int.TryParse(Console.ReadLine(), out int lengthOfArray);
                int[] numbersArray = new int[lengthOfArray];
                
                if (inputLength){

                    int result01 = 0;
                    int i = 0;

                    while( i < lengthOfArray ){
                        Console.WriteLine("Please enter number for position " + i);
                        bool input = int.TryParse(Console.ReadLine(), out int number);
                        if(input)
                        {
                            numbersArray[i] = number;
                            Console.WriteLine("The number " + number + " is stored in the array at index: " + i);
                            if(number % 2 == 0)
                            {
                               result01 += number;
                            }
                            i++;
                        }
                        else
                        {
                            Console.WriteLine("Invalid number type. Please write only numbers!");
                        }
                    }
                    Console.WriteLine("The sum of the even numbers from the array is :" + result01);
                }
                else {
                    inputLength = false;
                    Console.WriteLine("Wrong input. Please type in only numbers!");
                }
            }
            Console.ReadLine();
            #endregion
        }
    }
}