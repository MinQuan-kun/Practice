using System;
namespace tichuoc
{
    public class Program
    {
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            int res = 1;
            for(int i = 1; i <= n; i++)
                if(n % i == 0)
                    res *= i;
            Console.Write(res);
        }
    }
}