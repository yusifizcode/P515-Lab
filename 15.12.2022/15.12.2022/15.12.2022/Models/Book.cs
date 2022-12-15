using _15._12._2022.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._12._2022.Models
{
    internal class Book
    {
        static Book()
        {
            _no = 0;
        }
        public Book()
        {
            _no++;
            No = _no;
        }

        static int _no;
        public int No { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public Genre Genre { get; set; }
        public double Price { get; set; }
    }
}
