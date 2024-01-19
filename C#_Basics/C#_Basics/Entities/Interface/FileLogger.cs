using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics.Entities.Interface
{
    public class FileLogger: ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"File Log: {message}");
        }
    }
}
