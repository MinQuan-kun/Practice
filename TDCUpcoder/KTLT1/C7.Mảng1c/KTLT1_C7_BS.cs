using System;
namespace tachmangSNT
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
            int sl1 = 0;
            int temp = 0;
            for(int i = 0; i < n; i++)
                if(CheckSNT(Arr[i]))
                    sl1++;
            int[] mang1 = new int[sl1];
            for(int i = 0; i < n; i++)
            {
                if(CheckSNT(Arr[i])){
                    mang1[temp] = Arr[i];
                    temp++;
                }
            }
            for(int i = 0; i < sl1; i++)
                Console.Write("{0} ",mang1[i]);
        }
        static bool CheckSNT(int x)
        {
            if( x <= 1)
                return false;
             for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }
    }
}