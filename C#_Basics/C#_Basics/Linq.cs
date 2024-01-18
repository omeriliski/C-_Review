using C__Basics.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics
{
    public static class Linq
    {
        public static void BasicExamples()
        {
            Console.WriteLine("------------------------------ Linq ------------------------------");
            // create a list of products
            var products = new List<Product>(){new Product(1, "Product1", 10), new Product(2,"Product2",20), new Product(3, "Product3", 30), new Product(4, "Product4", 20)};

            var productCount = products.Count();   // it will give the count of the items
            Console.WriteLine("product count: " + productCount);

            var productCount20 = products.Count(element => element.Price == 20);   // it will give the count of the items which price is 20
            Console.WriteLine("product price=20: " + productCount20);

            Console.WriteLine("------------ Linq Where -------------------");
            var myGeneric3 = products.Where(element => element.Price == 20);   // it will give the items which price is 20
            // create a loop for print genericClass3
            foreach (var item in myGeneric3)
            {
                Console.WriteLine("name: " + item.Name + "     price:" + item.Price);
            }

            Console.WriteLine("------------ Linq Select -------------------");
            var myGeneric4 = products.Select(element => element.Name);   // it will give the names of the items
            // create a loop for print genericClass4
            foreach (var item in myGeneric4)
            {
                Console.WriteLine("name: " + item);
            }

            Console.WriteLine("------------ Linq Any -------------------");
            var myGeneric5 = products.Any(element => element.Price == 50);   // it will give true if there is any item which price is 20
            Console.WriteLine("any product price=50: " + myGeneric5);

            Console.WriteLine("------------ Linq All -------------------");
            var myGeneric6 = products.All(element => element.Price == 20);   // it will give true if all items price is 20
            Console.WriteLine("all product price=20: " + myGeneric6);
        }
    }
}
