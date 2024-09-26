using System;
namespace themphantuvaovitrix
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
            int index = int.Parse(Console.ReadLine());
            int pos = int.Parse(Console.ReadLine());
            int[] NewArr = new int[n + 1];
            if(pos < n && pos >=0)
            {
            for(int i = 0; i <= pos; i++)
                NewArr[i] = Arr[i];
            NewArr[pos + 1] = index;
            for(int i = pos + 1; i < n; i++)
                NewArr[i + 1] = Arr[i];
            for(int i = 0; i < n + 1; i++)
                Console.Write("{0} ",NewArr[i]);
            }
            else
                for(int i = 0; i < n; i++)
                    Console.Write("{0} ",Arr[i]);
            
           
        } 
    }
}