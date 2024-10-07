using System;
namespace HinhVuong
{
    public class Program
    {
        static void Main(string[]args)
        {
            double x = double.Parse(Console.ReadLine());
            double tong = Math.Sqrt(x);
            Console.Write(tong);
        }
    }
}