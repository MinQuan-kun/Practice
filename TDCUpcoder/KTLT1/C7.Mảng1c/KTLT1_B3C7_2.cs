using System;
namespace tinhtong2mang
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
            int max = n;
            if(n < n2)
                max = n2;
            int[] arrC = new int[max];
            for (int i = 0; i < max; i++)
            {
                int valA = 0;
                int valB = 0;
                if(i < n)
                    valA = arrA[i];
                if(i < n2)
                    valB = arrB[i];
                arrC[i] = valA + valB;
            }

            for (int i = 0; i < max; i++)
                Console.Write("{0} ", arrC[i]);
        }
    }
}