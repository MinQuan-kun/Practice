using System;
namespace CheckSHT
{
    public class Program
    {
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            if(CheckSHT(n))
                Console.Write("YES");
            else
                Console.Write("NO");
        }
        static bool CheckSHT(int x)
        {
            if (x <= 1) 
                return false; 
            int tong = 0;
            for (int i = 1; i <= x / 2; i++) {
                if (x % i == 0) {
                    tong += i;
                }
            }
            return tong == x;
        }
    }
}