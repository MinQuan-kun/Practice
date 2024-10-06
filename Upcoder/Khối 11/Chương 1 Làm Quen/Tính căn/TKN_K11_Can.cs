using System;
namespace Tinhsin
{
    public class Program
    {
        static void Main(string[]args)
        {
            double x = double.Parse(Console.ReadLine());
            double T = Math.Sqrt(x + Math.Sqrt(x + Math.Sqrt(x)));
            Console.Write("{0:0.00000}",T);
        }
    }
}