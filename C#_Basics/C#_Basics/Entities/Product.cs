using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics.Entities
{
    public class Product
    { 
        // constructor
        public Product(string name, int price) 
        {
            Id = new Random().Next(0, 1000);
            Name = name;
            Price = price;
        }

        // constructor (overloads the other constructor)
        public Product(int id, string name, int price) 
        {
            Id = id;
            Name = name;
            Price = price;
        }

        // properties
        public const int test = 5;      // it could be used only with classname, not with it's instance
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        // methods
        public string Description(params string[] description) // using params we can send indefinite parameters
        {
            string allDescription="";
            foreach (var item in description)
            {
                allDescription += item + " ";
            }
            return allDescription;
        }

        // method overloading
        public void Description(string s)
        {
            Console.WriteLine(s);
        }
    }
}