using System;

namespace Inan
{
    public class Program
    {
        static void Main(string[] args)
        {
            string [] input = Console.ReadLine().Split(' ');
            long T, P, C, A4;
            T = long.Parse(input[0]);
            P = long.Parse(input[1]);
            C = long.Parse(input[2]);
            if (T == 1)
            {
                A4 = P * C;
                Console.WriteLine(A4);
            }
            else if (T == 2)
            {
                if (P % 2 == 0)
                {
                    A4 = (P / 2) * C;
                }
                else
                {
                    A4 = ((P + 1) / 2) * C;
                }
                Console.WriteLine(A4);
            }
        }
    }
}
