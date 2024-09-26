using System;
namespace giaptbac2
{
    class Program
    {
        static void Main(string[]args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double delta = Math.Pow(b,2) - 4*a*c;
            if (a == 0)
            {
                if (b == 0 && c == 0)
                    Console.Write("VSN");
                else if (b == 0)
                    Console.Write("VN");
                else
                    Console.Write($"{- c/b:0.00}");
            }
            else
            {
                if(delta <0)
                    Console.Write("VN");
                else if(delta == 0)
                    Console.Write($"{-b / (2 * a):0.00}");
                else
                {
                    Console.WriteLine($"{(-b - Math.Sqrt(delta)) / (2 * a):0.00}");
                    Console.WriteLine($"{(-b + Math.Sqrt(delta)) / (2 * a):0.00}");
                }
            }
        }
    }
}