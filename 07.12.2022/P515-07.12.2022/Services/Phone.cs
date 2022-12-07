using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Phone:Product
    {
        public Phone(string name, double price) : base(name, price)
        {
        }

        public int SIMCount { get; set; }
    }
}
