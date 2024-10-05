using System;
namespace Tongchuso
{
    public class Program
    {
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            int tong = 0;
            while(n > 0)
            {
                tong += n % 10;
                n /= 10;
            }
            Console.Write(tong);
        }
    }
}