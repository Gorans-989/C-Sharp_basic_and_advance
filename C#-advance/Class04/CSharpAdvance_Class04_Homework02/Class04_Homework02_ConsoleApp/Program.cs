using Class04_Homework02_Domain.Entities;
using Class04_Homework02_Domain.GenericDB;
using Class04_Homework02_Domain.Extensions;
using System;

namespace Class04_Homework02_ConsoleApp
{
    class Program
    {
        //public static ShapesDB<Circle> CirclesDB = new ShapesDB<Circle>();
        public static ShapesDB<Rectangle> RectangleDB = new ShapesDB<Rectangle>();
        static void Main(string[] args)
        {
            ShapesDB<Circle> CirclesDB = new ShapesDB<Circle>();
            CirclesDB.InserItem(new Circle(2));
            CirclesDB.InserItem(new Circle(3));
            CirclesDB.InserItem(new Circle(4));
            CirclesDB.InserItem(new Circle(5));
            CirclesDB.InserItem(new Circle(6));

            RectangleDB.InserItem(new Rectangle(2, 5));
            RectangleDB.InserItem(new Rectangle(2, 4));
            RectangleDB.InserItem(new Rectangle(3, 8));
            RectangleDB.InserItem(new Rectangle(2, 9));
            RectangleDB.InserItem(new Rectangle(4, 6));

            Console.WriteLine("================================================\nPrinting info for circle shape");
            CirclesDB.PrintArea();
            CirclesDB.PrintPerimeter();
            Console.WriteLine("================================================\nPrinting info for rectangle shape");
            RectangleDB.PrintArea();
            RectangleDB.PrintPerimeter();
            Console.WriteLine("===================================================");

            
            CirclesDB.ShapeObjectsDB.ExtensionPrintTypeOf();
            CirclesDB.ShapeObjectsDB.ExtensionGetInfo();


            Console.ReadLine();
        }
        //    * Create a class Shape that has Id and methods GetArea and GetPerimeter
        //* Create a class Circle, with property radius that inherits from Shape.
        //* Create a class Rectangle, with properties sideA and sideB that inherits from Shape.
        //* Create a generic Db that holds a list of generic objects, that have a type that inherits from Shape.
        //* Create methods in the generic db that print the areas and perimeters of all shapes in the list.
        //* Create generic db for both types and call the methods of the db.
        //* Add extension methods for Circle and Rectangle, that print info for these types.
    }
}
