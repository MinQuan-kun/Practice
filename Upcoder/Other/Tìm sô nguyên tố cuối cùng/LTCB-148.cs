using System;
namespace LastSNT
{
    public class Program
    {
        static void Main(string[]args)
        {
            int temp = -1;
            int [] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
            arr[i] = int.Parse(Console.ReadLine());
            if(checksnt(arr[i]))
                temp = i;
            }
            if(temp == -1)
                Console.Write("-1");
            else
                Console.Write(arr[temp]);
        }
        static bool checksnt(int x) 
        {
            if (x < 2) 
                return false; 
            for (int i = 2; i <= x / 2; i++) 
            {
                if (x % i == 0) return false; 
            }
            return true;
        }
    }
}