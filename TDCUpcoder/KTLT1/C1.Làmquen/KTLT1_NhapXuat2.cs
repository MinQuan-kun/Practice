using System;
namespace Nhapxuat2
{
    class Program
    {
        static void Main(string[]args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(n / 100);
            Console.WriteLine(n / 10 % 10);
            Console.WriteLine(n % 10);
        }
    }
}