//Code này thì chỉ được 2.67đ
using System;

namespace GiaiPhuongTrinh
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double a, b, c, d, x1, x2;
            string[] input = Console.ReadLine().Split(' ');
            a = double.Parse(input[0]);
            b = double.Parse(input[1]);
            c = double.Parse(input[2]);

            if (a == 0 && b == 0 && c == 0)
            {
                Console.WriteLine(-1);
                return;
            }

            if (a == 0 && b == 0 && c != 0)
            {
                Console.WriteLine(0);
                return;
            }

            if (a == 0 && b != 0)
            {
                Console.WriteLine(1);
                x1 = c / -b;
                Console.WriteLine($"{x1:F10}");
                return;
            }

            if (a != 0)
            {
                d = b * b - 4 * a * c;

                if (d < 0)
                {
                    Console.WriteLine(0);
                    return;
                }

                if (d == 0)
                {
                    Console.WriteLine(1);
                    x1 = -b / (2 * a);
                    Console.WriteLine($"{x1:F10}");
                    return;
                }

                if (d > 0)
                {
                    Console.WriteLine(2);
                    x1 = (-b - Math.Sqrt(d)) / (2 * a);
                    x2 = (-b + Math.Sqrt(d)) / (2 * a);

                    // Sắp xếp x1 và x2
                    if (x1 > x2)
                    {
                        double temp = x1;
                        x1 = x2;
                        x2 = temp;
                    }
                    Console.WriteLine($"{x1:F10}");
                    Console.Write($"{x2:F10}");
                }
            }
        }
    }
}
