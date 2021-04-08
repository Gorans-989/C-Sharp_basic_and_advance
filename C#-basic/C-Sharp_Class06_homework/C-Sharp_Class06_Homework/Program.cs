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
            new Car("honda accord", 240),
            new Car("bmw x7", 280),
            new Car("aston martin", 200),
            new Car("ferrari", 340)
            };

            Console.WriteLine("Pick car number 1:");
            Car raceCar1 = PickCar(arrayOfCars);
           



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
                Console.WriteLine($"The winner is {firstCar.PrintCarDetails()} ");
            }
            else if(result1 < result2)
            {
                Console.WriteLine($"The winner is {secondCar.PrintCarDetails()}");
            }
            else
            {
                Console.WriteLine("It is a tie.");
            }
        }
        
        static Car PickCar(Car[] cars)
        {
            Car userChoice = new Car();
            foreach(Car element in cars)
            {
                Console.WriteLine(element.Model);
            }
            string choice = Console.ReadLine();
            foreach(Car element in cars)
            {
                if (choice.ToLower() == element.Model.ToLower())
                {
                    userChoice = element;
                }
                else
                {
                    Console.WriteLine("wrong input no such car");
                    
                }
            }
            return userChoice;
        }
        
            
    }
}
