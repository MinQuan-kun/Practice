using System;
namespace TongS
{
    public class Program
    {
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write(Res(n));
            
        }
        static int fib(int n)
        {
            if(n == 1)
                return 1;
            return n * fib(n - 1);
        }
        static int Res(int n)
        {
            if(n == 1)
                return 1;
            return fib(n) + Res(n - 1);
        }
            
    }
}