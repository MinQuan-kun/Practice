using System;
namespace Nhapxuat
{
    public class Program
    {
        static void Main(string[]args)
        {
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(a % 10);
            Console.WriteLine((a / 100) % 10);
            Console.Write((a /10) % 10);
        }
    }
}