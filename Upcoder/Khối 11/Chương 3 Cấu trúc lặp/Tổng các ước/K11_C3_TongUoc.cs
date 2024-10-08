using System;
namespace Tonguoc
{
    public class Program
    {
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            int tong = 0;
            if(n < 0)
                n *= -1;
            for(int i = 1; i <= n; i++)
                if(n % i == 0)
                    tong += i;
            Console.Write(tong);
        }
    }
}