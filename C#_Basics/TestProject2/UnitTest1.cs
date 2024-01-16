using C__Basics.Entities;
using System.Diagnostics;
using System.Globalization;
using System.Xml.Linq;

namespace TestProject2
{
    public class UnitTest1
    {
        // add a unit test for the increase method in the Product class
        [Fact]
        public void IncreaseTest()
        {
            // arrange
            Product product = new Product(1, "test", 100);
            int expected = 110;

            // act
            int actual = product.Increase(product.Price, 10);

            // assert
            Assert.Equal(expected, actual);
        }

        // add a unit test for the decrease method in the Product class
        [Fact]
        public void DecreaseTest()
        {
            // arrange
            Product product = new Product(1, "test", 100);
            int expected = 90;

            // act
            int actual = product.Decrease(product.Price, 10);

            // assert
            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> TestData()
        {
            string[] csvLines = File.ReadAllLines("C:\\Users\\ÖmerIliski\\OneDrive - ditegra GmbH\\Desktop\\ömer\\apps\\C# Apps\\C_Sharp_Review\\C#_Basics\\TestProject2\\products.csv");
            var data = new List<object[]>();
            foreach (var line in csvLines)
            {
                string[] values = line.Split(',');
                
                int id = int.Parse(values[0]);
                string name = values[1];
                int price = int.Parse(values[2]);
                int percantage = int.Parse(values[3]);
                int expected = int.Parse(values[4]);
                data.Add(new object[] { id, name, price, percantage, expected });        
            }   
            return data;
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void IncreaseTest2(int id, string name, int price, int percantage, int expected)
        {
            // arrange
            Product product = new Product(id, name, price);

            // act
            int actual = product.Increase(product.Price, percantage);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}