using System;
namespace Max2so
{
    public class Program
    {
        static void Main(string[]args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int max = a;
            if (max < b)
                max = b;
            Console.Write(max);
        }
    }
}