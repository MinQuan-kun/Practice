using System;

namespace InDayFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("1");
                return;
            }

            int f0 = 1;
            int f1 = 1;

            Console.Write(f0 + " " + f1 + " ");
            for (int i = 3; i <= n; i++)
            {
                int fNext = f0 + f1;  
                Console.Write(fNext + " ");  
                f0 = f1;  
                f1 = fNext; 
            }
        }
    }
}
