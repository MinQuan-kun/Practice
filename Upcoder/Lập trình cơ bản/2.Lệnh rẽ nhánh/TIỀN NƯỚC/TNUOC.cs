using System;

namespace tiềnnuoc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int A, N;
            A = int.Parse(Console.ReadLine());

            if (A < 17)
            {
                N = A * 7000;
                Console.Write(N);
            }
            else
            {
                if (A < 51)
                {
                    N = (A - 16) * 8500 + 16 * 7000;
                    Console.Write(N);
                }
                else
                {
                    N = (A - 50) * 100000 + 34 * 8500 + 16 * 7000;
                    Console.Write(N);
                }
            }
        }
    }
}
