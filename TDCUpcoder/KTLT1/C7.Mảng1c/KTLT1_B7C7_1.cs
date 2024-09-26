using System;
namespace xoaXkhoimang
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
            int sl1 = 0;
            int temp = 0;
            for(int i = 0; i < n; i++)
                if(Arr[i] != x)
                    sl1++;
            int[] mang1 = new int[sl1];
            for(int i = 0; i < n; i++)
            {
                if(Arr[i] != x){
                    mang1[temp] = Arr[i];
                    temp++;
                }
            }
            for(int i = 0; i < sl1; i++)
                Console.Write("{0} ",mang1[i]);
        }
    }
}