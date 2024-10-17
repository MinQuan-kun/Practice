using System;
namespace TongChan
{
    public class Program
    {
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            int tong = 0;
            for(int i = 1; i <= n; i++)
                 if(n % i == 0 && i % 2 == 0)
                    tong += i;
            Console.Write(tong);
        }
    }
}