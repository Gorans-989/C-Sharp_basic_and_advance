using System;

namespace Class03_bonus_homeworks
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Task 07 reverse the array
            //Task 7: Write a program that will reverse the array {“a”,”b”,”c”,”d”} so that the output is {“d”,“c”,“b”,“a”}.
            //-Do NOT use reverse array method:) 

            string[] originalArray = { "a", "b", "c", "d" };
            string[] reverseArray = new string[originalArray.Length];

            Console.Write("Reversed array elements are : ");
            int counter2 = 0;
            for (int i = originalArray.Length -1; i > -1; i--)
            {
                // int counter2 =0; Ako go inicijaliziram vo ovoj scope ne prifaka counter2 ++. Zosto?
                reverseArray[counter2] = originalArray[i];
                Console.Write(reverseArray[counter2] + ",");
                counter2++;
            }
            Console.WriteLine("..........");
            Console.WriteLine(reverseArray[0] + "...........");
            Console.WriteLine(reverseArray[1] + "...........");
            Console.WriteLine(reverseArray[2] + "...........");
            Console.WriteLine(reverseArray[3] + "...........");
            Console.WriteLine("========= END TASK ================");
            #endregion

            #region Task 01 & 02 divide by 3 and by 2
            //Write a program that will print out all numbers from the range 1-N (N is input from keyboard, N>2) that divide with 3.
            // same task but must divide by 3 and by 2
            Console.WriteLine("Enter a number bigger then 1 and smaller the 30");
            bool input = int.TryParse(Console.ReadLine(), out int numberN);
            int defaultResult = 0;

            if (input && numberN > 1 && numberN < 30)
            {
                Console.WriteLine("You entered the number: " + numberN);

                #region Divide by3
                //Task number divide by 3
                /*
                for (int i = 1; i < numberN; i++)
                {
                    if(i % 3 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine("========= END TASK ================");
                */
                #endregion

                #region Divide by 3 and by 2
                //Task number divide by 3 and by 2
                /*
                for (int i = 1; i < numberN; i++)
                {
                    if (i % 3 == 0 && i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine("========= END TASK ================");
                */
                #endregion

                #region Sum all even numbers
                // Task sum all even numbers
                for (int i = 1; i < numberN; i++)
                {
                    if (i % 2 == 0)
                    {
                        defaultResult += i;
                        
                    }
                }
                Console.WriteLine("The sum of all even numbers is: " + defaultResult);
                Console.WriteLine("========= END TASK ================");
                #endregion


            }
            else
            {
                Console.WriteLine("wrong input");
            }
            #endregion

            #region Task 3.
            //Write a program, which will be calculating the product of the digits of an input number.

            Console.WriteLine("Write some number with more than one digit: ");
            string inputNumber = Console.ReadLine();
            bool checkInput = int.TryParse(inputNumber, out int number);
            int multipliedResult = 1;

            if (checkInput)
            {
                Console.Write("You entered the number :" + number);
                for (int i = 0; i < inputNumber.Length; i++)
                {
                    string charToString = char.ToString(inputNumber[i]);
                    int parsedDigits = int.Parse(charToString);
                    multipliedResult *= parsedDigits;
                                    
                }
                //Console.Write("You entered the number:" + number);
                Console.WriteLine(". The product of the digits is :" + multipliedResult);
                Console.WriteLine("========= END TASK ================");
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
            #endregion

            Console.ReadLine();
        }
    }
}
