using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics.Entities
{
    public static class StringExtensions
    {
        public static string DoubleUp(this string input)
        {
            return input + input;
        }
    }
}
