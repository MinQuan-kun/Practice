using System;
namespace themphantumangSNT
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
            int[] mang1 = new int[n + 1];
            int index = -1;
            for(int i = 0; i < n; i++)
            {
                if(LaSoHoanThien(Arr[i])){
                    index = i;
                    break;
                }
            }
            if(index != -1){
            for(int i = 0; i <= index; i++)
                mang1[i] = Arr[i];
            mang1[index] = x;
            mang1[index + 1] = Arr[index];
            for(int i = index + 1; i < n; i++)
                mang1[i + 1] = Arr[i];
            for(int i = 0; i < n + 1; i++)
                Console.Write("{0} ",mang1[i]);
            }
            else
            {
                for(int i = 0; i < n; i++)
                    Console.Write("{0} ",Arr[i]);
            }
            
            
        }
         static bool LaSoHoanThien(int n)
        {
            if (n < 2) return false;
            int sum = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            return sum == n;
        }
    }
}