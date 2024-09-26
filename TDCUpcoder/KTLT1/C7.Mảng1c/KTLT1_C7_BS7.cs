using System;
namespace Xoasole
{
    public class Program
    {
        static void Main(string[]args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = input.Length;
            int[] Arr = new int[n];
            for(int i = 0; i < n; i++)
                Arr[i] = int.Parse(input[i]);
            for(int i = 0; i < n; i++)
            {
                if(Arr[i] % 2 != 0)
                    continue;
                Console.Write("{0} ",Arr[i]);
            }
                
        }
    }
}