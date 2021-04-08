using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Class06_Homework.MyClasses
{
    //Make a class Car. Add properties: Model, Speed and Driver
    //* Make a method of the Car class called : CalculateSpeed() that takes a driver object
    //and calculates the skill multiplied by the speed of the car and return it as a result.
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }

        public Car()
        {

        }

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        public string PrintCarDetails()
        {
            return string.Format("Model:{0}, Max speed:{1} km/h, Driven by:{2}", Model, Speed, Driver.Name);
        }
        public int CalculateSpeed(Driver driver)
        {
            int result = Speed * driver.Skill;
            return result;
        }



    }
}
