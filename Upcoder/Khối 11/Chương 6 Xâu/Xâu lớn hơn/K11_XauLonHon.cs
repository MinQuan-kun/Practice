using System;
namespace Xaulonhon
{
    public class Program
    {
        static void Main(string[]args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            if (string.Compare(a, b) > 0)
                Console.WriteLine(a);
            else if (string.Compare(b, a) > 0)
                Console.WriteLine(b);
            else
                Console.WriteLine("Hai xau bang nhau");
        }
    }
}
