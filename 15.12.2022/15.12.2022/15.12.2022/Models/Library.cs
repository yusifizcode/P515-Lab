using _15._12._2022.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._12._2022.Models
{
    internal class Library
    {
        public List<Book> Books { get; set; }
        public Library()
        {
            Books= new List<Book>();
        }

        public List<Book> FilterByPrice(int min,int max)
        {
            List<Book> list = new List<Book>();
            foreach (Book book in Books)
            {
                if(book.Price > min && book.Price < max)
                {
                    list.Add(book);
                }
            }
            return list;
        }

        public List<Book> FilterByGenre(Genre genre)
        {
            List<Book> list = new List<Book>();
            foreach (Book book in Books)
            {
                if (book.Genre == genre)
                {
                    list.Add(book);
                }
            }
            return list;
        }

        public Book FindBookByNo(int no)
        {
            foreach (Book book in Books)
            {
                if(book.No == no)
                {
                    return book;
                }
            }
            return null;
        }

        public bool isExistBookByNo(int no)
        {
            foreach (var book in Books)
            {
                if(book.No == no)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Book> RemoveAll(Predicate<Book> predicate)
        {
            List<Book> books = new List<Book>();
            foreach (var book in Books)
            {
                if (!predicate(book))
                {
                    books.Add(book);
                }
            }
            return books;
        }
    }
}
