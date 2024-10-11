using System;
namespace Ontap1
{
    public class Program
    {
        static void Main(string[]args)
        {
            string [] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            bool check = false;
            if (a + b >= 0) 
            {
                Console.Write("{0} ", a + b);
                check = true;
            }

            if (a - b >= 0) {
                Console.Write("{0} ", a - b);
                check = true;
            }
            if (a * b >= 0) {
                Console.Write("{0} ", a * b);
                check = true;
            }

            if (!check) {
                Console.Write("impossible");
            }
        }
    }
}