//Code này được 5 điểm
using System;
namespace Ptbac1
{
    public class Program
    {
        static void Main(string[]args)
        {
            
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            float x = 0;
            if(a == 0)
            {
                if(b == 0)
                    Console.Write("VSN");
                else
                    Console.Write("VN");

            }
            else
            {
                x = (float)-b / a;
                Console.Write("{0:0.00}", x);
            }
        }
    }
}