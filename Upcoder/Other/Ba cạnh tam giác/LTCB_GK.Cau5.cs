using System;
namespace Tamgiac
{
    public class Program
    {
        static void Main(string[]args)
        {
            string [] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            if (a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a)
            {
                double p = (a + b + c) / 2.0;
                double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                int perimeter = a + b + c;
                Console.Write("{0} ", perimeter);
                Console.Write("{0}", (int)S);
            } 
            else 
                Console.Write("Khong phai tam giac");
        }
    }
}