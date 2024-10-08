//Code này chỉ đc 3.75 Điểm 
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
                Console.Write(A);
            else if (string.Compare(A, B) < 0)
                Console.Write(B);
            else
                Console.Write("Hai xau bang nhau");
        }
    }
}
