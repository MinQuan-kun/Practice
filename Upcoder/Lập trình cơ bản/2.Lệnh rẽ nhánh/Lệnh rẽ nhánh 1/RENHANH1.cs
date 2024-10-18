using System;
namespace Lenhrenhanh
{
    public class Program
    {
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            if(n % 3 == 0)
                Console.Write("{0} chia het cho 3", n);
            if(n % 3 == 2)
                Console.Write("{0} chia 3 du 2", n);
            if(n % 3 == 1)
                Console.Write("{0} chia 3 du 1", n);
        }
    }
}