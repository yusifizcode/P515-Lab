using _15._12._2022.Models;
using _15._12._2022.Enums;
public class Program
{
    public static void Main()
    {
        Book book = new Book();
        book.Name = "Test";
        book.AuthorName = "Test Testov";
        book.Price = 10;
        book.Genre = Genre.Dedective;

        Book book1 = new Book();
        book1.Name = "Test1";
        book1.AuthorName = "Test1 Test1ov";
        book1.Price = 20;
        book1.Genre = Genre.Comedy;

        Book book2 = new Book();
        book2.Name = "Test2";
        book2.AuthorName = "Test2 Test2ov";
        book2.Price = 30;
        book2.Genre = Genre.Horror;

        Book book3 = new Book();
        book3.Name = "Test3";
        book3.AuthorName = "Test3 Test3ov";
        book3.Price = 40;
        book3.Genre = Genre.Dedective;

        Library library = new Library();
        library.Books.Add(book1);
        library.Books.Add(book);
        library.Books.Add(book2);
        library.Books.Add(book3);

        List<Book> genreBooks = library.FilterByGenre(Genre.Dedective);

        foreach (var item in genreBooks)
        {
            Console.WriteLine(item.Name);
        }
        Console.WriteLine("------------------------");

        List<Book> priceBooks = library.FilterByPrice(15, 35);
        foreach (var item in priceBooks) 
        {
            Console.WriteLine(item.Name);
        }

        Console.WriteLine("------------------------");
        foreach (var item in library.Books)
        {
            Console.WriteLine(item.No);
        }
        Console.WriteLine("------------------------");

        bool isExist =  library.isExistBookByNo(6);
        Console.WriteLine(isExist);
        Console.WriteLine("------------------------");

        Book findBook = library.FindBookByNo(6);

        Console.WriteLine(findBook?.Name);

        Console.WriteLine("------------------------");
        foreach (var item in library.Books)
        {
            Console.WriteLine(item.Name);
        }
        
        Console.WriteLine("After remove: ");

        foreach (var item in library.RemoveAll(x => x.No == 1))
        {
            Console.WriteLine(item.Name);
        }

    }
}