using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics.Entities.Abstract
{
    public class Triangle : Shape
    {
        public int Side1Length { get; set; }
        public int Side2Length { get; set; }
        public int Side3Length { get; set; }

        // Method Overriding
        public override int Perimeter()
        {
            return Side1Length + Side2Length + Side3Length;
        }

        public override decimal Area()
        {
            var semiPerimeter = Perimeter() / 2;
            return (decimal)Math.Sqrt(semiPerimeter * (semiPerimeter - Side1Length) * (semiPerimeter - Side2Length) * (semiPerimeter - Side3Length));
        }

    }
}
