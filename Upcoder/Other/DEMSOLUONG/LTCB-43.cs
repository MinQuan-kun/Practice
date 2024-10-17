using System;
namespace Demsoluong
{
    public class Program
    {
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            while(n != 0)
            {
                n/= 10;
                count++;
            }
            Console.Write(count);
        }
    }
}