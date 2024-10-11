using System;
namespace Ôntap2
{
    public class Program
    {
        static void Main(string[]args)
        {
            string [] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int A = 0, B = 0;
            if(a % 2 == 0)
                A = a;
            else
                A = -a;
            if(b % 2 != 0)
                B = b;
            else
                B = -b;
            Console.Write(A * B);
        }
    }
}