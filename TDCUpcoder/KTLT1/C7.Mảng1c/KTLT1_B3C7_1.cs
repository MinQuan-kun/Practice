using System;
namespace tinh2mang
{
    public class Program
    {
        static void Main(string[]args)
        {
            string[] inputA = Console.ReadLine().Split(' ');
            int n = inputA.Length;
            int[] arrA = new int[n];
            for(int i = 0; i < n; i++)
                arrA[i] = int.Parse(inputA[i]);
            string[] inputB = Console.ReadLine().Split(' ');
            int n2 = inputB.Length;
            int[] arrB = new int[n2];
            for(int i = 0; i < n2; i++)
                arrB[i] = int.Parse(inputB[i]);
            int[] arrC = new int[n];
            for(int i = 0; i < n; i++)
                arrC[i] = arrA[i] + arrB[i];
            for(int i = 0; i < n; i++)
                Console.Write("{0} ",arrC[i]);
        }
    }
}