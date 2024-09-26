using System;
namespace TinhTBC
{
    class Program
    {
        static void Main(string[]args)
        {
            int a, b ,c;
            float res;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            res = (a + b + c) / 3.0f; 
            res = (float)Math.Round(res, 2); 
            Console.WriteLine(res);
        }
    }
}
