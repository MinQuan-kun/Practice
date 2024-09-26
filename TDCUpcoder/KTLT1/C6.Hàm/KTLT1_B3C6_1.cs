using System;
namespace lietkeUS
{
    public class Program
    {
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            US(n);
        }
        static void US(int n)
        {
            for(int i = 1; i <= n; i++)
                if(n % i == 0)
                    Console.Write("{0} ",i);
        }
    }
}