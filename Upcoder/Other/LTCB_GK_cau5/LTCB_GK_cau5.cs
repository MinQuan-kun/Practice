using System;
namespace LTCB
{
    public class Program
    {
        static double S(int n)
        {
            if(n == 1)
                return 1.0 / Math.Pow(n, 3);
            return S(n - 1) + (1.0 / Math.Pow(n, 3));
        }
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            if(n == 1)
                Console.Write(1);
            else
                Console.Write("{0:0.000}",S(n));
        }
    }
}