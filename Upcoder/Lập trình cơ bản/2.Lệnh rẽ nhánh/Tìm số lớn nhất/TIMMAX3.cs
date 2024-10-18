//Điểm 7.5
using System;
namespace Timmax
{
    public class Program
    {
        static void Main(string[]args)
        {
            string [] input = Console.ReadLine().Split(' ');
            int n = input.Length;
            int [] A = new int[n];
            for(int i = 0; i < n; i++)
                A[i] = int.Parse(input[i]);
            int max = A[0];
            for(int i = 1; i < n; i++)
                if(max < A[i])
                    max = A[i];
            Console.Write(max);
        }
    }
}