using System;

namespace Chusohangnghin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int A;
            A = int.Parse(Console.ReadLine());

            if (A > 999)
            {
                A /= 1000;
                Console.Write(A % 10);
            }
            else
            {
                Console.Write("-1");
            }
        }
    }
}
