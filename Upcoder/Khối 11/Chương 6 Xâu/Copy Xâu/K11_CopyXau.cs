using System;
namespace Copyxau
{
    public class Program
    {
        static void Main(string[]args)
        {
            string a = Console.ReadLine();
            string [] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
    
            if (n < 0 || m >= a.Length || n > m)
            {
                Console.Write("gioi han khong dung");
            }
            else
            {
                Console.Write(a.Substring(n, m - n + 1));
            }
        }
    }
}