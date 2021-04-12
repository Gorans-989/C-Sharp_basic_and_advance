using System;
using C_Sharp_Class06_Homework.MyClasses;

namespace C_Sharp_Class06_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //* Ask the user to select a two cars and two drivers for the cars.
            //Add the drivers to the cars and call the RaceCars() methods
            //Make 4 car objects and 4 driver objects.
            Driver[] arrayOfDrivers = new Driver[]
            {
                new Driver("goran", 5),
                new Driver("petar", 3),
                new Driver("ana", 4),
                new Driver("iva", 2)
            };

            Car[] arrayOfCars = new Car[] 
            {
            new Car("honda", 240),
            new Car("bmw", 280),
            new Car("aston-martin", 200),
            new Car("ferrari", 340)
            };


            bool startGame = false;
            while (!startGame)
            {
                //method for picking cars
                Car raceCar1 = PickCar(arrayOfCars);
                raceCar1.Driver = PickDriver(arrayOfDrivers);

                Car raceCar2 = PickCar(arrayOfCars);
                raceCar2.Driver = PickDriver(arrayOfDrivers);

                RaceCars(raceCar1, raceCar2);

                bool restart = false;
                while (!restart)
                {
                    Console.WriteLine("Press \"1\" to restart game or press \"2\" to quit");
                    string userInput = Console.ReadLine();
                    if (userInput == "2")
                    {
                        restart = true;
                        startGame = true;
                    }
                    else if (userInput == "1")
                    {
                        restart = true;
                    }
                    else
                    {
                        Console.WriteLine("Wrong input. Type only 1 or 2");
                    }
                }
            }
            Console.ReadLine();
        }


        ////* Make a method RaceCars() that will get two Car objects that will determine
        //which car will win and print the result in the console. 
        static void RaceCars(Car firstCar, Car secondCar)
        {
            int result1 = firstCar.CalculateSpeed(firstCar.Driver);
            int result2 = secondCar.CalculateSpeed(secondCar.Driver);

            if(result1 > result2)
            {
                Console.WriteLine($"The winner is {firstCar.PrintCarDetails()}. Driving with speed of {result1} km/h");
            }
            else if(result1 < result2)
            {
                Console.WriteLine($"The winner is {secondCar.PrintCarDetails()}. Driving with speed of {result2} km/h");
            }
            else
            {
                Console.WriteLine("It is a tie.");
            }
        }
        
        static Car PickCar(Car[] cars)
        {
            Car userChoice = new Car();
            bool isValid = false;
            while(!isValid)
            {            
                Console.WriteLine("Please pick car :");
                foreach(Car element in cars)
                {
                    Console.WriteLine(element.Model);
                }
                string choice = Console.ReadLine();

                for (int i = 0; i < cars.Length; i++)
                {
                    if (choice.ToLower() == cars[i].Model.ToLower())
                    {   
                        userChoice = cars[i];
                        isValid = true;
                    }
                }
            }
            return userChoice;
        }

        static Driver PickDriver(Driver[] drivers)
        {
            Driver userChoise = new Driver();

            bool isValid = false;
            while (!isValid)
            {
                Console.WriteLine("Please pick driver");
                foreach (Driver element in drivers)
                {
                    Console.WriteLine(element.Name);
                }
                string input = Console.ReadLine();

                foreach(Driver element in drivers)
                {
                    if(input.ToLower() == element.Name.ToLower())
                    {
                        userChoise = element;
                        isValid = true;
                    }
                }
            }
            return userChoise;
        }

    }
}
