using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpAdv_Class06_Console.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find and print all persons firstnames  starting with 'R', ordered by Age -DESCENDING ORDER
            var personsNamesStartingWithRbyAge = Persons.Where(person => person.FirstName.ToLower().StartsWith("r"))
                .OrderByDescending(x => x.Age).ToList();
            Console.WriteLine("Find and print all persons firstnames  starting with 'R', ordered by Age -DESCENDING ORDER");
            personsNamesStartingWithRbyAge.ForEach(person => Console.WriteLine($"{person.FirstName}" +
                $" age: {person.Age}"));
            Console.WriteLine("==========================================");


            //●Find and print all brown dogs names and ages older than 3 years, ordered by Age -ASCENDING ORDER
            var brownDogsOlderThan3 = Dogs.Where(dog => dog.Color.ToLower() == "brown" && dog.Age > 3).OrderBy(x => x.Age).ToList();
            Console.WriteLine("Find and print all brown dogs names and ages older than 3 years, ordered by Age -ASCENDING ORDER");
            brownDogsOlderThan3.ForEach(dog => Console.WriteLine($"{dog.Name} age: {dog.Age}"));
            Console.WriteLine("===========================================");


            //●Find and print all persons with more than 2 dogs, ordered by Name -DESCENDING ORDER
            var personsWithMoreThan2Dogs = Persons.Where(person => person.Dogs.Count > 2)
                .OrderByDescending(x => x.FirstName).ToList();
            Console.WriteLine("Find and print all persons with more than 2 dogs, ordered by Name -DESCENDING ORDER");
            personsWithMoreThan2Dogs.ForEach(person => Console.WriteLine($"{person.FirstName} number of dogs {person.Dogs.Count}"));
            Console.WriteLine("============================================");


            //●Find and print all Freddy`s dogs names older than 1 year
            var freddysDogsOlderThan1Year = Persons.FirstOrDefault(person => person.FirstName.ToLower().Equals("freddy"))
                .Dogs.Where(dog => dog.Age > 1).ToList();
            Console.WriteLine("Find and print all Freddy`s dogs names older than 1 year");
            freddysDogsOlderThan1Year.ForEach(x => Console.WriteLine($"{x.Name} age: {x.Age}"));
            Console.WriteLine("============================================");


            //●Find and print Nathen`s first dog
            var NathansFirstDog = Persons.FirstOrDefault(person => person.FirstName.ToLower().Equals("nathen"))
                .Dogs[0].Name;
            Console.WriteLine($"Find and print Nathen`s first dog = {NathansFirstDog} \n===========================");


            //●Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name -ASCENDING ORDER
            var smt = Persons.Where(person =>
               (person.FirstName.ToLower().Equals("cristofer"))
            || (person.FirstName.ToLower().Equals("erin"))
            || (person.FirstName.ToLower().Equals("freddy"))
            || (person.FirstName.ToLower().Equals("amelia")) 
            ).Where(x => x.Dogs
            .Any(dog => dog.Color == "White")).SelectMany(y => y.Dogs).ToList();
           
            
            smt.ForEach(x => Console.WriteLine($"{x.Name}"));
            Console.WriteLine("===================================");
            




            Console.ReadLine();
        }
        //Find and print all persons firstnames  starting with 'R', ordered by Age -DESCENDING ORDER
        //●Find and print all brown dogs names and ages older than 3 years, ordered by Age -ASCENDING ORDER
        //●Find and print all persons with more than 2 dogs, ordered by Name -DESCENDING ORDER
        //●Find and print all Freddy`s dogs names older than 1 year
        //●Find and print Nathen`s first dog
        //●Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name -ASCENDING ORDER


        #region Database
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public Job Occupation { get; set; }
            public List<Dog> Dogs { get; set; }

            public Person(string firstName, string lastName, int age, Job occupation)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                Occupation = occupation;
                Dogs = new List<Dog>();
            }
        }

        public class Dog
        {
            public string Name { get; set; }
            public string Color { get; set; }
            public int Age { get; set; }
            public Race Race { get; set; }

            public Dog(string name, string color, int age, Race race)
            {
                Name = name;
                Color = color;
                Age = age;
                Race = race;
            }
        }

        public enum Race
        {
            Boxer,
            Bulldog,
            Collie,
            Dalmatian,
            Doberman,
            Mutt,
            Mudi,
            Pointer,
            Pug,
            Plott
        }

        public enum Job
        {
            Archivist,
            Waiter,
            Choreographer,
            Developer,
            Dentist,
            Sculptor,
            Interpreter,
            Barber
        }

        
            public static List<Dog> Dogs { get; set; } = new List<Dog>()
            {
                new Dog("Charlie", "Black", 3, Race.Collie), // 0
				new Dog("Buddy", "Brown", 1, Race.Doberman), //1
                new Dog("Max", "Olive", 1, Race.Plott),     // 2
                new Dog("Archie", "Black", 2, Race.Mutt),   // 3
                new Dog("Oscar", "White", 1, Race.Mudi),    // 4 - freddy
                new Dog("Toby", "Maroon", 3, Race.Bulldog), // 5 - freddy
				new Dog("Ollie", "Silver", 4, Race.Dalmatian), // 6
                new Dog("Bailey", "White", 4, Race.Pointer),  // 7
                new Dog("Frankie", "Gray", 2, Race.Pug),  // 8
                new Dog("Jack", "Black", 5, Race.Dalmatian), // 9
                new Dog("Chanel", "Black", 1, Race.Pug), // 10 - freddy
				new Dog("Henry", "White", 7, Race.Plott), // 11
                new Dog("Bo", "Maroon", 1, Race.Boxer), // 12 - freddy
                new Dog("Scout", "Olive", 2, Race.Boxer), // 13 - freddy
                new Dog("Ellie", "Brown", 6, Race.Doberman), // 14
                new Dog("Hank", "Silver", 2, Race.Collie), // 15
				new Dog("Shadow", "Silver", 3, Race.Mudi), // 16
                new Dog("Diesel", "Brown", 4, Race.Bulldog), // 17
                new Dog("Abby", "Black", 1, Race.Dalmatian), // 18
                new Dog("Trixie", "White", 8, Race.Pointer), // 19
			};

            public static List<Person> Persons { get; set; } = new List<Person>()
            {
                new Person("Nathanael", "Holt", 20, Job.Choreographer),
                new Person("Rick", "Chapman", 35, Job.Dentist),
                new Person("Oswaldo", "Wilson", 19, Job.Developer),
                new Person("Kody", "Walton", 43, Job.Sculptor),
                new Person("Andreas", "Weeks", 17, Job.Developer),
                new Person("Kayla", "Douglas", 28, Job.Developer),
                new Person("Richie", "Campbell", 19, Job.Waiter),
                new Person("Soren", "Velasquez", 33, Job.Interpreter),
                new Person("August", "Rubio", 21, Job.Developer),
                new Person("Rocky", "Mcgee", 57, Job.Barber),
                new Person("Emerson", "Rollins", 42, Job.Choreographer),
                new Person("Everett", "Parks", 39, Job.Sculptor),
                new Person("Amelia", "Moody", 24, Job.Waiter)
                { Dogs = new List<Dog>() {Dogs[16], Dogs[18] } },
                new Person("Emilie", "Horn", 16, Job.Waiter),
                new Person("Leroy", "Baker", 44, Job.Interpreter),
                new Person("Nathen", "Higgins", 60, Job.Archivist)
                { Dogs = new List<Dog>(){ Dogs[6], Dogs[0] } },
                new Person("Erin", "Rocha", 37, Job.Developer)
                { Dogs = new List<Dog>() { Dogs[2], Dogs[3], Dogs[19] } },
                new Person("Freddy", "Gordon", 26, Job.Sculptor)
                { Dogs = new List<Dog>() { Dogs[4], Dogs[5], Dogs[10], Dogs[12], Dogs[13] } },
                new Person("Valeria", "Reynolds", 26, Job.Dentist),
                new Person("Cristofer", "Stanley", 28, Job.Dentist)
                { Dogs = new List<Dog>() { Dogs[9], Dogs[14], Dogs[15] } }
            };
        #endregion
    }
}
