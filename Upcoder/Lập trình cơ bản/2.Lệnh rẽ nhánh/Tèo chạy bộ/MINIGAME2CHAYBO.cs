using System;
namespace Teochaybo
{
    public class Program
    {
        static void Main(string[] args)
        {
            string [] input = Console.ReadLine().Split(' ');
            int AB = int.Parse(input[0]);
            int BC = int.Parse(input[1]);
            int CA = int.Parse(input[2]);
            int n = int.Parse(Console.ReadLine());
            int S1 = AB + BC + CA;

            while (n > S1)
                n -= S1;

            if (n == AB)
            {
                Console.Write("B");
                return;
            }
            if (n < AB)
            {
                Console.Write("AB");
                return;
            }
            if (n == (AB + BC))
            {
                Console.Write("C");
                return;
            }
            if (n < (AB + BC))
            {
                Console.Write("BC");
                return;
            }
            if (n < (AB + BC + CA))
            {
                Console.Write("CA");
                return;
            }
            if (n == (AB + BC + CA))
            {
                Console.Write("A");
                return;
            }
        }
    }
}