using System;
namespace Xaudaihon
{
    public class Program
    {
        static void Main(string[]args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            if (a.Length > b.Length)
                Console.WriteLine(a);
            else if (a.Length < b.Length)
                Console.WriteLine(b);
            else
            Console.WriteLine("Hai xau dai bang nhau");
        }
    }
}