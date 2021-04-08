using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Class06_ClassCode.MyClasses
{
    public class Dog
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }

        //public Dog (string name, string race, string color)
        //{
        //    Name = name;
        //    Race = race;
        //    Color = color;
        //}

        public Dog()
        {

        }

        public void isPlaying()
        {
            Console.WriteLine($"The dog {Name}, race:{Race}, color:{Color} is playing now");
        }

        public void isChasingTail()
        {
            Console.WriteLine($"The dog {Name}, race:{Race}, color:{Color} is chasing his tail");
        }

        public void isEating()
        {
            Console.WriteLine($"The dog {Name}, race:{Race}, color:{Color} is eating.");
        }




    }
}
