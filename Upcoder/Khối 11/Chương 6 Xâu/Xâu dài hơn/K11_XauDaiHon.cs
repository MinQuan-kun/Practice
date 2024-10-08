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
                Console.Write(a);
            else if (a.Length < b.Length)
                Console.Write(b);
            else
            Console.Write("Hai xau dai bang nhau");
        }
    }
}