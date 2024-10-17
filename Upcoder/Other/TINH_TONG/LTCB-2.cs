using System;
namespace Tinhtong
{
    public class Program
    {
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            double tong = 0;
            for(int i = 1; i <= n; i++)
                tong += Math.Pow(i, 2);
            tong = (int)tong;
            Console.Write(tong);
        }
    }
}