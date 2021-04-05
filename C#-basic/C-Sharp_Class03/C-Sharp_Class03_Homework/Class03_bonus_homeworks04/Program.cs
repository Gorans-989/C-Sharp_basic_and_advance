using System;

namespace Class03_bonus_homeworks04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           ## 🔥🔥 BONUS🔥🔥 
            Create a program(game) Guess the number.
            */
            bool isValid = false;

            while (!isValid)
            {
                Console.WriteLine("Welcome to Guess the number");
                Console.WriteLine("You have 3 dificulties");
                Console.WriteLine("     Easy    - In easy mode user should have 9 tries to guess the number between 0 - 100.");
                Console.WriteLine("     Normal  - In normal mode user should have 7 tries to guess the number between 0 - 500.");
                Console.WriteLine("     Hard    - In hard mode user should have 5 tries to guess the number between 0 - 1000.");
                Console.WriteLine("What do you choose?");

                string input = (Console.ReadLine());
                if(input.ToLower() == "easy")
                {
                    Console.WriteLine("You choose EASY. you have 9 attempts. GOOD LUCK");
                    Random rd = new Random();
                    int randomNumber = rd.Next(0, 100);
                    int counter = 1;
                    Console.WriteLine(randomNumber);

                    while (counter <= 9)
                    {
                        Console.WriteLine($"Attempt: {counter} - Write a number between 0 - 100");
                        bool checkInput = int.TryParse(Console.ReadLine(), out int userNumber);
                        if(checkInput)
                        {
                            if(userNumber == randomNumber)
                            {
                                if (counter == 1)
                                {
                                    Console.WriteLine("Lucky guess. You won from the first try." + "Your number is: " +
                                        userNumber + ". The winning number is: " + randomNumber);

                                    Console.WriteLine("Press 1 to restart or press any key to quit");
                                    char choice = Convert.ToChar(Console.ReadLine());
                                    if (choice == '1')
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        isValid = true;
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Congratulations you WON!! on your " + counter + " attempt. " +
                                    "The winnig number is: " + randomNumber +
                                    ". You entered the number: " + userNumber);
                                    Console.WriteLine("Thank you for playing");

                                    Console.WriteLine("Press 1 to restart or press any key to quit");
                                    char choice = Convert.ToChar(Console.ReadLine());
                                    if (choice == '1')
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        isValid = true;
                                        break;
                                    }
                                }
                                
                            }
                            else if(userNumber > 0 && userNumber < 100)
                            {
                            
                                if(randomNumber > userNumber)
                                {
                                    //Console.WriteLine("Try attempt number: " + counter);
                                    int x = 0;
                                    x = randomNumber - userNumber;
                                    if(x <= 5)
                                    {
                                        Console.WriteLine("hotter. the Winning number is higher than :" + userNumber);
                                    }
                                    else if( x > 5 && x < 10)
                                    {
                                        Console.WriteLine("hot. the Winning number is higher than :" + userNumber);
                                    }
                                    else if ( x > 10 && x < 15)
                                    {
                                        Console.WriteLine(" warm. the Winning number is higher than :" + userNumber);
                                    }
                                    else if (x > 15 && x < 20)
                                    {
                                        Console.WriteLine(" COLD . The winning number is higher than :" + userNumber);
                                    }
                                    else if( x >= 20)
                                    {
                                        Console.WriteLine(" Freeze . The winning number is much higher than :" + userNumber);
                                    }

                                }
                                if(randomNumber < userNumber)
                                {
                                    //Console.WriteLine("Try attempt number: " + counter);
                                    int x = 0;
                                    x = userNumber - randomNumber;
                                    if (x <= 5)
                                    {
                                        Console.WriteLine("hotter. the Winning number is lower than :" + userNumber);
                                    }
                                    else if (x > 5  && x < 10)
                                    {
                                        Console.WriteLine("hot. the Winning number is lower than :" + userNumber);
                                    }
                                    else if (x >= 10 && x < 15)
                                    {
                                        Console.WriteLine(" warm. the Winning number is lower than :" + userNumber);
                                    }
                                    else if (x >= 15 && x < 20)
                                    {
                                        Console.WriteLine(" COLD . The winning number is much higher than :" + userNumber);
                                    }
                                    else if (x >= 20)
                                    {
                                        Console.WriteLine(" FREAZING . The winning number is very much lower than :" + userNumber);
                                    }
                                }
                            }

                            if (counter == 8)
                            {
                                Console.WriteLine("Last Try");
                            }
                            if (counter == 9) { 
                                Console.WriteLine("You lost. The winning number was:" + randomNumber);
                                Console.WriteLine("Press 1 to restart or press any key to quit");

                                char choice = Convert.ToChar(Console.ReadLine());
                                if (choice != '1')
                                {
                                    isValid = true;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong input. Please type only number. Attempts left: " + ( 9 - counter ));
                        }
                        counter++;
                    }

                }

                else if (input.ToLower() == "normal")
                {
                    Console.WriteLine("You choose normal. you have 7 attempts. GOOD LUCK");
                    Random rd = new Random();
                    int randomNumber = rd.Next(0, 500);
                    int counter = 1;
                    
                    while (counter <= 7)
                    {
                        Console.WriteLine($"Attempt: {counter} - Write a number between 0 - 500");
                        bool checkInput = int.TryParse(Console.ReadLine(), out int userNumber);
                        if (checkInput)
                        {
                            if (userNumber == randomNumber)
                            {
                                if (counter == 1)
                                {
                                    Console.WriteLine("Lucky guess. You won from the first try." + "Your number is: " +
                                        userNumber + ". The winning number is: " + randomNumber);

                                    Console.WriteLine("Press 1 to restart or press any key to quit");

                                    char choice = Convert.ToChar(Console.ReadLine());
                                    if (choice == '1')
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        isValid = true;
                                        break;
                                    }
                                }
                                else { 
                                    Console.WriteLine("Congratulations you WON!! on your " + counter + " attempt. " +
                                        "The winning number is: " + randomNumber +
                                        ". You entered the number: " + userNumber);
                                    Console.WriteLine("thanks for playing");

                                    Console.WriteLine("Press 1 to restart or press any key to quit");
                                    char choice = Convert.ToChar(Console.ReadLine());
                                    if (choice == '1')
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        isValid = true;
                                        break;
                                    }
                                }
                            }
                            else if (userNumber > 0 && userNumber < 500)
                            {

                                if (randomNumber > userNumber)
                                {
                                    //Console.WriteLine("Try attempt number: " + (counter + 1));
                                    int x = 0;
                                    x = randomNumber - userNumber;
                                    if (x <= 5)
                                    {
                                        Console.WriteLine("hotter. the Winning number is higher than :" + userNumber);
                                    }
                                    else if (x > 5 && x < 10)
                                    {
                                        Console.WriteLine("hot. the Winning number is higher than :" + userNumber);
                                    }
                                    else if (x > 10 && x < 15)
                                    {
                                        Console.WriteLine(" warm. the Winning number is higher than :" + userNumber);
                                    }
                                    else if (x > 15 && x < 20)
                                    {
                                        Console.WriteLine(" COLD . The winning number is higher than :" + userNumber);
                                    }
                                    else if (x >= 20)
                                    {
                                        Console.WriteLine(" Freeze . The winning number is much higher than :" + userNumber);
                                    }

                                }
                                if (randomNumber < userNumber)
                                {
                                   // Console.WriteLine("Try attempt number: " + (counter +1));
                                    int x = 0;
                                    x = userNumber - randomNumber;
                                    if (x <= 5)
                                    {
                                        Console.WriteLine("hotter. the Winning number is lower than :" + userNumber);
                                    }
                                    else if (x > 5 && x < 10)
                                    {
                                        Console.WriteLine("hot. the Winning number is lower than :" + userNumber);
                                    }
                                    else if (x >= 10 && x < 15)
                                    {
                                        Console.WriteLine(" warm. the Winning number is lower than :" + userNumber);
                                    }
                                    else if (x >= 15 && x < 20)
                                    {
                                        Console.WriteLine(" COLD . The winning number is much higher than :" + userNumber);
                                    }
                                    else if (x >= 20)
                                    {
                                        Console.WriteLine(" FREAZING . The winning number is very much lower than :" + userNumber);
                                    }
                                }
                            }

                            if (counter == 6)
                            {
                                Console.WriteLine("Last Try");
                            }
                            if (counter == 7)
                            {
                                Console.WriteLine("You lost. The winning number was:" + randomNumber);
                                Console.WriteLine("Press 1 to restart or press any key to quit");

                                char choice = Convert.ToChar(Console.ReadLine());
                                if (choice == '1')
                                {
                                    break;
                                }
                                else
                                {
                                    isValid = true;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong input. Please type only number. Attempts left: " + ( 9 - counter));
                        }
                        counter++;
                    }
                    
                }

                else if (input.ToLower() == "hard")
                {
                    Console.WriteLine("You choose HARD. you have 5 attempts. GOOD LUCK");
                    Random rd = new Random();
                    int randomNumber = rd.Next(0, 1000);
                    int counter = 1;
                    while (counter <= 5)
                    {
                        Console.WriteLine($"Attempt: {counter} - Write a number between 0 - 1000");
                        bool checkInput = int.TryParse(Console.ReadLine(), out int userNumber);
                        if (checkInput)
                        {
                            if (userNumber == randomNumber)
                            {
                                if (counter == 1)
                                {
                                    Console.WriteLine("Lucky guess. You won from the first try." + "Your number is: " +
                                        userNumber + ". The winning number is: " + randomNumber);
                                    Console.WriteLine("Thanks for playing");

                                    Console.WriteLine("Press 1 to restart or press any key to quit");
                                    char choice = Convert.ToChar(Console.ReadLine());
                                    if (choice == '1')
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        isValid = true;
                                        break;
                                    }
                                }
                                else
                                { 
                                    Console.WriteLine("Congratulations you WON!! on your " + counter + " attempt. " +
                                        "The winnig number is: " + randomNumber +
                                        ". You entered the number: " + userNumber);
                                    Console.WriteLine("thanks for playing");
                                    isValid = true;
                                    break;
                                }
                            }
                            else if (userNumber > 0 && userNumber < 1000)
                            {

                                if (randomNumber > userNumber)
                                {
                                    //Console.WriteLine("Try attempt number: " + counter);
                                    int x = 0;
                                    x = randomNumber - userNumber;
                                    if (x <= 5)
                                    {
                                        Console.WriteLine("hotter. the Winning number is higher than :" + userNumber);
                                    }
                                    else if (x > 5 && x < 10)
                                    {
                                        Console.WriteLine("hot. the Winning number is higher than :" + userNumber);
                                    }
                                    else if (x > 10 && x < 15)
                                    {
                                        Console.WriteLine(" warm. the Winning number is higher than :" + userNumber);
                                    }
                                    else if (x > 15 && x < 20)
                                    {
                                        Console.WriteLine(" COLD . The winning number is higher than :" + userNumber);
                                    }
                                    else if (x >= 20)
                                    {
                                        Console.WriteLine(" Freeze . The winning number is much higher than :" + userNumber);
                                    }

                                }
                                if (randomNumber < userNumber)
                                {
                                    //Console.WriteLine("Try attempt number: " + counter);
                                    int x = 0;
                                    x = userNumber - randomNumber;
                                    if (x <= 5)
                                    {
                                        Console.WriteLine("hotter. the Winning number is lower than :" + userNumber);
                                    }
                                    else if (x > 5 && x < 10)
                                    {
                                        Console.WriteLine("hot. the Winning number is lower than :" + userNumber);
                                    }
                                    else if (x >= 10 && x < 15)
                                    {
                                        Console.WriteLine(" warm. the Winning number is lower than :" + userNumber);
                                    }
                                    else if (x >= 15 && x < 20)
                                    {
                                        Console.WriteLine(" COLD . The winning number is much higher than :" + userNumber);
                                    }
                                    else if (x >= 20)
                                    {
                                        Console.WriteLine(" FREAZING . The winning number is very much lower than :" + userNumber);
                                    }
                                }
                            }

                            if (counter == 4)
                            {
                                Console.WriteLine("Last Try");
                            }
                            if (counter == 5)
                            {
                                Console.WriteLine("You lost. The winning number was:" + randomNumber);
                                Console.WriteLine("Press 1 to restart or press any key to quit");

                                char choice = Convert.ToChar(Console.ReadLine());
                                if (choice != '1')
                                {
                                    isValid = true;
                                }
                            } 
                        }
                        else
                        {
                            Console.WriteLine("Wrong input. Please type only number. Attempts left: " + ( 9 - counter));
                        }
                        counter++;
                    }
                   
                }

                else 
                {
                    Console.WriteLine("wrong input. Only type Easy / Normal / Hard");
                    Console.WriteLine("Press any key to continue or type 'q' to quit");
                    string inputQ = (Console.ReadLine());
                    if(inputQ.ToLower() == "q") {
                        isValid = true;
                    }
                }

            }
            Console.ReadLine();
        }
    }
}