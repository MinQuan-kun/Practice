using System;
namespace Tinhcos
{
    public class Program
    {
        static void Main(string[]args)
        {
            double x = double.Parse(Console.ReadLine());
            double tong = ((Math.Abs(2 * x + 3) / Math.Cos(x) ) + Math.Sqrt(2 + Math.Cos(x)));
            Console.Write("{0:0.00}",tong); // Làm tròn 2 só thập phân
        }
    }
}