using System;
namespace Solonnhi
{
    public class Program
    {
        static void Main(string[]args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = input.Length;
            int[] a = new int[n];
            for(int i = 0; i < n; i++)
                a[i] = int.Parse(input[i]);
            if(a[0] == a[1] && a[1] == a[2] && a[2] == a[3])
                Console.Write("-1");
            else
            {
                int Max = Math.Max(Math.Max(a[0], a[1]), Math.Max(a[2], a[3]));
                int Min = Math.Min(Math.Min(a[0], a[1]), Math.Min(a[2], a[3]));
                int Max2 = Min;
                if (Max2 < a[0] && a[0] != Max)
                    Max2 = a[0];
                if (Max2 < a[1] && a[1] != Max)
                    Max2 = a[1];
                if (Max2 < a[2] && a[2] != Max)
                    Max2 = a[2];
                if (Max2 < a[3] && a[3] != Max)
                    Max2 = a[3];
                Console.WriteLine(Max2);
            }
            
        }
    }
}