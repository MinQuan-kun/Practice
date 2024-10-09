using System;
namespace LTCB
{
    public class Program
    {
        static void Main(string[]args)
        {
            // Nhập số nguyên n
            int n = int.Parse(Console.ReadLine());
            
            int a = n / 1000;
            int b = (n / 100) % 10;
            int c = (n / 10) % 10;
            int d = n % 10;
            
            // Tìm max và min
            int max = Math.Max(Math.Max(a, b), Math.Max(c, d));
            int min = Math.Min(Math.Min(a, b), Math.Min(c, d));
            
            // In ra tổng của max và min
            Console.WriteLine(max + min);
        }
    }
}
