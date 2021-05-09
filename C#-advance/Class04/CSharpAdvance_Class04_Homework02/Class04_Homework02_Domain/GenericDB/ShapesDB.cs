using Class04_Homework02_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class04_Homework02_Domain.GenericDB
{
    public class ShapesDB<T>
        where T : Shape
    {
        public List<T> ShapeObjectsDB { get; set; }
        public ShapesDB()
        {
            ShapeObjectsDB = new List<T>();
        }
        public void InserItem(T someShape)
        {
            ShapeObjectsDB.Add(someShape);
        }
        public void RemoveShapeObject (T someObject)
        {
            ShapeObjectsDB.Remove(someObject);
            Console.WriteLine("Item removed!");
        }
        public void PrintArea()
        {
            foreach(T item in ShapeObjectsDB)
            {
                Console.WriteLine($"The area of the item: {item.GetType().Name} is: {item.GetArea()}");
            }

        }
        public void PrintPerimeter()
        {
            foreach( T item in ShapeObjectsDB)
            {
                Console.WriteLine($"the Perimeter of the item: {item.GetType().Name} is: {item.GetPerimeter()}");
            }
        }

    }
    //* Create a generic Db that holds a list of generic objects, that have a type that inherits from Shape.
    //* Create methods in the generic db that print the areas and perimeters of all shapes in the list.
    //* Create generic db for both types and call the methods of the db.
}
