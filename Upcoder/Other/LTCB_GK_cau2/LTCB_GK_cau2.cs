using System;
namespace LTCB
{
    public class Program
    {
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            
            if (n % 3 == 0)
            {
                Console.Write($"{n} chia het cho 3");
            }
            else if (n % 3 == 1)
            {
                Console.Write($"{n} chia 3 du {n % 3}");
            }
            else // n % 3 == 2
            {
                Console.Write($"{n} chia 3 du {n % 3}");
            }
        }
    }
}
    
