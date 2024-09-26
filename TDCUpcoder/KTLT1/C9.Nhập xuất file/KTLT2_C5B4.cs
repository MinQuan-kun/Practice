using System;
using System.IO;
namespace Timmax
{
    public class Program
    {
        static void Main(string[]args)
        {
            
            int n = int.Parse(Console.ReadLine());
            int[] Arr = new int[n];
            for(int i = 0; i < n; i++)
            Arr[i] = int.Parse(Console.ReadLine());
            using (StreamWriter writer = new StreamWriter("MangNguyen.txt"))
            {
                writer.WriteLine(n);
                for (int i = 0; i < n; i++)
                {
                    writer.WriteLine(Arr[i]);
                }
            }
        }
    }
}