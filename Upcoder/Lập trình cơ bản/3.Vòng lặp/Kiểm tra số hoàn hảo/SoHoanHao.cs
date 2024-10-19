using System;
namespace Shh
{
    public class Program
    {
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            SHH(n);
        }
        static void SHH(int n)
        {
            int tong = 0;
            for(int i = 1; i < n; i++)
                if(n % i == 0)
                    tong += i;
            if(tong == n)
                Console.Write("Yes");
            else
                Console.Write("No");
        }
    }
}