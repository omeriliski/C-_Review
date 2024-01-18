using C__Basics.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics
{
    public static class Collections
    {
        public static void BasicExamples()
        {
            Console.WriteLine("------------ Arrays -------------------");
            int[] numbers1 = new int[3];
            numbers1[0]=1;
            numbers1[1]=2;
            // numbers1.Append(3);  // you can't add an element to an array using Append method
            numbers1[2]=3;

            // create a loop for print numbers
            foreach (var number in numbers1)
            {
                Console.WriteLine(number);
            }

            int[] numbers2 = new int[] { 4, 5, 6 };
            // create a loop for print numbers
            foreach (var number in numbers2)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("------------Hashtable -------------------");
            // create a sorted list with string key and int value
            
            var daysHashTable = new Hashtable();
            daysHashTable.Add("Monday", 1);
            daysHashTable.Add("Tuesday", 2);
            daysHashTable.Add("Wednesday", 3);
            daysHashTable.Add("Thursday", 4);
            //create a loop for print hashtable
            foreach (DictionaryEntry day in daysHashTable)
            {
                Console.WriteLine(day.Key + ": " + day.Value);
            }
            Console.WriteLine("------------Sorted List -------------------");
            var daysSortedList = new SortedList<string, int>();
            daysSortedList.Add("Monday", 1);
            daysSortedList.Add("Tuesday", 2);
            daysSortedList.Add("Wednesday", 3);
            daysSortedList.Add("Thursday", 4);     // it will be written in the second line while it is a sorted list

            // create a loop for print daysSortedList
            foreach (var day in daysSortedList)
            {
                Console.WriteLine(day.Key + ": " + day.Value);
            }

            Console.WriteLine("the value of Monday:" + daysSortedList["Monday"]); ;   // it will give the value of Monday

            Console.WriteLine("------------ Queue -------------------");
            // ...

            Console.WriteLine("------------ Stack -------------------");
            // LIFO

            // create a stack with string type
            Stack<string> daysStack = new Stack<string>();
            daysStack.Push("Monday");
            daysStack.Push("Tuesday");
            daysStack.Push("Wednesday");

            var lastDay = daysStack.Pop();    // it will remove the last element of the stack
            Console.WriteLine("lastDay: " + lastDay);

            // create a loop for print daysStack
            foreach (var day in daysStack)
            {
                Console.WriteLine(day);
            }

            Console.WriteLine("------------ List -------------------");
            // create a string list has days of week
            List<string> days = new List<string>
            {
                "Montag", "Tuesday", "Thursday", "Friday", "Saturday"
            };

            days[0] = "Monday";

            days.Insert(2, "Wednesday");    // it will add the element to the second index of the list

            // days[9] = "Pazartesi";  // it will give an error because the list has only 6 elements

            days.Add("Sunday");     // it will add the element to the end of the list

            Console.WriteLine("Index of Monday: " + days.IndexOf("Monday"));     // it will give the index of Monday
            Console.WriteLine("ElementAt of 2: " + days.ElementAt(2));           // it will give the element at index 2

            // create a loop for print days
            foreach (var day in days)
            {
                Console.WriteLine(day);
            }

            List<Product> products = new List<Product>() { new Product("product1", 10), new Product("product2", 20) };
            // create a loop for print products
            foreach (var product in products)
            {
                Console.WriteLine("name: " + product.Name);
            }

            Console.WriteLine("------------ Dictionary <TKey, TValue> -------------------");
            // create a dictionary with string key and int value
            Dictionary<string, int> daysDictionary = new Dictionary<string, int>
            {
                { "Monday", 1 },{ "Tuesday", 2 },{ "Wednesday", 3 },{ "Thursday", 4 }
            };
            daysDictionary.Add("Friday", 5);
            //create a loop for print daysDictionary
            foreach (var day in daysDictionary)
            {
                Console.WriteLine(day.Key + ": " + day.Value);
            }

            Console.WriteLine("------------ Generics -------------------");
            // create a variable using GenericClass
            var myGeneric = new GenericClass<string>();
            myGeneric.Add("item1");
            myGeneric.Add("item2");
            // create a loop for print genericClass
            foreach (var item in myGeneric.Items)
            {
                Console.WriteLine(item);
            }

            var myGeneric2 = new GenericClass<Product>();
            myGeneric2.Add(new Product("product1", 10));
            myGeneric2.Add(new Product("product2", 20));
            myGeneric2.Add(new Product("product3", 30));
            myGeneric2.Add(new Product("product4", 20));

            // create a loop for print genericClass
            foreach (var item in myGeneric2.Items)
            {
                Console.WriteLine("name: " + item.Name);
            }
            
        }
    }
}
