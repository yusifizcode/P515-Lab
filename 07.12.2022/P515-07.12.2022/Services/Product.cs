using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Product
    {
        static Product()
        {
            _no = 0;
        }

        public Product(string name, double price)
        {
            Name= name;
            Price= price;

            _no++;
            No = _no;
        }
        static int _no;
        public int No { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int DiscountPercent { get; set; }
    }
}
