using System;
namespace Tinhtong
{
    public class Program
    {
        static double DequyS(int n)
        {
            if (n == 1)
                return 0.5;
            return DequyS(n - 1) + (1.0 / (2 * n));
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write("{0:F3}", DequyS(n)); 
        }
    }
}
