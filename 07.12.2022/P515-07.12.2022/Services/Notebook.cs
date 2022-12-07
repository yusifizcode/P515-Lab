using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Notebook:Product
    {
        public Notebook(string name, double price) : base(name, price)
        {
        }

        public int RAM { get; set; }
        public int Storage { get; set; }
    }
}
