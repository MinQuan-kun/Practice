using System;
namespace hoanvi2so
{
    public class Program
    {
        static void Main(string[]args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Hoanvi(a,b);
        }
        static void Hoanvi(int a, int b)
        {
            Console.WriteLine(b);
            Console.WriteLine(a);
        }
    }
}