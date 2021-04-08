using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Class06_ClassCode.MyClasses
{
    public class Product
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private DateTime SoldOn { get; set; } // default value (time) is 01.01.0001 12.00.00 AM
        private bool isBought { get; set; } // default value is FALSE always.

        public Product (int code, string name, double price) // ova e constructor.
        {
            Code = code;
            Name = name;
            Price = price;
        }

        public void BuyProduct(double money)
        {
            if (isBought)
            {
                CheckIfProductIsBought();
            }
            else if (money >= Price) 
            {
                SoldOn = DateTime.Now;
                isBought = true;
                Console.WriteLine($"Congratulations you bought the product: {Name}");
            }
            else
            {
                Console.WriteLine($"Sorry, you dont have enough money");
            }
        }

        public void CheckIfProductIsBought()
        {
            if (isBought)
            {
                Console.WriteLine(string.Format("The product {0} was bought on {1}", Name, SoldOn));
            }
            else
            {
                Console.WriteLine(string.Format("The product {0} is still available", Name));
            }
        }

    }
}
