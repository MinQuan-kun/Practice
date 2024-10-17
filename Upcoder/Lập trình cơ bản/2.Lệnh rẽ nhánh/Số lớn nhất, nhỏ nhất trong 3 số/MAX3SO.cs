using System;
namespace Max3so
{
    public class Program
    {
        static void Main(string[]args)
        {
            string [] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            int Max = a;
            if(Max < b)
                Max = b;
            if(Max < c)
                Max = c;
            int Min = a;
            if(Min > b)
                Min = b;
            if(Min > c)
                Min = c;
            Console.Write("{0} {1}", Max, Min);
        }
    }
}