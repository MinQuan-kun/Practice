using System;
namespace invitriSNT
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
            for(int i =0; i < n; i++)
                if(CheckSNT(Arr[i]))
                    Console.Write("{0} ",i);
            
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