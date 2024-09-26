using System;
namespace AplusB
{
    public class Program
    {
        static void Main(string[]args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = input.Length;
            int[] a = new int[n]
            int tong = 0;
            for(int i = 0; i < n; i++)
            {
                a[i] = int.Parse(input[i]);
                tong += a[i];
            }
            Console.Write(tong);
        }
    }
}