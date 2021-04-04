using System;

namespace Class03_bonus_homeworks03
{
    class Program
    {
        static void Main(string[] args)
        {

            //## Task 9:
            // Write a program that will find all numbers in between 1 and 1000,
            // that divide the sum composed of their digits.
            #region Task 09
            /*
            int sumResult = 0;
            int dividedResutl = 0;
            bool isValid = false;

            while(!isValid) {
                Console.WriteLine("Write a number between 1 and 100 ");
                bool checkInput = int.TryParse(Console.ReadLine(), out int numberInput);

                if (checkInput)
                {
               
                    if (numberInput > 1 && numberInput < 100)
                    {
                        for (int i = 1; i < numberInput; i++)
                        {
                            int a = i / 10;
                            Console.WriteLine("The first number /10 is:" + a);
                            Console.WriteLine("===============================");
                            int b = i % 10;
                            Console.WriteLine("the second number % 10 is : " + b);
                            Console.WriteLine("================================");
                            sumResult += a + b;
                            Console.WriteLine("The result is:  " + sumResult);
                            Console.WriteLine("===============================");
                        }
                        dividedResutl = sumResult / numberInput;

                        Console.WriteLine("sum of numbers digits " + sumResult + '/' + " number input " + numberInput + " eaquals= " + dividedResutl);
                        isValid = true;
                    }
                    else
                    {
                        if(numberInput < 1)
                        {
                            Console.WriteLine("The number: " + numberInput + "is smaller than 1.");
                        }
                        if(numberInput > 100)
                        {
                            Console.WriteLine("The number: " + numberInput + "is bigger than 100");
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Invalid input type. Please write only numbers!");
                }
            }
            */
            #endregion

            #region Task 12
            /** ## Task 12: 
            Write a short program that prints each number from 1 to 100 on a new line.
            For each number that is divided by 3 print “Fizz” instead of the number.
            For each number that is divided by 5 print “Buzz” instead of the number.
            For each number that is divided by 3 and 5  print “FizzBuzz” instead of the number.
            */
            /*
            int i = 1;
            while (i < 100)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if ( i % 3 == 0 || i % 5 == 0)
                {
                    if (i % 5 == 0) 
                    {
                        Console.WriteLine("Buzz");
                    }
                    if ( i % 3 ==0)
                    {
                        Console.WriteLine("Fizz");
                    }
                }
                else
                    {
                        Console.WriteLine("the number is: " + i);
                    }
                i++;
            }
            */
            #endregion

            #region Task 10
            /*## Task 10.
            Write a program that will find out all numbers in the range [1 : 1000] 
            That divide the product composed of their digits.
            */
            /*
            int i = 1;
            int productOfDigits = 1;
            int divideResult = 0;
            int resultSum = 0;

            

                while ( i < 1000 )
                {
                    int a = 0;
                    int b = 0;
                    if (i <= 99)
                    {
                        a = i % 10;
                        b = i / 10;
                        productOfDigits *= a * b;
                        divideResult = (a * b) / (a + b);
                        Console.WriteLine("the number is: " + i + ". first digit is: " + b + ". Second digit is: " + a);
                        Console.WriteLine(" (a * b) / (a + b) . the result is " + divideResult);
                        Console.WriteLine("====================================");
                    }
                    if (i>99)
                    {
                        productOfDigits *= a * b;
                        a = i % 10;
                        b = i / 10 % 10;
                        int c = i / 10 / 10;
                        divideResult = (a * b * c) / (a + b + c);
                        Console.WriteLine("the number is: " + i + ". first digit is: " + c + ". " +
                            "Second digit is: " + b + ". third digit is: " + a);
                        Console.WriteLine(" (a * b * c) / (a + b + c) . the result is " + divideResult);
                        Console.WriteLine("====================================");
                    }
                    
                i++;
                }
                Console.WriteLine("The product of all digits is : " + productOfDigits);
            */

            #endregion


            #region Task 11
            /*## Task 11:
            Write a program that will print out all two-digit numbers, 
                which have the first digit greater than the second digit.
            */
            /*
            for( int i = 1; i < 100; i++)
            {
                int a = 1;
                int b = 1;
                
                if ( i /10 != 0)
                {
                    a = i % 10;
                    b = i / 10;
                    if (b > a)
                    {
                        Console.WriteLine("The number is: " + i);
                        Console.WriteLine("The first digit: " + b + " is bigger than the second digit: " + a );
                    }
                }
            }
            */


            #endregion

            Console.ReadLine();
        }
    }
}
