using C_Sharp_Class06_ClassCode.MyClasses;
using System;


namespace C_Sharp_Class06_ClassCode
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Person and Human class
            /*
            Person person = new Person();
            person.Name = "Trajan";
            person.Age = 31;
            person.Talk("Hi there. i am the method talk");
            Console.WriteLine($" Hello. my name is {person.Name} and i am {person.Age} years old ");

            Console.WriteLine("================================");

            Person bill = new Person() { Name = "bill clinton", Age = 31 };
            bill.Talk("Hello from bill");

            Console.WriteLine("=================================");
            
            Person jill = new Person("Jill bureto", 29);
            jill.Talk("Hello from jill");
            */

            //Human human = new Human();
            //Console.WriteLine("Write your first name");
            //human.FirstName = Console.ReadLine();
            //Console.WriteLine("Write your last name");
            //human.LastName = Console.ReadLine();
            //Console.WriteLine("Write your age");
            //human.Age = int.Parse(Console.ReadLine());

            //string personalStats = human.GetPersonStats();
            //Console.WriteLine(personalStats);

            #endregion

            #region Product Class
            //Example Product Class
            /*
            Product iceCream = new Product(22 , "Snikers", 55);
            iceCream.CheckIfProductIsBought();
            iceCream.BuyProduct(10);
            iceCream.BuyProduct(60);
            iceCream.CheckIfProductIsBought();
            */
            #endregion

            /*
            GetInputsForDog();
            */
            Student[] students = new Student[5];

            students[0] = new Student("ana", "Photography", 1);
            students[1] = new Student("goran", "Web development", 4);
            students[2] = new Student("zoran", "Science", 2);
            students[3] = new Student("kiko", "Photography", 1);
            students[4] = new Student("maja", "Science", 2);

            Console.WriteLine("Enter student name");
            string userInput = Console.ReadLine();

            students[1].DisplayStats(userInput);

            //foreach(Student student in students)
            //{
            //    student.DisplayStats(userInput);
            //}

            Console.ReadLine();
        }
        /*
        static Dog GetInputsForDog()
        {
            Dog dog = new Dog();
            Console.WriteLine("enter the dogs name");
            dog.Name = Console.ReadLine();
            Console.WriteLine("Enter the dogs race");
            dog.Race = Console.ReadLine();
            Console.WriteLine("enter the dogs color");
            dog.Color = Console.ReadLine();
            return dog;
        }
        */

        //static void ChooseOption(int number)
        //{
        //    if (number == 1)
        //    {

        //    }
        //}
    }    
}
