using System;
namespace Timso
{
    public class Program
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            long tong = 0;
            long kq = 0;
    
            for (long i = 1; i < n; i++)
            {
                tong += i;
                if (tong > n)
                    break;
                kq = i;
            }
    
            Console.Write(kq);
        }
    }
}
    
