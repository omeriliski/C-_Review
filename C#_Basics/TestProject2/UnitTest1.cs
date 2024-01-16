using C__Basics.Entities;
using System.Diagnostics;
using System.Xml.Linq;

namespace TestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int expected = 150; 
            int actual = 150;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            Product product = new Product(1, "Laptop", 1000);
            var newPrice = product.Increase(product.Price, 10);
            Assert.Equal(1100, newPrice);
        }
    }
}