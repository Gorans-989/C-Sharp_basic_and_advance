using System;

namespace C_Sharp_Class04_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] inputFromKeyboard = new int[5];
            int sumResult = 0;
            
            int i = 0;
            while( i < 5)
            {
                Console.WriteLine("write number: " + i +" ");
                bool isValid = int.TryParse(Console.ReadLine(), out int number);

                if (isValid)
                {
                    inputFromKeyboard[i] = number;
                    sumResult += inputFromKeyboard[i];
                    i++;
                }
                else {
                    Console.WriteLine("Input not of valid type"); 
                }
                
            }
            Console.WriteLine(sumResult);
            */

            
            bool isValid = false;
            //int i = 0;
            string[] arrayInput = new string[1];
            
            while (!isValid)
            {
                
                Console.WriteLine("Please enter name:....");
                string userInput = Console.ReadLine();
                arrayInput[arrayInput.Length - 1] = userInput;




                Console.WriteLine("Do you want to continue? y or n");
                string yesOrNo = Console.ReadLine(); 

                if (yesOrNo == "n")
                {
                    foreach(string element in arrayInput)
                    {
                        Console.WriteLine(element);
                    }
                    isValid = true;
                    //break;
                }
                    
                if (yesOrNo == "yes")
                {
                    
                    Array.Resize(ref arrayInput, arrayInput.Length + 1);
                   
                }
                
            }



            Console.ReadLine();
        }
    }
}
