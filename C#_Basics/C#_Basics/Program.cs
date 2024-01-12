
using C__Basics;
using C__Basics.Entities;

Console.WriteLine("------------ Variables -------------------");
// type Casting
decimal valueA = 10;
int valueB = (int)valueA;   // Explicit conversion

decimal valueC = valueA;    // Implicit conversion

int valueD = 3;

// it returns decimal
Console.WriteLine("Type of Value:"+ (valueA / valueB).GetType());

// GetType()
Console.WriteLine("Type of Value:" + valueA.GetType());

// Float    6-9 digits      4 bytes
// Double   15-17 digits    8 bytes
// Decimal  28-29 digits    16bytes



Console.WriteLine("------------ Date Types -------------------");
DateTime today = new DateTime(2024, 11, 01 , 16, 2, 0);
Console.WriteLine("today: " + today);
Console.WriteLine("timeOfDay:" + today.TimeOfDay);
Console.WriteLine("tomorrow: " + today.AddDays(2));

Console.WriteLine("now:" + DateTime.Now);

Console.WriteLine("------------ Classes -------------------");
Helper.WriteSomething();    // to check puclic...etc
Console.WriteLine("test:" + Product.test);

Product product1 = new Product(1, "tisch", 150);
Console.WriteLine("description: " + product1.Description("new", "expensive", "amazing"));
Console.WriteLine("id: " + product1.Id + " name: "+ product1.Name + " price: " + product1.Price + "Euro");

Product product2 = new Product("stuhl", 50);
Console.WriteLine("id: " + product2.Id + " name: " + product2.Name + " price: " + product2.Price + "Euro");
product2.Description("description: new, cheap, ok");