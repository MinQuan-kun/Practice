using System;
namespace SOchinhphuong
{
    public class Program
    {
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            int n1 = 0;
            if(n < 0)
                Console.Write("False");
            else
            {
                n1 = (int)Math.Sqrt(n);
                if(n1 * n1 == n)
                    Console.Write("True");
                else
                    Console.Write("False");
            }
        }
    }
}