using System;
namespace tinhtong3
{
    public class Program
    {
        static void Main(string[]args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int tong = a % 10 + b % 10;
            Console.Write(tong);
        }
    }
}