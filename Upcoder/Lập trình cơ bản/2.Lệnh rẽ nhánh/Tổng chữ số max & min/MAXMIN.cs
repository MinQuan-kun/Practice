using System;
namespace tongmaxmin
{
    public class Program
    {
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int a = n /1000;
            int b = n / 100 % 10;
            int c = n / 10 % 10;
            int d = n % 10;
            int Max = a;
            int Min = a;
            if(Max < b)
                Max = b;
            if(Max < c)
                Max = c;
            if(Max < d)
                Max = d;
            if(Min > b)
                Min = b;
            if(Min > c)
                Min = c;
            if(Min > d)
                Min = d;
            Console.Write(Max + Min);
        }
    }
}