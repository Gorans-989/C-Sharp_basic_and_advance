using System;

namespace C_Sharp_Class05_homework02
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Task10
            /*## Task 10: 
            Create a function that takes a number as an argument and returns an array of numbers counting down from this number to zero.
            * 5 -> [5, 4, 3, 2, 1, 0]
            */

            /*
            int[] resultArray = new int[] { };

            Console.WriteLine("Write a number and wait for countdown");
            bool checkInput = int.TryParse(Console.ReadLine(), out int counter);

            if (checkInput)
            {
                if (counter > 0)
                {
                    
                    resultArray = countingDownArray(counter);
                }
                else
                {
                    Console.WriteLine("Error - You entered a invalid number");
                }
            }
            else
            {
                Console.WriteLine("Error - You entered a invalid number");
            }

            //Console.WriteLine(resultArray[0]);
            //Console.WriteLine(resultArray[5]);
            */

            #endregion

            #region Task 11
            /*## Task 11:
            Create a function that takes an array and returns the difference between the biggest and smallest numbers.
            * [10, 4, 1, 4, -10, -50, 32, 21] -> 82
            */
            /*
            Console.WriteLine("Difference in array");
            int[] exampleArray = { 85, 4, -120, -5, -606, 84, 150, 372 };
            differenceInArray(exampleArray);

            */
            #endregion

            #region Task 12
            /*## Task 12: 
            Create a function that goes through the array, incrementing (+1) for each odd number
            and decrementing (-1) for each even number and returns that array.
            * [1, 2, 3, 4, 5] -> [2, 1, 4, 3, 6]
            */

            /*
            Console.WriteLine("Some task");
            int[] someNumberArray = { 32, 45, 2, -8, -7, 9 };
            int [] alteredArray = incrementDecrementArray(someNumberArray);

            Console.Write("Original array is array: ");
            foreach (int num in someNumberArray)
            {
                Console.Write($"{num}/");
            }
            Console.WriteLine("End of original array");

            Console.Write("Altered array is array: ");
            foreach (int num in alteredArray)
            {
                Console.Write($"{num}/");
            }
            Console.WriteLine("End of alttered array");
            */

            #endregion


            Console.ReadLine();
        }
        
        //write methods in Class Program!
        
        //task10 method
        static int[] countingDownArray(int number)
        {
            int[] result = new int[number + 1];
            for(int i = number; i >= 0; i--)
            {
                result[i] = i;
                Console.WriteLine(result[i]);
            }
            return result;
        }
    
        //task11 method
        static void differenceInArray(int[] array1)
        {
            int a = 0;
            int b = 0;
            foreach(int number in array1)
            {
                if(a < number)
                {
                    a = number;
                }
                if(b > number)
                {
                    b = number;
                }
            }
            int result = a - b;
            Console.WriteLine($"The difference between {a} and {b} is: {result}");
        }
    
        //task12 method
        static int[] incrementDecrementArray(int[] inputArray)
        {
            int[] result = new int[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                if(inputArray[i] % 2 == 0)
                {
                    result[i] = inputArray[i] - 1;
                }
                else
                {
                    result[i] = inputArray[i] + 1;
                }
            }
            return result;
        }


    }
}
