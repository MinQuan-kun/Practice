using System;
namespace Tinhtong
{
    public class Program
    {
        static void Main(string[]args)
        {
            string [] input = Console.ReadLine().Split(' ');
            int x = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            double s = DequyS(x, n);
            if(x < 0 || n < 0)
                Console.Write(-1);
            else
                Console.Write("{0:0.000}",s);
        }
        static double DequyS(int x, int n)
        {
            if(n == 0)
                return 0;
            else
                return 1.0 / (n * x * (n + 1)) + DequyS(x, n - 1);
        }
    }
}