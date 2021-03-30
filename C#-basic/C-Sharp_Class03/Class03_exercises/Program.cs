using System;

namespace Class03_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task
            //// Task 01
            //Console.WriteLine("please enter some number");
            //int input1 = int.Parse(Console.ReadLine());

            //for(int i = 2; i < input1; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        Console.WriteLine("the even numbers are :" + i);
            //    }

            //}


            //// Task 02

            //Console.WriteLine("enter some number");
            //int input2 = int.Parse(Console.ReadLine());

            //for (int i = 1; i < input2; i++)
            //{
            //    if(i % 2 !=0)
            //    {
            //        Console.WriteLine("Even number is " + i);
            //    }
            //}

            //// Task 03

            //Console.WriteLine("Enter some number");
            //int input3 = int.Parse(Console.ReadLine());

            //for (int i = 0; i < input3; i++)
            //{
            //    if(i % 3 == 0 || i % 7 == 0)
            //    {
            //        continue;
            //    }

            //    else
            //    {
            //        Console.WriteLine("the numbers are:" + i);
            //    }
            //}
            #endregion

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 10 };
            
            for (int i = array.Length -1 ; i > -1 ; i--)
            {
                int[] reverseArray = new int[array.Length];
                int counter2 = 0;
                reverseArray[counter2] = array[i];
                Console.WriteLine("Reverse array is " + reverseArray[counter2]);
                Console.WriteLine(reverseArray[0]);
            }

            int[] someArray = new int[5];
            someArray[0] = array[0];

            Console.WriteLine(someArray[0] + "last cw line");
            

            Console.ReadLine();
        }
    }
}
