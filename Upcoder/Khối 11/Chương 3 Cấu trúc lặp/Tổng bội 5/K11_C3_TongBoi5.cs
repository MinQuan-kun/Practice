using System;
namespace Boi5
{
    public class Program
    {
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            int tong = 0;
            for(int i = 1; i <= n; i++)
                if(i % 5 == 0)
                    tong += i;
            Console.Write(tong);
        }
    }
}