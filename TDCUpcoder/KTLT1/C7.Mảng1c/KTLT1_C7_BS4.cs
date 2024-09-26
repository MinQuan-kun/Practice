using System;
namespace xoaphantui
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
            int x = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < n; i++)
                if(i == x)
                continue;
                else
                Console.Write("{0} ",Arr[i]);
        }
        
    }
}