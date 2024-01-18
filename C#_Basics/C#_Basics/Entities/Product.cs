using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics.Entities
{

    public class Product: EventArgs
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
        public void Description(string s = "description: new, cheap, wonderfull")   // we can give default value to the parameter or send it
        {
            Console.WriteLine(s);
        }

        public string Description(string s, params string[] description) // when we use more than one parameter, we musst use params at the end
        {
            string allDescription = "";
            foreach (var item in description)
            {
                allDescription += item + " ";
            }
            return allDescription;
        }




        // Delegates, (it's like callback)
        // !!! I don't think that i use it
        public delegate int ManipulatePrice(int price, int percentage);

        public int Manipulate(int price, int percentage, ManipulatePrice manipulatePrice)
        {
            var result = manipulatePrice(price, percentage);
            return result;
        }

        // the signature musst match
        public int Increase(int price, int percentage)
        {
            var result = price + price * percentage / 100;
            return result;
        }

        public int Decrease(int price, int percentage)
        {
            var result = price - price * percentage / 100;
            return result;
        }

        // create a method, takes product price as euro and converts it to dollar, return the dollar
        public decimal ConvertToDollar(int price)
        {
            var result = price * 1.2m;
            return result;
        }

        // create a method, takes product price as dollar and converts it to euro, return the euro
        public decimal ConvertToEuro(int price)
        {
            var result = price / 1.2m;
            return result;
        }

        // Events
        // don't need, i think

        // Enum
        public enum TaxRate
        {
            Normal, More
        }

    }
}