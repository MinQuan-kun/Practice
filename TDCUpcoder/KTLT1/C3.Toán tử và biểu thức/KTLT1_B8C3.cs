using System;

namespace chantanglegiam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if(n % 2 == 0)
            Console.Write(n + 1);
            else
            Console.Write(n - 1);

        }
    }
}