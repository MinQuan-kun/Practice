using System;
namespace Tamgiacpascal
{
    public class Program
    {
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i ++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{Sum(i, j)} "); 
                }
                Console.WriteLine();
            }
        }
        static int Sum(int n, int k)
        {
            return Giaithua(n) / (Giaithua(k) * Giaithua(n-k));
        }
        static int Giaithua(int x)
        {
            if (x == 0 || x == 1)
                return 1;
            int result = 1;
            for (int i = 2; i <= x; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}