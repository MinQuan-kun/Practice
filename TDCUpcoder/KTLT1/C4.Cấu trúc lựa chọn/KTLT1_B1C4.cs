using System;
namespace timmax
{
    class Programn
    {
        static void Main(string[]args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int max = a;
            if(max < b)
            max = b;
            if(max < c)
            max = c;
            if(max < d)
            max = d;
            Console.Write(max);
            
        }
    }
}