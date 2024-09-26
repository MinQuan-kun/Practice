using System;
namespace tachmang
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
            int sl2 = 0;
            for(int i = 0; i < n; i++)
            {
                if(Arr[i] >= 0)
                    sl1++;
                else
                    sl2++;
            }
            int temp1 = 0;
            int temp2 = 0;
            int[] mang1 = new int[sl1];
            int[] mang2 = new int[sl2];
            for(int i = 0; i < n; i++)
                if(Arr[i] >= 0)
                {
                    mang1[temp1] = Arr[i];
                    temp1++;
                }
                else{
                    mang2[temp2] = Arr[i];
                    temp2++;
                }
            for(int i = 0; i < temp1; i++)
                Console.Write("{0} ",mang1[i]);
            Console.WriteLine("");
            for(int i = 0; i < temp2; i++)
                Console.Write("{0} ",mang2[i]);
        }
    }
}