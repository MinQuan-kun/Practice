using System;
namespace Chanle
{
    public class Program
    {
        static void Main(string[]args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
                Console.Write("chan");
            else
                Console.Write("le");
        }
    }
}