using System;
namespace tinhPvaS
{
    class Program
    {
        static void Main(string[]args)
        {
            const double PI = 3.141;
            double r = double.Parse(Console.ReadLine());
            double P, S;
            P = 2 * r * PI;
            S = PI * r * r;
            Console.Write("{0:0.00}",P);
            Console.Write(" {0:F2}",S);
        }
    }
}