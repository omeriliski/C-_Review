using C__Basics.Entities.Abstract;
using C__Basics.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics
{
    public static class Abstaract_Classes_Interfaces
    {
        public static void Examples()
        {
            Console.WriteLine("------------ Abstract -------------------");
            // var shape = new Shape();    // Error: Cannot create an instance of the abstract class or interface 'Shape'
            Shape triangle = new Triangle() { Side1Length=3, Side2Length=4, Side3Length=5};
            Console.WriteLine($"Triangle: Perimeter: {triangle.Perimeter()}, Area: {triangle.Area()}");

            Shape rectangle = new Rectangle() { Length = 3, Width = 4 };
            Console.WriteLine($"Rectangle: Perimeter: {rectangle.Perimeter()}, Area: {rectangle.Area()}");


            Console.WriteLine("------------ Interface -------------------");
            FileLogger fileLogger = new FileLogger();
            fileLogger.Log("hello");

            ConsoleLogger consoleLogger = new ConsoleLogger();
            consoleLogger.Log("hello");

            Console.WriteLine("------------ Error Handling -------------------");
            try
            {
                throw new Exception("errrorrrr");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
