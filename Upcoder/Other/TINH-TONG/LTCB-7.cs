using System;
namespace Tinhtong
{
    public class Program
    {
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            double S = Dequy(n);
            Console.Write("{0:0.000}",S);
        }
        static double Dequy(int n)
        {
            if(n == 1)
                return 1.0 / 2.0;
            else
                return Dequy(n - 1) + (n * 1.0/(n + 1));
        }
    }
}