using Class04_Homework02_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class04_Homework02_Domain.Extensions
{
    public static class ShapesExtensionHelper
    {

        public static void ExtensionPrintTypeOf<T>(this List<T> someItem)
        {
            foreach( T item in someItem)
            {
                Console.WriteLine($"{item.GetType().Name}");
            }
            
        }

        public static void ExtensionGetInfo<T>(this List<T> list)
        {
            T first = list[0];
            Console.WriteLine($"This lisst has {list.Count} members of typr {first.GetType().Name}");
            
        }

    }
}
