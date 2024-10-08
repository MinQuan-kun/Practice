using System;
namespace Gachsoc
{
    public class Program
    {
        static void Main(string[]args)
        {
            double x = double.Parse(Console.ReadLine());
            double Shcn = x * x;
            double Shtron = Math.PI * (x / 2) * (x / 2);
            Console.Write(Shcn - Shtron);
        }
    }
}