using System;
namespace Lietke
{
    public class Program
    {
        static void Main(string[]args)
        {
            for(int i = 10 ; i <= 99 ; i++)
            {
                int a = i / 10;
                int b = i % 10;
                if((2*(a + b)) == (a * b))
                    Console.Write("{0} ",i);
            }
        }  
    }
}