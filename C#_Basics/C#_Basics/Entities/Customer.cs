using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics.Entities
{
    // Partial Keyword
    public partial class Customer
    {
        public int Id { get; set; }
    }

    public partial class  Customer
    {
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
