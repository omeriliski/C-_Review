using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics.Entities
{
    public class GenericClass<T>
    {
        public List<T> Items = new List<T>();
        public void Add(T item)
        {
            Items.Add(item);
        }
    }
}
