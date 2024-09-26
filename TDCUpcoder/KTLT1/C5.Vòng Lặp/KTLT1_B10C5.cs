using System;

namespace VeTamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
 
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
              
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                    if (k < i)
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
