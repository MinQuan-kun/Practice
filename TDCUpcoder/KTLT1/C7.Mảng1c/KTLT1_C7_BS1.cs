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
                if(CheckSCP(Arr[i])){
                    index = i;
                }
            }
            if(index != -1){
            for(int i = 0; i <= index; i++)
                mang1[i] = Arr[i];
            mang1[index + 1] = x;
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
        static bool CheckSCP(int x)
        {
            if(x <= 0)
                return false;
            int temp = (int)Math.Sqrt(x);
            return temp * temp == x;
        }
    }
}