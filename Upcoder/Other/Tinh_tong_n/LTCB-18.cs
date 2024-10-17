using System;
namespace TinhtongS
{
    public class Program
    {
        static void Main(string[]args)
        {
            double x = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double S = Dequy(x, n);
            Console.Write("{0:0.00}", S);
            
        }
        static double Dequy(double x, int n)
        {
            if(n == 0)
                return 1;
            if(n == 1)
                return 1 + (Math.Pow(x, 2))/ Fib(2);
            return Dequy(x , n - 1) + (Math.Pow(x, 2 * n) / Fib(2 * n));
        }
        static double Fib(int n)
        {
            if(n == 1)
                return 1;
            return n * Fib(n - 1);
        }
    }
}