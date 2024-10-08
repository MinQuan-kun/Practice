using System;
namespace Xaulonhon
{
    public class Program
    {
        static void Main(string[]args)
        {
            string A = Console.ReadLine();
            string B = Console.ReadLine();
            if (string.Compare(A, B) > 0)
                Console.WriteLine(A);
            else if (string.Compare(A, B) < 0)
                Console.WriteLine(B);
            else
                Console.WriteLine("Hai xau bang nhau");
        }
    }
}
