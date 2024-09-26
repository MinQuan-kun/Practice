using System;
namespace xoasodoixung
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
            int index = 0;
            int temp = 0;
            for(int i = 0; i < n; i++)
                if(SDX(Arr[i]))
                    index++;
            int[] mang1 = new int[index];
            for(int i = 0; i < n; i++)
            {
                if(SDX(Arr[i]))
                {
                    mang1[temp] = Arr[i];
                    temp++;
                }
                   
            }
            for(int i = 0; i < index; i++)
                Console.Write("{0} ",mang1[i]);
        }
        static bool SDX(int x)
        {
            int temp = x;
            int sum = 0;
            while(temp!=0){
                sum = sum*10 + temp%10;
                temp/=10;
            }
            if(sum == x)
                return false;
            return true;
        }
    }
}