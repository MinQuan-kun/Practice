using System;
namespace Tinhtong
{
    public class Program
    {
        static double Dequy(long n)
        {
            double result = 1.0 / 2.0 + 3.0 / 4.0;
            for (int i = 2; i <= n; i++)
            {
                result += (2 * i + 1.0) / (2 * i + 2.0);
            }
            return result;
        }
    
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.Write(1.0 / 2.0);
            }
            else
            {
                Console.Write(Dequy(n));
            }
        }
    }

}
    