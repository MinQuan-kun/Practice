using System;
namespace Checkamduong
{
    public class Program
    {
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            if(n < 0)
                Console.Write("AM");
            else if(n == 0)
                Console.Write("KHONG");
            else
                Console.Write("DUONG");
        }
    }
}