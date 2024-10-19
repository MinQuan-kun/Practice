using System;
namespace tinhtong
{
    public class Program
    {
        static void Main(string[]args)
        {
            int n;
            while (int.TryParse(Console.ReadLine(), out n))
            {
                int tong = 0;
                while (n != 0)
                {
                    tong += n % 10;
                    n /= 10;
                }
                Console.WriteLine(tong);
            }
        }
    }
}