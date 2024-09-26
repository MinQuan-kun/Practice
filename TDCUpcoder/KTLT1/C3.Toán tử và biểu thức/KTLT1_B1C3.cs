using System;
namespace pheptinh
{
    class Program
    {
        static void Main(string[]args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.Write(a+b);
            Console.Write($" {a - b} {a * b} {(a / b):F1}", a, b);    
        }
    }
}