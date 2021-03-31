using System;

namespace Class03_bonus_homeworks02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 08

            /*Write a program that will read two arrays from console input.
             * Then the program has to make a comparison of the arrays and determine whether they are equal or not.
            { 1, 2, 3, 4 } == { 1, 2, 3, 4 }
            { 1, 2, 3, 4 } != { 2, 1, 3, 4 }*/

            #region first array input

                Console.WriteLine("How many numbers you want in the array? type number: ");
                bool inputLength = int.TryParse(Console.ReadLine(), out int lengthOfArray);
            
                int[] numbersArray = new int[lengthOfArray];

                if (inputLength)
                {
                    int i = 0;

                    while (i < lengthOfArray)
                    {
                        Console.WriteLine("Please enter number for position " + i);
                        bool input = int.TryParse(Console.ReadLine(), out int number);
                        if (input)
                        {
                            numbersArray[i] = number;
                            Console.WriteLine("The number " + number + " is stored in the array at index: " + i);
                            i++;
                        }
                        else
                        {
                            Console.WriteLine("Invalid number type. Please write only numbers!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input. Please type in only numbers!");
                }

            #endregion


            #region second array input

            Console.WriteLine("How many numbers you want in the array? type number: ");
            bool inputLength2 = int.TryParse(Console.ReadLine(), out int lengthOfArray2);

            int[] numbersArray2 = new int[lengthOfArray2];

            if (inputLength2)
            {
                int i = 0;

                while (i < lengthOfArray2)
                {
                    Console.WriteLine("Please enter number for position " + i);
                    bool input = int.TryParse(Console.ReadLine(), out int number);
                    if (input)
                    {
                        numbersArray2[i] = number;
                        Console.WriteLine("The number " + number + " is stored in the array at index: " + i);
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid number type. Please write only numbers!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Wrong input. Please type in only numbers!");
            }


            #endregion

            //Console.WriteLine("length of array 1 " + numbersArray.Length);
            //Console.WriteLine("length of array 2 " + numbersArray2.Length);

            #region compairing arrays

            if (numbersArray.Length == numbersArray2.Length)
            {
                for (int i = 0; i < numbersArray.Length; i++)
                {
                    if (Array.IndexOf(numbersArray, numbersArray2[i]) == i)
                    {
                        Console.WriteLine("Array1: " + numbersArray[i] + " . vs array2: " + numbersArray2[i]);
                    }
                    else
                    {
                        Console.WriteLine("The arrays are not equal");
                    }
                }
            }
            else
            {
                Console.WriteLine("start over. Array length is not same");
            }
            #endregion
            
            Console.ReadLine();
        }
    }
}
