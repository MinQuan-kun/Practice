using System;
namespace Daonguoc
{
    public class Program
    {
        static void Main(string[]args)
        {
            int a = int.Parse(Console.ReadLine());
            int tong = 0;
            while(a != 0)
            {
                tong = tong * 10 + a % 10;
                a /= 10;
            }
            Console.Write(tong);
        }
    }
}