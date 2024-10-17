// Code chưa chấm trên upcoder
using System;
namespace Tinhuocle
{
    public class Program
    {
        static int Sum(int n)
        {
            int S = 1;
            for(int i = 1; i <= i; i++)
                if(n %i == 0 && i % 2 == 0)
                    S *= i;
            return S;     
        }
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write(Sum(n));
        }
    }
}