using System;
namespace demuoc
{
    public class Program
    {
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            COUNT(n);
        }
        static void COUNT(int n)
        {
            int Cnt = 0;
            for(int i = 1; i <= n; i++)
                if(n % i == 0)
                    Cnt++;
            Console.Write(Cnt);
        }
    }
}