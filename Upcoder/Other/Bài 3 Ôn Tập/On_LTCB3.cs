// Code này chưa chấm trên Upcoder
using System;
namespace Ôntap3
{
    public class Program
    {
        static void Main(string[]args)
        {
            string [] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            int max = a;
            if(max < b)
                max = b;
            if(max < c)
                max = c;
            int min = a;
            if(min > b)
                min = b;
            if(min > c)
                min = c;
            int medium = a;
            if ((b > min && b < max) || (b > max && b < min))
                medium = b;
            if ((c > min && c < max) || (c > max && c < min))
                medium = c;
            if (medium % 2 == 0)
                Console.Write("{0} la so chan", medium);
            else
                Console.Write("{0} la so le", medium);
        }
    }
}