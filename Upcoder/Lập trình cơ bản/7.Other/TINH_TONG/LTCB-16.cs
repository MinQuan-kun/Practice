using System;
namespace Tinhtong
{
    public class Program
    {
        static double DequyS(int n)
        {
            if (n == 1)
                return 1;
            return n + DequyS(n - 1);
        }

        static double DequyX(int x, int n)
        {
            if (n == 1)
                return x;
            return DequyX(x, n - 1) + (Math.Pow(x, n) / DequyS(n));
        }

        static void Main(string[]args)
        {
            var input = Console.ReadLine().Split();
            int x = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            Console.WriteLine(DequyX(x, n));
        }
    }

}
