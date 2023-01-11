using _21._12._2022_Lab.Models;

public class Program
{
    public static void Main()
    {
        MyList<int> ints= new MyList<int>();
        foreach (var item in ints)
        {
            Console.WriteLine(item);
        }

        ints[1] = 3;
    }
}