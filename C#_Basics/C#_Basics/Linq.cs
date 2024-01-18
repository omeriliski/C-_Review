using C__Basics.Entities;
using LINQtoCSV;
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
            // Lesson 5
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

            Console.WriteLine("------------ Linq First -------------------");
            var myGeneric7 = products.First();   // it will give the first item
            Console.WriteLine("first product: " + myGeneric7.Name);

            Console.WriteLine("------------ Linq Skip,Take -------------------");
            var myGeneric8 = products.Skip(1).Take(2);   // it will give the first 2 items
            // create a loop for print genericClass8
            foreach (var item in myGeneric8)
            {
                Console.WriteLine("name: " + item.Name + "     price:" + item.Price);
            }

            Console.WriteLine("------------ Linq OrderBy -------------------");
            var myGeneric9 = products.OrderBy(element => element.Price);   // it will give the items which are ordered by price
            // create a loop for print genericClass9
            foreach (var item in myGeneric9)
            {
                Console.WriteLine("name: " + item.Name + "     price:" + item.Price);
            }

            Console.WriteLine("------------ Linq OrderByDescending -------------------");
            var myGeneric10 = products.OrderByDescending(element => element.Price);   // it will give the items which are ordered by price descending
            // create a loop for print genericClass10
            foreach (var item in myGeneric10)
            {
                Console.WriteLine("name: " + item.Name + "     price:" + item.Price);
            }

            Console.WriteLine("------------ Linq ThenBy -------------------");
            var myGeneric11 = products.OrderBy(element => element.Price).ThenBy(element => element.Name);   // it will give the items which are ordered by price and then by name
            // create a loop for print genericClass11
            foreach (var item in myGeneric11)
            {
                Console.WriteLine("name: " + item.Name + "     price:" + item.Price);
            }

            Console.WriteLine("------------ Linq FirstOrDefault -------------------");
            var myGeneric12 = products.FirstOrDefault(element => element.Price == 20);   // it will give the first item which price is 20
            Console.WriteLine("first product price=20: " +  myGeneric12.Name);

            Console.WriteLine("------------ Linq Expressions -------------------");
            var outProducts = from product in products
                              where product.Price >= 20
                              orderby product.Name descending
                              select product;
            
            // create a loop for print genericClass12
            foreach (var item in outProducts)
            {
                Console.WriteLine("name: " + item.Name + "     price:" + item.Price);
            }

            Console.WriteLine("------------ group -------------------");
            var outProducts2 = from product in products
                              group product by product.Price;

            // create a loop for print genericClass12
            foreach (var item in outProducts2)
            {
                Console.WriteLine("price: " + item.Key);
                foreach (var item2 in item)
                {
                    Console.WriteLine("name: " + item2.Name);
                }
            }

            Console.WriteLine("------------ csv -------------------");
            // ich habe Fehler, not important
            //var inputFileDescription = new CsvFileDescription
            //{
            //    SeparatorChar = ';', 
            //    FirstLineHasColumnNames = true
            //};
            //var context = new CsvContext();
            //var productsCsv = context.Read("C:\\Users\\ÖmerIliski\\OneDrive - ditegra GmbH\\Desktop\\ömer\\apps\\C# Apps\\C_Sharp_Review\\C#_Basics\\C#_Basics\\Example.csv", inputFileDescription);
            //foreach (var item in productsCsv)
            //{
            //    Console.WriteLine("name: " + item.Name + "     price:" + item.Price);
            //}

            Console.WriteLine("------------ Extention Methods -------------------");
            string myString = "Shopware";
            string myString2 = myString.DoubleUp();
            Console.WriteLine("myString2: " + myString2);

        }
    }
}
