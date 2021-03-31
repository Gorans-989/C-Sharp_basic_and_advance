using System;

namespace C_Sharp_Class03_Homework02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 02
            /*## Task 2
            * Make a new console application called StudentGroup
            * Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names. 
            * Get a number from the console between 1 and 2 and print the students from that group in the console.
                        */
            string[] studentGroup1 = { "goran", "zoran", "mile", "pero", "ace" };
            string[] studentGroup2 = { "maja", "ana", "sanja", "tina", "iva" };

            bool input = false;
            while (!input)
            {
                Console.WriteLine("Please enter number '1' or number '2'");
                input = int.TryParse(Console.ReadLine(), out int group);

                if (input)
                {
                    if (group == 1 || group == 2)
                    {
                        switch(group)
                        {
                            case 1:
                                Console.WriteLine("Student group 1 :");
                                
                                for (int i = 0; i < studentGroup1.Length; i++)
                                {
                                    Console.WriteLine("*" + studentGroup1[i]);
                                }

                                Console.WriteLine("=========== BYE :) ================");
                                break;
                            case 2:
                                Console.WriteLine("Student group 2 :");
                                
                                for (int i = 0; i < studentGroup2.Length; i++)
                                {    
                                    Console.WriteLine("*" + studentGroup2[i]);   
                                }

                                Console.WriteLine("=========== BYE :) ================");
                                break;
                        }
                    }
                    else {
                        input = false;
                        Console.WriteLine("You entered group number: " + group + ". There is no such group"); 
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input type. Please type only numbers");
                }
            }

            Console.ReadLine();
        }
    }
}
