using System;
namespace demuoc
{
    public class Program
    {
        static void Main(string[]args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i = 1; i <= n; i++ )
                if(n % i == 0)
                    count++;
            Console.Write(count);
        }
    }
}