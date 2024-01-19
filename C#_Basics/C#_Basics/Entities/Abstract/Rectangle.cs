using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics.Entities.Abstract
{
    public class Rectangle : Shape
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public override int Perimeter()
        {
            return Length * 2 + Width * 2;
        }
        public override decimal Area()
        {
            return Length * Width;
        }
    }
}
